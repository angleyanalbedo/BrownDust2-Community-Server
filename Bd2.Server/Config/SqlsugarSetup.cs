using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bd2.Server.Common;
using Bd2.Server.Common.DB;
using Bd2.Server.DAO.Game;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using SqlSugar.Extensions;

namespace Bd2.Server.Config;

public static class SqlsugarSetup
{
    public static void AddSqlsugarSetup(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        if (!string.IsNullOrEmpty(AppSettings.app("MainDB")))
        {
            MainDb.CurrentDbConnId = AppSettings.app("MainDB");
        }

        BaseDBConfig.MutiConnectionString.allDbs.ForEach(m =>
        {
            var connectionConfig = new ConnectionConfig
            {
                ConfigId = m.ConnId.ObjToString().ToLower(),
                ConnectionString = m.Connection,
                DbType = (DbType)m.DbType,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,
                MoreSettings = new ConnMoreSettings
                {
                    IsAutoRemoveDataCache = true,
                    SqlServerCodeFirstNvarchar = true
                }
            };

            if ("log".Equals(m.ConnId.ToLower()))
            {
                BaseDBConfig.LogConfig = connectionConfig;
            }
            else
            {
                BaseDBConfig.ValidConfig.Add(connectionConfig);
            }

            BaseDBConfig.AllConfigs.Add(connectionConfig);
        });

        if (BaseDBConfig.LogConfig == null)
        {
            throw new ApplicationException("未配置Log库连接");
        }

        services.AddSingleton<ISqlSugarClient>(provider =>
        {
            var scope = new SqlSugarScope(BaseDBConfig.AllConfigs, db =>
            {
                BaseDBConfig.ValidConfig.ForEach(config =>
                {
                    db.GetConnectionScope(config.ConfigId);
                });
            });

            InitAllDaoTables(scope);
            SeedScheduleInfoData(scope);

            return scope;
        });
    }

    private static void InitAllDaoTables(SqlSugarScope sqlSugar)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a =>
            {
                try { return a.GetTypes(); }
                catch (ReflectionTypeLoadException ex) { return ex.Types.Where(t => t != null)!; }
            })
            .Where(t =>
                t != null &&
                t.IsClass &&
                !t.IsAbstract &&
                t.GetCustomAttribute<SugarTable>() != null &&
                t.Namespace != null &&
                (t.Namespace == "Bd2.Server.DAO" || t.Namespace.StartsWith("Bd2.Server.DAO.")))
            .ToArray();

        Console.WriteLine($"[CodeFirst] 扫描到实体类数量: {types.Length}");

        try
        {
            var mainDb = sqlSugar.GetConnectionScope("main");
            if (mainDb != null && types.Length > 0)
            {
                mainDb.CodeFirst.InitTables(types);
                Console.WriteLine($"[CodeFirst] Main 库表结构初始化成功！");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CodeFirst Error] Main 库初始化表失败: {ex.Message}\n{ex.StackTrace}");
        }
    }

    /// <summary>
    /// 确保 ScheduleInfo 表有客户端所需的所有赛程内容记录。
    /// 客户端 SetGuild() 会调用 SeasonState(6) 查询公会突袭赛程，
    /// 如果 _schedules 字典中没有对应的 key 会抛出 KeyNotFoundException。
    /// </summary>
    private static void SeedScheduleInfoData(SqlSugarScope sqlSugar)
    {
        try
        {
            var mainDb = sqlSugar.GetConnectionScope("main");
            if (mainDb == null) return;

            var existingIds = mainDb.Queryable<ScheduleInfoDao>()
                .Select(x => x.Id)
                .ToList();

            var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var seasonStart = now;
            var seasonEnd = now + 90L * 24 * 60 * 60 * 1000; // 90天后

            // 客户端验证方法要求必须存在的 ContentId：1, 2, 5, 6, 8, 9
            // SetGuild() 直接使用 id=6 (GuildRaid)
            var requiredSchedules = new List<ScheduleInfoDao>
            {
                new() { Id = 1, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
                new() { Id = 2, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
                new() { Id = 3, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 0, NextStartTime = 0, NextEndTime = 0 },
                new() { Id = 4, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 0, NextStartTime = 0, NextEndTime = 0 },
                new() { Id = 5, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
                new() { Id = 6, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
                new() { Id = 7, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 0, NextStartTime = 0, NextEndTime = 0 },
                new() { Id = 8, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
                new() { Id = 9, CurrentSeason = 1, CurrentStartTime = seasonStart, CurrentEndTime = seasonEnd, NextSeason = 2, NextStartTime = seasonEnd, NextEndTime = seasonEnd + 90L * 24 * 60 * 60 * 1000 },
            };

            var toInsert = requiredSchedules.Where(s => !existingIds.Contains(s.Id)).ToList();
            if (toInsert.Count > 0)
            {
                mainDb.Insertable(toInsert).ExecuteCommand();
                Console.WriteLine($"[SeedData] ScheduleInfo 表插入 {toInsert.Count} 条记录 (Id: {string.Join(", ", toInsert.Select(x => x.Id))})");
            }
            else
            {
                Console.WriteLine($"[SeedData] ScheduleInfo 表已有所有必要记录，跳过初始化");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[SeedData Error] ScheduleInfo 种子数据初始化失败: {ex.Message}");
        }
    }

}

# BrownDust2 Community Server

一个面向本地研究、测试和社区开发的 BrownDust2 服务端项目。

这是一个非官方社区项目，与游戏发行商或运营商无关。请只在你拥有合法授权的环境中使用，并遵守当地法律、游戏条款和相关版权要求。

本项目采用仓库内的教育/非商业许可，禁止未经书面许可的商业使用。详见 `LICENSE`。

## 快速开始

1. 安装 .NET 8 SDK。
2. 准备与客户端版本匹配的设计数据库，并放到运行目录的 `design_dbs/`。
3. 修改 `Bd2.Server/appsettings.json` 中的数据库和监听配置。
4. 使用管理员 PowerShell 执行 `tools/gen-cert.ps1`，为本机生成 HTTPS 证书（默认密码：`bd2`）。
5. 根据需要使用 `tools/hosts.ps1` 配置本地域名解析；必要时执行 `tools/install-cert.ps1` 安装证书。
6. 运行 `dotnet run --project Bd2.Server/Bd2.Server.csproj`。

设计数据库、玩家数据库、客户端 dump、插件和构建产物不包含在本公开发布包中。

## 目录

- `Bd2.Server/`：ASP.NET Core 服务端源代码和管理面板
- `tools/`：本地 host 配置和自签名证书生成/安装脚本

## 证书说明

证书不会随公开包提供。请使用 `tools/gen-cert.ps1` 为自己的电脑生成证书，默认密码为 `bd2`；请勿将生成的 `.pfx` 提交到公开仓库或用于生产环境。

## English

An unofficial community server for local research, testing, and development around BrownDust2.

This project is not affiliated with the game publisher or operator. Use it only in environments where you have authorization, and follow applicable law, terms of service, and copyright requirements.

This project is distributed under the repository's Educational Non-Commercial License. Commercial use requires prior written permission; see `LICENSE`.

The public package contains source code and selected local host/certificate tooling only. Design databases, player databases, client dumps, plugins, private notes, generated certificates, and build artifacts are intentionally excluded.

Generate your own local certificate with `tools/gen-cert.ps1` (default password: `bd2`). Never commit the generated `.pfx` or use it in production.

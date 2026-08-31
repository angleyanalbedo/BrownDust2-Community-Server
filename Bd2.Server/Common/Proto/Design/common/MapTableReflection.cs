using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MapTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cidjb21tb24uZGIvTWFwVGFibGVfX1/rp7UvTWFwVGFibGUucHJvdG8SE1By" + "b3RvLkRlc2lnbi5jb21tb24iwgUKCE1hcFRhYmxlEhkKEWFjY2VsZXJhdGlv" + "blNwZWVkGAEgASgBEhkKEWFkdmFudENoYXJFbGVtZW50GAIgASgFEhQKDGFt" + "YmllbmNlTmFtZRgDIAEoCRIWCg5hdWRpb0Nyb3NzZmFkZRgEIAEoBRIUCgxi" + "YXR0bGVEZWNrSWQYBSADKAUSFQoNY29tbW9uU291bmRJZBgGIAEoBRIZChFl" + "bmNvdW50ZVNhZmVWYWx1ZRgHIAEoBRIZChFlbmNvdW50ZXJNYXhWYWx1ZRgI" + "IAEoBRIdChVlbnZFZmZlY3RSZXNvdXJjZU5hbWUYCSABKAkSHQoVZmxhc2hs" + "aWdodFJlc291Y2VOYW1lGAogASgJEhkKEWZvb3RTdGVwU291bmRUeXBlGAsg" + "ASgFEg4KBmdhdGVJZBgMIAMoBRIKCgJpZBgNIAEoBRITCgtpc0luc2lkZU1h" + "cBgOIAEoBRIRCgltYXBFZmZlY3QYDyABKAUSGAoQbWFwRWZmZWN0RnJlcU1h" + "eBgQIAEoBRIYChBtYXBFZmZlY3RGcmVxTWluGBEgASgFEhIKCm1hcEdyb3Vw" + "SWQYEiABKAUSFQoNbWFwTmFtZVRleHRJZBgTIAEoBRIQCghtYXBTY2FsZRgU" + "IAEoBRIUCgxtYXBTY2VuZVBhdGgYFSABKAkSDwoHbWFwVHlwZRgWIAEoBRIQ" + "CghtYXhTcGVlZBgXIAEoARITCgttaW5pbWFwU2l6ZRgYIAEoCRIZChFtaW5p" + "bWFwU3ByaXRlTmFtZRgZIAEoCRIWCg5tb25zdGVyRWxlbWVudBgaIAEoBRIO" + "CgZvZmZzZXQYGyABKAkSDgoGcGFja0lkGBwgASgFEhAKCHNob3dIcFVpGB0g" + "ASgFEhMKC3Nob3dRdWVzdElkGB4gASgFEhkKEXRpbWVMaW5lRWZmZWN0VXNl" + "GB8gASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MapTable), MapTable.Parser, new string[31]
		{
			"AccelerationSpeed", "AdvantCharElement", "AmbienceName", "AudioCrossfade", "BattleDeckId", "CommonSoundId", "EncounteSafeValue", "EncounterMaxValue", "EnvEffectResourceName", "FlashlightResouceName",
			"FootStepSoundType", "GateId", "Id", "IsInsideMap", "MapEffect", "MapEffectFreqMax", "MapEffectFreqMin", "MapGroupId", "MapNameTextId", "MapScale",
			"MapScenePath", "MapType", "MaxSpeed", "MinimapSize", "MinimapSpriteName", "MonsterElement", "Offset", "PackId", "ShowHpUi", "ShowQuestId",
			"TimeLineEffectUse"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}

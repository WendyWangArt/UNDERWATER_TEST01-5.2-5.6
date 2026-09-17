using UnrealBuildTool;

public class UNDERWATER_TEST01ServerTarget : TargetRules
{
	public UNDERWATER_TEST01ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("UNDERWATER_TEST01");
	}
}

using UnrealBuildTool;

public class UNDERWATER_TEST01ClientTarget : TargetRules
{
	public UNDERWATER_TEST01ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("UNDERWATER_TEST01");
	}
}

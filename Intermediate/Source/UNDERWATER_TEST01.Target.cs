using UnrealBuildTool;

public class UNDERWATER_TEST01Target : TargetRules
{
	public UNDERWATER_TEST01Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("UNDERWATER_TEST01");
	}
}

using UnrealBuildTool;

public class UNDERWATER_TEST01EditorTarget : TargetRules
{
	public UNDERWATER_TEST01EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("UNDERWATER_TEST01");
	}
}

using UnrealBuildTool;

public class ArchVizInteriorTarget : TargetRules
{
	public ArchVizInteriorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ArchVizInterior");
	}
}

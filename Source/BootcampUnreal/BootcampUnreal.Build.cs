// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BootcampUnreal : ModuleRules
{
	public BootcampUnreal(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}

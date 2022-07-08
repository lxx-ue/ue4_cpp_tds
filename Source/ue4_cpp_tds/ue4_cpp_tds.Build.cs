// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ue4_cpp_tds : ModuleRules
{
	public ue4_cpp_tds(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule" });
    }
}

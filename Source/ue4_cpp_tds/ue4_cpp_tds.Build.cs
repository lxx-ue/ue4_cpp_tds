// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ue4_cpp_tds : ModuleRules
{
	public ue4_cpp_tds(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule" });


		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[]
		{
			"ue4_cpp_tds/Character",
			"ue4_cpp_tds/FuncLibrary",
			"ue4_cpp_tds/Game"
		});

	}
}

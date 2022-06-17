// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class ink_ue5_integration : ModuleRules
{
	public ink_ue5_integration(ReadOnlyTargetRules Target) : base(Target)
	{
		//PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// Enable C++17 support
		PCHUsage = ModuleRules.PCHUsageMode.NoSharedPCHs;
		PrivatePCHHeaderFile = "../ThirdParty/inkcpp/inkcpp/Source/inkcpp/Public/inkcpp.h";
		CppStandard = CppStandardVersion.Cpp17;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		PublicIncludePaths.Add("../Source/ThirdParty/inkcpp/include/public");
		PublicIncludePaths.Add("../Source/ThirdParty/inkcpp/inkcpp/Source/inkcpp/Public");


		PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "../ThirdParty/inkcpp/lib/inkcpp.lib"));
		PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "../ThirdParty/inkcpp/lib/inkcpp_compiler.lib"));

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ArchivoTecsup : ModuleRules
{
	public ArchivoTecsup(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ArchivoTecsup",
			"ArchivoTecsup/Variant_Horror",
			"ArchivoTecsup/Variant_Horror/UI",
			"ArchivoTecsup/Variant_Shooter",
			"ArchivoTecsup/Variant_Shooter/AI",
			"ArchivoTecsup/Variant_Shooter/UI",
			"ArchivoTecsup/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

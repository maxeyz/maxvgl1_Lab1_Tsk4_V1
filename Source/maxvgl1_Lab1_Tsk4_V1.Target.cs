// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class maxvgl1_Lab1_Tsk4_V1Target : TargetRules
{
	public maxvgl1_Lab1_Tsk4_V1Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "maxvgl1_Lab1_Tsk4_V1" } );
	}
}

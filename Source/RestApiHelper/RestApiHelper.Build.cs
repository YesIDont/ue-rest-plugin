// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RestApiHelper : ModuleRules
{
    public RestApiHelper(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
          new string[] {
          }
          );


        PrivateIncludePaths.AddRange(
          new string[] {
          }
          );


        PublicDependencyModuleNames.AddRange(
          new string[]
          {
        "Core", "Engine", "CoreUObject", "HTTP", "Json", "JsonUtilities",
          }
          );


        PrivateDependencyModuleNames.AddRange(
          new string[]
          {
          }
          );


        DynamicallyLoadedModuleNames.AddRange(
          new string[]
          {
          }
          );
    }
}

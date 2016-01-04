using System;
using ObjCRuntime;

[assembly: LinkWith ("SWRevealViewControllerSDK.a", LinkTarget.Simulator64 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.ArmV7, ForceLoad = true)]

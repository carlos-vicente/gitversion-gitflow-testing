#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0

#tool dotnet:?package=GitVersion.Tool&version=5.2.4

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    var settings = new GitVersionSettings{
        NoFetch = true
    };
    var gitversion = GitVersion(settings);
    
    Information($"MajorMinorPatch: {gitversion.MajorMinorPatch}");
    Information($"FullSemVer: {gitversion.FullSemVer}");
    Information($"PreReleaseTag: {gitversion.PreReleaseTag}");
    Information($"PreReleaseNumber: {gitversion.PreReleaseNumber}");
    Information($"InformationalVersion: {gitversion.InformationalVersion}");
});

RunTarget(target);
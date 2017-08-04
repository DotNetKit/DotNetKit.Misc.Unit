.nuget\nuget.exe pack DotNetKit.Misc.Unit\DotNetKit.Misc.Unit.csproj.nuspec -Build
.nuget\nuget.exe push *.nupkg -Source https://www.nuget.org/api/v2/package
del /Q *.nupkg

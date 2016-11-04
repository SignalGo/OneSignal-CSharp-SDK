msbuild src\OneSignal.CSharp.SDK.sln /verbosity:minimal /p:Configuration=Release

copy .\src\OneSignal.CSharp.SDK\bin\Release\OneSignal.CSharp.SDK.dll .\build\net45\OneSignal.CSharp.SDK.dll /Y

cd build
del *.nupkg
nuget pack OneSignal.CSharp.SDK.nuspec

pause
call NuGet-Settings.cmd

"%MSBUILD_EXE%" %NUGET_PROJECT% /t:Clean
"%MSBUILD_EXE%" %NUGET_PROJECT% /t:Build /p:Configuration="Net35"
REM "%MSBUILD_EXE%" %NUGET_PROJECT% /t:Build /p:Configuration="Net35CP"
"%MSBUILD_EXE%" %NUGET_PROJECT% /t:Build /p:Configuration="Net40"
REM "%MSBUILD_EXE%" %NUGET_PROJECT% /t:Build /p:Configuration="Net40CP"
"%MSBUILD_EXE%" %NUGET_PROJECT% /t:Build /p:Configuration="Net45"

"%NUGET_EXE%" pack "%NUGET_PROJECT%" -Verbosity detailed -Build -Properties Configuration="Net40"

pause
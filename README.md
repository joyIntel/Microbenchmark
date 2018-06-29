# Microbenchmark
## Build
1. Fork it.
2. `cd path/to/Microbenchmark`
3. Change `<RuntimeIdentifier>win7-x64</RuntimeIdentifier>` in file PerfMark.csproj to `<RuntimeIdentifier>ubuntu.14.04-x64</RuntimeIdentifier>` if your platform is Ubuntu.
4. Change `<ServerGarbageCollection>false</ServerGarbageCollection>` in file HelloWorld.csproj to use server GC.
5. `dotnet restore`
6. `dotnet publish -c Release`
## Run
1.dotnet .\bin\Release\netcoreapp2.0\win7-x64\publish\Microbenchmark.dll


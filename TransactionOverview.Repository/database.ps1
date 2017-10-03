[string]$currentPath=Split-Path ((Get-Variable MyInvocation -Scope 0).Value).MyCommand.Path
cd $currentPath

dotnet ef migrations add ImportDefaults
#dotnet ef database drop -f 
dotnet ef migrations add m_v1
dotnet ef database update

#dotnet ef migrations add m_v2






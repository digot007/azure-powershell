$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzCloudServiceRoleInstanceRemoteDesktopFile.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzCloudServiceRoleInstanceRemoteDesktopFile' {

    It 'Get remote desktop file' {
        $RDPOutputFile = [System.IO.Path]::Combine($PSScriptRoot, "test-artifacts", $env.RDPOutputFile)
        RemoveFile $RDPOutputFile
        $x = Get-AzCloudServiceRoleInstanceRemoteDesktopFile -ResourceGroupName $env.ResourceGroupName -CloudServiceName $env.CloudServiceName -RoleInstance $env.RoleInstanceName -OutFile $RDPOutputFile
        Test-Path $RDPOutputFile | Should be $true
        $content = Get-Content $RDPOutputFile
        $content[2].contains($env.RoleInstanceName) | Should be $true
    }
}

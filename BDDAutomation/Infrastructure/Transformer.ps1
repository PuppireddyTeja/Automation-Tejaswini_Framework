 Param(
	[string]$browser,
    [string]$path
 )

$appConfig = $path
$xmlDocument = (Get-Content $appConfig) -as [Xml]

$driverPort = $xmlDocument.configuration.appSettings.add | where { $_.Key -eq "DriverPort" }
$driverPath = $xmlDocument.configuration.appSettings.add | where { $_.Key -eq "DriverPath" }
$browserKey = $xmlDocument.configuration.appSettings.add | where { $_.Key -eq "Browser" }
$url = $xmlDocument.configuration.appSettings.add | where { $_.Key -eq "PortalURL" }
$dbConnection = $xmlDocument.configuration.appSettings.add | where { $_.Key -eq "DBConnectionString" }



if($browser -eq "chrome"){
	$driverPort.value = "53996"
	$driverPath.value = "C:\E2ETests\Tools"
	$browserKey.value = "Chrome"

    Write-Output $browserKey.value
}

if($browser -eq "ie"){
	$driverPort.value = "64667"
	$driverPath.value = "C:\E2ETests\Tools"
	$browserKey.value = "IE"
}

if($browser -eq "firefox"){
 Write-Output "asdasdasd"
	$driverPort.value = "64668"
	$driverPath.value = "C:\E2ETests\Tools"
	$browserKey.value = "Firefox"
}


#QA parameters
$url.value = "https://nwecloudportal-d.deloitte.nl/app"

$xmlDocument.save($appConfig);
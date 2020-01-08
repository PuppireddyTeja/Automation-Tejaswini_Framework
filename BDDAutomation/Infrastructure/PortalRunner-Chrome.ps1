$outputTxtPath = "C:\E2ETests\Portal-OUT\Output-Chrome.txt"
$outputXmlPath = "C:\E2ETests\Portal-OUT\Result-Chrome.xml"
$outputHtmlPath = "C:\E2ETests\Portal-OUT\E2EReport-Chrome.html"

$projectPath = "E:\BDDAutomation\BDDAutomation\BDDAutomation.csproj"
$binPath = "E:\BDDAutomation\BDDAutomation\bin\Debug\BDDAutomation.dll"
$specflowPath = "C:\E2ETests\SpecFlow.2.1.0\tools\specflow.exe"
$configPath = "E:\BDDAutomation\BDDAutomation\bin\Debug\BDDAutomation.dll.config"
$featuresPath = "C:\E2ETests\FeatureTags.xml"

#Get Features from Google Docs

[xml]$xmlIncludeDocument = (Get-Content $featuresPath)
[string]$include = "";

# change for total time hours
$Global:new_html=@() 
Function TotalTimeDuration
{
    [xml]$parametersXML = New-Object System.Xml.XmlDocument
    $parametersXML.Load($outputXmlPath)
    $xpathNavigator = $parametersXML.CreateNavigator()
    $Namespace = $xpathNavigator.SelectSingleNode('//test-suite[@type="Assembly"]').NamespaceURI
    $ds =  [timespan]::fromseconds($xpathNavigator.SelectSingleNode('//test-suite[@type="Assembly"]').GetAttribute("time",$Namespace))
    $ts = "{0:HH:mm}" -f ([datetime]$ds.Ticks)

    $replaceHeaderString = [string]::Format("Ignored</th><th class='top'>Total Duration For Execution(Hrs:Min)</th>", $ts.ToString());
    #$replaceValue1 = [string]::Format("failed'>&nbsp;</div><div class='duration' style='width:16.42346208869814em' title='{0} duration>'", $ts.ToString());
    $replaceValue2 = [string]::Format("<td>{0}</td></tr></table><hr /><h2>Feature Summary</h2>'", $ts.ToString());

    $file= Get-Content $outputHtmlPath
    $found1 = $false
    $found2 = $false
     foreach($_ in $file) { 
   
    if ($_ -match "<h2>Summary</h2>" -and $found1 -eq $false){
               $new_html += ($_ -replace "Ignored</th>",$replaceHeaderString)       
              $found1 = $true
              }
    elseif ($_ -match "</td></tr>" -and $found2 -eq $false){
            $new_html += ($_ -replace "</tr></table><hr /><h2>Feature Summary</h2>",$replaceValue2)  
            $found2 = $true      
            }

    else {
            $new_html += $_       
    }
  
    }
    $new_html | set-content $outputHtmlPath
}

foreach($row in $xmlIncludeDocument.Columns.Rows){
    
    if($row.ChildNodes.Count -ne 0){
        if($row.ChildNodes[0].'#text' -ne "Include" -and $row.ChildNodes[0].'#text' -ne "NA"){
            $include = $include + "|" + $row.ChildNodes[0].'#text';        
        }
    }

    if($row.ChildNodes.Count -eq 2){
        if($row.ChildNodes[1].'#text' -ne "Exclude" -and $row.ChildNodes[1].'#text' -ne "NA"){
            $include = $include + "-" + $row.ChildNodes[1].'#text';            
        }
    }
}

$include = $include.Substring(1, $include.Length - 1);

Write-Host -ForegroundColor Green "Expression Feature: ($include)"

#Execution

& nunit3-console.exe --labels=All "--result=$outputXmlPath;format=nunit2" /output=$outputTxtPath $binPath /framework:net-4.5
& $specflowPath nunitexecutionreport $projectPath /xmlTestResult:$outputXmlPath /out:$outputHtmlPath
TotalTimeDuration
.\EmailSender.ps1 -file "C:\E2ETests\Portal-OUT\E2EReport-Chrome.html" -browser "Chrome"
.\Archiver.ps1 



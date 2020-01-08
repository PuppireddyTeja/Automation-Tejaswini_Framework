[CmdletBinding()]
 Param(
	[string]$file,
    [string]$browser
 )  

 Write-Output $file

##############################################################################
$From = "subbarao@jobiak.ai"
$To = @("subbarao@jobiak.ai")
$Cc = "subbarao.research@gmail.com"
$Attachment = $file
$Subject = "Automation Scripts Report on Portal in Dev Environment - $browser"
$Body = "Automation Scripts Execution on Portal has been completed. Please find the attached report for feature wise results.

Thank you,
QA-Jobiak"
$SMTPServer = "smtp.gmail.com"
$SMTPPort = "587"
Write-Output $SMTPPort
Send-MailMessage -From $From -to $To -Cc $Cc -Subject $Subject `
-Body $Body -SmtpServer $SMTPServer -port $SMTPPort -UseSsl `
-Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "subbarao@jobiak.ai",("Subhash@12" | ConvertTo-SecureString -AsPlainText -Force)
) -Attachments $Attachment
##############################################################################
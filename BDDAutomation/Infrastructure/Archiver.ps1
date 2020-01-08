$TimeStamp = Get-Date -Format o | foreach {$_ -replace ":", "."}
$DirectoryFrom = "C:\E2ETests\Portal-OUT\*"
$DirectoryTo = "C:\E2ETests\Portal-OUT-Archive\$TimeStamp"

New-Item -ItemType Directory -Force $DirectoryTo

Copy-Item $DirectoryFrom -Destination $DirectoryTo
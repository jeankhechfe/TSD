function CPU()
{
    Get-Process | Where-Object {$_.WorkingSet -gt 10000000} | Out-File D:/Process.txt
}

function MSDN()
{
    $lineNumber = 0
    foreach($line in Get-Content D:/MSDN.txt) {
    $lineNumber++
        if($line -match "PowerShell"){
            echo $lineNumber $line
        }
    }
}

function RSS()
{
    [xml]$Content = Invoke-WebRequest -Uri "https://sleepy-wilson-d2b50e.netlify.com/powershell/PowerShell.rss"
    $Feed = $Content.rss.channel
    echo ""
    echo "Titles"
    echo "------"
    ForEach ($msg in $Feed.Item)
    {
        echo $msg.title
    }
}
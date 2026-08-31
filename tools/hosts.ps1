# Run as Administrator
# Add or remove hosts file entries

param(
    [switch]$Remove
)

$hostsFile = "$env:SystemRoot\System32\drivers\etc\hosts"
$marker = "# Bd2.PrivateServer"
$entries = @(
    "127.0.0.1  mt.bd2.pmang.cloud $marker"
    "127.0.0.1  loki.bd2.pmang.cloud $marker"
    "127.0.0.1  acf.neonapi.com $marker"
    "127.0.0.1  global.neonapi.com $marker"
)

if ($Remove) {
    $content = Get-Content $hostsFile -Raw
    $lines = $content -split "`r?`n" | Where-Object { $_ -notmatch [regex]::Escape($marker) }
    $lines | Set-Content $hostsFile -Encoding ASCII
    Write-Host "hosts restored (removed Bd2 entries)" -ForegroundColor Green
} else {
    $content = Get-Content $hostsFile -Raw
    $lines = $content -split "`r?`n" | Where-Object { $_ -notmatch [regex]::Escape($marker) }
    $lines += $entries
    $lines | Set-Content $hostsFile -Encoding ASCII
    Write-Host "hosts entries added:" -ForegroundColor Green
    Write-Host "  127.0.0.1  mt.bd2.pmang.cloud"
    Write-Host "  127.0.0.1  loki.bd2.pmang.cloud"
    Write-Host "  127.0.0.1  acf.neonapi.com"
    Write-Host "  127.0.0.1  global.neonapi.com"
}

# Flush DNS cache
ipconfig /flushdns | Out-Null
Write-Host "DNS cache flushed" -ForegroundColor Cyan

Write-Host ""
Write-Host "Usage:" -ForegroundColor Cyan
Write-Host "  Add:    .\hosts.ps1"
Write-Host "  Remove: .\hosts.ps1 -Remove"

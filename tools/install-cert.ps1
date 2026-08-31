# Run as Administrator
# Install certificate to trusted root store

$certPath = Join-Path $PSScriptRoot "site.cer"

if (-not (Test-Path $certPath)) {
    Write-Host "Certificate not found: $certPath" -ForegroundColor Red
    exit 1
}

Import-Certificate -FilePath $certPath -CertStoreLocation "Cert:\LocalMachine\Root"
Write-Host "Certificate installed successfully" -ForegroundColor Green
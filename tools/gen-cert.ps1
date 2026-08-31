# Run as Administrator
# Generate self-signed certificate

$cert = New-SelfSignedCertificate `
    -DnsName "*.bd2.pmang.cloud","mt.bd2.pmang.cloud","loki.bd2.pmang.cloud","acf.neonapi.com","global.neonapi.com","127.0.0.1" `
    -CertStoreLocation "Cert:\CurrentUser\My" `
    -NotAfter (Get-Date).AddYears(10) `
    -KeyUsage DigitalSignature, KeyEncipherment `
    -Type SSLServerAuthentication

$password = ConvertTo-SecureString -String "bd2" -Force -AsPlainText
Export-PfxCertificate -Cert $cert -FilePath "$PSScriptRoot\site.pfx" -Password $password
Export-Certificate -Cert $cert -FilePath "$PSScriptRoot\site.cer"

Write-Host "Certificate generated:" -ForegroundColor Green
Write-Host "  site.pfx - for server (password: bd2)"
Write-Host "  site.cer - install to trusted store"
Write-Host "  Thumbprint: $($cert.Thumbprint)" -ForegroundColor Cyan
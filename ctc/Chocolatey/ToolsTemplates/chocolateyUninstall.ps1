﻿$packageName = '__PACKAGE_NAME__' # name for the package, used in messages
$zipName = "bin.zip"

$installDir = Join-Path $env:AllUsersProfile "$packageName"
Uninstall-ChocolateyZipPackage "$packageName" "$zipName" 
Remove-Item -Recurse -Force "$installDir"

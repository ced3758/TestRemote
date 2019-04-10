dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true 
pushd .\bin\Debug\netcoreapp2.2\linux-arm\publish
pscp -pw sncf72000 -v -r .\* pi@192.168.1.210:/home/pi/Desktop/TestRemote
popd
#!ps
#timeout=699999
#maxlength=609000
function Get-Chrome {
    $path = "c:\temp"
    $uri = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B5BD4D824-50AD-C6AF-0F69-9D3B3844A4A1%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dtrue%26ap%3Dx64-stable-statsdef_0%26brand%3DGCEA/dl/chrome/install/googlechromestandaloneenterprise64.msi"
    if (!(test-path $path)) {mkdir $path}
    invoke-webrequest -uri $uri -outfile "$($path)\chrome.msi"
    $argument = "/i `"$($path)\chrome.msi`" /quiet /log `"$($path)\chromeinstall.txt`""
    start-process msiexec.exe -ArgumentList $argument -Wait
    remove-item "$($path)\chrome.msi"
    get-content "$($path)\chromeinstall.txt"
}
Get-Chrome



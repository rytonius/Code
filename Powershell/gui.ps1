<# This form was created using POSHGUI.com  a free online gui designer for PowerShell
.NAME
    PoshGuidemo
#>

Add-Type -AssemblyName System.Windows.Forms
[System.Windows.Forms.Application]::EnableVisualStyles()

$Form                            = New-Object system.Windows.Forms.Form
$Form.ClientSize                 = '400,400'
$Form.text                       = "Demo"
$Form.TopMost                    = $false

$btnGetProcess                   = New-Object system.Windows.Forms.Button
$btnGetProcess.BackColor         = "#4a90e2"
$btnGetProcess.text              = "Get Process"
$btnGetProcess.width             = 133
$btnGetProcess.height            = 30
$btnGetProcess.location          = New-Object System.Drawing.Point(117,214)
$btnGetProcess.Font              = 'Microsoft Sans Serif,10'
$btnGetProcess.ForeColor         = "#ffffff"

$lblName                         = New-Object system.Windows.Forms.Label
$lblName.text                    = "Type Process Name:"
$lblName.AutoSize                = $true
$lblName.width                   = 25
$lblName.height                  = 10
$lblName.location                = New-Object System.Drawing.Point(64,78)
$lblName.Font                    = 'Microsoft Sans Serif,10'

$txtName                         = New-Object system.Windows.Forms.TextBox
$txtName.multiline               = $false
$txtName.BackColor               = "#ff0000"
$txtName.width                   = 100
$txtName.height                  = 20
$txtName.location                = New-Object System.Drawing.Point(197,73)
$txtName.Font                    = 'Microsoft Sans Serif,10'

$Form.controls.AddRange(@($btnGetProcess,$lblName,$txtName))

$btnGetProcess.Add_Click({ btnGetProcess_click })

function btnGetProcess_click {get-process | out-gridview }


#Write your logic code here

[void]$Form.ShowDialog()
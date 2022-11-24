function ConvertTo-Jpg {
    <#
    .Description
        ConvertTo-Jpg is used to convert image files to jpeg, lower quality amount will reduce file size more while reducing... quality of image.
        I found when converting .png with 100 quality it reduces file size in half without anything noticeable even when zoomed in by 800%
        90 took a 492 KB size on disk to 83.3 KB and only when zoomed in by 800% do i notice some artifacting.  I don't really recommend going
        below 90

        THIS WILL NOT DELETE THE OLD IMAGE, so you can safely convert at different quality and test things out.

    .Example
        this example just shows that i'm taking my entire picture directorly and converting all my .png to jpg.  Reminder that this does NOT
        delete the old picture.
        Get-ChildItem c:\User\Work\Pictures\*.png | ConvertTo-Jpg
    #>
    [cmdletbinding()]
    param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)] $Path,
        [int]$quality = 100
    )

    process {
        if ($Path -is [string])
        { $Path = get-childitem $Path }

        $qualityEncoder = [System.Drawing.Imaging.Encoder]::Quality

        $encoderParams = New-Object System.Drawing.Imaging.EncoderParameters(1)
        $encoderParams.Param[0] = New-Object System.Drawing.Imaging.EncoderParameter($qualityEncoder, $quality)
        $jpegCodecInfo = [System.Drawing.Imaging.ImageCodecInfo]::GetImageEncoders() | Where-Object { $_.MimeType -eq 'image/jpeg' }

        $Path | ForEach-Object {
            $image = [System.Drawing.Image]::FromFile($($_.FullName));
            $FilePath = [IO.Path]::ChangeExtension($_.FullName, '.jpg');
            $image.Save($FilePath, $jpegCodecInfo, $encoderParams);
            $image.Dispose();
        }
    }

}
"https://phishalert-releases.s3.amazonaws.com/PhishAlert.msi?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA37KREM2QGCWODIM7%2F20211230%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211230T221420Z&X-Amz-Expires=432000&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEP3%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJGMEQCIBNroDi0p5lIopg0qcFmN3QRtbn27o%2BBz6PYA3UlnFkJAiA8dcqduARD90Bhc26iD8MAQ%2BDQ8v%2FpvfJ3ww2sdZ%2BKXSqIBAj2%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAAaDDgyMzE5MzI2NTgyNCIMzrv%2FxV1IVi20m7IbKtwD7M30XWUTKsZncy%2BnoT4j3T5F%2BYX7luwojysAYfIsrI34NLk3no9z1TA9n9Q8RTHCWYqMMYF6ZHxb0OaHGa33xyhwfpDKwAkDtMR0lL4mXNRke7BIIMuvJN6SuuHBOrJ5NE8ZrCoYi3yG5cwSe2C3%2FtEkW4c0xpm2RU3NyAQFPaA56kxvk6ODdMR%2Fz2xGJE%2BLeIms6UQYHQxCN%2Bnua260Z4jZKS3QDcscwguUW3RK1RLzgjbdKS0xLR7JbYBrFLZl2g5FeSKyoyZ%2FEN3WESub236GjrgmVLv5TXzqhMUEQMNbhFeVkMmnbGXxesLuxuo5IkU9pp2JCT8GOGmXhZwTKKGDPeUS0v7iZ6QqFibw6iiqbVwO2Nx8nqY9ACAvrHVLVR2te%2Bu2%2BrAOQKoiE6PIL1Myqo01vkXz5%2BOCWMD44pF6Rx7ev4Mp4DCXKdBYhqD8tV7poniDw4ekDjZImwZJyiRPq92TNBPrG%2BdRI%2BaXfpi6zwy23iATedQB1wFNvE10uoH3BuvO5sp%2Fo7MlqUL5dS8aYY5uKwxgphhZTB4RJEdciQbj9UZb3Tbz94KbVARj1Jl31S4Nz%2FUxKOBZx6%2BR6KJ0Bh%2Fxa0wrEUAP1xmR9ZiHIklyopdisGormVgw37O4jgY6pgHffNfwwS08yBxixhDWHNlCXrKl8bsbct39UI1EJsf9CRfT2clY3MK0KgtiOfYnxtBjcqY8N9zVIKyNFzsNLnXvvQ2Y2sJlClLTN9lprXGtI7AwW4c7Hy8vb8bEYynYanUSOvsbbLESV4K%2BKsi%2FNOOcyhY%2FU3L5083JQF%2Bo%2BOf6fxKID9K%2F0HMEv3tidv0KxM4umlmIsuIrqto78%2B%2B1i6rJ7cIOJKG8&X-Amz-SignedHeaders=host&X-Amz-Signature=5ff86714362869790533ff973d9991bb35c8b98a654cb0cd224bd4abe9e32f8f"

#!ps
#timeout=699999
#maxlength=699000
Function Get-PhishAlert {
    $path = "c:\windows\temp"
    $uri = "https://phishalert-releases.s3.amazonaws.com/PhishAlert.msi?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA37KREM2QGCWODIM7%2F20211230%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211230T221420Z&X-Amz-Expires=432000&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEP3%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJGMEQCIBNroDi0p5lIopg0qcFmN3QRtbn27o%2BBz6PYA3UlnFkJAiA8dcqduARD90Bhc26iD8MAQ%2BDQ8v%2FpvfJ3ww2sdZ%2BKXSqIBAj2%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAAaDDgyMzE5MzI2NTgyNCIMzrv%2FxV1IVi20m7IbKtwD7M30XWUTKsZncy%2BnoT4j3T5F%2BYX7luwojysAYfIsrI34NLk3no9z1TA9n9Q8RTHCWYqMMYF6ZHxb0OaHGa33xyhwfpDKwAkDtMR0lL4mXNRke7BIIMuvJN6SuuHBOrJ5NE8ZrCoYi3yG5cwSe2C3%2FtEkW4c0xpm2RU3NyAQFPaA56kxvk6ODdMR%2Fz2xGJE%2BLeIms6UQYHQxCN%2Bnua260Z4jZKS3QDcscwguUW3RK1RLzgjbdKS0xLR7JbYBrFLZl2g5FeSKyoyZ%2FEN3WESub236GjrgmVLv5TXzqhMUEQMNbhFeVkMmnbGXxesLuxuo5IkU9pp2JCT8GOGmXhZwTKKGDPeUS0v7iZ6QqFibw6iiqbVwO2Nx8nqY9ACAvrHVLVR2te%2Bu2%2BrAOQKoiE6PIL1Myqo01vkXz5%2BOCWMD44pF6Rx7ev4Mp4DCXKdBYhqD8tV7poniDw4ekDjZImwZJyiRPq92TNBPrG%2BdRI%2BaXfpi6zwy23iATedQB1wFNvE10uoH3BuvO5sp%2Fo7MlqUL5dS8aYY5uKwxgphhZTB4RJEdciQbj9UZb3Tbz94KbVARj1Jl31S4Nz%2FUxKOBZx6%2BR6KJ0Bh%2Fxa0wrEUAP1xmR9ZiHIklyopdisGormVgw37O4jgY6pgHffNfwwS08yBxixhDWHNlCXrKl8bsbct39UI1EJsf9CRfT2clY3MK0KgtiOfYnxtBjcqY8N9zVIKyNFzsNLnXvvQ2Y2sJlClLTN9lprXGtI7AwW4c7Hy8vb8bEYynYanUSOvsbbLESV4K%2BKsi%2FNOOcyhY%2FU3L5083JQF%2Bo%2BOf6fxKID9K%2F0HMEv3tidv0KxM4umlmIsuIrqto78%2B%2B1i6rJ7cIOJKG8&X-Amz-SignedHeaders=host&X-Amz-Signature=5ff86714362869790533ff973d9991bb35c8b98a654cb0cd224bd4abe9e32f8f"

    if (!(test-path $path)) {mkdir $path}
    invoke-webrequest -uri $uri -outfile "$($path)\PhishAlert.msi"
   
    msiexec /quiet /i "c:\windows\temp\phishalert.msi" LicenseKey=8D7A91A4C34E24AB2B1169EF15C6DDB9 ALLUSERS=1 /log "c:\windows\temp\phishalert.log"
    start-sleep -seconds 30
    select-string -path "c:\windows\temp\phishalert.log" -context 5,5 -pattern "Logging stopped:"
}
Get-PhishAlert



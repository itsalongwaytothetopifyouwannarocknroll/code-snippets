# IP function for VBA

Main function:
 - IPv4StrToBin
 - IPv4BinToStr
 - IPv6StrToBin
 - IPv6BinToStr
 - IPv4isValidStr
 - IPv6isValidStr
 - IPv4isValidBin
 - IPv6isValidBin


```visualbasic
Private Function test()
Dim testedIPsv6(11) As String

testedIPsv6(0) = "::1"
testedIPsv6(1) = "2001:db8:a0b:12f0::1"
testedIPsv6(2) = "2001:0db8:0a0b:12f0:0000:0000:0000:0001"
testedIPsv6(3) = "2001:0000:6dcd:8c74:76cc:63bf:ac32:6a1"
testedIPsv6(4) = "2001:1::1"
testedIPsv6(5) = "2001:0002:cd:65a:753::a1"
testedIPsv6(6) = "2001:5::"
testedIPsv6(7) = "2001:11::3f4b:1aff:f7b2"
testedIPsv6(8) = "2620:4f:8000::"
testedIPsv6(9) = "not valid"
testedIPsv6(10) = "not:valid:ip"
testedIPsv6(11) = "2001:0db8:0a0b:12f0:0:0:0:0001"

For i = LBound(testedIPsv6) To UBound(testedIPsv6)
    If IPv6isValidStr(testedIPsv6(i)) Then
        Debug.Print testedIPsv6(i) & "[" & IPv6BinToStr(IPv6StrToBin(testedIPsv6(i))) & "]"
    Else
        Debug.Print " - - [" & testedIPsv6(i) & "] is not valid"
    End If
Next i

Debug.Print "Done"
End Function
```
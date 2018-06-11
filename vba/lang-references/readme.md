### Application.Version

- Excel 97 = 8
- Excel 2000 = 9
- Excel 2002 = 10
- Excel 2003 = 11
- Excel 2007 = 12
- Excel 2010 = 14
- Excel 2013 = 15
- Excel 2016 = 16

### Application.International(xlCountrySetting)

http://support.microsoft.com/kb/213833/en-us

### Application.LanguageSettings.LanguageID(msoLanguageIDUI)

```visualbasic
Sub Test2()
    Select Case Application.LanguageSettings.LanguageID(msoLanguageIDUI)
    Case 1043: MsgBox "Run code for Dutch"
    Case 1049: MsgBox "Run code for Russian"
    Case Else: MsgBox "Run code for English (default)"
    End Select
End Sub
```
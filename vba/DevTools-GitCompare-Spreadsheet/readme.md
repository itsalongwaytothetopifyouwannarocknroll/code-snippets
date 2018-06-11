# GIT DevTools for Excel Spreadsheets
Module wich helps visual source controlling of file content. Use default for MS Office >2014 tool [__Spreadsheet Compare__] (https://support.office.com/en-us/article/Overview-of-Spreadsheet-Compare-13fafa61-62aa-451b-8674-242ce5f2c986)

## Origin article
https://www.xltrail.com/blog/git-diff-spreadsheetcompare
https://github.com/ZoomerAnalytics/git-spreadsheetcompare

## GIT Config
.git/config

```
[diff "excel"]
    command = C:/tools/xldiff.bat
```

## GIT Attributes
.attributes

```
*.xls* diff=excel
```

## GIT Ignore
.gitignore

```
# ignore temporary excel files
~$*
*.laccdb
*.tmp
```

## BAT file
File __xldiff.bat__ included.

### MS Spreadsheet Compare

Default location for Office 2014 x64: "C:\Program Files (x86)\Microsoft Office\Office15\DCF\SPREADSHEETCOMPARE.EXE"
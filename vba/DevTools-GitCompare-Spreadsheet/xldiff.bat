@ECHO OFF

ECHO %2 > xlcompare.tmp
dir %5 /B /S >> xlcompare.tmp

"C:\Program Files (x86)\Microsoft Office\Office15\DCF\SPREADSHEETCOMPARE.EXE" xlcompare.tmp
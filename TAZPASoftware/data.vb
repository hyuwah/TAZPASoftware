' Data.vb
' Specifies filehelpers setting for data used in form1.vb
' Structure for data saved by software
'-> Never forget:  Imports FileHelpers
Imports FileHelpers

<DelimitedRecord(";"), IgnoreFirst(1)>
Public Class data


    <FieldConverter(ConverterKind.Date, "mm:ss.ff")>
    Public dataX As DateTime

    Public dataES As Double

    Public dataEZ As Double


End Class


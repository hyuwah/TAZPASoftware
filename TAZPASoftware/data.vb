'-> Never forget:  Imports FileHelpers
Imports FileHelpers

<DelimitedRecord(",")>
Public Class data

    <FieldConverter(ConverterKind.Date, "HH:mm:ss")>
    Public dataX As DateTime

    Public dataY As Decimal


End Class


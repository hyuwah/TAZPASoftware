'-> Never forget:  Imports FileHelpers
Imports FileHelpers

<DelimitedRecord(","), IgnoreFirst(1)>
Public Class data


    <FieldConverter(ConverterKind.Date, "HH:mm:ss")>
    Public dataX As DateTime

    Public dataY As Double


End Class


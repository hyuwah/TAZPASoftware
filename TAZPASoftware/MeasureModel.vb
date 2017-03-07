Public Class MeasureModel
    Public Property DateTime() As DateTime
        Get
            Return m_DateTime
        End Get
        Set(Value As DateTime)
            m_DateTime = Value
        End Set
    End Property
    Private m_DateTime As DateTime
    Public Property Value() As Double
        Get
            Return m_Value
        End Get
        Set
            m_Value = Value
        End Set
    End Property
    Private m_Value As Double
End Class

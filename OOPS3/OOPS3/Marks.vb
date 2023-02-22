Public Class Marks
    Inherits Student

    Private m1, m2 As Integer
    Public Property Mark1 As Integer
        Get
            Return m1
        End Get
        Set(value As Integer)
            m1 = value
        End Set
    End Property
    Public Property Mark2 As Integer
        Get
            Return m2
        End Get
        Set(value As Integer)
            m2 = value
        End Set
    End Property
End Class

Public Class Student
    Private rno As Integer
    Private SName As String

    Public Property ROLLNO As Integer
        Get
            Return rno
        End Get
        Set(value As Integer)
            If value < 0 Then
                value = 0
            End If
            rno = value
        End Set
    End Property
    Public Property NAME As String
        Get
            Return SName
        End Get
        Set(value As String)

            SName = value
        End Set
    End Property
End Class


Public Class Student
        Private rno As Integer
        Private sname As String

        Public Sub New()
            Console.WriteLine("Constructor called")
        End Sub
        Public Sub New(ByVal a As Integer, ByVal b As String)
            rno = a
            sname = b
        End Sub

        Protected Overrides Sub Finalize()
            Console.Write("Finalize method called")
        End Sub
        Public Property RollNo() As Integer
            Get
                Return rno
            End Get
            Set(value As Integer)
                rno = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return sname
            End Get
            Set(value As String)
                sname = value
            End Set
        End Property
    End Class




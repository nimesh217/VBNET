Imports oops4

Public Class Child2
    Inherits Parent1
    Implements Interface1, Interface2

    Public j As Integer

    Public Property mymethod As Integer Implements Interface1.mymethod
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property
    Public Sub newmethod() Implements Interface1.newmethod

    End Sub
    Public Function myfun() As Char Implements Interface2.myfun
        Return "X"
    End Function

End Class

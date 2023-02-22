
Public Class Marks
    Inherits Student

    Private m1 As Integer
    Private m2 As Integer
    Public Sub New()

    End Sub
    Public Property mark1
        Get
            Return m1
        End Get
        Set(value)
            m1 = value
        End Set
    End Property

    Public Property mark2
        Get
            Return m2
        End Get
        Set(value)
            m2 = value
        End Set
    End Property
    Public Sub inputdata(ByVal rno As Integer, ByVal nm As String, ByVal x As Integer, ByVal y As Integer)
        RollNo = rno
        Name = nm
        mark1 = x
        mark2 = y
    End Sub
    Public Sub PrintMarks()
        Console.WriteLine("Student Roll no: " & RollNo)
        Console.WriteLine("Student Name : " & Name)
        Console.WriteLine("Student Marks 1: " & mark1)
        Console.WriteLine("Student Marks 2: " & mark2)

    End Sub
End Class



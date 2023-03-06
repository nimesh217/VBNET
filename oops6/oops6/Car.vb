Public Class Car
    Inherits Vehicle
    Public Function Drive(ByVal a As String) As Integer
        Console.WriteLine("Car Drive")
        Return 1
    End Function
    Public Overrides Sub sstop()
        MyBase.sstop()
        Console.WriteLine("Car sstop")
    End Sub
End Class

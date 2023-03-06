Public Class Vehicle
    Dim vehiclename As String
    Public Overloads Function Drive(ByVal a As String) As Integer
        Console.WriteLine("Vehicle Drive")
        Return 1
    End Function
    Public Overridable Sub sstop()
        Console.WriteLine("Vehicle Stop")
    End Sub

End Class

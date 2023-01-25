Module Module1

    Sub Add(X As Integer, Y As Integer)
        Dim Z As Integer
        Z = Val(X) + Y
        If (Z < 5) Then
            Console.WriteLine("Very small number")
            Return
        End If
        If (Z > 100) Then
            Console.WriteLine("number is larger than 100")
            Exit Sub
        End If
        Console.WriteLine(Z)

    End Sub

    Function Mul(ByRef X As Integer, ByRef Y As Integer) As Integer
        Dim Z As Integer
        'Z = X * Y
        '        Return Z
        X = X + 5 '25
        Mul = X * Y ' 25*5 =125
    End Function

    Sub Main()
        Dim a, b As Integer
        Dim c As Integer
        a = 20
        b = 5
        Add(a, b)
        c = Mul(a, b)
        Console.WriteLine("Multiplication is " & c.ToString)
        Console.WriteLine(a.ToString & " " & b.ToString)
        Console.ReadKey()

    End Sub

End Module

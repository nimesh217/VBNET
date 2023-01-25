Module MyModule
    Sub myMethod()
        Console.Write("hi")
    End Sub

    Sub Main()
        Dim a, b, c As Integer

        Console.Write("Enter first value: ")
        a = Console.ReadLine()
        Console.Write("Enter second value: ")
        b = Console.ReadLine()
        Console.Write("Enter third value: ")
        c = Console.ReadLine()
        Dim tot, min, max As Integer
        Dim avg As Decimal



        tot = a + b + c
        avg = tot / 3
        If a > b And a > c Then
            max = a
        ElseIf b > a And b > c Then
            max = b
        Else
            max = c
        End If
        If a < b And a < c Then
            min = a
        ElseIf b < a And b < c Then
            min = b
        Else
            min = c
        End If

        Console.WriteLine("The Sum of " + a.ToString() + ", " + b.ToString() + " and " + c.ToString() + " is " + tot.ToString())
        Console.WriteLine("Average is " + avg.ToString())
        Console.WriteLine("Maximum Value is " + max.ToString())
        Console.WriteLine("Minimum value is " + min.ToString())
        Console.WriteLine("Average is " & avg)
        Console.ReadKey()

    End Sub
End Module

Module Module1

    Sub Main()
        Dim no As Integer
        Console.Write("Enter number: ")
        no = Console.ReadLine()

        '        1
        '      1   1
        '    1   2    1
        '  1   3    3    1
        '1   4    6    4   1

        '1
        '1   1
        '1   2    1
        '1   3    3    1
        '1   4    6    4   1

        '0 1 1 2 3 5 8 13 
        Dim value As Integer

        For i = 0 To no - 1
            For k = no - i To 1 Step -1
                Console.Write(" ")
            Next

            value = 1
            For j = 0 To i
                If ((i = 0 Or j = 0) Or j = i) Then
                    value = 1
                Else
                    value = (value * (i - j + 1)) / j
                End If
                Console.Write(value & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module

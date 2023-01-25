Module Module1

    Sub Main()
        'no = 4
        '*
        '* *
        '* * *
        '* * * *

        'pascal triangle
        '       1
        '     1   1
        '    1   2   1
        '  1   3   3   1
        '1   4   6   4  1
        '
        '

        Dim no As Integer
        Dim i, j As Integer
        Console.Write("Enter your number :- ")
        no = Integer.Parse(Console.ReadLine())
        For i = 1 To no
            For j = 1 To i
                Console.Write("* ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module

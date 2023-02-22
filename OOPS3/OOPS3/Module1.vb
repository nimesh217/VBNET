Module Module1

    Sub Main()
        Dim x1, x3, x4 As Integer
        Dim x2 As String

        Console.Write("Enter Value for roll no: ")
        x1 = Integer.Parse(Console.ReadLine())
        Console.Write("Enter Value for Student Name: ")
        x2 = Console.ReadLine()
        Console.Write("Enter Value for subject 1: ")
        x3 = Integer.Parse(Console.ReadLine())
        Console.Write("Enter Value for subject2: ")
        x4 = Integer.Parse(Console.ReadLine())
        'Dim ob As Student
        'ob = New Student()
        'ob.ROLLNO = x1
        'ob.NAME = x2

        'Console.WriteLine(ob.ROLLNO & " " & ob.NAME)

        Dim ob1 As Marks
        ob1 = New Marks()
        ob1.ROLLNO = x1
        ob1.NAME = x2
        ob1.Mark1 = x3
        ob1.Mark2 = x4
        Console.WriteLine(ob1.ROLLNO & " " & ob1.NAME & " " & ob1.Mark1.ToString + " " + ob1.Mark2.ToString)
        Console.ReadKey()
    End Sub

End Module

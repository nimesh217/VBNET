Module Module1

    Sub Main()
        Dim s1, s2 As Student
        s1 = New Student()
        s2 = New Student(49, "Hiren")
        s1.Name = "Nimesh"
        s1.RollNo = 99

        Console.WriteLine("Roll no " & s1.RollNo & " Name is " & s1.Name)

        Console.WriteLine("Roll no " & s2.RollNo & " Name is " & s2.Name)
        'GC.Collect()
        mymethod()


        Dim sm1 As Marks
        sm1 = New Marks()
        sm1.inputdata(55, "Shrikesh", 44, 57)
        sm1.PrintMarks()
        Console.ReadKey()
    End Sub
    Sub mymethod()
        Dim s3 As Student
        s3 = New Student(46, "Hardik")
        Console.WriteLine("Roll no " & s3.RollNo & " Name is " & s3.Name)

    End Sub
End Module

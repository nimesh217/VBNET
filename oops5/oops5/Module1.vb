Imports ClassLibrary1
Imports ClassLibrary2


Module Module1

    Sub Main()
        Dim ob As MyClass1
        ob = New MyClass1()
        ' public, friend, protected friend
        Dim ob2 As MyClass2
        ob2 = New MyClass2()
        ob2.b = 90
        Dim ob3 As Class1
        ob3 = New Class1()
        ob3.b = 99
        'ob3.f = 10
        Dim s As Student
        s = New Student()
        s.rno = 111

        s.u = 99 'protected friend
        s.w = 22 'friend
        s.y = 33 ' pubic
    End Sub

End Module
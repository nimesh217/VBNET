

Module Module1

    Sub Main()
        Dim c As Car
        Dim v, v1 As Vehicle
        c = New Car()
        v = New Vehicle()
        c.Drive("Maruti")
        v.Drive("BASe")
        v1 = New Car()
        v1.Drive("Derived")
        c.sstop()
        Console.ReadKey()

    End Sub

End Module

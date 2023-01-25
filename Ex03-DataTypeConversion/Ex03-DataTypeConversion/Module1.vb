Module Module1
    Sub Main()
        Dim n As Integer
        Dim da As Date
        Dim bl As Boolean = True
        n = 1234567
        da = Today
        Dim f As Double
        f = 4556.24513
        Console.WriteLine(bl)
        Console.WriteLine(da)
        Console.WriteLine(n)
        Console.WriteLine(CStr(bl))
        Console.WriteLine(CSByte(bl))
        Console.WriteLine(CStr(da))
        Console.WriteLine(CChar(CStr(n)))
        Console.WriteLine(CChar(CStr(da)))
        Console.WriteLine(f)
        Console.WriteLine(CStr(f))
        Console.ReadKey()
    End Sub
End Module

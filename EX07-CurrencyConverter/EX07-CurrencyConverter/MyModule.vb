Module MyModule
    Sub sum(ByVal a As Integer, ByVal b As Integer)
        MsgBox(a + b)
    End Sub
    Sub exchange(ByVal a As Integer, ByVal b As Integer)
        Dim t As Integer
        t = a
        a = b
        b = t

    End Sub
End Module

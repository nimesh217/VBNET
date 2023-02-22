Module Module1

    Sub Main()
        Dim ob As Child
        ob = New Child()
        ob.y = 10 'parent member
        ob.K = 20 'child member
        Dim ob2 = New Child2()
        ob2.y = 20
        ob2.j = 30 'child2 member

    End Sub

End Module

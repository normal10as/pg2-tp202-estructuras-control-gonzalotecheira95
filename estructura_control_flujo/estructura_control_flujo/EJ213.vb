Module EJ213
    Sub Main()
        Dim a As Integer
        Dim band As Boolean = True
        a = 1
        Do While a < 1000
            If (a Mod 2 <> 0) Then
                Console.WriteLine(a)
            End If
            a = a + 1
        Loop
        Console.ReadKey()
    End Sub
End Module

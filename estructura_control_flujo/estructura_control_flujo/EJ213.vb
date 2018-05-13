Module EJ213
    Sub Main()
        Dim a As Integer
        Dim band As Boolean = True

        Do While a < 1000
            For i As Integer = 1 To a + 1
                If (a Mod i = 0) Then
                    a = a + 1
                End If
            Next i
            Console.WriteLine(a)
            a = a + 1
        Loop
        Console.ReadKey()
    End Sub
End Module

Module EJ22
    Sub Main()
        Dim a, b, c, d As Integer

        Console.WriteLine("Ingrese 3 numeros para saber el menor: ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()

        If (a < b) And (a < c) Then
            d = a
        ElseIf (b < c) Then
            d = b
        Else
            d = c
        End If
        Console.WriteLine("El numero es:" & d)

        Console.ReadKey()

    End Sub
End Module

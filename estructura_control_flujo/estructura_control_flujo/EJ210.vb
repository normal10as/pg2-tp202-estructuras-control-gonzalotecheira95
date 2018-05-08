Module EJ210
    Sub Main()
        Dim a, b, c, m, j, g As Integer

        Console.WriteLine("Introduca un valor entero")
        a = Console.ReadLine()
        Console.WriteLine("Introduca un valor entero mayor que el primer valor")
        b = Console.ReadLine()

        If a > b Then
            c = a
            a = b
            b = c
        End If

        For j = a To b
            m = j Mod 5

            If m = 0 Then
                Console.WriteLine("numero" & j & "es multiplo de 5")
            End If

        Next
        Do While (g > 0)
            g = b Mod 5
            b = b + 1
            Console.WriteLine("asd" & g)
        Loop


        Console.ReadKey()

    End Sub
End Module

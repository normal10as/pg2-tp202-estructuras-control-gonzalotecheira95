Module EJ211
    Sub Main()
        Dim x, acum, par, impar As Integer
        x = 1
        Do While x > 0
            Console.WriteLine("Ingrese numeros para sumar y 0 para mostrar resultados.")
            x = Console.ReadLine()
            acum = acum + x
            If x Mod 2 = 0 Then
                If x <> 0 Then
                    par = par + 1
                End If
            Else
                impar = impar + 1
            End If

        Loop
        If par = 0 Then
            Console.WriteLine("todos los numeros son impares: ")
        ElseIf impar = 0 Then
            Console.WriteLine("todos los numeros son pares: ")
        End If
        Console.WriteLine("La suma de todos los numero es: " & acum)
        Console.WriteLine("Se han ingresado " & par & "par/es de numero/s.")
        Console.WriteLine("Se han ingresado " & impar & "impar/es de numero/s.")
        Console.ReadKey()
    End Sub
End Module

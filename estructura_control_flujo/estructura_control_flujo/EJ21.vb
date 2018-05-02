Module EJ21

    Sub Main()
        Dim a, b As Integer

        Console.WriteLine("Ingrese 2 numeros: ")
        a = Console.ReadLine()
        b = Console.ReadLine()

        If a < b Then
            Console.WriteLine("El primer numero ingresado es menor al segundo num.")
        ElseIf a = b Then
            Console.WriteLine("Los numeros ingresados son iguales.")
        Else
            Console.WriteLine("el primero numero es mayor al segundo num.")

        End If

        Console.ReadKey()

    End Sub

End Module

Module EJ215

    Friend Const interes As Decimal = 1.36
    Sub Main()
        Dim cant_inicial, cant_mes, interess As Integer
        Dim a, b, c As Integer

        Console.WriteLine("Ingrese el monto inicial: ")
        cant_inicial = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de meses: ")
        cant_mes = Console.ReadLine()
        a = cant_inicial


        For i As Int16 = 1 To cant_mes
            b = cant_inicial * (interes / 12)
            a += c
            c = a + b

            interess = interes + b

            Console.WriteLine(i & "  " & a & " " & b & " " & c)

        Next
        Console.WriteLine(a)
        Console.WriteLine(interess)

        Console.ReadKey()

    End Sub

End Module

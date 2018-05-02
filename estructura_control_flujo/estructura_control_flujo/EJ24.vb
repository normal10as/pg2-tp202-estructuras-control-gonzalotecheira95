Module EJ24
    Sub Main()
        Dim a, b, c, d As Integer

        Console.WriteLine("ingrese cantidad de producto: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese precio del producto por unidad: ")
        b = Console.ReadLine()
        d = (a * b)
        Console.WriteLine("Sub Total" & vbCrLf & "Cantidad por precio unitario: " & d)
        If (a >= 10) And (a <= 50) Then
            c = d * 5 / 100
            Console.WriteLine("Se desconto un 5%")
        ElseIf (a >= 51) And (a <= 250) Then
            c = d * 10 / 100
            Console.WriteLine("Se desconto un 10%")
        ElseIf (a >= 251) Then
            c = d * 20 / 100
            Console.WriteLine("Se desconto un 20%")
        End If

        Console.WriteLine("Monto descontado: " & c)
        Console.WriteLine("Precio Total: " & (d - c))
        Console.ReadKey()

    End Sub
End Module

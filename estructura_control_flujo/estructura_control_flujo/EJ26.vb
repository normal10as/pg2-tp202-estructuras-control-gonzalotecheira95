Module EJ26
    Sub Main()
        Dim a, b, c, d As Integer

        Console.WriteLine("ingrese cantidad de producto: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese precio del producto por unidad: ")
        b = Console.ReadLine()
        d = (a * b)
        Console.WriteLine("Sub Total" & vbCrLf & "Cantidad por precio unitario: " & d)
        Select Case a

            Case Is >= 10
                c = d * 5 / 100
                Console.WriteLine("Se desconto un 5%")
            Case Is >= 51
                c = d * 10 / 100
                Console.WriteLine("Se desconto un 10%")
            Case Is >= 251
                c = d * 20 / 100
                Console.WriteLine("Se desconto un 20%")
        End Select

        Console.WriteLine("Monto descontado: " & c)
        Console.WriteLine("Precio Total: " & (d - c))
        Console.ReadKey()
    End Sub

End Module

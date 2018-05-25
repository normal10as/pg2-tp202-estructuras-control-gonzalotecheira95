Module EJ214
    Sub Main()
        Dim a, b, c, d, tot_desc, tot_cob, tot As Integer

        Do
            Console.WriteLine("ingrese cantidad de producto: ")
            a = Console.ReadLine()
            If a <> 0 Then
                Console.WriteLine("ingrese precio del producto por unidad: ")
                b = Console.ReadLine()
            End If


            d = (a * b)
            tot = (d - c)
            tot_cob = tot_cob + tot
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
            tot_desc = tot_desc + c
            Console.WriteLine("Monto descontado: " & c)
            Console.WriteLine("Precio Total: " & tot)
        Loop While (a <> 0)

        Console.WriteLine("Descuento Total: " & tot_desc)
        Console.WriteLine("Precio Total a cobrar: " & tot_cob)


        Console.ReadKey()
    End Sub
End Module

Module EJ214
    Sub Main()
        Dim cant, preunit, eval, ccc As Integer

        ccc = 1
        Console.WriteLine("Ingrese Cantidad de Productos a Evaluar")
        eval = Console.ReadLine()
        Do
            Console.WriteLine("Producto: " & ccc)
            Console.WriteLine("Ingresar Cantidad de Productos")
            cant = Console.ReadLine()
            Console.WriteLine("Ingresar Precio Unitario Prod.")
            preunit = Console.ReadLine()

            ccc = ccc + 1
        Loop While (ccc < eval)
    End Sub
End Module

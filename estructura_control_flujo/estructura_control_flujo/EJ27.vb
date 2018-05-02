Module EJ27
    Sub Main()
        Dim a As Integer

        Console.WriteLine("Ingrese un grado de angulo para saber a que corresponde:")
        a = Console.ReadLine()

        Select Case a
            Case a < 90
                Console.WriteLine("El angulo es Agudo!.")
            Case a = 90
                Console.WriteLine("El angulo es Recto!.")
            Case a > 90 And a < 180
                Console.WriteLine("El angulo es Obtuso!.")
            Case a = 180
                Console.WriteLine("El angulo es Llano!.")
            Case a > 180 And a < 360
                Console.WriteLine("El angulo es Concavo!.")
            Case a < 0 And a > 360
                Console.WriteLine("Error ingrese un grado que corresponde!.")
        End Select
        Console.ReadKey()

    End Sub
End Module

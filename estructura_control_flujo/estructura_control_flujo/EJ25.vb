Module EJ25
    Sub Main()
        Dim a As String

        Console.WriteLine("Ingrese un numero correspondiente al mes:")
        a = Console.ReadLine()
        Select Case a
            Case "1"
                Console.WriteLine("El mes Ingresado es Enero")
            Case "2"
                Console.WriteLine("El mes Ingresado es Frebrero")
            Case "3"
                Console.WriteLine("El mes Ingresado es Marzo")
            Case "4"
                Console.WriteLine("El mes Ingresado es Abril")
            Case "5"
                Console.WriteLine("El mes Ingresado es Mayo")
            Case "6"
                Console.WriteLine("El mes Ingresado es Junio")
            Case "7"
                Console.WriteLine("El mes Ingresado es Julio")
            Case "8"
                Console.WriteLine("El mes Ingresado es Agosto")
            Case "9"
                Console.WriteLine("El mes Ingresado es Septiembre")
            Case "10"
                Console.WriteLine("El mes Ingresado es Octubre")
            Case "11"
                Console.WriteLine("El mes Ingresado es Noviembre")
            Case "12"
                Console.WriteLine("El mes Ingresado es Diciembre")
            Case Else
                Console.WriteLine("Ingrese un numero correspondiente al mes:")
        End Select
        If a > 12 Then
            a = Console.ReadLine()
        End If
        Console.ReadKey()
    End Sub

End Module

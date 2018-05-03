Module _2_8
    Sub Main()
        Dim a, b As Integer

        Console.WriteLine("ingrese un año")
        a = Console.ReadLine()
        Console.WriteLine("ingrese mes")
        b = Console.ReadLine()


        Select Case b
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes tiene 31 Dias")
            Case 2
                If Es_Bisiesto(a) Then
                    Console.WriteLine("El mes de Febrero tiene 29 dias por ser Bisiesto")
                Else
                    Console.WriteLine("El mes de Febrero tiene 28 dias por no ser Bisiesto")
                End If
            Case 4, 6, 9, 11
                Console.WriteLine("El mes tiene 30 Dias")
            Case Else
                Console.WriteLine("Error en la lectura. Ingrese el numero de mes correcto")
                a = Console.ReadLine()
        End Select
        Console.ReadKey()

    End Sub
    Public Function Es_Bisiesto(Año As Integer) As Boolean
        On Error GoTo ErrorEs_Bisiesto
        If Año Mod 4 = 0 Then
            If (Año Mod 100 = 0) And Not (Año Mod 400 = 0) Then
                Es_Bisiesto = False
            Else
                Es_Bisiesto = True
            End If
        Else
            Es_Bisiesto = False
        End If
        Exit Function
ErrorEs_Bisiesto:
        Es_Bisiesto = False
    End Function
End Module

Module EJ23
    Sub Main()
        Dim a, b, c, d, e As Integer

        Console.WriteLine("Ingrese 5 numeros:")

        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        e = Console.ReadLine()

        If (a > b) And (a > c) And (a > d) And (a > e) Then
            Console.WriteLine("El numero mayor es el primero")
        ElseIf (b > a) And (b > c) And (b > d) And (b > e) Then
            Console.WriteLine("El numero mayor es el segundo")
        ElseIf (c > a) And (c > b) And (c > d) And (c > e) Then
            Console.WriteLine("El numero mayor es el tercero")
        ElseIf (d > a) And (a > b) And (a > c) And (a > e) Then
            Console.WriteLine("El numero mayor es el cuerto")
        ElseIf (e > a) And (e > b) And (e > c) And (e > d) Then
            Console.WriteLine("El numero mayor es el quinto")
        End If

        Console.ReadKey()
    End Sub
End Module

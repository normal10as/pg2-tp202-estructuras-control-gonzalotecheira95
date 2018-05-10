Module EJ212
    Sub Main()
        Dim a As Long = 0
        Dim b As Long = 1
        Dim c As Long
        Dim cc As Integer
        cc = 0
        Do
            Console.WriteLine(c)
            c = c + b

            a = b
            b = c
            cc = cc + 1

        Loop While cc <= 20

        Console.ReadKey()

    End Sub
End Module

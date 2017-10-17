Module Module1

    Sub Main()
        Dim arre(2, 2) As Integer
        Dim cont As Integer = 0
        Dim cont2 As Integer
        Dim val As Integer
        Console.WriteLine("calculo del determinante de una matriz de 3x3")

        While cont < 3
            cont2 = 0
            While cont2 < 3
                Console.Write("valor:")
                val = Integer.Parse(Console.ReadLine())
                arre(cont, cont2) = val
                cont2 = cont2 + 1
                Console.WriteLine("")
            End While
            cont = cont + 1
        End While
        Dim deter As Integer
        deter = arre(0, 0) * ((arre(1, 1) * arre(2, 2)) - (arre(2, 1) * arre(1, 2))) - arre(1, 0) * ((arre(0, 1) * arre(2, 2)) - (arre(2, 1) * arre(0, 2))) + arre(2, 0) * ((arre(0, 1) * arre(1, 2)) - (arre(1, 1) * arre(0, 2)))
        Console.WriteLine("el determinante de tu matriz es:" & deter)
        Console.ReadKey()
    End Sub

End Module

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim contador As Integer
        Dim i As Integer
        Dim impares As Integer
        Dim m As Integer
        Dim mayor As Integer
        Dim multiplo As Integer
        Dim n As Integer
        Dim numeron As Integer
        Dim p As Integer
        Dim pares As Integer
        Dim posicion As Integer
        Dim resto As Double
        Dim x As Integer
        Dim vector(10) As Integer
        Dim par(10) As Integer
        Dim impar(10) As Integer
        Dim vectorinverso(10) As Integer
        Dim multiplos(10) As Integer
        pares = 1
        impares = 1
        multiplo = 1
        For i = 1 To 10
            vector(i) = InputBox()
        Next i
        Console.WriteLine("Ingrese un N° para determinar si existen múltiplos en el Vector")
        numeron = Integer.Parse(Console.ReadLine())
        For n = 1 To 10
            resto = vector(n) Mod 2
            If resto = 0 Then
                par(pares) = vector(n)
                pares = pares + 1
            Else
                impar(impares) = vector(n)
                impares = impares + 1
            End If
        Next n
        Console.Write("N° Par: ")
        For p = 1 To 10
            If par(p) <> 0 Then
                Console.Write(" - ", par(p))
            End If
        Next p
        Console.WriteLine(" ")
        Console.Write("N° Impar: ")
        For i = 1 To 10
            If impar(i) <> 0 Then
                Console.Write(" - ", impar(i))
            End If
        Next i
        For m = 1 To 10
            If vector(m) > mayor Then
                mayor = vector(m)
                posicion = m
            End If
        Next m
        Console.WriteLine(" ")
        Console.WriteLine("El N° Mayor es: ", mayor, " fue ingresado en la: ", posicion, " Posicion")
        For m = 1 To 10
            resto = vector(m) Mod numeron
            If resto = 0 Then
                multiplos(multiplo) = vector(m)
                multiplo = multiplo + 1
            End If
        Next m
        Console.Write("Los Multiplos de N son: ")
        For m = 1 To 10
            If multiplos(m) <> 0 Then
                Console.Write(" - ", multiplos(m))
            End If
        Next m
        Console.WriteLine(" ")
        contador = 10
        For x = 1 To 10
            vectorinverso(x) = vector(contador)
            contador = contador - 1
        Next x
        Console.WriteLine("Vector Inverso")
        For i = 1 To 10
            Console.WriteLine(vectorinverso(i))
        Next i
    End Sub


End Class

Public Class Form1
    Public Function VerifFibo(n As Integer) As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until c = n Or c > n
        Return c = n
    End Function

    Public Function VerifPrimo(n As Integer) As Boolean
        Dim c As Integer
        Dim b As Boolean
        If n > 1 Then
            c = 1
            Do
                c = c + 1
            Loop Until n Mod c = 0
            b = n = c
        Else
            b = False
        End If
        Return b
    End Function

    Public Function VerifMult(n As Integer, m As Integer) As Boolean
        Return n Mod m = 0
    End Function

    Public Function SeRepite(n As Integer, d As Integer) As Boolean
        Dim c, da As Integer
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c > 1
    End Function

    Public Function Cantidad_SeRepiteDig(n As Integer, d As Integer) As Integer
        Dim c, da As Integer
        c = 0
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c
    End Function

    Public Function DigMenor(n As Integer) As Integer
        Dim d, men As Integer
        men = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d < men) Then
                men = d
            End If
        End While
        Return men
    End Function

    Public Function DigMayor(n As Integer) As Integer
        Dim d, may As Integer
        may = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d > may) Then
                may = d
            End If
        End While
        Return may
    End Function

    Public Function EliminarDigito(n As Integer, dig As Integer) As Integer
        Dim d, nu, p As Integer
        Dim b As Boolean
        b = True
        d = 0
        p = -1
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If d <> dig Then
                p = p + 1
                nu = nu + d * 10 ^ p
            Else
                b = False
            End If
        End While
        nu = Unir2Numeros(n, nu)
        Return nu
    End Function

    Public Function Eliminar_Digito(n As Integer, d As Integer) As Integer
        Dim r, da, m As Integer
        r = 0
        m = 1
        While n > 0
            da = n Mod 10
            n = n \ 10
            If d <> da Then
                r = r + (da * m)
                m = m * 10
            End If
        End While
        Return r
    End Function

    Public Function Ndigs(n As Integer) As Integer
        Dim nd As Integer
        nd = 0
        While n > 0
            n = n \ 10
            nd = nd + 1
        End While
        Return nd
    End Function

    Public Function Unir2Numeros(n1 As Integer, n2 As Integer) As Integer
        Dim nu As Integer
        nu = n1 * 10 ^ Ndigs(n2) + n2
        Return nu
    End Function

    Public Function Ordenar_DigMayor_Menor(n As Integer) As Integer
        Dim d, ne As Integer
        ne = 0
        While n > 0
            d = DigMayor(n)
            ne = ne * 10 + d
            n = EliminarDigito(n, d)
        End While
        Return ne
    End Function

    Public Function Ordenar_DigMenor_Mayor(n As Integer) As Integer
        Dim d, ne As Integer
        ne = 0
        While n > 0
            d = DigMenor(n)
            ne = ne * 10 + d
            n = EliminarDigito(n, d)
        End While
        Return ne
    End Function

    Public Function Invertir(n As Integer) As Integer
        Dim d, nu As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            nu = nu * 10 + d
        End While
        Return nu
    End Function

    Public Function Frecuencia_dig(n As Integer, dig As Integer) As Integer
        Dim fd, d As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            If dig = d Then
                fd = fd + 1
            End If
        End While
        Return fd
    End Function

    Public Function BuscDig(n1 As Integer, dig As Integer) As Boolean
        Dim AccDig As Integer
        Dim b As Boolean
        b = False
        Do While n1 > 0
            AccDig = n1 Mod 10
            n1 = n1 \ 10
            If AccDig = dig Then
                b = True
            End If
        Loop
        Return b
    End Function

    Public Function Ejercicio_1(n As Integer) As String
        Dim d, s As Integer
        Dim f, t As String
        Dim b As Boolean
        d = 0 : f = " F = "
        s = 1
        b = True
        While n > 0
            d = n Mod 10
            n = n \ 10
            t = Str(s) + "/" + Str(d)
            If b = True Then
                f = f + " + " + t
            Else
                f = f + " - " + t
            End If
            s = s + 1
            b = Not b
        End While
        Return f
    End Function

    Public Function Ejercicio_2(n As Integer) As String
        Dim d As Integer
        Dim f, t As String
        Dim b As Boolean
        b = True : f = " F = "
        While n > 0
            d = n Mod 10
            n = n \ 10
            t = Str(d) + "!/" + Str(d)
            If b = True Then
                f = f + " - " + t
            Else
                f = f + " + " + t
            End If
            b = Not b
        End While
        Return f
    End Function

    Public Function Ejercicio_3(n As Integer) As String
        Dim d As Integer
        Dim f, t As String
        f = " F = "
        While n > 0
            d = n Mod 10
            n = n \ 10
            t = "1/cos(" + Str(d) + ")"
            If VerifFibo(d) Then
                f = f + t + " + "
            End If
        End While
        Return f
    End Function

    Public Function Ejercicio_4(n As Integer) As Boolean
        Dim d As Integer
        Dim b As Boolean
        b = True
        While n > 0
            d = n Mod 10
            n = n \ 10
            If Not VerifPrimo(d) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function Ejercicio_5(n As Integer) As Boolean
        Dim b As Boolean
        Dim d, dr As Integer
        b = True
        dr = n Mod 10 : n = n \ 10
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If d >= dr Then
                dr = d
            Else
                b = False
            End If
        End While
        Return b
    End Function

    Public Function Ejercicio_6(n As Integer, d1 As Integer) As Integer
        Dim d, r, m As Integer
        r = 0 : m = 1
        While n > 0
            d = n Mod 10
            If Not VerifMult(d, d1) Then
                r = r + (d * m)
                m = m * 10
            End If
            n = EliminarDigito(n, d)
        End While
        Return r
    End Function

    Public Function Ejercicio_7(n As Integer) As Integer
        Dim d, nu As Integer
        nu = 0
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPrimo(d) Then
                nu = nu * 10 + d
            End If
        End While
        Return nu
    End Function

    Public Function Ejercicio_8(n As Integer) As Integer
        Dim da, ne, m, r As Integer
        r = 0 : m = 1
        ne = n
        While n > 0
            da = n Mod 10
            n = n \ 10
            If SeRepite(ne, da) Then
                r = r + (da * m)
                m = m * 10
            End If
        End While
        Return Invertir(r)
    End Function

    Public Function Ejercicio_9(n1 As Integer, n2 As Integer) As Integer
        Dim dig, nu As Integer
        nu = 0
        Do While n1 > 0
            dig = n1 Mod 10
            n1 = n1 \ 10
            If BuscDig(n2, dig) = True Then
                nu = (nu * 10) + dig
            End If
        Loop
        nu = Invertir(nu)
        Return nu
    End Function

    Public Function Ejercicio_10(n As Integer) As Boolean
        Dim d, ref As Integer
        Dim b As Boolean
        ref = n Mod 10 : n = n \ 10
        b = True
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If Not (d = ref) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function Ejercicio_11(n As Integer) As Integer
        Dim da, ne, m, r As Integer
        r = 0 : m = 1
        ne = n
        While n > 0
            da = n Mod 10
            n = n \ 10
            If Not SeRepite(ne, da) Then
                r = r + (da * m)
                m = m * 10
            End If
        End While
        Return r
    End Function

    Public Function Ejercicio_12(n As Integer) As Integer
        Dim rep, noRep, da, r, mRep, mNoRep As Integer
        r = 0 : rep = 0 : noRep = 0
        mRep = 1 : mNoRep = 1
        While (n > 0)
            da = n Mod 10
            If (SeRepite(n, da)) Then
                Dim canRep = Cantidad_SeRepiteDig(n, da)
                While (canRep > 0)
                    rep = rep + (da * mRep)
                    mRep = mRep * 10
                    canRep = canRep - 1
                End While
            Else
                noRep = noRep + (da * mNoRep)
                mNoRep = mNoRep * 10
            End If
            n = Eliminar_Digito(n, da)
        End While
        r = (rep * mNoRep) + noRep
        Return r
    End Function

    Public Function Ejercicio_13(n As Integer) As Integer
        Dim d, dr, mayfrec, n2, frec As Integer
        n2 = n
        dr = n Mod 10
        n = n \ 10
        frec = Frecuencia_dig(n2, dr)
        mayfrec = dr
        While n > 0
            d = n Mod 10
            n = n \ 10
            If Frecuencia_dig(n2, d) > frec Then
                mayfrec = d
                frec = Frecuencia_dig(n2, d)
            End If
        End While
        Return mayfrec
    End Function

    Public Function Ejercicio_14(n As Integer) As Integer
        Dim d, c As Integer
        c = 0
        While (n > 0)
            d = n Mod 10
            If SeRepite(n, d) Then
                c = c + 1
            Else
                c = c + 1
            End If
            n = Eliminar_Digito(n, d)
        End While
        Return c
    End Function

    Public Function Ejercicio_15(n As Integer, d1 As Integer, d2 As Integer) As Integer
        Dim d, nu, m As Integer
        nu = 0 : m = 1
        While n > 0
            d = n Mod 10
            n = n \ 10
            If d = d1 Then
                nu = nu + (d2 * m)
                m = m * 10
            Else
                nu = nu + (d * m)
                m = m * 10
            End If
        End While
        Return nu
    End Function


    Private Sub EJERCICIO1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_1(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_2(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO3ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_3(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO4ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_4(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO5ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_5(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO6ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_6(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub EJERCICIO7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO7ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_7(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO8ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_8(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO9ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_9(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub EJERCICIO10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO10ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio_10(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem1.Click
        TextBox2.Text = Ejercicio_11(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem1.Click
        TextBox2.Text = Ejercicio_12(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIO3ToolStripMenuItem1.Click
        TextBox2.Text = Ejercicio_13(TextBox1.Text)
    End Sub
    Private Sub EJERCICIO4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIO4ToolStripMenuItem1.Click
        TextBox2.Text = Ejercicio_14(TextBox1.Text)
    End Sub

    Private Sub EJERCICIO5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIO5ToolStripMenuItem1.Click
        TextBox2.Text = Ejercicio_15(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub
End Class

Public Class Form1
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

    Public Function Invertir(n As Integer) As Integer
        Dim d, nu As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            nu = nu * 10 + d
        End While
        Return nu
    End Function

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

    Public Function OrderDigMenorMayor(n As Integer) As Integer
        Dim d, ne As Integer
        ne = 0
        While n > 0
            d = DigMenor(n)
            ne = ne * 10 + d
            n = EliminarDigito(n, d)
        End While
        Return ne
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

    Public Function Respuesta_1(n As Integer) As Integer
        Dim d, nu As Integer
        nu = 0
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPrimo(d) Then
                nu = nu * 10 + d
                If SeRepite(nu, d) Then
                    nu = Eliminar_Digito(nu, d)
                    nu = nu * 10 + d
                End If
            End If
        End While
        Return Invertir(nu)
    End Function

    Public Function Respuesta_2(n As Integer, d1 As Integer, d2 As Integer) As Integer
        Dim d, nu, m As Integer
        nu = 0 : m = 1           'n = 234581: d1 = 3: d2 = 5
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d = d2) Then
                nu = nu + (d1 * m)
                m = m * 10
            Else
                If (d = d1) Then
                    nu = nu + (d2 * m)
                    m = m * 10
                Else
                    nu = nu + (d * m)
                    m = m * 10
                End If
            End If
        End While
        Return nu
    End Function

    Public Function Respuesta_3(n As Integer) As Integer
        Dim d, nu As Integer
        nu = 0                          ' n = 6535422
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifFibo(d) Then
                nu = nu * 10 + d
                If SeRepite(nu, d) Then
                    nu = Eliminar_Digito(nu, d)
                    nu = nu * 10 + d
                End If
            End If
        End While
        Return Invertir(nu)
    End Function

    Public Function Respuesta_4(n As Integer) As Integer
        Dim d, nu, p As Integer
        Dim b As Boolean
        nu = 0 : p = -1                   ' n = 43537
        b = True
        While n > 0
            d = n Mod 10
            n = n \ 10
            If b = True Then
                p = p + 1
                nu = nu + d * 10 ^ p
            End If
        End While
        Return nu
    End Function

    Public Function Respuesta_1_SD(n As Integer, d1 As Integer) As Integer
        Dim d, aux, p, r As Integer
        Dim b As Boolean
        b = True : aux = 0 : p = -1
        While (n > 0) And (b = True)
            d = n Mod 10
            n = n \ 10
            If d > d1 Then
                p = p + 1
                aux = aux + d * 10 ^ p
            Else
                b = False
            End If
        End While
        If b = False Then
            n = n * 10 + d
            n = n * 10 + d1
            r = Unir2Numeros(n, aux)
        Else
            r = Unir2Numeros(d1, aux)
        End If
        Return r
    End Function

    Public Function Respuesta_5(n As Integer, d1 As Integer) As Integer
        Return OrderDigMenorMayor(Unir2Numeros(n, d1))
    End Function

    Private Sub RESPUESTA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA2ToolStripMenuItem.Click
        TextBox4.Text = Respuesta_2(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub RESPUESTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA1ToolStripMenuItem.Click
        TextBox4.Text = Respuesta_1(TextBox1.Text)
    End Sub

    Private Sub RESPUESTA1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RESPUESTA1ToolStripMenuItem1.Click
        TextBox4.Text = Respuesta_3(TextBox1.Text)
    End Sub

    Private Sub RESPUESTA2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RESPUESTA2ToolStripMenuItem1.Click
        TextBox4.Text = Respuesta_4(TextBox1.Text)
    End Sub

    Private Sub RESPUESTA2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RESPUESTA2ToolStripMenuItem2.Click
        TextBox4.Text = Respuesta_2(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub RESPUESTA1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RESPUESTA1ToolStripMenuItem2.Click
        TextBox4.Text = Respuesta_5(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub RESPUESTA21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA21ToolStripMenuItem.Click
        TextBox4.Text = Respuesta_1_SD(TextBox1.Text, TextBox2.Text)
    End Sub
End Class

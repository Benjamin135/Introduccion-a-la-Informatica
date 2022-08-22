Public Class Form1
    Public Function Serie_Factorial(n As Integer) As Double
        Dim i As Integer
        Dim f As Double
        If (n > 0) Then
            f = 1
            For i = n To 1 Step -1
                f = f * i
            Next
        Else
            f = 1
        End If
        Return f
    End Function

    Public Function Serie_1(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, m As Double
        f = 0
        m = 10
        For i = 1 To n
            t = Math.Log10(m) / (vi + (i - 1) * r)
            m = m * 10
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie1_Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim m As Double
        f = " F = "
        m = 10
        For i = 1 To n
            t = "Log10(" + Str(m) + ")/(" + Str(vi + (i - 1) * r) + ") + "
            m = m * 10
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_2(n As Integer, vi As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = vi
            vi = vi - i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie2_Tex(n As Integer, vi As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = Str(vi) + " + "
            vi = vi - i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_3(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, s, vi2, r2 As Double
        f = 0
        vi2 = 10 : r2 = 2
        For i = 1 To n
            s = vi2 - (i - 1) * r2
            t = (vi + (i - 1) * r) / Serie_Factorial(s)
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie3_Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim s, vi2, r2 As Double
        f = " F = "
        vi2 = 10 : r2 = 2
        For i = 1 To n
            s = vi2 - (i - 1) * r2
            t = Str(vi + (i - 1) * r) + "/" + Str(s) + "! + "
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_4(n As Integer, x As Double, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, s, vi2, r2 As Double
        f = 0
        vi2 = 2 : r2 = 2
        For i = 1 To n
            s = vi2 + (i - 1) * r2
            t = x ^ (vi + (i - 1) * r) / Serie_Factorial(s)
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie4_Tex(n As Integer, x As Double, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim s, vi2, r2 As Double
        f = " F = "
        vi2 = 2 : r2 = 2
        For i = 1 To n
            s = vi2 + (i - 1) * r2
            t = "(x^" + Str(vi + (i - 1) * r) + ")/" + Str(s) + "! + "
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_5(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, z, x, y As Double
        f = 0
        x = -1 : y = 1
        For i = 1 To n
            z = x + y : x = y : y = z
            t = z ^ (1 / (vi + (i - 1) * r))
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie5_Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim z, x, y As Double
        f = " F = "
        x = -1 : y = 1
        For i = 1 To n
            z = x + y : x = y : y = z
            t = Str(z) + " ^ (1/" + Str(vi + (i - 1) * r) + ") + "
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_6(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As Double
        Dim i As Integer
        Dim f As Double
        f = 0
        For i = 1 To n
            If i Mod 2 = 1 Then
                f = f + (Math.Cos(vi1 + (i - 1) * r1) ^ (1 / (vi + (i - 1) * r)))
            Else
                f = f - (Math.Cos(vi1 + (i - 1) * r1) ^ (1 / (vi + (i - 1) * r)))
            End If
        Next
        Return f
    End Function

    Public Function Serie6_Tex(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As String
        Dim i As Integer
        Dim f As String
        f = " F = "
        For i = 1 To n
            If i Mod 2 = 1 Then
                f += "Cos(" + Str(vi1 + (i - 1) * r1) + ") ^ (1/" + Str(vi + (i - 1) * r) + ") - "
            Else
                f += "Cos(" + Str(vi1 + (i - 1) * r1) + ") ^ (1/" + Str(vi + (i - 1) * r) + ") + "
            End If
        Next
        Return f
    End Function

    Public Function Serie_7(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As Double
        Dim i As Integer
        Dim f As Double
        f = 0
        For i = 1 To n
            If i Mod 2 = 1 Then
                f = f - (Math.Sqrt(Math.Sin(vi + (i - 1) * r) / (Serie_Factorial(vi1 + (i - 1) * r1) / 2)))
            Else
                f = f + (Math.Sqrt(Math.Sin(vi + (i - 1) * r) / (Serie_Factorial(vi1 + (i - 1) * r1) / 2)))
            End If
        Next
        Return f
    End Function

    Public Function Serie7_Tex(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As String
        Dim i As Integer
        Dim f As String
        f = " F = "
        For i = 1 To n
            If i Mod 2 = 1 Then
                f += " - Sqrt(Sin(" + Str(vi + (i - 1) * r) + ")/(" + Str(vi1 + (i - 1) * r1) + "!/2))"
            Else
                f += " + Sqrt(Sin(" + Str(vi + (i - 1) * r) + ")/(" + Str(vi1 + (i - 1) * r1) + "!/2))"
            End If
        Next
        Return f
    End Function

    Public Function Serie_8(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, m As Double
        f = 0
        m = 1000
        For i = 1 To n
            t = (Math.PI / (vi + (i - 1) * r)) / Math.Sqrt(m)
            m = m + i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie8_Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim m As Double
        f = " F = "
        m = 1000
        For i = 1 To n
            t = "(PI/" + Str(vi + (i - 1) * r) + ")/Sqrt(" + Str(m) + ") + "
            m = m + i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_9(n As Integer, m As Double, d As Double, x As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = (x / d) ^ (1 / m)
            d = d / 2
            m = m * 2
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie9_Tex(n As Integer, m As Double, d As Double, x As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = "(x/" + Str(d) + ") ^ (1/" + Str(m) + ") + "
            d = d / 2
            m = m * 2
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_10(n As Integer, b As Double, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, e As Double
        f = 0
        For i = 1 To n
            e = vi + (i - 1) * r
            t = b ^ (1 / e)
            b = b * 2
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie10_Tex(n As Integer, b As Double, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim e As Double
        f = " F = "
        For i = 1 To n
            e = vi + (i - 1) * r
            t = Str(b) + "^ (1 /" + Str(e) + ") + "
            b = b * 2
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_11(n As Integer, vi As Double, r As Double, x As Double, m As Double) As Double
        Dim i As Integer
        Dim f, t, c As Double
        Dim b As Boolean
        b = True
        f = 0
        c = 0
        For i = 1 To n
            c = c + 2
            m = m - (i - 1)
            t = (Math.Sin(vi + (i - 1) * r) / ((Serie_Factorial(c) + x) / m)) ^ (1 / c)
            If b = True Then
                f = f - t
            Else
                f = f + t
            End If
            b = Not b
        Next
        Return f
    End Function

    Public Function Serie11_Tex(n As Integer, vi As Double, r As Double, x As Double, m As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim c As Double
        Dim b As Boolean
        b = True
        f = " F = "
        c = 0
        For i = 1 To n
            c = c + 2
            m = m - (i - 1)
            t = "(Sin(" + Str(vi + (i - 1) * r) + ")/(" + Str(c) + "! + x)/" + Str(m) + ")^(1/" + Str(c) + ")"
            If b = True Then
                f = f + " - " + t
            Else
                f = f + " + " + t
            End If
            b = Not b
        Next
        Return f
    End Function

    Private Sub SERIE1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE1ToolStripMenuItem.Click
        TextBox6.Text = Serie_1(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = Serie1_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIE2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE2ToolStripMenuItem.Click
        TextBox6.Text = Serie_2(TextBox1.Text, TextBox2.Text)
        TextBox7.Text = Serie2_Tex(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SERIE3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE3ToolStripMenuItem.Click
        TextBox6.Text = Serie_3(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = Serie3_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIE4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE4ToolStripMenuItem.Click
        TextBox6.Text = Serie_4(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox7.Text = Serie4_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub SERIE5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE5ToolStripMenuItem.Click
        TextBox6.Text = Serie_5(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = Serie5_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIE6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE6ToolStripMenuItem.Click
        TextBox6.Text = Serie_6(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie6_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub

    Private Sub SERIE7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE7ToolStripMenuItem.Click
        TextBox6.Text = Serie_7(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie7_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub

    Private Sub SERIE8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE8ToolStripMenuItem.Click
        TextBox6.Text = Serie_8(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = Serie8_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIE9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE9ToolStripMenuItem.Click
        TextBox6.Text = Serie_9(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox7.Text = Serie9_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub SERIE10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE10ToolStripMenuItem.Click
        TextBox6.Text = Serie_10(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox7.Text = Serie10_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub SERIE11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE11ToolStripMenuItem.Click
        TextBox6.Text = Serie_11(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie11_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class

Public Class Form1
    Public Function S_Regular(n As Integer, vi As Double, r As Double) As String
        Dim s As String
        Dim i As Integer
        Dim t As Double
        s = ""
        For i = 1 To n
            t = vi + (i - 1) * r
            s = s + Str(t) + ","
        Next
        Return s
    End Function

    Public Function S_Fibonacci(n As Integer, x As Double, y As Double) As Double
        Dim i As Integer
        Dim z, s As Double
        s = 0
        For i = 1 To n
            z = x + y
            s = s + z
            x = y
            y = z
        Next
        Return s
    End Function

    Public Function S_FibonacciProg(n As Integer, x As Double, y As Double) As String
        Dim s As String
        Dim i As Integer
        Dim z As Double
        s = ""
        For i = 1 To n
            z = x + y
            s = s + Str(z) + ","
            x = y
            y = z
        Next
        Return s
    End Function

    Public Function S_FibonacciRegr(n As Integer, x As Double, y As Double) As String
        Dim s As String
        Dim i As Integer
        Dim z As Double
        s = ""
        For i = 1 To n
            z = x - y
            s = s + Str(z) + ","
            x = y
            y = z
        Next
        Return s
    End Function

    Public Function S_Divisor(n As Integer, vi As Double, d As Double) As String
        Dim s As String
        Dim i As Integer
        Dim va As Double
        va = vi * d
        s = ""
        For i = 1 To n
            va = va / d
            s = s + Str(va) + ","
        Next
        Return s
    End Function

    Public Function S_Multiplicador(n As Integer, vi As Double, m As Double) As String
        Dim s As String
        Dim i As Integer
        Dim va As Double
        va = vi / m
        s = ""
        For i = 1 To n
            va = va * m
            s = s + Str(va) + ","
        Next
        Return s
    End Function

    Public Function S_ExponencialProg(n As Integer, b As Double) As String
        Dim s As String
        Dim i As Integer
        Dim t As Double
        s = ""
        For i = 1 To n
            t = b ^ i
            s = s + Str(t) + ","
        Next
        Return s
    End Function

    Public Function S_ExponencialRegr(n As Integer, b As Double) As String
        Dim s As String
        Dim i As Integer
        Dim t As Double
        s = ""
        For i = n To 1 Step -1
            t = b ^ i
            s = s + Str(t) + ","
        Next
        Return s
    End Function

    Public Function S_DigitosProg(n As Integer, d As Double) As String
        Dim s As String
        Dim i As Integer
        Dim nu As Double
        s = ""
        nu = 0
        For i = 1 To n
            nu = nu * 10 + d
            s = s + Str(nu) + ","
        Next
        Return s
    End Function

    Public Function S_DigitosRegr(n As Integer) As String
        Dim s As String
        Dim nu As Double
        s = ""
        nu = n * 10
        Do
            nu = nu \ 10
            s = s + Str(nu) + ","
        Loop Until nu < 10
        Return s
    End Function

    Public Function S_Factorial(n As Integer) As Double
        Dim f As Double
        Dim i As Integer
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

    Public Function S_Numerica1(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim t, f As Double
        f = 0
        For i = 1 To n
            t = 1 / (vi + (i - 1) * r)
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica1Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = "1" + "/" + Str(vi + (i - 1) * r) + "+"
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica2(n As Integer, vi As Double, r As Double, x1 As Double) As Double
        Dim i As Integer
        Dim x, y, z, f, t As Double
        x = -1 : y = 1
        f = 0
        For i = 1 To n
            z = x + y : x = y : y = z
            t = Math.Sqrt((vi + (i - 1) * r) + x1) / S_Factorial(z)
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica2Tex(n As Integer, vi As Double, r As Double, x1 As Double) As String
        Dim i As Integer
        Dim x, y, z As Double
        Dim f, t As String
        x = -1 : y = 1
        f = " F = "
        For i = 1 To n
            z = x + y : x = y : y = z
            t = "Sqrt(" + Str(vi + (i - 1) * r) + " + x1) /" + Str(z) + "!"
            f = f + t + "+"
        Next
        Return f
    End Function

    Public Function S_Numerica3(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double, vim As Double, m As Double, d As Double) As Double
        Dim am, ad, f, t As Double
        Dim i As Integer
        am = vim / m : ad = 0 : f = 0
        For i = 1 To n
            am = am * m : ad = ad * 10 + d
            t = (Math.Sin(vi2 + (i - 1) * r2) / (am + ad)) ^ (1 / (vi1 + (i - 1) * r1))
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica3Tex(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double, vim As Double, m As Double, d As Double) As String
        Dim am, ad As Double
        Dim f, t As String
        Dim i As Integer
        am = vim / m : ad = 0 : f = " F = "
        For i = 1 To n
            am = am * m : ad = ad * 10 + d
            t = "(Sin(" + Str(vi2 + (i - 1) * r2) + ")) / (" + Str(am) + " + " + Str(ad) + ") ^ (1 / (" + Str(vi1 + (i - 1) * r1) + "))"
            f = f + t + " + "
        Next
        Return f
    End Function

    Public Function S_Numerica4(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = vi1 + (i - 1) * r1 / vi2 + (i - 1) * r2
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica4Tex(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = Str(vi1 + (i - 1) * r1) + " /" + Str(vi2 + (i - 1) * r2)
            f = f + t + " + "
        Next
        Return f
    End Function

    Public Function S_Numerica5(n As Integer, vim As Double, m As Double, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, am As Double
        am = vim / m : f = 0
        For i = 1 To n
            am = am * m
            t = am / S_Factorial(vi + (i - 1) * r)
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica5Tex(n As Integer, vim As Double, m As Double, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        Dim am As Double
        am = vim / m : f = " F = "
        For i = 1 To n
            am = am * m
            t = Str(am) + " / " + Str(vi + (i - 1) * r) + "!"
            f = f + t + " + "
        Next
        Return f
    End Function

    Public Function S_Numerica6(n As Integer, x As Double, y As Double, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim z, f, t As Double
        f = 0
        For i = 1 To n
            z = x + y : x = y : y = z
            t = z / S_Factorial(vi + (i - 1) * r)
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica6Tex(n As Integer, x As Double, y As Double, vi As Double, r As Double) As String
        Dim i As Integer
        Dim z As Double
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            z = x + y : x = y : y = z
            t = Str(z) + " / " + Str(vi + (i - 1) * r) + "!"
            f = f + t + " + "
        Next
        Return f
    End Function

    Public Function S_Numerica7(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As Double
        Dim i As Integer
        Dim f, t, b As Double
        f = 0
        For i = 1 To n
            b = (vi1 + (i - 1) * r1) ^ 3
            t = b / S_Factorial(vi2 + (i - 1) * r2) + 1
            f = f + t
        Next
        Return f
    End Function

    Public Function S_Numerica7Tex(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = "(" + Str(vi1 + (i - 1) * r1) + " ^ 3) / (" + Str(vi2 + (i - 1) * r2) + "! + 1)"
            f = f + t + " + "
        Next
        Return f
    End Function

    Public Function Serie_1(n As Integer, vi As Double) As String
        Dim s As String
        Dim i As Integer
        Dim t As Double
        s = ""
        For i = 1 To n
            t = vi + i
            s = s + Str(t) + ","
        Next
        Return s
    End Function

    Public Function S_Factorial_(n As Integer) As String
        Dim i As Integer
        Dim f As Double
        Dim s As String
        s = ""
        f = 1
        For i = 1 To n
            f = f * i
            s = s + Str(f) + ","
        Next
        Return s
    End Function

    Public Function Serie2(n As Integer, vi As Double, va As Double) As String
        Dim i As Integer
        Dim s As String
        Dim t As Double
        s = ""
        If (n = 0) Then
            t = va
            For i = 1 To n
                t = t + 2
            Next
        Else
            n = 1
            s = s + Str(t)
        End If
        Return s
    End Function

    Private Sub SERIEPROGRESIVOREGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEPROGRESIVAREGRESIVAToolStripMenuItem.Click
        TextBox4.Text = S_Regular(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIEDEFIBONACCIPROGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEDEFIBONACCIPROGRESIVAToolStripMenuItem.Click
        TextBox4.Text = S_FibonacciProg(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIEDEFIBONACCIREGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEDEFIBONACCIREGRESIVAToolStripMenuItem.Click
        TextBox4.Text = S_FibonacciRegr(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIEDIVISORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEDIVISORToolStripMenuItem.Click
        TextBox4.Text = S_Divisor(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIEMULTIPLICADORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEMULTIPLICADORToolStripMenuItem.Click
        TextBox4.Text = S_Multiplicador(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIEEXPONENCIALPROGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEEXPONENCIALToolStripMenuItem.Click
        TextBox4.Text = S_ExponencialProg(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SERIEEXPONENCIALREGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEEXPONENCIALREGRESIVAToolStripMenuItem.Click
        TextBox4.Text = S_ExponencialRegr(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SERIEDEDIGITIOSPROGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEDEDIGITIOSPROGRESIVOToolStripMenuItem.Click
        TextBox4.Text = S_DigitosProg(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SERIEDEDIGITOSREGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEDEDIGITOSREGRESIVOToolStripMenuItem.Click
        TextBox4.Text = S_DigitosRegr(TextBox1.Text)
    End Sub

    Private Sub SERIEFACTORIALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEFACTORIALToolStripMenuItem.Click
        TextBox4.Text = S_Factorial(TextBox1.Text)
    End Sub

    Private Sub SERIENUMERICA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA1ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica1(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox5.Text = S_Numerica1Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub SERIENUMERICA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA2ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica2(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text)
        TextBox5.Text = S_Numerica2Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text)
    End Sub

    Private Sub SERIENUMERICA3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA3ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica3(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text)
        TextBox5.Text = S_Numerica3Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text)
    End Sub

    Private Sub SERIEPROGRESIVOPROGRESIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA4ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica4(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
        TextBox5.Text = S_Numerica4Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
    End Sub

    Private Sub SERIEMULTIPLICADORFACTORIALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA5ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica5(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
        TextBox5.Text = S_Numerica5Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
    End Sub

    Private Sub SERIEFIBONACCIFACTORIALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIENUMERICA6ToolStripMenuItem.Click
        TextBox4.Text = S_Numerica6(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
        TextBox5.Text = S_Numerica6Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
    End Sub

    Private Sub SERIEPROGRESIVAEXPONENCIALFACTORIALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEPROGRESIVAEXPONENCIALFACTORIALToolStripMenuItem.Click
        TextBox4.Text = S_Numerica7(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
        TextBox5.Text = S_Numerica7Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text)
    End Sub

    Private Sub SERIE1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE1ToolStripMenuItem.Click
        TextBox4.Text = Serie_1(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SERIEFACTORIAL2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIE2ToolStripMenuItem.Click
        TextBox4.Text = S_Factorial(TextBox1.Text)
    End Sub

    Private Sub SERIEFIBONACCIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERIEFIBONACCIToolStripMenuItem.Click
        TextBox4.Text = S_Fibonacci(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class

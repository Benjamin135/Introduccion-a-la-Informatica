Public Class Form1
    Public Function A_Cuadrado(l As Double) As Double
        Dim Ac As Double = l ^ 2
        Return Ac
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = b * h / 2
        Return At
    End Function

    Public Function Dif_1(l As Double) As Double
        Dim Dif1 As Double = A_Cuadrado(l) - A_Triangulo(l, l / 2)
        Return Dif1
    End Function

    Private Sub RESPUESTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA1ToolStripMenuItem.Click
        TextBox2.Text = Dif_1(TextBox1.Text)
    End Sub



    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = b * h
        Return At
    End Function

    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.PI * r ^ 2
        Return Ac
    End Function

    Public Function Peri_Cir(r As Double) As Double
        Dim PeriCir As Double
        PeriCir = 2 * Math.PI * r
        Return PeriCir
    End Function

    Public Function Sum_4(r As Double, h As Double) As Double
        Dim Sum4 As Double = 2 * A_Circunfrencia(r) + A_Rectangulo(Peri_Cir(r), h)
        Return Sum4
    End Function

    Private Sub RESPUESTA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA2ToolStripMenuItem.Click
        TextBox2.Text = Sum_4(TextBox1.Text, TextBox3.Text)
    End Sub
End Class

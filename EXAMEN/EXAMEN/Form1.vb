Public Class Form1
    Public Function A_Circunferencia(r As Double) As Double
        Dim Ac As Double = 3.1416 * r ^ 2
        Return Ac
    End Function

    Public Function A_Trapecio(a As Double, b As Double, h As Double) As Double
        Dim At As Double = (a + b) / 2 * h
        Return At
    End Function

    Public Function Dif_Area(a As Double, b As Double, h As Double) As Double
        Dim Dif As Double = A_Trapecio(a, b, h) - 1 / 2 * A_Circunferencia(b / 2)
        Return Dif
    End Function

    Public Function A_Rectangulo(a As Double, b As Double) As Double
        Dim Ar As Double = a * b
        Return Ar
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = b * h / 2
        Return At
    End Function

    Public Function Sum_Area(a As Double, b As Double, h As Double) As Double
        Dim Sum As Double = A_Rectangulo(a, b) + 2 * A_Triangulo(a, h) + 2 * A_Triangulo(b, h)
        Return Sum 
    End Function

    Private Sub RESPUESTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA1ToolStripMenuItem.Click
        TextBox4.Text = Dif_Area(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub RESPUESTA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA2ToolStripMenuItem.Click
        TextBox4.Text = Sum_Area(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class

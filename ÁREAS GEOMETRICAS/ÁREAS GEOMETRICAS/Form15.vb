Public Class Form15
    Public Function A_Cuadrado(a As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(a ^ 2), 2)
        Return Ac
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Public Function Dif_1(l As Double) As Double
        Dim Dif1 As Double = A_Cuadrado(l) - A_Triangulo(l, l / 2)
        Return Dif1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Dif_1(TextBox1.Text)
    End Sub
End Class
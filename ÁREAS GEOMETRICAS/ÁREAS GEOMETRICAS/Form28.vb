Public Class Form28
    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2), 2)
        Return Ac
    End Function

    Public Function Peri_Cir(r As Double) As Double
        Dim PeriCir As Double
        PeriCir = Math.Round(Convert.ToDouble(2 * 3.1416 * r), 2)
        Return PeriCir
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Public Function Sum_7(r As Double, h As Double) As Double
        Dim Sum7 As Double = A_Circunfrencia(r) + A_Triangulo(Peri_Cir(r), h)
        Return Sum7
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Sum_7(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
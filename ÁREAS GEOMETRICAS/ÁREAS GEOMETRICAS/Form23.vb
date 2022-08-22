Public Class Form23
    Public Function A_Trapecio(b As Double, a As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble((b + a) / 2 * h), 2)
        Return At
    End Function

    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2), 2)
        Return Ac
    End Function

    Public Function Peri_Cir(r As Double) As Double
        Dim PeriCir As Double
        PeriCir = Math.Round(Convert.ToDouble(2 * 3.1416 * r), 2)
        Return PeriCir
    End Function

    Public Function Sum_2(r1 As Double, r2 As Double, h As Double) As Double
        Dim Sum2 As Double = A_Trapecio(Peri_Cir(r2), Peri_Cir(r1), h) + A_Circunfrencia(r1) + A_Circunfrencia(r2)
        Return Sum2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Sum_2(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
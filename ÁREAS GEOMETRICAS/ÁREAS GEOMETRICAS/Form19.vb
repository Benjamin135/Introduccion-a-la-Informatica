Public Class Form19
    Public Function A_Triangulo_Eq(a As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(Math.Sqrt(3) / 4 * a ^ 2), 2)
        Return At
    End Function

    Public Function Apotema_Tri_Eq(a As Double) As Double
        Dim Ap As Double = Math.Round(Convert.ToDouble(Math.Sqrt(3) / 6 * a), 2)
        Return Ap
    End Function

    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2), 2)
        Return Ac
    End Function

    Public Function Dif_5(a As Double) As Double
        Dim Dif5 As Double = A_Triangulo_Eq(a) - A_Circunfrencia(Apotema_Tri_Eq(a))
        Return Dif5
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Dif_5(TextBox1.Text)
    End Sub
End Class
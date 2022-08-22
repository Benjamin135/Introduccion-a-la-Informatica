Public Class Form20
    Public Function A_Cuadrado(a As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(a ^ 2), 2)
        Return Ac
    End Function

    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2), 2)
        Return Ac
    End Function

    Public Function Dif_6(l As Double) As Double
        Dim Dif6 As Double = A_Cuadrado(l) - 1 / 2 * A_Circunfrencia(l / 2)
        Return Dif6
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Dif_6(TextBox1.Text)
    End Sub
End Class
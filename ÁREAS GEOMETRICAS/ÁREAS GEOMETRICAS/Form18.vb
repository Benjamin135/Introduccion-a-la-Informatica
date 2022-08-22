Public Class Form18
    Public Function A_Trapecio(b As Double, a As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble((b + a) / 2 * h), 2)
        Return At
    End Function

    Public Function A_Circunfrencia(r As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2), 2)
        Return Ac
    End Function

    Public Function Dif_4(a As Double, b As Double, h As Double) As Double
        Dim Dif4 As Double = A_Trapecio(a, b, h) - 1 / 2 * A_Circunfrencia(b / 2)
        Return Dif4
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Dif_4(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
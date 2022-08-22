Public Class Form26
    Public Function A_Hexagono(l As Double, ap As Double) As Double
        Dim Ah As Double = Math.Round(Convert.ToDouble(3 * l * ap), 2)
        Return Ah
    End Function

    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h), 2)
        Return At
    End Function

    Public Function Sum_5(l As Double, ap As Double, h As Double) As Double
        Dim Sum5 As Double = 6 * A_Rectangulo(l, h) + 2 * A_Hexagono(l, ap)
        Return Sum5
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Sum_5(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
Public Class Form27
    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h), 2)
        Return At
    End Function

    Public Function Sum_6(x As Double, y As Double, z As Double) As Double
        Dim Sum6 As Double = 2 * A_Rectangulo(x, z) + 2 * A_Rectangulo(y, z) + 2 * A_Rectangulo(x, y)
        Return Sum6
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Sum_6(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
Public Class Form4
    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = A_Triangulo(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
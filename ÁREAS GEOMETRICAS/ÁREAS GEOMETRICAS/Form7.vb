Public Class Form7
    Public Function A_Trapecio(b As Double, a As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble((b + a) / 2 * h), 2)
        Return At
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = A_Trapecio(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
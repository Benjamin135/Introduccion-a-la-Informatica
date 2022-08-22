Public Class Form6
    Public Function A_Elipse(a As Double, b As Double) As Double
        Dim Ae As Double = Math.Round(Convert.ToDouble(3.1416 * a * b), 2)
        Return Ae
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = A_Elipse(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
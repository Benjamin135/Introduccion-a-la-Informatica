Public Class Form13
    Public Function V_Piramide(a As Double, b As Double, h As Double) As Double
        Dim Vp As Double = Math.Round(Convert.ToDouble(a * b * h / 3), 2)
        Return Vp
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = V_Piramide(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
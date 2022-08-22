Public Class Form12
    Public Function V_Cono(r As Double, h As Double) As Double
        Dim Vc As Double = Math.Round(Convert.ToDouble(3.1416 * r ^ 2 * h / 3), 2)
        Return Vc
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = V_Cono(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
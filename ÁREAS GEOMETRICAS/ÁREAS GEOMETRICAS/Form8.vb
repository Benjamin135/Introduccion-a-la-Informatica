Public Class Form8
    Public Function A_Rombo(d1 As Double, d2 As Double) As Double
        Dim Ar As Double = Math.Round(Convert.ToDouble(d1 * d2 / 2), 2)
        Return Ar
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = A_Rombo(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
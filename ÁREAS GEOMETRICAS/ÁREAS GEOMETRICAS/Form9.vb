Public Class Form9
    Public Function A_Pentagono(l As Double, apt As Double) As Double
        Dim Ap As Double = Math.Round(Convert.ToDouble(5 * l * apt / 2), 2)
        Return Ap
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = A_Pentagono(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
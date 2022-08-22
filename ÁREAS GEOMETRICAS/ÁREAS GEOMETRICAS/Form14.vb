Public Class Form14
    Public Function V_Prisma(l As Double, h As Double, ap As Double) As Double
        Dim Vp As Double = Math.Round(Convert.ToDouble(5 * l * ap / 2 * h), 2)
        Return Vp
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = V_Prisma(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
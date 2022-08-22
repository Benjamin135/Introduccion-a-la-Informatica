Public Class Form5
    Public Function A_Cuadrado(a As Double) As Double
        Dim Ac As Double = Math.Round(Convert.ToDouble(a ^ 2), 2)
        Return Ac
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = A_Cuadrado(TextBox1.Text)
    End Sub
End Class
Public Class Form10
    Public Function A_Hexagono(l As Double, ap As Double) As Double
        Dim Ah As Double = Math.Round(Convert.ToDouble(3 * l * ap), 2)
        Return Ah
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = A_Hexagono(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
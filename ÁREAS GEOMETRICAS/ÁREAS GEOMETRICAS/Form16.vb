Public Class Form16
    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h), 2)
        Return At
    End Function

    Public Function A_Elipse(a As Double, b As Double) As Double
        Dim Ae As Double = Math.Round(Convert.ToDouble(3.1416 * a * b), 2)
        Return Ae
    End Function

    Public Function Dif_2(l1 As Double, l2 As Double) As Double
        Dim Dif2 As Double = A_Rectangulo(l1, l2) - A_Elipse(l2 / 3, l1 / 2)
        Return Dif2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Dif_2(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
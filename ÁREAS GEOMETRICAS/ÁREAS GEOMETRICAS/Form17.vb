Public Class Form17
    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h), 2)
        Return At
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Public Function Dif_3(l1 As Double, l2 As Double) As Double
        Dim Dif3 As Double = A_Rectangulo(l1 / 2, l2 / 2) - A_Triangulo(l1 / 4, l2 / 2)
        Return Dif3
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Dif_3(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
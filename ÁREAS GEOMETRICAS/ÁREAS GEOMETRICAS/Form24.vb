Public Class Form24
    Public Function A_Pentagono(l As Double, apt As Double) As Double
        Dim Ap As Double = Math.Round(Convert.ToDouble(5 * l * apt / 2), 2)
        Return Ap
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Public Function Sum_3(l As Double, ap As Double, h As Double) As Double
        Dim Sum3 As Double = A_Pentagono(l, ap) + 5 * A_Triangulo(l, h)
        Return Sum3
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Sum_3(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
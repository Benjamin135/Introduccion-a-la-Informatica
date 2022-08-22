Public Class Form22
    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h), 2)
        Return At
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double = Math.Round(Convert.ToDouble(b * h / 2), 2)
        Return At
    End Function

    Public Function Hipotenusa(a As Double, b As Double) As Double
        Dim Hipo As Double = Math.Round(Convert.ToDouble(Math.Sqrt(a ^ 2 + b ^ 2)), 2)
        Return Hipo
    End Function

    Public Function Sum_1(a As Double, b As Double, h As Double) As Double
        Dim Sum1 As Double = A_Rectangulo(a, b) + 2 * A_Triangulo(a, Hipotenusa(b / 2, h)) + 2 * A_Triangulo(b, Hipotenusa(a / 2, h))
        Return Sum1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Sum_1(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
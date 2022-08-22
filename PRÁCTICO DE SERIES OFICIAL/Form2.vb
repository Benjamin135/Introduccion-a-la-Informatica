Public Class Form2
    Public Function Serie_1(n As Integer, vi1 As Double, d As Double, vi2 As Double, r As Double) As Double
        Dim i As Integer
        Dim va, t, f As Double
        va = vi1 / d
        f = 0
        For i = 1 To n
            va = va * d
            t = Math.Log10(va) / (vi2 + (i - 1) * r)
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_1_Tex(n As Integer, vi1 As Double, d As Double, vi2 As Double, r As Double) As String
        Dim i As Integer
        Dim va As Double
        Dim t, f As String
        va = vi1 / d
        f = " F = "
        For i = 1 To n
            va = va * d
            t = "Log10(" + Str(va) + ") / " + Str(vi2 + (i - 1) * r) + " + "
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie_1_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class
Public Class Form7
    Public Function Serie_6(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            If i Mod 2 = 1 Then
                t = Math.Cos(vi + (i - 1) * r) ^ (1 / (vi1 + (i - 1) * r1))
                f = f + t
            Else
                t = -Math.Cos(vi + (i - 1) * r) ^ (1 / (vi1 + (i - 1) * r1))
                f = f + t
            End If
        Next
        Return f
    End Function

    Public Function Serie_6_Tex(n As Integer, vi As Double, r As Double, vi1 As Double, r1 As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            If i Mod 2 = 1 Then
                t = "Cos(" + Str(vi + (i - 1) * r) + ")^1/" + Str(vi1 + (i - 1) * r1) + " - "
                f = f + t
            Else
                t = "Cos(" + Str(vi + (i - 1) * r) + ")^1/" + Str(vi1 + (i - 1) * r1) + " + "
                f = f + t
            End If
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_6(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie_6_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class

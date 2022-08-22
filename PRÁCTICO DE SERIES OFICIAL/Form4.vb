Public Class Form4
    Public Function Serie_Factorial(n As Integer) As Double
        Dim i As Integer
        Dim f As Double
        If (n > 0) Then
            f = 1
            For i = n To 1 Step -1
                f = f * i
            Next
        Else
            f = 1
        End If
        Return f
    End Function

    Public Function Serie_3(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = (vi1 + (i - 1) * r1) / Serie_Factorial(vi2 + (i - 1) * r2)
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_3_Tex(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = Str(vi1 + (i - 1) * r1) + " / " + Str((vi2 + (i - 1) * r2)) + "!" + " + "
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_3(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie_3_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class
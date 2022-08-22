Public Class Form5
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

    Public Function Serie_4(n As Integer, x As Double, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = x ^ (vi + (i - 1) * r) / Serie_Factorial(vi + (i - 1) * r)
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_4_Tex(n As Integer, x As Double, vi As Double, r As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = " x^" + Str(vi + (i - 1) * r) + "/" + Str(vi + (i - 1) * r) + "!" + " + "
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_4(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox7.Text = Serie_4_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub
End Class
Public Class Form3
    Public Function Serie_2(n As Integer, vi As Double) As Double
        Dim i As Integer
        Dim f, t As Double
        f = 0
        For i = 1 To n
            t = vi + 1
            vi = t-i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_2_Tex(n As Integer, vi As Double) As String
        Dim i As Integer
        Dim f, t As String
        f = " F = "
        For i = 1 To n
            t = Str(vi + (i - 1) * -i) + " + "
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_2(TextBox1.Text, TextBox2.Text)
        TextBox7.Text = Serie_2_Tex(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
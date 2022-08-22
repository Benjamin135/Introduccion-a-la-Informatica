Public Class Form9
    Public Function Serie_8(n As Integer) As Double
        Dim i As Integer
        Dim f, t, m, s As Double
        f = 0
        m = 2
        s = 1000
        For i = 1 To n
            t = (Math.PI / m) / Math.Sqrt(s)
            m = m - 0.1
            s = s + i
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_8_Tex(n As Integer) As String
        Dim i As Integer
        Dim f, t As String
        Dim m, s As Double
        f = " F = "
        m = 2
        s = 1000
        For i = 1 To n
            t = "(PI/" + Str(m) + ")/" + "Sqrt(" + Str(s) + ") + "
            m = m - 0.1
            s = s + i
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_8(TextBox1.Text)
        TextBox7.Text = Serie_8_Tex(TextBox1.Text)
    End Sub
End Class
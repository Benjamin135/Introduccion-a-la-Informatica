Public Class Form6
    Public Function Serie_5(n As Integer, vi As Double, r As Double) As Double
        Dim i As Integer
        Dim f, t, z, x, y As Double
        f = 0
        x = -1 : y = 1
        For i = 1 To n
            z = x + y : x = y : y = z
            t = z ^ (1 / (vi + (i - 1) * r))
            f = f + t
        Next
        Return f
    End Function

    Public Function Serie_5_Tex(n As Integer, vi As Double, r As Double) As String
        Dim i As Integer
        Dim z, x, y As Double
        Dim f, t As String
        f = " F = "
        x = -1 : y = 1
        For i = 1 To n
            z = x + y : x = y : y = z
            t = Str(z) + "^1/(" + Str(vi + (i - 1) * r) + ") + "
            f = f + t
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_5(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = Serie_5_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub



    'EJERCICIO 6
    Public Function Serie_6(n As Integer, vi As Double, r As Double, vi1 As Double) As Double
        Dim i As Integer
        Dim f, t, t1, t2 As Double
        f = 0
        For i = 1 To n
            t1 = vi + (i - 1) * r
            t2 = vi1 - (i - 1)
            If i Mod 2 = 1 Then
                t = Math.Cos(t1) ^ (1 / (t2))
            Else
                t = -Math.Cos(t1) ^ (1 / (t2))
            End If
            f = f + t
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
End Class
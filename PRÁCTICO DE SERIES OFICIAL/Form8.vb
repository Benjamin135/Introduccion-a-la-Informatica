Public Class Form8
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

    Public Function Serie_7(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As Double
        Dim i As Integer
        Dim f As Double
        Dim bn As Boolean
        f = 0
        bn = True
        For i = 1 To n
            If bn = True Then
                f -= Math.Sqrt(Math.Sin(vi1 + (i - 1) * r1) / (Serie_Factorial(vi2 + (i - 1) * r2) / 2))
            Else
                f += Math.Sqrt(Math.Sin(vi1 + (i - 1) * r1) / (Serie_Factorial(vi2 + (i - 1) * r2) / 2))
            End If
            bn = Not bn
        Next
        Return f
    End Function

    Public Function Serie_7_Tex(n As Integer, vi1 As Double, r1 As Double, vi2 As Double, r2 As Double) As String
        Dim i As Integer
        Dim f As String
        Dim bn As Boolean
        f = " F = "
        bn = True
        For i = 1 To n
            If bn = True Then
                f += " - Sqrt(Sin(" + Str(vi1 + (i - 1) * r1) + ")/(" + Str(vi2 + (i - 1) * r2) + "!" + "/ 2))"
            Else
                f += " + Sqrt(Sin(" + Str(vi1 + (i - 1) * r1) + ")/(" + Str(vi2 + (i - 1) * r2) + "!" + "/ 2))"
            End If
            bn = Not bn
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = Serie_7(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        TextBox7.Text = Serie_7_Tex(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class
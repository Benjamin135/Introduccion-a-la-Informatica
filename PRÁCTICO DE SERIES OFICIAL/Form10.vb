Public Class Form10
    Public Function Serie_9(n As Integer, x As Double) As Double
        Dim i As Integer
        Dim f, t, va, m, d As Double
        f = 0
        m = 2
        d = 2
        va = m / d
        For i = 1 To n
            va = m * d
            t =
            f = f + t
        Next
        Return f
    End Function
End Class
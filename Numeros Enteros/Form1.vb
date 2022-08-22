Public Class Form1
    Public Function Lanzar() As Integer
        Dim i, d, n As Integer
        n = 0                               'a = 1   y   b = 6
        For i = 1 To 5
            d = 1 + Rnd() * (6 - 1)         ' 3 = a + Rnd() * (b - a)
            n = n * 10 + d                  ' 0.4966
        Next
        Return n
    End Function

    Public Function VerifPar(n As Integer) As Boolean
        Dim re As Integer
        Dim b As Boolean
        re = n Mod 2
        If re = 0 Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function

    Public Function VerifPares(n As Integer) As Boolean
        Return n Mod 2 = 0
    End Function

    Public Function VerifMult(n As Integer, m As Integer) As Boolean
        Return n Mod m = 0
    End Function

    Public Function ContarDigitos(n As Integer) As Integer
        Dim d, np As Integer
        np = 0
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) = True Then
                np = np + 1
            End If
        End While
        Return np
    End Function

    Public Function BuscarDigito(n As Integer, dig As Integer) As Boolean
        Dim b As Boolean
        Dim d As Integer
        b = False
        While n > 0 And b = False
            d = n Mod 10
            n = n \ 10
            If d = dig Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function VerificarPares(n As Integer) As Boolean
        Dim b As Boolean
        Dim d As Integer
        b = True
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If Not VerifPar(d) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function VerificarImpares(n As Integer) As Boolean
        Dim b As Boolean
        Dim d As Integer
        b = True
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function VerificarOrden(n As Integer) As Boolean
        Dim b As Boolean
        Dim d, dr As Integer
        b = True
        dr = n Mod 10 : n = n \ 10
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If d >= dr Then
                dr = d
            Else
                b = False
            End If
        End While
        Return b
    End Function

    Public Function Ejercicio_5(n As Integer) As Boolean
        Dim b As Boolean
        b = True
        If Not VerificarOrden(n) Then
            b = False
        End If
        Return b
    End Function

    Public Function FormarPares(n As Integer) As Integer
        Dim d, nu As Integer
        nu = 0
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                nu = nu * 10 + d
            End If
        End While
        Return nu
    End Function

    Public Function FormarDigito(n As Integer) As Integer
        Dim d, nu, p As Integer
        nu = 0
        p = -1
        While n > 0
            d = n Mod 10
            n = n \ 10
            p = p + 1
            nu = nu + d * 10 ^ p
        End While
        Return nu
    End Function

    Public Function Invertir(n As Integer) As Integer
        Dim d, nu As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            nu = nu * 10 + d
        End While
        Return nu
    End Function

    Public Function FiltrarPares(n As Integer) As Integer
        Dim d, nu, p As Integer
        nu = 0
        p = -1
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                p = p + 1
                nu = nu + d * 10 ^ p
            End If
        End While
        Return nu
    End Function

    Public Function BinarioADecimal(n As Integer) As Integer
        Dim d, nu, p As Integer
        nu = 0
        p = -1
        While n > 0
            d = n Mod 10
            n = n \ 10
            p = p + 1
            nu = nu + d * 2 ^ p
        End While
        Return nu
    End Function

    Public Function VerificarBase(n As Integer, ba As Integer) As Boolean
        Dim d As Integer
        Dim b As Boolean
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If Not d < ba Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function EliminarDigito(n As Integer, dig As Integer) As Integer
        Dim d, nu, p As Integer
        Dim b As Boolean
        b = True
        nu = 0
        p = -1
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If d <> dig Then
                p = p + 1
                nu = nu + d * 10 ^ p
            Else
                b = False
            End If
        End While
        nu = Unir2Numeros(n, nu)
        Return nu
    End Function

    Public Function Eliminar_Digito(n As Integer, d As Integer) As Integer
        Dim r, da, m As Integer
        r = 0
        m = 1
        While n > 0
            da = n Mod 10
            n = n \ 10
            If d <> da Then
                r = r + (da * m)
                m = m * 10
            End If
        End While
        Return r
    End Function

    Public Function Ejercicio_2(n As Integer) As Integer
        Dim rep, noRep, da, r, mRep, mNoRep As Integer
        r = 0 : rep = 0 : noRep = 0
        mRep = 1 : mNoRep = 1
        While (n > 0)
            da = n Mod 10
            If (SeRepite(n, da)) Then
                Dim canRep = Cantidad_SeRepiteDig(n, da)
                While (canRep > 0)
                    rep = rep + (da * mRep)
                    mRep = mRep * 10
                    canRep = canRep - 1
                End While
            Else
                noRep = noRep + (da * mNoRep)
                mNoRep = mNoRep * 10
            End If
            n = Eliminar_Digito(n, da)
        End While
        r = (rep * mNoRep) + noRep
        Return r
    End Function

    Public Function OrderDigMenorMayor(n As Integer) As Integer
        Dim d, ne As Integer
        ne = 0
        While n > 0
            d = DigMenor(n)
            ne = ne * 10 + d
            n = EliminarDigito(n, d)
        End While
        Return ne
    End Function

    Public Function OrderDigMayorMenor(n As Integer) As Integer
        Dim d, ne As Integer
        ne = 0
        While n > 0
            d = DigMayor(n)
            ne = ne * 10 + d
            n = EliminarDigito(n, d)
        End While
        Return ne
    End Function

    Public Function SegParImpar(n As Integer) As Integer
        Dim d, p1, p2, PAR, IMPAR, ne As Integer
        p1 = -1 : p2 = -1
        PAR = 0 : IMPAR = 0
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                p1 = p1 + 1
                PAR = PAR + d * 10 ^ p1
            Else
                p2 = p2 + 1
                IMPAR = IMPAR + d * 10 ^ p2
            End If
        End While
        ne = Unir2Numeros(PAR, IMPAR)
        Return ne
    End Function

    Public Function Ndigs(n As Integer) As Integer
        Dim nd As Integer
        nd = 0
        While n > 0
            n = n \ 10
            nd = nd + 1
        End While
        Return nd
    End Function

    Public Function Unir2Numeros(n1 As Integer, n2 As Integer) As Integer
        Dim nu As Integer
        nu = n1 * 10 ^ Ndigs(n2) + n2
        Return nu
    End Function

    Public Function VerifFibonacci(n As Integer) As Boolean
        Dim x, y, z As Integer
        x = -1 : y = 1
        Do
            z = x + y
            x = y
            y = z
        Loop Until z = n Or z > n
        Return z = n
    End Function

    Public Function VerifPrimo(n As Integer) As Boolean
        Dim i, a As Integer
        Dim b As Boolean
        a = 0
        For i = 1 To n + 1
            If (n Mod i = 0) Then
                a = a + 1
            End If
        Next i
        If (a <> 2) Then
            b = False
        Else
            b = True
        End If
        Return b
    End Function

    Public Function VerifPri(n As Integer) As Boolean
        Dim i, a As Integer
        a = 0
        For i = 1 To n + 1
            If (n Mod i = 0) Then
                a = a + 1
            End If
        Next i
        Return a = 2
    End Function

    Public Function VerifDigsIgual(n As Integer) As Boolean
        Dim d, ref As Integer
        Dim b As Boolean
        ref = n Mod 10 : n = n \ 10
        b = True
        While n > 0 And b = True
            d = n Mod 10
            n = n \ 10
            If Not (d = ref) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function DigMenor(n As Integer) As Integer
        Dim d, men As Integer
        men = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d < men) Then
                men = d
            End If
        End While
        Return men
    End Function

    Public Function DigMayor(n As Integer) As Integer
        Dim d, may As Integer
        may = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d > may) Then
                may = d
            End If
        End While
        Return may
    End Function

    Public Function Capicua(n As Integer) As Boolean
        Return n = Invertir(n)
    End Function

    Public Function SeRepite(n As Integer, d As Integer) As Boolean
        Dim c, da As Integer
        c = 0
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c > 1
    End Function

    Public Function Cantidad_SeRepiteDig(n As Integer, d As Integer) As Integer
        Dim c, da As Integer
        c = 0
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c
    End Function

    Public Function Respuesta_2(n As Integer, d1 As Integer, d2 As Integer) As Integer
        Dim d, nu, m As Integer
        nu = 0 : m = 1           'n = 234581: d1 = 3: d2 = 5
        While n > 0
            d = n Mod 10
            n = n \ 10
            If (d = d2) Then
                nu = nu + (d1 * m)
                m = m * 10
            Else
                If (d = d1) Then
                    nu = nu + (d2 * m)
                    m = m * 10
                Else
                    nu = nu + (d * m)
                    m = m * 10
                End If
            End If
        End While
        Return nu
    End Function

    Public Function BuscarDigImpar(n As Integer) As Boolean
        Dim b As Boolean
        Dim d As Integer
        b = False
        While n > 0
            d = n Mod 10
            n = n \ 10
            If Not VerifPar(d) Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function BuscarDigPar(n As Integer) As Boolean
        Dim b As Boolean
        Dim d As Integer
        b = False
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function Buscar_DigImpar(n As Integer) As Integer
        Dim d, nu, m As Integer
        nu = 0 : m = 1
        While n > 0
            d = n Mod 10
            n = n \ 10
            If Not VerifPar(d) Then
                nu = nu + (d * m)
                m = m * 10
            End If
        End While
        Return nu
    End Function

    Public Function Buscar_DigPar(n As Integer) As Integer
        Dim d, nu, m As Integer
        nu = 0 : m = 1
        While n > 0
            d = n Mod 10
            n = n \ 10
            If VerifPar(d) Then
                nu = nu + (d * m)
                m = m * 10
            End If
        End While
        Return nu
    End Function

    Public Function DigMenorPar(n As Integer) As Integer
        Return DigMenor(Buscar_DigPar(n))
    End Function

    Public Function DigMenorImpar(n As Integer) As Integer
        Return DigMenor(Buscar_DigImpar(n))
    End Function

    Public Function IntercalarDigs_Pares_Impares(n As Integer) As Integer
        Dim d, nu As Integer
        Dim b As Boolean
        b = True
        nu = 0
        While n > 0
            If b = True Then
                If BuscarDigPar(n) Then
                    d = DigMenorPar(n)
                    nu = nu * 10 + d
                    n = EliminarDigito(n, d)
                End If
            Else
                If BuscarDigImpar(n) Then
                    d = DigMenorImpar(n)
                    nu = nu * 10 + d
                    n = EliminarDigito(n, d)
                End If
            End If
            b = Not b
        End While
        Return nu
    End Function

    Public Function IntercalarDigs_Mayor_Menor(n As Integer) As Integer
        Dim d, nu As Integer
        Dim b As Boolean
        b = True : nu = 0
        While n > 0
            If b = True Then
                d = DigMayor(n)
                nu = nu * 10 + d
                n = EliminarDigito(n, d)
            Else
                d = DigMenor(n)
                nu = nu * 10 + d
                n = EliminarDigito(n, d)
            End If
            b = Not b
        End While
        Return nu
    End Function

    Public Function VerifFibo(n As Integer) As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until c = n Or c > n
        Return c = n
    End Function

    Public Function Respuesta_1_SD(n As Integer, d1 As Integer) As Integer
        Dim d, aux, p, r As Integer
        Dim b As Boolean
        b = True : aux = 0 : p = -1
        While (n > 0) And (b = True)
            d = n Mod 10
            n = n \ 10
            If d > d1 Then
                p = p + 1
                aux = aux + d * 10 ^ p
            Else
                b = False
            End If
        End While
        If b = False Then
            n = n * 10 + d
            n = n * 10 + d1
            r = Unir2Numeros(n, aux)
        Else
            r = Unir2Numeros(d1, aux)
        End If
        Return r
    End Function

    Public Function Frecuencia_dig(n As Integer, dig As Integer) As Integer
        Dim fd, d As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            If dig = d Then
                fd = fd + 1
            End If
        End While
        Return fd
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Lanzar()
    End Sub

    Private Sub BUSCARDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARDIGITOToolStripMenuItem.Click
        TextBox3.Text = BuscarDigito(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub TODOSSONPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSSONPARESToolStripMenuItem.Click
        TextBox3.Text = VerificarPares(TextBox1.Text)
    End Sub

    Private Sub TODOSSONIMPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSSONIMPARESToolStripMenuItem.Click
        TextBox3.Text = VerificarImpares(TextBox1.Text)
    End Sub

    Private Sub TODOSSONPARESOIMPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSSONPARESOIMPARESToolStripMenuItem.Click
        TextBox3.Text = VerificarPares(TextBox1.Text) Or VerificarImpares(TextBox1.Text)
    End Sub

    Private Sub FORMARPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMARPARESToolStripMenuItem.Click
        TextBox3.Text = FormarPares(TextBox1.Text)
    End Sub

    Private Sub INVERTIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVERTIRToolStripMenuItem.Click
        TextBox3.Text = Invertir(TextBox1.Text)
    End Sub

    Private Sub VERIFICARCAPICUAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARCAPICUAToolStripMenuItem.Click
        TextBox3.Text = Capicua(TextBox1.Text)
    End Sub

    Private Sub FORMARDIGITOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMARDIGITOSToolStripMenuItem.Click
        TextBox3.Text = FormarDigito(TextBox1.Text)
    End Sub

    Private Sub FILTRARPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILTRARPARESToolStripMenuItem.Click
        TextBox3.Text = FiltrarPares(TextBox1.Text)
    End Sub

    Private Sub CONVERTIRBINARIOADECIMALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONVERTIRBINARIOADECIMALToolStripMenuItem.Click
        TextBox3.Text = BinarioADecimal(TextBox1.Text)
    End Sub

    Private Sub VERIFICARBASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARBASEToolStripMenuItem.Click
        TextBox3.Text = VerificarBase(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SEGMENTARPARIMPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEGMENTARPARIMPARToolStripMenuItem.Click
        TextBox3.Text = SegParImpar(TextBox1.Text)
    End Sub

    Private Sub VERIFICARSIESDEFIBONACCIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSIESDEFIBONACCIToolStripMenuItem.Click
        TextBox3.Text = VerifFibonacci(TextBox1.Text)
    End Sub

    Private Sub VERIFICARPRIMOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARPRIMOSToolStripMenuItem.Click
        TextBox3.Text = VerifPrimo(TextBox1.Text)
    End Sub

    Private Sub VERIFPRIMOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFPRIMOToolStripMenuItem.Click
        TextBox3.Text = VerifPri(TextBox1.Text)
    End Sub

    Private Sub VERIFICARDIGITOSIGUALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARDIGITOSIGUALESToolStripMenuItem.Click
        TextBox3.Text = VerifDigsIgual(TextBox1.Text)
    End Sub

    Private Sub DIGITOMENORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIGITOMENORToolStripMenuItem.Click
        TextBox3.Text = DigMenor(TextBox1.Text)
    End Sub

    Private Sub DIGITOMAYORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIGITOMAYORToolStripMenuItem.Click
        TextBox3.Text = DigMayor(TextBox1.Text)
    End Sub

    Private Sub VERIFICARORDENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICAERORDENToolStripMenuItem.Click
        TextBox3.Text = VerificarOrden(TextBox1.Text)
    End Sub

    Private Sub VERIFICARMULTIPLOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARMULTIPLOToolStripMenuItem.Click
        TextBox3.Text = VerifMult(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub SEREPITEELDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEREPITEELDIGITOToolStripMenuItem.Click
        TextBox3.Text = SeRepite(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub EJERCICIO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem.Click
        TextBox3.Text = Ejercicio_2(TextBox1.Text)
    End Sub

    Private Sub CANTIDADQUESEREPITEUNDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANTIDADQUESEREPITEUNDIGITOToolStripMenuItem.Click
        TextBox3.Text = Cantidad_SeRepiteDig(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub EJERCICIO5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO5ToolStripMenuItem.Click
        TextBox3.Text = Ejercicio_5(TextBox1.Text)
    End Sub

    Private Sub INTERCAMBIAR2NUMEROSDEPOSICIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCAMBIAR2NUMEROSDEPOSICIÓNToolStripMenuItem.Click
        TextBox3.Text = Respuesta_2(TextBox1.Text, TextBox2.Text, TextBox4.Text)
    End Sub

    Private Sub BUSCARDIGITOIMPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARDIGITOIMPARToolStripMenuItem.Click
        TextBox3.Text = BuscarDigImpar(TextBox1.Text)
        TextBox2.Text = Buscar_DigImpar(TextBox1.Text)
    End Sub

    Private Sub DIGITOMENORPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIGITOMENORPARToolStripMenuItem.Click
        TextBox3.Text = DigMenorPar(TextBox1.Text)
    End Sub

    Private Sub BUSCARDIGITOPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARDIGITOPARToolStripMenuItem.Click
        TextBox3.Text = BuscarDigPar(TextBox1.Text)
        TextBox2.Text = Buscar_DigPar(TextBox1.Text)
    End Sub

    Private Sub DIGITOMENORIMPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIGITOMENORIMPARToolStripMenuItem.Click
        TextBox3.Text = DigMenorImpar(TextBox1.Text)
    End Sub

    Private Sub INTERCALARDIGITOSPARESEIMPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCALARDIGITOSPARESEIMPARESToolStripMenuItem.Click
        TextBox3.Text = IntercalarDigs_Pares_Impares(TextBox1.Text)
    End Sub

    Private Sub INTERCALARDIGITOSMAYORYMENORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCALARDIGITOSMAYORYMENORToolStripMenuItem.Click
        TextBox3.Text = IntercalarDigs_Mayor_Menor(TextBox1.Text)
    End Sub

    Private Sub ELIMINARDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARDIGITOToolStripMenuItem.Click
        TextBox3.Text = EliminarDigito(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub ELIMINARTODOUNDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARTODOUNDIGITOToolStripMenuItem.Click
        TextBox3.Text = Eliminar_Digito(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub ORDENARDIGITOMAYORAMENORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDIGITOMAYORAMENORToolStripMenuItem.Click
        TextBox3.Text = OrderDigMayorMenor(TextBox1.Text)
    End Sub

    Private Sub ORDENARDIGITOMENORAMAYORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDIGITOMENORAMAYORToolStripMenuItem.Click
        TextBox3.Text = OrderDigMenorMayor(TextBox1.Text)
    End Sub

    Private Sub VERIFICARDIGITOSDEFIBONACCIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARDIGITOSDEFIBONACCIToolStripMenuItem.Click
        TextBox3.Text = VerifFibo(TextBox1.Text)
    End Sub

    Private Sub UNIR2NÚMEROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNIR2NÚMEROSToolStripMenuItem.Click
        TextBox3.Text = Unir2Numeros(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub RESPUESTA1SDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPUESTA1SDToolStripMenuItem.Click
        TextBox3.Text = Respuesta_1_SD(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub FRECUENCIADEDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRECUENCIADEDIGITOToolStripMenuItem.Click
        TextBox3.Text = Frecuencia_dig(TextBox1.Text, TextBox2.Text)
    End Sub
End Class

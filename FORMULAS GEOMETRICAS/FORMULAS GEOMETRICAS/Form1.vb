Public Class Form1

    Public Function A_Circunferencia(r As Double) As Double
        Dim Ac As Double
        Ac = 3.1416 * r ^ 2
        Return Ac
    End Function

    Public Function Peri_Cir(r As Double) As Double
        Dim PeriCir As Double
        PeriCir = 2 * 3.1416 * r
        Return PeriCir
    End Function

    Public Function A_Rectangulo(b As Double, h As Double) As Double
        Dim Ar As Double
        Ar = b * h
        Return Ar
    End Function

    Public Function A_Triangulo(b As Double, h As Double) As Double
        Dim At As Double
        At = b * h / 2
        Return At
    End Function

    Public Function A_Triangulo_Eq(a As Double) As Double
        Dim At As Double
        At = Math.Sqrt(3) / 4 * a ^ 2
        Return At
    End Function

    Public Function Apotema_Tri(l As Double) As Double
        Dim Ap As Double
        Ap = Math.Sqrt(3) / 6 * l
        Return Ap
    End Function

    Public Function A_Cuadrado(a As Double) As Double
        Dim Ac As Double
        Ac = a ^ 2
        Return Ac
    End Function

    Public Function A_Elipse(a As Double, b As Double) As Double
        Dim Ae As Double
        Ae = 3.1416 * a * b
        Return Ae
    End Function

    Public Function A_Trapecio(a As Double, b As Double, h As Double) As Double
        Dim At As Double
        At = (a + b) / 2 * h
        Return At
    End Function

    Public Function A_Rombo(d1 As Double, d2 As Double) As Double
        Dim Ar As Double
        Ar = d1 * d2 / 2
        Return Ar
    End Function

    Public Function A_Pentagano(l As Double, apt As Double) As Double
        Dim Ap As Double
        Ap = 5 * l * apt / 2
        Return Ap
    End Function

    Public Function A_Hexagono(l As Double, ap As Double) As Double
        Dim Ah As Double
        Ah = 3 * l * ap
        Return Ah
    End Function

    Public Function V_Cilindro(r As Double, h As Double) As Double
        Dim Vc As Double
        Vc = 3.1416 * r ^ 2 * h
        Return Vc
    End Function

    Public Function V_Cono(r As Double, h As Double) As Double
        Dim Vc As Double
        Vc = 3.1416 * r ^ 2 * h / 3
        Return Vc
    End Function

    Public Function V_Piramide(a As Double, b As Double, h As Double) As Double
        Dim Vp As Double
        Vp = a * b * h / 3
        Return Vp
    End Function

    Public Function V_Prisma(l As Double, h As Double, ap As Double) As Double
        Dim Vp As Double
        Vp = 5 * l * ap / 2 * h
        Return Vp
    End Function

    Public Function Dif_Area1(l As Double) As Double
        Dim Dif1 As Double
        Dif1 = A_Cuadrado(l) - A_Triangulo(l, l / 2)
        Return Dif1
    End Function

    Public Function Dif_Area2(l1 As Double, l2 As Double) As Double
        Dim Dif2 As Double
        Dif2 = A_Rectangulo(l1, l2) - A_Elipse(l1 / 2, l2 / 3)
        Return Dif2
    End Function

    Public Function Dif_Area3(l1 As Double, l2 As Double) As Double
        Dim Dif3 As Double
        Dif3 = A_Rectangulo(l1 / 2, l2 / 2) - A_Triangulo(l1 / 4, l2 / 2)
        Return Dif3
    End Function

    Public Function Dif_Area4(a As Double, b As Double, h As Double) As Double
        Dim Dif4 As Double
        Dif4 = A_Trapecio(a, b, h) - 1 / 2 * A_Circunferencia(b / 2)
        Return Dif4
    End Function

    Public Function Dif_Area5(a As Double) As Double
        Dim Dif5 = A_Triangulo_Eq(a) - A_Circunferencia(Apotema_Tri(a))
        Return Dif5
    End Function

    Public Function Dif_Area6(l As Double) As Double
        Dim Dif6 As Double
        Dif6 = A_Cuadrado(l) - 1 / 2 * A_Circunferencia(l / 2)
        Return Dif6
    End Function

    Public Function Dif_Area7(l1 As Double, l2 As Double) As Double
        Dim Dif7 As Double
        Dif7 = A_Rectangulo(l1, l2) - 2 * A_Triangulo(1 / 4 * l1, 1 / 2 * l2)
        Return Dif7
    End Function

    Public Function Hipotenusa(a As Double, b As Double) As Double
        Dim Hipo As Double = Math.Sqrt(a ^ 2 + b ^ 2)
        Return Hipo
    End Function

    Public Function Sum_Area1(a As Double, b As Double, h As Double) As Double
        Dim Sum1 As Double
        Sum1 = A_Rectangulo(a, b) + 2 * A_Triangulo(a, Hipotenusa(b / 2, h)) + 2 * A_Triangulo(b, Hipotenusa(a / 2, h))
        Return Sum1
    End Function

    Public Function Sum_Area2(r1 As Double, r2 As Double, h As Double) As Double
        Dim Sum2 As Double
        Sum2 = A_Circunferencia(r1) + A_Circunferencia(r2) + A_Trapecio(Peri_Cir(r1), Peri_Cir(r2), h)
        Return Sum2
    End Function

    Public Function Sum_Area3(l As Double, ap As Double, h As Double) As Double
        Dim Sum3 As Double
        Sum3 = 5 * A_Triangulo(l, h) + A_Pentagano(l, ap)
        Return Sum3
    End Function

    Public Function Sum_Area4(r As Double, h As Double) As Double
        Dim Sum4 As Double
        Sum4 = 2 * A_Circunferencia(r) + A_Rectangulo(Peri_Cir(r), h)
        Return Sum4
    End Function

    Public Function Sum_Area5(l As Double, ap As Double, h As Double) As Double
        Dim Sum5 As Double
        Sum5 = 2 * A_Hexagono(l, ap) + 6 * A_Rectangulo(l, h)
        Return Sum5
    End Function

    Public Function Sum_Area6(x As Double, y As Double, z As Double) As Double
        Dim Sum6 As Double
        Sum6 = 2 * A_Rectangulo(x, y) + 2 * A_Rectangulo(z, y) + 2 * A_Rectangulo(x, z)
        Return Sum6
    End Function

    Public Function Sum_Area7(r As Double, h As Double) As Double
        Dim Sum7 As Double
        Sum7 = A_Triangulo(Peri_Cir(r), h) + A_Circunferencia(r)
        Return Sum7
    End Function

    Private Sub ÁREADEUNACIRCUNFERENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNACIRCUNFERENCIAToolStripMenuItem.Click
        TextBox2.Text = A_Circunferencia(TextBox1.Text)
    End Sub

    Private Sub ÁREADEUNARECTÁNGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNARECTÁNGULOToolStripMenuItem.Click
        TextBox2.Text = A_Rectangulo(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNTRIÁNGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNTRIÁNGULOToolStripMenuItem.Click
        TextBox2.Text = A_Triangulo(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNCUADRADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNCUADRADOToolStripMenuItem.Click
        TextBox2.Text = A_Cuadrado(TextBox1.Text)
    End Sub

    Private Sub ÁREADEUNAELIPSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNAELIPSEToolStripMenuItem.Click
        TextBox2.Text = A_Elipse(TextBox1.Text, TextBox3.Text)
    End Sub
    Private Sub ÁREADEUNTRAPECIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNTRAPECIOToolStripMenuItem.Click
        TextBox2.Text = A_Trapecio(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNROMBOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNROMBOToolStripMenuItem.Click
        TextBox2.Text = A_Rombo(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNPENTAGONOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNPENTAGONOToolStripMenuItem.Click
        TextBox2.Text = A_Pentagano(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNHEXAGONOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNHEXAGONOToolStripMenuItem.Click
        TextBox2.Text = A_Hexagono(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub VOLUMENDEUNCILINDROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLUMENDEUNCILINDROToolStripMenuItem.Click
        TextBox2.Text = V_Cilindro(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub VOLUMENDEUNCONOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLUMENDEUNCONOToolStripMenuItem.Click
        TextBox2.Text = V_Cono(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub VOLUMENDEUNAPIRAMIDERECTANGULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLUMENDEUNAPIRAMIDERECTANGULARToolStripMenuItem.Click
        TextBox2.Text = V_Piramide(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub VOLUMENDEUNPRISMAPENTAGONALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLUMENDEUNPRISMAPENTAGONALToolStripMenuItem.Click
        TextBox2.Text = V_Prisma(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DIFERENCIADEUNCUADRADOTRIÁNGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNCUADRADOTRIÁNGULOToolStripMenuItem.Click
        TextBox2.Text = Dif_Area1(TextBox1.Text)
    End Sub

    Private Sub DIFERENCIADEUNRECTÁNGULOELIPSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNRECTÁNGULOELIPSEToolStripMenuItem.Click
        TextBox2.Text = Dif_Area2(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub DIFERENCIADEUNRECTÁNGULOTRIÁNGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNRECTÁNGULOTRIÁNGULOToolStripMenuItem.Click
        TextBox2.Text = Dif_Area3(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub DIFERENCIADEUNTRAPECIOCIRCUNFERENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNTRAPECIOCIRCUNFERENCIAToolStripMenuItem.Click
        TextBox2.Text = Dif_Area4(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DIFERENCIADEUNTRIÁNGULOCIRCUNFERENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNTRIÁNGULOCIRCUNFERENCIAToolStripMenuItem.Click
        TextBox2.Text = Dif_Area5(TextBox1.Text)
    End Sub

    Private Sub DIFERENCIADEUNCUADRADOCIRCUNFERENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNCUADRADOCIRCUNFERENCIAToolStripMenuItem.Click
        TextBox2.Text = Dif_Area6(TextBox1.Text)
    End Sub

    Private Sub DIFERENCIADEUNRECTÁNGULOCON2TRIÁNGULOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEUNRECTÁNGULOCON2TRIÁNGULOSToolStripMenuItem.Click
        TextBox2.Text = Dif_Area7(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNAPIRAMIDERECTANGULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUMADETRIÁNGULORECTÁNGULOToolStripMenuItem.Click
        TextBox2.Text = Sum_Area1(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNTRONCODECONOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNTRONCODECONOToolStripMenuItem.Click
        TextBox2.Text = Sum_Area2(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNPRISMAPENTAGONALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNPRISMAPENTAGONALToolStripMenuItem.Click
        TextBox2.Text = Sum_Area3(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNCILINDROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNCILINDROToolStripMenuItem.Click
        TextBox2.Text = Sum_Area4(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub ÁREADEUNPRISMAHEXAGONALToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÁREADEUNHEXAGONOToolStripMenuItem1.Click
        TextBox2.Text = Sum_Area5(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNPRISMARECTANGULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNPRISMARECTANGULARToolStripMenuItem.Click
        TextBox2.Text = Sum_Area6(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ÁREADEUNCONOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁREADEUNCONOToolStripMenuItem.Click
        TextBox2.Text = Sum_Area7(TextBox1.Text, TextBox3.Text)
    End Sub

    'EJERCICIOS DE JUNIOR

    Public Function Area_Elipse(a As Double, b As Double) As Double
        Dim Ae As Double
        Ae = 3.1416 * a * b
        Return Ae
    End Function

    Public Function Area_Rombo(d1 As Double, d2 As Double) As Double
        Dim Ar As Double
        Ar = d1 * d2 / 2
        Return Ar
    End Function

    Public Function Dif_Area8(l1 As Double, l2 As Double) As Double
        Dim Dif8 As Double
        Dif8 = Area_Elipse(l1, l2) - Area_Rombo(l1, l2)
        Return Dif8
    End Function

    Private Sub DIFERENCIADEELIPCEROMBOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADEELIPCEROMBOToolStripMenuItem.Click
        TextBox2.Text = Dif_Area8(TextBox1.Text, TextBox3.Text)
    End Sub

    Public Function Respuesta_2(l As Double, h As Double, ap As Double) As Double
        Dim respuesta As Double
        respuesta = 2 * A_Pentagano(l, ap) + 5 * A_Rectangulo(l, h)
        Return respuesta
    End Function

    Private Sub ÁREADEUNPRISMAPENTAGONALToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÁREADEUNPRISMAPENTAGONALToolStripMenuItem1.Click
        TextBox2.Text = Respuesta_2(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Public Function A_Trapecio1(a As Double, b As Double, h As Double) As Double
        Dim At As Double
        At = (a + b) / 2 * h
        Return At
    End Function

    Public Function Respuesta_1(a As Double, b As Double, h As Double) As Double
        Dim respuesta As Double
        respuesta = A_Trapecio1(a, b, h) - 2 * A_Trapecio1(b, (b * 3) / 4, h / 2) - A_Trapecio1(h, h / 2, h / 3)
        Return respuesta
    End Function

    Private Sub DIFERENCIADETRAPECIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIFERENCIADETRAPECIOSToolStripMenuItem.Click
        TextBox2.Text = Respuesta_1(TextBox1.Text, TextBox3.Text, TextBox4.Text)
    End Sub
End Class
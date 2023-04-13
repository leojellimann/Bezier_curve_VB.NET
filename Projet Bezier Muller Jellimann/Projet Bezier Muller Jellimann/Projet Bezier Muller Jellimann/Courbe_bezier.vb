Public Class Courbe_bezier
    Dim etatBouton As Boolean = False

    Dim Xdeb As Double
    Dim Ydeb As Double
    Dim Xfin As Double
    Dim Yfin As Double
    Dim XptgDeb As Double
    Dim YptgDeb As Double
    Dim XptgFin As Double
    Dim YptgFin As Double

    Dim Xdebi As Integer
    Dim Ydebi As Integer
    Dim Xfini As Integer
    Dim Yfini As Integer
    Dim XptgDebi As Integer
    Dim YptgDebi As Integer
    Dim XptgFini As Integer
    Dim YptgFini As Integer



    Private Sub btnPtDébFin_Click(sender As Object, e As EventArgs) Handles btnPtDéb.Click, btnPtFin.Click, btnPtgDeb.Click, btnPtgFin.Click

        'Gestion du placement du point de départ
        If sender Is btnPtDéb Then

            txtBoxXDéb.Enabled = True
            txtBoxYDéb.Enabled = True
            txtBoxXDéb.Focus()
        End If

        'Gestion du placement du point de fin
        If sender Is btnPtFin Then

            txtBoxXFin.Enabled = True
            txtBoxYFin.Enabled = True
            txtBoxXFin.Focus()
        End If

        'Gestion du placement du point de tangante de debut
        If sender Is btnPtgDeb Then

            txtBoxPtgDebX.Enabled = True
            txtBoxPtgDebY.Enabled = True
            txtBoxPtgDebX.Focus()
        End If

        'Gestion du placement du point de tangante de Fin
        If sender Is btnPtgFin Then

            txtBoxPtgFinX.Enabled = True
            txtBoxPtgFinY.Enabled = True
            txtBoxPtgFinX.Focus()



        End If
    End Sub


    Public Function ConverterX(PointX As Double)
        Dim X As Double

        If PointX < 0 Then
            X = PointX * (-430)

        ElseIf PointX > 0 Then
            X = PointX * (430)

        End If
        X = Convert.ToInt32(X)
        Return X

    End Function

    Public Function ConverterY(PointY As Double)
        Dim Y As Double

        If PointY < 0 Then
            Y = PointY * (-430)

        ElseIf PointY > 0 Then
            Y = PointY * 430

        End If
        Y = Convert.ToInt32(Y)
        Return Y

    End Function





    Private Sub txtBoxXDéb_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxXDéb.KeyDown, txtBoxXFin.KeyDown, txtBoxPtgDebX.KeyDown, txtBoxPtgFinX.KeyDown, txtBoxPtgFinY.KeyDown, txtBoxPtgDebY.KeyDown, txtBoxYFin.KeyDown, txtBoxYDéb.KeyDown
        '************ Bouton Deb ****************
        If e.KeyValue = Keys.Decimal Then
            MessageBox.Show("Veuillez remplacer le point par une virgule")

        End If
        If sender Is txtBoxXDéb And e.KeyValue = Keys.Enter Then 'sur l'appui de la touche entrée deplacer le focus sur la case suivante 
            txtBoxYDéb.Focus()
        End If

        If sender Is txtBoxYDéb And e.KeyValue = Keys.Enter Then 'sur l'appui de entrée dans txtBox Y -> prendre les valeurs et les mettres dans des variables 
            Xdeb = Convert.ToDouble(txtBoxXDéb.Text)
            Ydeb = Convert.ToDouble(txtBoxYDéb.Text)
            Xdebi = ConverterX(Xdeb)
            Ydebi = ConverterY(Ydeb)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, Xdebi - 2, Ydebi, Xdebi + 2, Ydebi)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, Xdebi, Ydebi - 2, Xdebi, Ydebi + 2)
        End If

        '************ Bouton Fin ****************
        If sender Is txtBoxXFin And e.KeyValue = Keys.Enter Then 'sur l'appui de la touche entrée deplacer le focus sur la case suivante
            txtBoxYFin.Focus()
        End If

        If sender Is txtBoxYFin And e.KeyValue = Keys.Enter Then 'sur l'appui de entrée dans txtBox Y -> prendre les valeurs et les mettres dans des variables 
            Xfin = Convert.ToDouble(txtBoxXFin.Text)
            Yfin = Convert.ToDouble(txtBoxYFin.Text)
            Xfini = ConverterX(Xfin)
            Yfini = ConverterY(Yfin)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, Xfini - 2, Yfini, Xfini + 2, Yfini)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, Xfini, Yfini - 2, Xfini, Yfini + 2)

        End If
        '************ Bouton PtgDeb ****************
        If sender Is txtBoxPtgDebX And e.KeyValue = Keys.Enter Then 'sur l'appui de la touche entrée deplacer le focus sur la case suivante
            txtBoxPtgDebY.Focus()
        End If

        If sender Is txtBoxPtgDebY And e.KeyValue = Keys.Enter Then 'sur l'appui de entrée dans txtBox Y -> prendre les valeurs et les mettres dans des variables

            XptgDeb = Convert.ToDouble(txtBoxPtgDebX.Text)
            YptgDeb = Convert.ToDouble(txtBoxPtgDebY.Text)
            XptgDebi = ConverterX(XptgDeb)
            YptgDebi = ConverterY(YptgDeb)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, XptgDebi - 2, YptgDebi, XptgDebi + 2, YptgDebi)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, XptgDebi, YptgDebi - 2, XptgDebi, YptgDebi + 2)
        End If

        '************ Bouton PtgFin ****************
        If sender Is txtBoxPtgFinX And e.KeyValue = Keys.Enter Then 'sur l'appui de la touche entrée deplacer le focus sur la case suivante
            txtBoxPtgFinY.Focus()
        End If

        If sender Is txtBoxPtgFinY And e.KeyValue = Keys.Enter Then 'sur l'appui de entrée dans txtBox Y -> prendre les valeurs et les mettres dans des variables 

            XptgFin = Convert.ToDouble(txtBoxPtgFinX.Text)
            YptgFin = Convert.ToDouble(txtBoxPtgFinY.Text)
            XptgFini = ConverterX(XptgFin)
            YptgFini = ConverterY(YptgFin)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, XptgFini - 2, YptgFini, XptgFini + 2, YptgFini)
            PictureBox1.CreateGraphics().DrawLine(Pens.Red, XptgFini, YptgFini - 2, XptgFini, YptgFini + 2)



        End If
    End Sub

    Private Sub Courbe_bezier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PictureBox1.CreateGraphics().DrawLine(Pens.Black, 0, 215, 430, 215)

        Dim img As New Bitmap(430, 430)
        Dim g As Graphics = Graphics.FromImage(img)
        Dim pinceau As New Pen(Color.Black)

        g.DrawLine(pinceau, 0, 215, 430, 215)
        g.DrawLine(pinceau, 215, 0, 215, 430)


        PictureBox1.Image = img

    End Sub
End Class

Imports System.IO
Public Class Courbe_bezier
    Dim listeNonConvert(7) As Double
    Dim listePoints(7) As Integer
    Dim listePointsGrid(7) As Double
    Dim listeBezier As New List(Of Integer)
    Dim nbrElemtsListe As Integer
    Dim nbrElemtsListeBezier As Integer
    Dim etatTextBox As Integer
    Dim n As Integer = 0 'nbresegments
    Dim calculBezier As Boolean = False
    Dim stopBezier As Boolean = False
    Dim IdPoint As Control ' Savoir quel point est selectionné pour saisir le point avec la souris 
    Dim MouseX As Double
    Dim MouseY As Double
    Dim img As New Bitmap(430, 430)
    Dim g As Graphics = Graphics.FromImage(img)
    Dim mycolor As Color = Color.Black
    Dim PenCourbe As Pen
    Dim nbrCourbeBezier As Integer = 0


    '************************************************************************************************************
    'Fonction pour activer ou non l'écriture dans les TextBox
    Private Function EnableTxtBox(txtBoxX As TextBox, txtBoxY As TextBox)
        txtBoxX.Enabled = True
        txtBoxY.Enabled = True
        txtBoxX.Focus()
    End Function

    '************************************************************************************************************
    'Remplace le "." en ",", déplace le curseur dans la prochaine textBox, gère le texte entré dans les textbox

    Private Function RemplacementPointVirgule(txtBox As TextBox)
        Dim newTextBox As Control
        Dim entréeTextBox As Double
        etatTextBox = 0


        If txtBox.Text.Contains(".") Then
            txtBox.Text = Replace(txtBox.Text, ".", ",") ' remplacer le point par la virgule 
        End If


        Dim success As Boolean = Double.TryParse(txtBox.Text, entréeTextBox)
        If success Then
            If entréeTextBox >= -1 And entréeTextBox <= 1 Then
                etatTextBox = 1
                'Passe au textbox d'après

                newTextBox = GetNextControl(txtBox, True) 'Detecte le textbox d'apres
                newTextBox.Focus() 'Bug lors de la dernière textbox car il ne peut plus focus sur autre chose

            Else
                MessageBox.Show("Veuillez entrer un nombre entre -1 et 1")
            End If
        ElseIf success = False Then
            MessageBox.Show("Veuillez ne pas entrer du texte")
        End If

    End Function

    '************************************************************************************************************
    'Dessine les 4 points à placer pour réaliser la courbe

    Private Function DessinerPoint(x As Integer, y As Integer)
        'Affiche le point seulement toutes les 2 textbox renseignées
        'nbreElemtsListe - 2 = point x de la textbox en cours
        'nbreElemtsListe - 1 = point y de la textbox en cours
        g.DrawLine(Pens.Red, x - 2, y, x + 2, y)
        g.DrawLine(Pens.Red, x, y - 2, x, y + 2)
        PictureBox1.CreateGraphics().DrawLine(Pens.Red, x - 2, y, x + 2, y)
        PictureBox1.CreateGraphics().DrawLine(Pens.Red, x, y - 2, x, y + 2)
        PictureBox1.Image = img
    End Function

    '************************************************************************************************************
    'Convertit les points du picture box sur une échelle -1;1

    Private Function ConvertirX(Point As Double)

        Dim N_Point As Double
        N_Point = 215 * Point + 215
        Return N_Point
        ' nbrElemtsListe = listePoints.Count 'Récupère le nombre de points renseignés 

    End Function

    '************************************************************************************************************
    Private Function ConvertirY(Point As Double)

        Dim N_Point As Double
        'Position du Y
        If Point >= 0 Then
            N_Point = 215 * -Point + 215
        ElseIf Point < 0 Then
            N_Point = 215 * Math.Abs(Point) + 215
        End If
        Return N_Point

    End Function

    '************************************************************************************************************
    'calcul la courbe de Bézier
    Private Function CourbeBezier(n As Integer)
        Dim incr As Integer
        Dim i As Double
        Dim x As Double
        Dim y As Double

        listeBezier.Clear()

        For i = 0 To 1 Step 1 / n

            x = Math.Pow((1 - i), 3) * listePoints(0) + 3 * i * Math.Pow((1 - i), 2) * listePoints(4) + 3 * Math.Pow(i, 2) * (1 - i) * listePoints(6) + Math.Pow(i, 3) * listePoints(2)

            listeBezier.Add(x)

            y = Math.Pow((1 - i), 3) * listePoints(1) + 3 * i * Math.Pow((1 - i), 2) * listePoints(5) + 3 * Math.Pow(i, 2) * (1 - i) * listePoints(7) + Math.Pow(i, 3) * listePoints(3)

            listeBezier.Add(y)
        Next

        nbrElemtsListeBezier = listeBezier.Count
        For incr = 0 To nbrElemtsListeBezier - 3 Step 2
            'Dessiner les segments en reliant les points
            g.DrawLine(New Pen(mycolor, 2), listeBezier(incr), listeBezier(incr + 1), listeBezier(incr + 2), listeBezier(incr + 3))
            PictureBox1.CreateGraphics().DrawLine(New Pen(mycolor, 2), listeBezier(incr), listeBezier(incr + 1), listeBezier(incr + 2), listeBezier(incr + 3))
        Next
        PictureBox1.Image = img

    End Function

    '************************************************************************************************************
    'Calcul la longueur de la courbe
    Private Function LongueurCourbe()
        Dim i As Integer
        Dim longueur As Double = 0
        For i = 0 To (nbrElemtsListeBezier - 4) Step 2
            longueur += Math.Sqrt(Math.Pow((listeBezier(i + 2) - listeBezier(i)), 2) + Math.Pow((listeBezier(i + 3) - listeBezier(i + 1)), 2))
        Next
        longueur = longueur / 215
        txtBoxLongCourbe.Text = longueur.ToString()
    End Function

    '************************************************************************************************************
    ' si la Case est coché, disable toute les textBox
    Private Sub ChekPointSouris_CheckedChanged(sender As Object, e As EventArgs) Handles ChekPointSouris.CheckedChanged

        If ChekPointSouris.Checked = True Then
            txtBoxPtgDebX.Enabled = False
            txtBoxPtgDebY.Enabled = False
            txtBoxPtgFinX.Enabled = False
            txtBoxPtgFinY.Enabled = False
            txtBoxXDéb.Enabled = False
            txtBoxXFin.Enabled = False
            txtBoxYDéb.Enabled = False
            txtBoxYFin.Enabled = False

        End If
    End Sub

    '************************************************************************************************************
    'definir les valeurs quand on utilise la souris 
    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        Dim Disp_MouseX As Double
        Dim Disp_MouseY As Double

        If ChekPointSouris.Checked = True Then 'si la case est coché 

            MouseX = Convert.ToDouble(e.X) 'récuperer les valeurs de X
            MouseY = Convert.ToDouble(e.Y) 'recuperer les valeurs de y

            Disp_MouseX = MouseX / 215 - 1
            Disp_MouseY = -MouseY / 215 + 1


            If IdPoint Is btnPtDéb Then 'si idpoint defini dans la fonction @btn4Pts_Click vaux btnptdeb
                txtBoxXDéb.Text = Disp_MouseX 'le text dans la textboxX
                txtBoxYDéb.Text = Disp_MouseY 'le text dans la textboxY
                listePoints(0) = MouseX  'mettre les valeurs dans la liste 
                listePoints(1) = MouseY  'mettre les valeurs dans la liste 
                listePointsGrid(0) = Disp_MouseX
                listePointsGrid(1) = Disp_MouseY
                'pour redessiner la courbe apres le changement d'un point 
                Redessiner()

            ElseIf IdPoint Is btnPtFin Then
                txtBoxXFin.Text = Disp_MouseX
                txtBoxYFin.Text = Disp_MouseY
                listePoints(2) = MouseX
                listePoints(3) = MouseY
                listePointsGrid(2) = Disp_MouseX
                listePointsGrid(3) = Disp_MouseY
                Redessiner()

            ElseIf IdPoint Is btnPtgDeb Then
                txtBoxPtgDebX.Text = Disp_MouseX
                txtBoxPtgDebY.Text = Disp_MouseY
                listePoints(4) = MouseX
                listePoints(5) = MouseY
                listePointsGrid(4) = Disp_MouseX
                listePointsGrid(5) = Disp_MouseY
                Redessiner()

            ElseIf IdPoint Is btnPtgFin Then
                txtBoxPtgFinX.Text = Disp_MouseX
                txtBoxPtgFinY.Text = Disp_MouseY
                listePoints(6) = MouseX
                listePoints(7) = MouseY
                listePointsGrid(6) = Disp_MouseX
                listePointsGrid(7) = Disp_MouseY
                Redessiner()
            End If
        End If

    End Sub

    '************************************************************************************************************
    'Ecriture des valeurs dans les TextBox 
    Private Sub btn4Pts_Click(sender As Object, e As EventArgs) Handles btnPtDéb.Click, btnPtFin.Click, btnPtgDeb.Click, btnPtgFin.Click

        'Gestion du placement du point de départ
        If sender Is btnPtDéb Then
            If ChekPointSouris.Checked = False Then ' si la case n'est pas coché 
                EnableTxtBox(txtBoxXDéb, txtBoxYDéb) 'enable la txtbox
            Else                                    ' si la case est coché 
                sender.FlatAppearance.BorderColor = Color.Blue 'alors le bord de la case est bleu 

                IdPoint = btnPtDéb 'id point prend la valeur 
            End If
        End If

        'Gestion du placement du point de fin
        If sender Is btnPtFin Then
            If ChekPointSouris.Checked = False Then
                EnableTxtBox(txtBoxXFin, txtBoxYFin)
            Else
                sender.FlatAppearance.BorderColor = Color.Blue

                IdPoint = btnPtFin
            End If
        End If

        'Gestion du placement du point de tangante de debut
        If sender Is btnPtgDeb Then
            If ChekPointSouris.Checked = False Then
                EnableTxtBox(txtBoxPtgDebX, txtBoxPtgDebY)
            Else
                sender.FlatAppearance.BorderColor = Color.Blue

                IdPoint = btnPtgDeb
            End If
        End If

        'Gestion du placement du point de tangante de Fin
        If sender Is btnPtgFin Then
            If ChekPointSouris.Checked = False Then
                EnableTxtBox(txtBoxPtgFinX, txtBoxPtgFinY)
            Else
                sender.FlatAppearance.BorderColor = Color.Blue

                IdPoint = btnPtgFin
            End If
        End If
    End Sub

    '************************************************************************************************************
    Private Sub Dessinercourbe(StopBezier As Boolean)
        If StopBezier = False Then
            Dim tangPen = New Pen(Color.Gray, 1)
            'Dessiner chaque point 
            DessinerPoint(listePoints(6), listePoints(7))
            DessinerPoint(listePoints(4), listePoints(5))
            DessinerPoint(listePoints(2), listePoints(3))
            DessinerPoint(listePoints(0), listePoints(1))
            'dessiner la courbe  
            CourbeBezier(NumericUpDown1.Value)
            'calculer la longueur de la courbe 
            LongueurCourbe()
            'dessiner les tangeante
            PictureBox1.CreateGraphics().DrawLine(tangPen, listePoints(0), listePoints(1), listePoints(4), listePoints(5))
            PictureBox1.CreateGraphics().DrawLine(tangPen, listePoints(2), listePoints(3), listePoints(6), listePoints(7))
            g.DrawLine(tangPen, listePoints(0), listePoints(1), listePoints(4), listePoints(5))
            g.DrawLine(tangPen, listePoints(2), listePoints(3), listePoints(6), listePoints(7))
            PictureBox1.Image = img
        End If
    End Sub

    '************************************************************************************************************
    'Méthode principale pour enregistrer les coordonnées des points  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub txtBoxXDéb_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxXDéb.KeyDown, txtBoxXFin.KeyDown, txtBoxPtgDebX.KeyDown, txtBoxPtgFinX.KeyDown, txtBoxPtgFinY.KeyDown, txtBoxPtgDebY.KeyDown, txtBoxYFin.KeyDown, txtBoxYDéb.KeyDown
        Dim i As Integer = 0

        'On regarde chaque fois que l'utilisateur appuie sur Entrer 

        If e.KeyValue = Keys.Enter Then
            If sender Is txtBoxPtgFinY Then
                RemplacementPointVirgule(sender)
                'Condition pour être sûr de ce qui est entré dans la textbox

                If etatTextBox = 1 Then
                    listeNonConvert(7) = Double.Parse(sender.text)
                    listePoints(7) = ConvertirY(listeNonConvert(7))
                    DessinerPoint(listePoints(6), listePoints(7))
                    Redessiner()

                End If
            End If

            If sender Is txtBoxPtgDebY Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(5) = Double.Parse(sender.text)
                    listePoints(5) = ConvertirY(listeNonConvert(5))
                    DessinerPoint(listePoints(4), listePoints(5))
                    Redessiner()
                End If
            End If

            If sender Is txtBoxYFin Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(3) = Double.Parse(sender.text)
                    listePoints(3) = ConvertirY(listeNonConvert(3))
                    DessinerPoint(listePoints(2), listePoints(3))
                    Redessiner()
                End If
            End If

            If sender Is txtBoxYDéb Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(1) = Double.Parse(sender.text)
                    listePoints(1) = ConvertirY(listeNonConvert(1))
                    DessinerPoint(listePoints(0), listePoints(1))
                    Redessiner()
                End If
            End If


            If sender Is txtBoxPtgFinX Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(6) = Double.Parse(sender.text)
                    listePoints(6) = ConvertirX(listeNonConvert(6))
                End If
            End If

            If sender Is txtBoxPtgDebX Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(4) = Double.Parse(sender.text)
                    listePoints(4) = ConvertirX(listeNonConvert(4))
                End If
            End If

            If sender Is txtBoxXFin Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(2) = Double.Parse(sender.text)
                    listePoints(2) = ConvertirX(listeNonConvert(2))
                End If
            End If

            If sender Is txtBoxXDéb Then
                RemplacementPointVirgule(sender)
                If etatTextBox = 1 Then
                    listeNonConvert(0) = Double.Parse(sender.text)
                    listePoints(0) = ConvertirX(listeNonConvert(0))

                End If
            End If

        End If
    End Sub

    Private Sub DrawAxes()
        Dim pinceau As New Pen(Color.Black)
        'Traçage du graphe
        g.DrawLine(pinceau, 0, 215, 430, 215)
        g.DrawLine(pinceau, 215, 0, 215, 430)


        Dim MyBrush As New SolidBrush(Color.Black)
        Dim StringFont As New Font("Arial", 10)
        'axe abscisse
        g.DrawString("-1", StringFont, MyBrush, 0, 215)
        g.DrawString("0", StringFont, MyBrush, 215, 215)
        g.DrawString("1", StringFont, MyBrush, 415, 215)


        'axe ordonnée
        g.DrawString("1", StringFont, MyBrush, 215, 0)
        g.DrawString("-1", StringFont, MyBrush, 215, 410)
    End Sub


    '************************************************************************************************************
    Private Sub Courbe_bezier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g.Clear(Color.White)
        DrawAxes()

        PictureBox2.BackColor = mycolor
        PictureBox1.Image = img
    End Sub

    '************************************************************************************************************
    Private Sub Redessiner()
        If stopBezier = True Then
            g.Clear(Color.White)
            DrawAxes()
            EffacerPB() ' effacer le picture box
            Dessinercourbe(False)
        End If
    End Sub

    '************************************************************************************************************
    Private Sub EffacerPB()
        PictureBox1.Refresh()

    End Sub

    '************************************************************************************************************
    Private Sub btnDeleteBezier_Click(sender As Object, e As EventArgs) Handles btnDeleteBezier.Click
        g.Clear(Color.White)
        DrawAxes()
        txtBoxLongCourbe.Text = 0
        stopBezier = False
        EffacerPB()
        Dim i As Integer
        For i = 0 To 7 Step 1
            listePoints(i) = 0
            listeNonConvert(i) = 0
        Next

        txtBoxPtgDebX.Text = ""
        txtBoxPtgDebY.Text = ""
        txtBoxPtgFinX.Text = ""
        txtBoxPtgFinY.Text = ""
        txtBoxXDéb.Text = ""
        txtBoxXFin.Text = ""
        txtBoxYDéb.Text = ""
        txtBoxYFin.Text = ""
    End Sub

    '************************************************************************************************************
    Private Sub btnDrawBezier_Click(sender As Object, e As EventArgs) Handles btnDrawBezier.Click
        Dessinercourbe(stopBezier)
        stopBezier = True
    End Sub

    '************************************************************************************************************
    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            PictureBox2.BackColor = ColorDialog1.Color
            mycolor = ColorDialog1.Color

            If stopBezier = True Then
                EffacerPB() ' effacer le picture box
                Dessinercourbe(False)
            End If

        End If
        'PictureBox2.BackColor = mycolor
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            MessageBox.Show("Sélectionnez minimum 1 segment")
            NumericUpDown1.Value = 1
        Else
            g.Clear(Color.White)
            DrawAxes()
            Redessiner()
        End If
    End Sub

    Private Sub BtnSaveAsJPEG_Click(sender As Object, e As EventArgs) Handles BtnSaveAsJPEG.Click
        PictureBox1.BackColor = Color.White

        Dim sfdPic As New SaveFileDialog()
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        Dim Dir As String = System.IO.Path.GetDirectoryName(Path)

        Dim title As String = "Code"
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information

        Try
            If Not System.IO.Directory.Exists(Dir) Then
                System.IO.Directory.CreateDirectory(Dir)
            End If

            With sfdPic
                .Title = "Save as"
                .Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Image|*.png"
                .AddExtension = True
                .DefaultExt = ".jpeg"
                .FileName = "courbe_bezier.jpeg"
                .ValidateNames = True
                .OverwritePrompt = True
                .InitialDirectory = Dir
                .RestoreDirectory = True

                If .ShowDialog = DialogResult.OK Then
                    If .FilterIndex = 1 Then
                        PictureBox1.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Jpeg)
                    ElseIf .FilterIndex = 2 Then
                        PictureBox1.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Png)
                    End If
                Else
                    Return
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("Error: Saving Image Failed ->> " & ex.Message.ToString())
        Finally
            sfdPic.Dispose()
        End Try

    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        If Not listePointsGrid(0) = 0 And Not listePointsGrid(1) = 0 And Not listePointsGrid(2) = 0 And Not listePointsGrid(3) = 0 And Not listePointsGrid(4) = 0 And Not listePointsGrid(5) = 0 And Not listePointsGrid(6) = 0 And Not listePointsGrid(7) = 0 Then
            Dim rowId As Integer = DataGrid.Rows.Add()
            Dim row As DataGridViewRow = DataGrid.Rows(rowId)
            row.Cells(0).Value = listePointsGrid(0)
            row.Cells(1).Value = listePointsGrid(1)
            row.Cells(2).Value = listePointsGrid(2)
            row.Cells(3).Value = listePointsGrid(3)
            row.Cells(4).Value = listePointsGrid(4)
            row.Cells(5).Value = listePointsGrid(5)
            row.Cells(6).Value = listePointsGrid(6)
            row.Cells(7).Value = listePointsGrid(7)
        Else
            MessageBox.Show("Veuillez d'abord tracer la courbe")
        End If

    End Sub

    Private Sub BtnDelRow_Click(sender As Object, e As EventArgs) Handles BtnDelRow.Click
        Try
            If DataGrid.RowCount <= 1 Then
                MessageBox.Show("Veuillez sauvegarder au moins une courbe")

            ElseIf Not DataGrid.CurrentCell.RowIndex + 1 = DataGrid.RowCount Then
                DataGrid.Rows.RemoveAt(DataGrid.CurrentCell.RowIndex)
            Else
            MessageBox.Show("Veuillez sélectionner une ligne")
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez sauvegarder au moins une courbe")
        End Try


    End Sub

    Private Sub BtnSaveBez_Click(sender As Object, e As EventArgs) Handles BtnSaveBez.Click
        Try
            If DataGrid.RowCount <= 1 Then
                MessageBox.Show("Veuillez sauvegarder au moins une courbe")

            ElseIf Not DataGrid.CurrentCell.RowIndex + 1 = DataGrid.RowCount Then
                Dim headers = (From header As DataGridViewColumn In DataGrid.Columns.Cast(Of DataGridViewColumn)()
                               Select header.HeaderText).ToArray
                Dim rows = From row As DataGridViewRow In DataGrid.Rows.Cast(Of DataGridViewRow)()
                           Where Not row.IsNewRow
                           Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
                Using sw As New IO.StreamWriter("data.txt")
                    sw.WriteLine(String.Join(";", headers))
                    For Each r In rows
                        sw.WriteLine(String.Join(";", r))
                    Next
                End Using
                Process.Start("data.txt")
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez sauvegarder au moins une courbe")
        End Try


    End Sub

    Private Sub BtnPrintRow_Click(sender As Object, e As EventArgs) Handles BtnPrintRow.Click
        Try
            Dessinercourbe(stopBezier)
            stopBezier = True
            Dim rowSelected As Integer
            If DataGrid.RowCount <= 1 Then
                MessageBox.Show("Veuillez sauvegarder au moins une courbe")

            ElseIf Not DataGrid.CurrentCell.RowIndex + 1 = DataGrid.RowCount Then
                rowSelected = DataGrid.CurrentCell.RowIndex
                Dim row As DataGridViewRow = DataGrid.Rows(rowSelected)

                listePointsGrid(0) = row.Cells(0).Value
                listePointsGrid(1) = row.Cells(1).Value
                listePointsGrid(2) = row.Cells(2).Value
                listePointsGrid(3) = row.Cells(3).Value
                listePointsGrid(4) = row.Cells(4).Value
                listePointsGrid(5) = row.Cells(5).Value
                listePointsGrid(6) = row.Cells(6).Value
                listePointsGrid(7) = row.Cells(7).Value

                txtBoxXDéb.Text = listePointsGrid(0)
                txtBoxYDéb.Text = listePointsGrid(1)
                txtBoxXFin.Text = listePointsGrid(2)
                txtBoxYFin.Text = listePointsGrid(3)
                txtBoxPtgDebX.Text = listePointsGrid(4)
                txtBoxPtgDebY.Text = listePointsGrid(5)
                txtBoxPtgFinX.Text = listePointsGrid(6)
                txtBoxPtgFinY.Text = listePointsGrid(7)

                listePoints(0) = (listePointsGrid(0) + 1) * 215
                listePoints(1) = (listePointsGrid(1) - 1) * (-215)
                listePoints(2) = (listePointsGrid(2) + 1) * 215
                listePoints(3) = (listePointsGrid(3) - 1) * (-215)
                listePoints(4) = (listePointsGrid(4) + 1) * 215
                listePoints(5) = (listePointsGrid(5) - 1) * (-215)
                listePoints(6) = (listePointsGrid(6) + 1) * 215
                listePoints(7) = (listePointsGrid(7) - 1) * (-215)
                Redessiner()
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez sauvegarder au moins une courbe")
        End Try

    End Sub

    Private Sub BtnModRow_Click(sender As Object, e As EventArgs) Handles BtnModRow.Click
        Try
            Dim rowSelected As Integer
            If DataGrid.RowCount <= 1 Then
                MessageBox.Show("Veuillez sauvegarder au moins une courbe")

            ElseIf Not DataGrid.CurrentCell.RowIndex + 1 = DataGrid.RowCount Then
                rowSelected = DataGrid.CurrentCell.RowIndex
                Dim row As DataGridViewRow = DataGrid.Rows(rowSelected)
                listePointsGrid(0) = txtBoxXDéb.Text
                listePointsGrid(1) = txtBoxYDéb.Text
                listePointsGrid(2) = txtBoxXFin.Text
                listePointsGrid(3) = txtBoxYFin.Text
                listePointsGrid(4) = txtBoxPtgDebX.Text
                listePointsGrid(5) = txtBoxPtgDebY.Text
                listePointsGrid(6) = txtBoxPtgFinX.Text
                listePointsGrid(7) = txtBoxPtgFinY.Text

                row.Cells(0).Value = listePointsGrid(0)
                row.Cells(1).Value = listePointsGrid(1)
                row.Cells(2).Value = listePointsGrid(2)
                row.Cells(3).Value = listePointsGrid(3)
                row.Cells(4).Value = listePointsGrid(4)
                row.Cells(5).Value = listePointsGrid(5)
                row.Cells(6).Value = listePointsGrid(6)
                row.Cells(7).Value = listePointsGrid(7)
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez sauvegarder au moins une courbe")
        End Try
    End Sub

    Private Sub BtnImpBez_Click(sender As Object, e As EventArgs) Handles BtnImpBez.Click
        Dim lines() As String
        Dim vals() As String

        lines = File.ReadAllLines(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\Bezier.txt")

        For i As Integer = 0 To lines.Length - 1 Step 1
            vals = lines(i).ToString().Split(";")
            Dim row(vals.Length - 1) As String

            For j As Integer = 0 To vals.Length - 1 Step 1
                row(j) = vals(j).Trim()
            Next j
            DataGrid.Rows.Add(row)
        Next i
    End Sub
End Class

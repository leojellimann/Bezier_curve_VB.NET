<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Courbe_bezier
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPtDéb = New System.Windows.Forms.Button()
        Me.btnPtFin = New System.Windows.Forms.Button()
        Me.txtBoxXDéb = New System.Windows.Forms.TextBox()
        Me.txtBoxYDéb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxXFin = New System.Windows.Forms.TextBox()
        Me.txtBoxYFin = New System.Windows.Forms.TextBox()
        Me.btnPtgDeb = New System.Windows.Forms.Button()
        Me.txtBoxPtgDebY = New System.Windows.Forms.TextBox()
        Me.txtBoxPtgDebX = New System.Windows.Forms.TextBox()
        Me.txtBoxPtgFinY = New System.Windows.Forms.TextBox()
        Me.txtBoxPtgFinX = New System.Windows.Forms.TextBox()
        Me.btnPtgFin = New System.Windows.Forms.Button()
        Me.ChekPointSouris = New System.Windows.Forms.CheckBox()
        Me.txtBoxLongCourbe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnDrawBezier = New System.Windows.Forms.Button()
        Me.btnDeleteBezier = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnSaveAsJPEG = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Pdébx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pdéby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pfinx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pfiny = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtgDebx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtgDeby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtgFinx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtgFiny = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSaveData = New System.Windows.Forms.Button()
        Me.BtnPrintRow = New System.Windows.Forms.Button()
        Me.BtnModRow = New System.Windows.Forms.Button()
        Me.BtnDelRow = New System.Windows.Forms.Button()
        Me.BtnSaveBez = New System.Windows.Forms.Button()
        Me.BtnImpBez = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(387, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 430)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPtDéb
        '
        Me.btnPtDéb.Location = New System.Drawing.Point(24, 101)
        Me.btnPtDéb.Name = "btnPtDéb"
        Me.btnPtDéb.Size = New System.Drawing.Size(75, 23)
        Me.btnPtDéb.TabIndex = 1
        Me.btnPtDéb.Text = "Pdéb"
        Me.btnPtDéb.UseVisualStyleBackColor = True
        '
        'btnPtFin
        '
        Me.btnPtFin.Location = New System.Drawing.Point(24, 130)
        Me.btnPtFin.Name = "btnPtFin"
        Me.btnPtFin.Size = New System.Drawing.Size(75, 23)
        Me.btnPtFin.TabIndex = 4
        Me.btnPtFin.Text = "Pfin"
        Me.btnPtFin.UseVisualStyleBackColor = True
        '
        'txtBoxXDéb
        '
        Me.txtBoxXDéb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxXDéb.Enabled = False
        Me.txtBoxXDéb.Location = New System.Drawing.Point(129, 103)
        Me.txtBoxXDéb.MaxLength = 7
        Me.txtBoxXDéb.Name = "txtBoxXDéb"
        Me.txtBoxXDéb.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxXDéb.TabIndex = 2
        '
        'txtBoxYDéb
        '
        Me.txtBoxYDéb.Enabled = False
        Me.txtBoxYDéb.Location = New System.Drawing.Point(239, 103)
        Me.txtBoxYDéb.MaxLength = 7
        Me.txtBoxYDéb.Name = "txtBoxYDéb"
        Me.txtBoxYDéb.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxYDéb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "y"
        '
        'txtBoxXFin
        '
        Me.txtBoxXFin.Enabled = False
        Me.txtBoxXFin.Location = New System.Drawing.Point(129, 133)
        Me.txtBoxXFin.MaxLength = 7
        Me.txtBoxXFin.Name = "txtBoxXFin"
        Me.txtBoxXFin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxXFin.TabIndex = 5
        '
        'txtBoxYFin
        '
        Me.txtBoxYFin.Enabled = False
        Me.txtBoxYFin.Location = New System.Drawing.Point(239, 133)
        Me.txtBoxYFin.MaxLength = 7
        Me.txtBoxYFin.Name = "txtBoxYFin"
        Me.txtBoxYFin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxYFin.TabIndex = 6
        '
        'btnPtgDeb
        '
        Me.btnPtgDeb.Location = New System.Drawing.Point(24, 159)
        Me.btnPtgDeb.Name = "btnPtgDeb"
        Me.btnPtgDeb.Size = New System.Drawing.Size(75, 23)
        Me.btnPtgDeb.TabIndex = 7
        Me.btnPtgDeb.Text = "PtgDeb"
        Me.btnPtgDeb.UseVisualStyleBackColor = True
        '
        'txtBoxPtgDebY
        '
        Me.txtBoxPtgDebY.Enabled = False
        Me.txtBoxPtgDebY.Location = New System.Drawing.Point(239, 162)
        Me.txtBoxPtgDebY.MaxLength = 7
        Me.txtBoxPtgDebY.Name = "txtBoxPtgDebY"
        Me.txtBoxPtgDebY.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgDebY.TabIndex = 9
        '
        'txtBoxPtgDebX
        '
        Me.txtBoxPtgDebX.Enabled = False
        Me.txtBoxPtgDebX.Location = New System.Drawing.Point(129, 162)
        Me.txtBoxPtgDebX.MaxLength = 7
        Me.txtBoxPtgDebX.Name = "txtBoxPtgDebX"
        Me.txtBoxPtgDebX.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgDebX.TabIndex = 8
        '
        'txtBoxPtgFinY
        '
        Me.txtBoxPtgFinY.Enabled = False
        Me.txtBoxPtgFinY.Location = New System.Drawing.Point(239, 191)
        Me.txtBoxPtgFinY.MaxLength = 7
        Me.txtBoxPtgFinY.Name = "txtBoxPtgFinY"
        Me.txtBoxPtgFinY.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgFinY.TabIndex = 12
        '
        'txtBoxPtgFinX
        '
        Me.txtBoxPtgFinX.Enabled = False
        Me.txtBoxPtgFinX.Location = New System.Drawing.Point(129, 191)
        Me.txtBoxPtgFinX.MaxLength = 7
        Me.txtBoxPtgFinX.Name = "txtBoxPtgFinX"
        Me.txtBoxPtgFinX.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgFinX.TabIndex = 11
        '
        'btnPtgFin
        '
        Me.btnPtgFin.Location = New System.Drawing.Point(24, 188)
        Me.btnPtgFin.Name = "btnPtgFin"
        Me.btnPtgFin.Size = New System.Drawing.Size(75, 23)
        Me.btnPtgFin.TabIndex = 10
        Me.btnPtgFin.Text = "PtgFin"
        Me.btnPtgFin.UseVisualStyleBackColor = True
        '
        'ChekPointSouris
        '
        Me.ChekPointSouris.AutoSize = True
        Me.ChekPointSouris.Location = New System.Drawing.Point(24, 53)
        Me.ChekPointSouris.Name = "ChekPointSouris"
        Me.ChekPointSouris.Size = New System.Drawing.Size(203, 17)
        Me.ChekPointSouris.TabIndex = 21
        Me.ChekPointSouris.Text = "Selectionner les points avec la souris "
        Me.ChekPointSouris.UseVisualStyleBackColor = True
        '
        'txtBoxLongCourbe
        '
        Me.txtBoxLongCourbe.Location = New System.Drawing.Point(192, 351)
        Me.txtBoxLongCourbe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxLongCourbe.Name = "txtBoxLongCourbe"
        Me.txtBoxLongCourbe.Size = New System.Drawing.Size(131, 20)
        Me.txtBoxLongCourbe.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 328)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Longueur de la courbe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 328)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nombre de segments"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(24, 351)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown1.TabIndex = 25
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'btnDrawBezier
        '
        Me.btnDrawBezier.Location = New System.Drawing.Point(24, 227)
        Me.btnDrawBezier.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDrawBezier.Name = "btnDrawBezier"
        Me.btnDrawBezier.Size = New System.Drawing.Size(147, 55)
        Me.btnDrawBezier.TabIndex = 26
        Me.btnDrawBezier.Text = "Tracer la courbe"
        Me.btnDrawBezier.UseVisualStyleBackColor = True
        '
        'btnDeleteBezier
        '
        Me.btnDeleteBezier.Location = New System.Drawing.Point(192, 227)
        Me.btnDeleteBezier.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDeleteBezier.Name = "btnDeleteBezier"
        Me.btnDeleteBezier.Size = New System.Drawing.Size(147, 55)
        Me.btnDeleteBezier.TabIndex = 27
        Me.btnDeleteBezier.Text = "Supprimer la courbe"
        Me.btnDeleteBezier.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(22, 413)
        Me.BtnColor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(86, 28)
        Me.BtnColor.TabIndex = 28
        Me.BtnColor.Text = "Couleur"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(112, 413)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'BtnSaveAsJPEG
        '
        Me.BtnSaveAsJPEG.Location = New System.Drawing.Point(24, 571)
        Me.BtnSaveAsJPEG.Name = "BtnSaveAsJPEG"
        Me.BtnSaveAsJPEG.Size = New System.Drawing.Size(220, 53)
        Me.BtnSaveAsJPEG.TabIndex = 30
        Me.BtnSaveAsJPEG.Text = "Enregistrer la courbe en JPEG/PNG"
        Me.BtnSaveAsJPEG.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pdébx, Me.Pdéby, Me.Pfinx, Me.Pfiny, Me.PtgDebx, Me.PtgDeby, Me.PtgFinx, Me.PtgFiny})
        Me.DataGrid.GridColor = System.Drawing.SystemColors.Control
        Me.DataGrid.Location = New System.Drawing.Point(305, 482)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersWidth = 51
        Me.DataGrid.Size = New System.Drawing.Size(654, 142)
        Me.DataGrid.TabIndex = 31
        '
        'Pdébx
        '
        Me.Pdébx.FillWeight = 75.0!
        Me.Pdébx.HeaderText = "Pdébx"
        Me.Pdébx.MinimumWidth = 6
        Me.Pdébx.Name = "Pdébx"
        Me.Pdébx.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pdébx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Pdébx.Width = 75
        '
        'Pdéby
        '
        Me.Pdéby.FillWeight = 75.0!
        Me.Pdéby.HeaderText = "Pdéby"
        Me.Pdéby.MinimumWidth = 6
        Me.Pdéby.Name = "Pdéby"
        Me.Pdéby.Width = 75
        '
        'Pfinx
        '
        Me.Pfinx.FillWeight = 75.0!
        Me.Pfinx.HeaderText = "Pfinx"
        Me.Pfinx.MinimumWidth = 6
        Me.Pfinx.Name = "Pfinx"
        Me.Pfinx.Width = 75
        '
        'Pfiny
        '
        Me.Pfiny.FillWeight = 75.0!
        Me.Pfiny.HeaderText = "Pfiny"
        Me.Pfiny.MinimumWidth = 6
        Me.Pfiny.Name = "Pfiny"
        Me.Pfiny.Width = 75
        '
        'PtgDebx
        '
        Me.PtgDebx.FillWeight = 75.0!
        Me.PtgDebx.HeaderText = "PtgDebx"
        Me.PtgDebx.MinimumWidth = 6
        Me.PtgDebx.Name = "PtgDebx"
        Me.PtgDebx.Width = 75
        '
        'PtgDeby
        '
        Me.PtgDeby.FillWeight = 75.0!
        Me.PtgDeby.HeaderText = "PtgDeby"
        Me.PtgDeby.MinimumWidth = 6
        Me.PtgDeby.Name = "PtgDeby"
        Me.PtgDeby.Width = 75
        '
        'PtgFinx
        '
        Me.PtgFinx.FillWeight = 75.0!
        Me.PtgFinx.HeaderText = "PtgFinx"
        Me.PtgFinx.MinimumWidth = 6
        Me.PtgFinx.Name = "PtgFinx"
        Me.PtgFinx.Width = 75
        '
        'PtgFiny
        '
        Me.PtgFiny.FillWeight = 75.0!
        Me.PtgFiny.HeaderText = "PtgFiny"
        Me.PtgFiny.MinimumWidth = 6
        Me.PtgFiny.Name = "PtgFiny"
        Me.PtgFiny.Width = 75
        '
        'BtnSaveData
        '
        Me.BtnSaveData.Location = New System.Drawing.Point(24, 482)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(220, 53)
        Me.BtnSaveData.TabIndex = 32
        Me.BtnSaveData.Text = "Enregistrer la courbe dans le tableau"
        Me.BtnSaveData.UseVisualStyleBackColor = True
        '
        'BtnPrintRow
        '
        Me.BtnPrintRow.Location = New System.Drawing.Point(1024, 351)
        Me.BtnPrintRow.Name = "BtnPrintRow"
        Me.BtnPrintRow.Size = New System.Drawing.Size(233, 78)
        Me.BtnPrintRow.TabIndex = 33
        Me.BtnPrintRow.Text = "Afficher la ligne sélectionnée"
        Me.BtnPrintRow.UseVisualStyleBackColor = True
        '
        'BtnModRow
        '
        Me.BtnModRow.Location = New System.Drawing.Point(1024, 447)
        Me.BtnModRow.Name = "BtnModRow"
        Me.BtnModRow.Size = New System.Drawing.Size(233, 78)
        Me.BtnModRow.TabIndex = 34
        Me.BtnModRow.Text = "Enregistrer la modification de la courbe"
        Me.BtnModRow.UseVisualStyleBackColor = True
        '
        'BtnDelRow
        '
        Me.BtnDelRow.Location = New System.Drawing.Point(1024, 549)
        Me.BtnDelRow.Name = "BtnDelRow"
        Me.BtnDelRow.Size = New System.Drawing.Size(233, 75)
        Me.BtnDelRow.TabIndex = 35
        Me.BtnDelRow.Text = "Supprimer la courbe du tableau"
        Me.BtnDelRow.UseVisualStyleBackColor = True
        '
        'BtnSaveBez
        '
        Me.BtnSaveBez.Location = New System.Drawing.Point(1024, 254)
        Me.BtnSaveBez.Name = "BtnSaveBez"
        Me.BtnSaveBez.Size = New System.Drawing.Size(233, 78)
        Me.BtnSaveBez.TabIndex = 36
        Me.BtnSaveBez.Text = "Sauvegarder les courbes dans un fichier txt"
        Me.BtnSaveBez.UseVisualStyleBackColor = True
        '
        'BtnImpBez
        '
        Me.BtnImpBez.Location = New System.Drawing.Point(1024, 150)
        Me.BtnImpBez.Name = "BtnImpBez"
        Me.BtnImpBez.Size = New System.Drawing.Size(233, 78)
        Me.BtnImpBez.TabIndex = 37
        Me.BtnImpBez.Text = "Importer des courbes d'un fichier txt"
        Me.BtnImpBez.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(823, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(452, 31)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Projet VB.NET Courbe de bézier :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(837, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(420, 31)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Antoine Muller et Léo Jellimann"
        '
        'Courbe_bezier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1283, 650)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnImpBez)
        Me.Controls.Add(Me.BtnSaveBez)
        Me.Controls.Add(Me.BtnDelRow)
        Me.Controls.Add(Me.BtnModRow)
        Me.Controls.Add(Me.BtnPrintRow)
        Me.Controls.Add(Me.BtnSaveData)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.BtnSaveAsJPEG)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.btnDeleteBezier)
        Me.Controls.Add(Me.btnDrawBezier)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBoxLongCourbe)
        Me.Controls.Add(Me.ChekPointSouris)
        Me.Controls.Add(Me.txtBoxPtgFinY)
        Me.Controls.Add(Me.txtBoxPtgFinX)
        Me.Controls.Add(Me.btnPtgFin)
        Me.Controls.Add(Me.txtBoxPtgDebY)
        Me.Controls.Add(Me.txtBoxPtgDebX)
        Me.Controls.Add(Me.btnPtgDeb)
        Me.Controls.Add(Me.txtBoxYFin)
        Me.Controls.Add(Me.txtBoxXFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxYDéb)
        Me.Controls.Add(Me.txtBoxXDéb)
        Me.Controls.Add(Me.btnPtFin)
        Me.Controls.Add(Me.btnPtDéb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Courbe_bezier"
        Me.Text = "Projet courbe bezier"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPtDéb As Button
    Friend WithEvents btnPtFin As Button
    Friend WithEvents txtBoxXDéb As TextBox
    Friend WithEvents txtBoxYDéb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxXFin As TextBox
    Friend WithEvents txtBoxYFin As TextBox
    Friend WithEvents btnPtgDeb As Button
    Friend WithEvents txtBoxPtgDebY As TextBox
    Friend WithEvents txtBoxPtgDebX As TextBox
    Friend WithEvents txtBoxPtgFinY As TextBox
    Friend WithEvents txtBoxPtgFinX As TextBox
    Friend WithEvents btnPtgFin As Button
    Friend WithEvents ChekPointSouris As CheckBox
    Friend WithEvents txtBoxLongCourbe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnDrawBezier As Button
    Friend WithEvents btnDeleteBezier As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnColor As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnSaveAsJPEG As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents BtnPrintRow As Button
    Friend WithEvents BtnModRow As Button
    Friend WithEvents BtnDelRow As Button
    Friend WithEvents BtnSaveBez As Button
    Friend WithEvents BtnImpBez As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Pdébx As DataGridViewTextBoxColumn
    Friend WithEvents Pdéby As DataGridViewTextBoxColumn
    Friend WithEvents Pfinx As DataGridViewTextBoxColumn
    Friend WithEvents Pfiny As DataGridViewTextBoxColumn
    Friend WithEvents PtgDebx As DataGridViewTextBoxColumn
    Friend WithEvents PtgDeby As DataGridViewTextBoxColumn
    Friend WithEvents PtgFinx As DataGridViewTextBoxColumn
    Friend WithEvents PtgFiny As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courbe_bezier
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPtDéb = New System.Windows.Forms.Button()
        Me.btnPtFin = New System.Windows.Forms.Button()
        Me.txtBoxXDéb = New System.Windows.Forms.TextBox()
        Me.txtBoxYDéb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxXFin = New System.Windows.Forms.TextBox()
        Me.txtBoxYFin = New System.Windows.Forms.TextBox()
        Me.btnPtgDeb = New System.Windows.Forms.Button()
        Me.txtBoxPtgDebY = New System.Windows.Forms.TextBox()
        Me.txtBoxPtgDebX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBoxPtgFinY = New System.Windows.Forms.TextBox()
        Me.txtBoxPtgFinX = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPtgFin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(433, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 430)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPtDéb
        '
        Me.btnPtDéb.Location = New System.Drawing.Point(34, 87)
        Me.btnPtDéb.Name = "btnPtDéb"
        Me.btnPtDéb.Size = New System.Drawing.Size(75, 23)
        Me.btnPtDéb.TabIndex = 1
        Me.btnPtDéb.Text = "Pdéb"
        Me.btnPtDéb.UseVisualStyleBackColor = True
        '
        'btnPtFin
        '
        Me.btnPtFin.Location = New System.Drawing.Point(34, 221)
        Me.btnPtFin.Name = "btnPtFin"
        Me.btnPtFin.Size = New System.Drawing.Size(75, 23)
        Me.btnPtFin.TabIndex = 2
        Me.btnPtFin.Text = "Pfin"
        Me.btnPtFin.UseVisualStyleBackColor = True
        '
        'txtBoxXDéb
        '
        Me.txtBoxXDéb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxXDéb.Enabled = False
        Me.txtBoxXDéb.Location = New System.Drawing.Point(58, 126)
        Me.txtBoxXDéb.Name = "txtBoxXDéb"
        Me.txtBoxXDéb.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxXDéb.TabIndex = 3
        '
        'txtBoxYDéb
        '
        Me.txtBoxYDéb.Enabled = False
        Me.txtBoxYDéb.Location = New System.Drawing.Point(58, 152)
        Me.txtBoxYDéb.Name = "txtBoxYDéb"
        Me.txtBoxYDéb.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxYDéb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "x ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "y ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "x ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "y ="
        '
        'txtBoxXFin
        '
        Me.txtBoxXFin.Enabled = False
        Me.txtBoxXFin.Location = New System.Drawing.Point(58, 250)
        Me.txtBoxXFin.Name = "txtBoxXFin"
        Me.txtBoxXFin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxXFin.TabIndex = 9
        '
        'txtBoxYFin
        '
        Me.txtBoxYFin.Enabled = False
        Me.txtBoxYFin.Location = New System.Drawing.Point(58, 276)
        Me.txtBoxYFin.Name = "txtBoxYFin"
        Me.txtBoxYFin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxYFin.TabIndex = 10
        '
        'btnPtgDeb
        '
        Me.btnPtgDeb.Location = New System.Drawing.Point(34, 339)
        Me.btnPtgDeb.Name = "btnPtgDeb"
        Me.btnPtgDeb.Size = New System.Drawing.Size(75, 23)
        Me.btnPtgDeb.TabIndex = 11
        Me.btnPtgDeb.Text = "PtgDeb"
        Me.btnPtgDeb.UseVisualStyleBackColor = True
        '
        'txtBoxPtgDebY
        '
        Me.txtBoxPtgDebY.Enabled = False
        Me.txtBoxPtgDebY.Location = New System.Drawing.Point(58, 404)
        Me.txtBoxPtgDebY.Name = "txtBoxPtgDebY"
        Me.txtBoxPtgDebY.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgDebY.TabIndex = 15
        '
        'txtBoxPtgDebX
        '
        Me.txtBoxPtgDebX.Enabled = False
        Me.txtBoxPtgDebX.Location = New System.Drawing.Point(58, 378)
        Me.txtBoxPtgDebX.Name = "txtBoxPtgDebX"
        Me.txtBoxPtgDebX.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgDebX.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "y ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "x ="
        '
        'txtBoxPtgFinY
        '
        Me.txtBoxPtgFinY.Enabled = False
        Me.txtBoxPtgFinY.Location = New System.Drawing.Point(58, 517)
        Me.txtBoxPtgFinY.Name = "txtBoxPtgFinY"
        Me.txtBoxPtgFinY.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgFinY.TabIndex = 20
        '
        'txtBoxPtgFinX
        '
        Me.txtBoxPtgFinX.Enabled = False
        Me.txtBoxPtgFinX.Location = New System.Drawing.Point(58, 491)
        Me.txtBoxPtgFinX.Name = "txtBoxPtgFinX"
        Me.txtBoxPtgFinX.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPtgFinX.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 521)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "y ="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "x ="
        '
        'btnPtgFin
        '
        Me.btnPtgFin.Location = New System.Drawing.Point(34, 452)
        Me.btnPtgFin.Name = "btnPtgFin"
        Me.btnPtgFin.Size = New System.Drawing.Size(75, 23)
        Me.btnPtgFin.TabIndex = 16
        Me.btnPtgFin.Text = "PtgFin"
        Me.btnPtgFin.UseVisualStyleBackColor = True
        '
        'Courbe_bezier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 620)
        Me.Controls.Add(Me.txtBoxPtgFinY)
        Me.Controls.Add(Me.txtBoxPtgFinX)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPtgFin)
        Me.Controls.Add(Me.txtBoxPtgDebY)
        Me.Controls.Add(Me.txtBoxPtgDebX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPtgDeb)
        Me.Controls.Add(Me.txtBoxYFin)
        Me.Controls.Add(Me.txtBoxXFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxYDéb)
        Me.Controls.Add(Me.txtBoxXDéb)
        Me.Controls.Add(Me.btnPtFin)
        Me.Controls.Add(Me.btnPtDéb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Courbe_bezier"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxXFin As TextBox
    Friend WithEvents txtBoxYFin As TextBox
    Friend WithEvents btnPtgDeb As Button
    Friend WithEvents txtBoxPtgDebY As TextBox
    Friend WithEvents txtBoxPtgDebX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBoxPtgFinY As TextBox
    Friend WithEvents txtBoxPtgFinX As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPtgFin As Button
End Class

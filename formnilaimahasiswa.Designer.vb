<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.lblnpm = New System.Windows.Forms.Label()
        Me.lblsks = New System.Windows.Forms.Label()
        Me.lblntgs = New System.Windows.Forms.Label()
        Me.lbltn = New System.Windows.Forms.Label()
        Me.lblnuas = New System.Windows.Forms.Label()
        Me.lblnuts = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.NAMA = New System.Windows.Forms.TextBox()
        Me.NPM = New System.Windows.Forms.TextBox()
        Me.SKS = New System.Windows.Forms.TextBox()
        Me.NILAITUGAS = New System.Windows.Forms.TextBox()
        Me.NILAIUTS = New System.Windows.Forms.TextBox()
        Me.NILAIUAS = New System.Windows.Forms.TextBox()
        Me.TOTALNILAI = New System.Windows.Forms.TextBox()
        Me.TOTALSEMESTER = New System.Windows.Forms.TextBox()
        Me.IPK = New System.Windows.Forms.TextBox()
        Me.IPS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(61, 122)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(55, 20)
        Me.label.TabIndex = 1
        Me.label.Text = "NAMA"
        '
        'lblnpm
        '
        Me.lblnpm.AutoSize = True
        Me.lblnpm.Location = New System.Drawing.Point(61, 184)
        Me.lblnpm.Name = "lblnpm"
        Me.lblnpm.Size = New System.Drawing.Size(43, 20)
        Me.lblnpm.TabIndex = 2
        Me.lblnpm.Text = "NPM"
        '
        'lblsks
        '
        Me.lblsks.AutoSize = True
        Me.lblsks.Location = New System.Drawing.Point(61, 264)
        Me.lblsks.Name = "lblsks"
        Me.lblsks.Size = New System.Drawing.Size(41, 20)
        Me.lblsks.TabIndex = 4
        Me.lblsks.Text = "SKS"
        '
        'lblntgs
        '
        Me.lblntgs.AutoSize = True
        Me.lblntgs.Location = New System.Drawing.Point(56, 317)
        Me.lblntgs.Name = "lblntgs"
        Me.lblntgs.Size = New System.Drawing.Size(110, 20)
        Me.lblntgs.TabIndex = 5
        Me.lblntgs.Text = "NILAI TUGAS"
        '
        'lbltn
        '
        Me.lbltn.AutoSize = True
        Me.lbltn.Location = New System.Drawing.Point(679, 267)
        Me.lbltn.Name = "lbltn"
        Me.lbltn.Size = New System.Drawing.Size(108, 20)
        Me.lbltn.TabIndex = 6
        Me.lbltn.Text = "TOTAL NILAI "
        '
        'lblnuas
        '
        Me.lblnuas.AutoSize = True
        Me.lblnuas.Location = New System.Drawing.Point(387, 311)
        Me.lblnuas.Name = "lblnuas"
        Me.lblnuas.Size = New System.Drawing.Size(88, 20)
        Me.lblnuas.TabIndex = 7
        Me.lblnuas.Text = "NILAI UAS"
        '
        'lblnuts
        '
        Me.lblnuts.AutoSize = True
        Me.lblnuts.Location = New System.Drawing.Point(389, 261)
        Me.lblnuts.Name = "lblnuts"
        Me.lblnuts.Size = New System.Drawing.Size(86, 20)
        Me.lblnuts.TabIndex = 8
        Me.lblnuts.Text = "NILAI UTS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(679, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TOTAL SEMESTER"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(572, 546)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "IPK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 546)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "IPS"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1187, 662)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 52
        Me.LineShape2.X2 = 1052
        Me.LineShape2.Y1 = 375
        Me.LineShape2.Y2 = 378
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 60
        Me.LineShape1.X2 = 472
        Me.LineShape1.Y1 = 234
        Me.LineShape1.Y2 = 234
        '
        'NAMA
        '
        Me.NAMA.Location = New System.Drawing.Point(159, 122)
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Size = New System.Drawing.Size(292, 26)
        Me.NAMA.TabIndex = 25
        '
        'NPM
        '
        Me.NPM.Location = New System.Drawing.Point(159, 178)
        Me.NPM.Name = "NPM"
        Me.NPM.Size = New System.Drawing.Size(292, 26)
        Me.NPM.TabIndex = 26
        '
        'SKS
        '
        Me.SKS.Location = New System.Drawing.Point(193, 258)
        Me.SKS.Name = "SKS"
        Me.SKS.Size = New System.Drawing.Size(175, 26)
        Me.SKS.TabIndex = 27
        '
        'NILAITUGAS
        '
        Me.NILAITUGAS.Location = New System.Drawing.Point(192, 308)
        Me.NILAITUGAS.Name = "NILAITUGAS"
        Me.NILAITUGAS.Size = New System.Drawing.Size(176, 26)
        Me.NILAITUGAS.TabIndex = 28
        '
        'NILAIUTS
        '
        Me.NILAIUTS.Location = New System.Drawing.Point(481, 258)
        Me.NILAIUTS.Name = "NILAIUTS"
        Me.NILAIUTS.Size = New System.Drawing.Size(192, 26)
        Me.NILAIUTS.TabIndex = 29
        '
        'NILAIUAS
        '
        Me.NILAIUAS.Location = New System.Drawing.Point(481, 305)
        Me.NILAIUAS.Name = "NILAIUAS"
        Me.NILAIUAS.Size = New System.Drawing.Size(192, 26)
        Me.NILAIUAS.TabIndex = 30
        '
        'TOTALNILAI
        '
        Me.TOTALNILAI.Location = New System.Drawing.Point(849, 267)
        Me.TOTALNILAI.Name = "TOTALNILAI"
        Me.TOTALNILAI.Size = New System.Drawing.Size(192, 26)
        Me.TOTALNILAI.TabIndex = 31
        '
        'TOTALSEMESTER
        '
        Me.TOTALSEMESTER.Location = New System.Drawing.Point(849, 320)
        Me.TOTALSEMESTER.Name = "TOTALSEMESTER"
        Me.TOTALSEMESTER.Size = New System.Drawing.Size(192, 26)
        Me.TOTALSEMESTER.TabIndex = 32
        '
        'IPK
        '
        Me.IPK.Location = New System.Drawing.Point(639, 540)
        Me.IPK.Name = "IPK"
        Me.IPK.Size = New System.Drawing.Size(192, 26)
        Me.IPK.TabIndex = 33
        '
        'IPS
        '
        Me.IPS.Location = New System.Drawing.Point(374, 540)
        Me.IPS.Name = "IPS"
        Me.IPS.Size = New System.Drawing.Size(192, 26)
        Me.IPS.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 58)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 58)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "HITUNG"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(546, 55)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DATA NILAI MAHASISWA"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 662)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IPS)
        Me.Controls.Add(Me.IPK)
        Me.Controls.Add(Me.TOTALSEMESTER)
        Me.Controls.Add(Me.TOTALNILAI)
        Me.Controls.Add(Me.NILAIUAS)
        Me.Controls.Add(Me.NILAIUTS)
        Me.Controls.Add(Me.NILAITUGAS)
        Me.Controls.Add(Me.SKS)
        Me.Controls.Add(Me.NPM)
        Me.Controls.Add(Me.NAMA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblnuts)
        Me.Controls.Add(Me.lblnuas)
        Me.Controls.Add(Me.lbltn)
        Me.Controls.Add(Me.lblntgs)
        Me.Controls.Add(Me.lblsks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblnpm)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents lblnpm As System.Windows.Forms.Label
    Friend WithEvents lblsks As System.Windows.Forms.Label
    Friend WithEvents lblntgs As System.Windows.Forms.Label
    Friend WithEvents lbltn As System.Windows.Forms.Label
    Friend WithEvents lblnuas As System.Windows.Forms.Label
    Friend WithEvents lblnuts As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents NAMA As System.Windows.Forms.TextBox
    Friend WithEvents NPM As System.Windows.Forms.TextBox
    Friend WithEvents SKS As System.Windows.Forms.TextBox
    Friend WithEvents NILAITUGAS As System.Windows.Forms.TextBox
    Friend WithEvents NILAIUTS As System.Windows.Forms.TextBox
    Friend WithEvents NILAIUAS As System.Windows.Forms.TextBox
    Friend WithEvents TOTALNILAI As System.Windows.Forms.TextBox
    Friend WithEvents TOTALSEMESTER As System.Windows.Forms.TextBox
    Friend WithEvents IPK As System.Windows.Forms.TextBox
    Friend WithEvents IPS As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

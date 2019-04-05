<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Playing_Area = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_ballY = New System.Windows.Forms.Label()
        Me.lbl_ballX = New System.Windows.Forms.Label()
        Me.lbl_mouseY = New System.Windows.Forms.Label()
        Me.lbl_mouseX = New System.Windows.Forms.Label()
        Me.lbl_charX = New System.Windows.Forms.Label()
        Me.lbl_charY = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_grad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_dX = New System.Windows.Forms.Label()
        Me.lbl_dY = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Playing_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Playing_Area
        '
        Me.Playing_Area.Location = New System.Drawing.Point(12, 12)
        Me.Playing_Area.Name = "Playing_Area"
        Me.Playing_Area.Size = New System.Drawing.Size(1064, 598)
        Me.Playing_Area.TabIndex = 0
        Me.Playing_Area.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1124, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mouse X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1124, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mouse Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1214, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ball  Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1214, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ball  X"
        '
        'lbl_ballY
        '
        Me.lbl_ballY.AutoSize = True
        Me.lbl_ballY.Location = New System.Drawing.Point(1217, 460)
        Me.lbl_ballY.Name = "lbl_ballY"
        Me.lbl_ballY.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ballY.TabIndex = 5
        Me.lbl_ballY.Text = "Label5"
        '
        'lbl_ballX
        '
        Me.lbl_ballX.AutoSize = True
        Me.lbl_ballX.Location = New System.Drawing.Point(1220, 406)
        Me.lbl_ballX.Name = "lbl_ballX"
        Me.lbl_ballX.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ballX.TabIndex = 6
        Me.lbl_ballX.Text = "Label6"
        '
        'lbl_mouseY
        '
        Me.lbl_mouseY.AutoSize = True
        Me.lbl_mouseY.Location = New System.Drawing.Point(1127, 164)
        Me.lbl_mouseY.Name = "lbl_mouseY"
        Me.lbl_mouseY.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mouseY.TabIndex = 7
        Me.lbl_mouseY.Text = "Label7"
        '
        'lbl_mouseX
        '
        Me.lbl_mouseX.AutoSize = True
        Me.lbl_mouseX.Location = New System.Drawing.Point(1124, 84)
        Me.lbl_mouseX.Name = "lbl_mouseX"
        Me.lbl_mouseX.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mouseX.TabIndex = 8
        Me.lbl_mouseX.Text = "Label8"
        '
        'lbl_charX
        '
        Me.lbl_charX.AutoSize = True
        Me.lbl_charX.Location = New System.Drawing.Point(1130, 406)
        Me.lbl_charX.Name = "lbl_charX"
        Me.lbl_charX.Size = New System.Drawing.Size(39, 13)
        Me.lbl_charX.TabIndex = 12
        Me.lbl_charX.Text = "Label6"
        '
        'lbl_charY
        '
        Me.lbl_charY.AutoSize = True
        Me.lbl_charY.Location = New System.Drawing.Point(1127, 460)
        Me.lbl_charY.Name = "lbl_charY"
        Me.lbl_charY.Size = New System.Drawing.Size(39, 13)
        Me.lbl_charY.TabIndex = 11
        Me.lbl_charY.Text = "Label5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1124, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Char X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1124, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Char Y"
        '
        'lbl_grad
        '
        Me.lbl_grad.AutoSize = True
        Me.lbl_grad.Location = New System.Drawing.Point(1266, 87)
        Me.lbl_grad.Name = "lbl_grad"
        Me.lbl_grad.Size = New System.Drawing.Size(39, 13)
        Me.lbl_grad.TabIndex = 14
        Me.lbl_grad.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1260, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Gradient"
        '
        'lbl_dX
        '
        Me.lbl_dX.AutoSize = True
        Me.lbl_dX.Location = New System.Drawing.Point(1258, 157)
        Me.lbl_dX.Name = "lbl_dX"
        Me.lbl_dX.Size = New System.Drawing.Size(39, 13)
        Me.lbl_dX.TabIndex = 18
        Me.lbl_dX.Text = "Label8"
        '
        'lbl_dY
        '
        Me.lbl_dY.AutoSize = True
        Me.lbl_dY.Location = New System.Drawing.Point(1261, 237)
        Me.lbl_dY.Name = "lbl_dY"
        Me.lbl_dY.Size = New System.Drawing.Size(39, 13)
        Me.lbl_dY.TabIndex = 17
        Me.lbl_dY.Text = "Label7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1258, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Difference Y"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1258, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Difference X"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1130, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Speed up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1130, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Speed down"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 622)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_dX)
        Me.Controls.Add(Me.lbl_dY)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_grad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_charX)
        Me.Controls.Add(Me.lbl_charY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_mouseX)
        Me.Controls.Add(Me.lbl_mouseY)
        Me.Controls.Add(Me.lbl_ballX)
        Me.Controls.Add(Me.lbl_ballY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Playing_Area)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Playing_Area, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Playing_Area As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_ballY As Label
    Friend WithEvents lbl_ballX As Label
    Friend WithEvents lbl_mouseY As Label
    Friend WithEvents lbl_mouseX As Label
    Friend WithEvents lbl_charX As Label
    Friend WithEvents lbl_charY As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_grad As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_dX As Label
    Friend WithEvents lbl_dY As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

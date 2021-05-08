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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkp2slot3 = New System.Windows.Forms.CheckBox()
        Me.chkp2slot2 = New System.Windows.Forms.CheckBox()
        Me.chkp2slot1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkp1slot3 = New System.Windows.Forms.CheckBox()
        Me.chkp1slot2 = New System.Windows.Forms.CheckBox()
        Me.chkp1slot1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'chkp2slot3
        '
        Me.chkp2slot3.AutoSize = True
        Me.chkp2slot3.Location = New System.Drawing.Point(6, 135)
        Me.chkp2slot3.Name = "chkp2slot3"
        Me.chkp2slot3.Size = New System.Drawing.Size(82, 22)
        Me.chkp2slot3.TabIndex = 3
        Me.chkp2slot3.Text = "SLOT3"
        Me.chkp2slot3.UseVisualStyleBackColor = True
        '
        'chkp2slot2
        '
        Me.chkp2slot2.AutoSize = True
        Me.chkp2slot2.Location = New System.Drawing.Point(6, 78)
        Me.chkp2slot2.Name = "chkp2slot2"
        Me.chkp2slot2.Size = New System.Drawing.Size(82, 22)
        Me.chkp2slot2.TabIndex = 2
        Me.chkp2slot2.Text = "SLOT2"
        Me.chkp2slot2.UseVisualStyleBackColor = True
        '
        'chkp2slot1
        '
        Me.chkp2slot1.AutoSize = True
        Me.chkp2slot1.Location = New System.Drawing.Point(6, 23)
        Me.chkp2slot1.Name = "chkp2slot1"
        Me.chkp2slot1.Size = New System.Drawing.Size(82, 22)
        Me.chkp2slot1.TabIndex = 1
        Me.chkp2slot1.Text = "SLOT1"
        Me.chkp2slot1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkp2slot3)
        Me.GroupBox2.Controls.Add(Me.chkp2slot2)
        Me.GroupBox2.Controls.Add(Me.chkp2slot1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(314, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 194)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PARKING2"
        '
        'chkp1slot3
        '
        Me.chkp1slot3.AutoSize = True
        Me.chkp1slot3.Location = New System.Drawing.Point(17, 135)
        Me.chkp1slot3.Name = "chkp1slot3"
        Me.chkp1slot3.Size = New System.Drawing.Size(82, 22)
        Me.chkp1slot3.TabIndex = 2
        Me.chkp1slot3.Text = "SLOT3"
        Me.chkp1slot3.UseVisualStyleBackColor = True
        '
        'chkp1slot2
        '
        Me.chkp1slot2.AutoSize = True
        Me.chkp1slot2.Location = New System.Drawing.Point(17, 78)
        Me.chkp1slot2.Name = "chkp1slot2"
        Me.chkp1slot2.Size = New System.Drawing.Size(82, 22)
        Me.chkp1slot2.TabIndex = 1
        Me.chkp1slot2.Text = "SLOT2"
        Me.chkp1slot2.UseVisualStyleBackColor = True
        '
        'chkp1slot1
        '
        Me.chkp1slot1.AutoSize = True
        Me.chkp1slot1.Location = New System.Drawing.Point(17, 23)
        Me.chkp1slot1.Name = "chkp1slot1"
        Me.chkp1slot1.Size = New System.Drawing.Size(82, 22)
        Me.chkp1slot1.TabIndex = 0
        Me.chkp1slot1.Text = "SLOT1"
        Me.chkp1slot1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkp1slot3)
        Me.GroupBox1.Controls.Add(Me.chkp1slot2)
        Me.GroupBox1.Controls.Add(Me.chkp1slot1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 194)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PARKING1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(700, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "SLOT3"
        '
        'SerialPort1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(700, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "SLOT2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(700, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "SLOT1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "SLOT3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(700, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "SLOT2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(700, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "SLOT1"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(816, 415)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(816, 361)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(816, 309)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(816, 212)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(816, 167)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(816, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 56)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(455, 38)
        Me.TextBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(327, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 38)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Show Report:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(539, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 38)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Show Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parking System Display:"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkp2slot3 As CheckBox
    Friend WithEvents chkp2slot2 As CheckBox
    Friend WithEvents chkp2slot1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkp1slot3 As CheckBox
    Friend WithEvents chkp1slot2 As CheckBox
    Friend WithEvents chkp1slot1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

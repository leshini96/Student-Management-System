<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.EmailTb = New System.Windows.Forms.TextBox()
        Me.StdDGV = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.phoneTb = New System.Windows.Forms.TextBox()
        Me.lblP_no = New System.Windows.Forms.Label()
        Me.lbldepartment = New System.Windows.Forms.Label()
        Me.DepCb = New System.Windows.Forms.ComboBox()
        Me.StDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GenCb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_nameTb = New System.Windows.Forms.TextBox()
        Me.lblL_name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.F_nameTb = New System.Windows.Forms.TextBox()
        Me.lblF_name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.StdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(66, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Fees"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(510, 142)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 19)
        Me.lblEmail.TabIndex = 78
        Me.lblEmail.Text = "Email"
        '
        'EmailTb
        '
        Me.EmailTb.Location = New System.Drawing.Point(510, 163)
        Me.EmailTb.Name = "EmailTb"
        Me.EmailTb.Size = New System.Drawing.Size(126, 20)
        Me.EmailTb.TabIndex = 77
        '
        'StdDGV
        '
        Me.StdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StdDGV.Location = New System.Drawing.Point(163, 270)
        Me.StdDGV.Name = "StdDGV"
        Me.StdDGV.Size = New System.Drawing.Size(637, 222)
        Me.StdDGV.TabIndex = 76
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(552, 204)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(93, 33)
        Me.btndelete.TabIndex = 75
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnedit.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(436, 204)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(93, 33)
        Me.btnedit.TabIndex = 74
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(316, 201)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 33)
        Me.btnsave.TabIndex = 73
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(443, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Teacher List"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(163, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 65)
        Me.Panel2.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(38, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Teacher Registation"
        '
        'AddressTb
        '
        Me.AddressTb.Location = New System.Drawing.Point(652, 162)
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(126, 20)
        Me.AddressTb.TabIndex = 71
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(648, 140)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(58, 19)
        Me.lbladdress.TabIndex = 70
        Me.lbladdress.Text = "Address"
        '
        'phoneTb
        '
        Me.phoneTb.Location = New System.Drawing.Point(373, 162)
        Me.phoneTb.MaxLength = 10
        Me.phoneTb.Name = "phoneTb"
        Me.phoneTb.Size = New System.Drawing.Size(100, 20)
        Me.phoneTb.TabIndex = 69
        '
        'lblP_no
        '
        Me.lblP_no.AutoSize = True
        Me.lblP_no.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP_no.Location = New System.Drawing.Point(370, 140)
        Me.lblP_no.Name = "lblP_no"
        Me.lblP_no.Size = New System.Drawing.Size(71, 19)
        Me.lblP_no.TabIndex = 68
        Me.lblP_no.Text = "Phone No"
        '
        'lbldepartment
        '
        Me.lbldepartment.AutoSize = True
        Me.lbldepartment.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepartment.Location = New System.Drawing.Point(170, 140)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.Size = New System.Drawing.Size(83, 19)
        Me.lbldepartment.TabIndex = 67
        Me.lbldepartment.Text = "Department"
        '
        'DepCb
        '
        Me.DepCb.FormattingEnabled = True
        Me.DepCb.Items.AddRange(New Object() {"Department of Art (Special) Performing Art", "Department of Science", "Department of Law", "Department of Information System", "Department of Statistics", "Department of Finance ad Insurance", "Department of Management", "Department of Electronic and Information Technology", "Department of medicine", "Department of English"})
        Me.DepCb.Location = New System.Drawing.Point(170, 162)
        Me.DepCb.Name = "DepCb"
        Me.DepCb.Size = New System.Drawing.Size(174, 21)
        Me.DepCb.TabIndex = 66
        '
        'StDOB
        '
        Me.StDOB.Location = New System.Drawing.Point(650, 102)
        Me.StDOB.Name = "StDOB"
        Me.StDOB.Size = New System.Drawing.Size(128, 20)
        Me.StDOB.TabIndex = 65
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(646, 79)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(88, 19)
        Me.lblDOB.TabIndex = 64
        Me.lblDOB.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Department"
        '
        'GenCb
        '
        Me.GenCb.FormattingEnabled = True
        Me.GenCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenCb.Location = New System.Drawing.Point(510, 101)
        Me.GenCb.Name = "GenCb"
        Me.GenCb.Size = New System.Drawing.Size(100, 21)
        Me.GenCb.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Gender"
        '
        'L_nameTb
        '
        Me.L_nameTb.Location = New System.Drawing.Point(333, 101)
        Me.L_nameTb.Name = "L_nameTb"
        Me.L_nameTb.Size = New System.Drawing.Size(126, 20)
        Me.L_nameTb.TabIndex = 61
        '
        'lblL_name
        '
        Me.lblL_name.AutoSize = True
        Me.lblL_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL_name.Location = New System.Drawing.Point(334, 79)
        Me.lblL_name.Name = "lblL_name"
        Me.lblL_name.Size = New System.Drawing.Size(75, 19)
        Me.lblL_name.TabIndex = 60
        Me.lblL_name.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "DashBoard"
        '
        'F_nameTb
        '
        Me.F_nameTb.Location = New System.Drawing.Point(170, 101)
        Me.F_nameTb.Name = "F_nameTb"
        Me.F_nameTb.Size = New System.Drawing.Size(126, 20)
        Me.F_nameTb.TabIndex = 59
        '
        'lblF_name
        '
        Me.lblF_name.AutoSize = True
        Me.lblF_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF_name.Location = New System.Drawing.Point(170, 79)
        Me.lblF_name.Name = "lblF_name"
        Me.lblF_name.Size = New System.Drawing.Size(76, 19)
        Me.lblF_name.TabIndex = 58
        Me.lblF_name.Text = "First Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(1, -41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 533)
        Me.Panel1.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Student"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.StudentManagement1.My.Resources.Resources.black_close_icon_3
        Me.PictureBox3.Location = New System.Drawing.Point(609, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.StudentManagement1.My.Resources.Resources._1658694_200
        Me.PictureBox5.Location = New System.Drawing.Point(11, 343)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 63
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.StudentManagement1.My.Resources.Resources._1925343_200
        Me.PictureBox4.Location = New System.Drawing.Point(11, 271)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagement1.My.Resources.Resources._1864903_200
        Me.PictureBox1.Location = New System.Drawing.Point(11, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StudentManagement1.My.Resources.Resources._5040011_200
        Me.PictureBox2.Location = New System.Drawing.Point(11, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.EmailTb)
        Me.Controls.Add(Me.StdDGV)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AddressTb)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.phoneTb)
        Me.Controls.Add(Me.lblP_no)
        Me.Controls.Add(Me.lbldepartment)
        Me.Controls.Add(Me.DepCb)
        Me.Controls.Add(Me.StDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.GenCb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_nameTb)
        Me.Controls.Add(Me.lblL_name)
        Me.Controls.Add(Me.F_nameTb)
        Me.Controls.Add(Me.lblF_name)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.StdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents EmailTb As TextBox
    Friend WithEvents StdDGV As DataGridView
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents lbladdress As Label
    Friend WithEvents phoneTb As TextBox
    Friend WithEvents lblP_no As Label
    Friend WithEvents lbldepartment As Label
    Friend WithEvents DepCb As ComboBox
    Friend WithEvents StDOB As DateTimePicker
    Friend WithEvents lblDOB As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GenCb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents L_nameTb As TextBox
    Friend WithEvents lblL_name As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents F_nameTb As TextBox
    Friend WithEvents lblF_name As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class

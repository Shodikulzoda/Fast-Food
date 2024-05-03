<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button2 = New Button()
        Panel1 = New Panel()
        PictureBox14 = New PictureBox()
        dashboard = New Button()
        side = New Panel()
        username = New Label()
        Label3 = New Label()
        PictureBox6 = New PictureBox()
        logout = New Button()
        PictureBox7 = New PictureBox()
        records = New Button()
        PictureBox8 = New PictureBox()
        reports = New Button()
        PictureBox5 = New PictureBox()
        admin = New Button()
        PictureBox4 = New PictureBox()
        billing = New Button()
        PictureBox3 = New PictureBox()
        master = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button1 = New Button()
        Panel23 = New Panel()
        PictureBox13 = New PictureBox()
        Panel22 = New Panel()
        PictureBox12 = New PictureBox()
        Panel21 = New Panel()
        PictureBox11 = New PictureBox()
        Panel20 = New Panel()
        PictureBox10 = New PictureBox()
        Panel19 = New Panel()
        PictureBox9 = New PictureBox()
        Panel16 = New Panel()
        Label9 = New Label()
        Panel17 = New Panel()
        Panel18 = New Panel()
        Panel13 = New Panel()
        Label8 = New Label()
        Panel14 = New Panel()
        Panel15 = New Panel()
        Panel10 = New Panel()
        Label7 = New Label()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Panel4 = New Panel()
        Label6 = New Label()
        Panel6 = New Panel()
        Panel9 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel23.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        Panel22.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel21.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        Panel20.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        Panel19.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel16.SuspendLayout()
        Panel13.SuspendLayout()
        Panel10.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlText
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(613, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 22)
        Button2.TabIndex = 6
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(PictureBox14)
        Panel1.Controls.Add(dashboard)
        Panel1.Controls.Add(side)
        Panel1.Controls.Add(username)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(records)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(reports)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(admin)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(billing)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(master)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(205, 515)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(26, 107)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(43, 39)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 22
        PictureBox14.TabStop = False
        ' 
        ' dashboard
        ' 
        dashboard.BackColor = Color.Transparent
        dashboard.FlatAppearance.BorderSize = 0
        dashboard.FlatStyle = FlatStyle.Flat
        dashboard.Font = New Font("Segoe UI", 12.25F)
        dashboard.ForeColor = Color.White
        dashboard.Location = New Point(68, 106)
        dashboard.Margin = New Padding(2)
        dashboard.Name = "dashboard"
        dashboard.Size = New Size(136, 40)
        dashboard.TabIndex = 21
        dashboard.Text = "Dashboard"
        dashboard.UseVisualStyleBackColor = False
        ' 
        ' side
        ' 
        side.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        side.Location = New Point(5, 106)
        side.Name = "side"
        side.Size = New Size(17, 39)
        side.TabIndex = 9
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Segoe UI", 12F)
        username.ForeColor = SystemColors.ControlLightLight
        username.Location = New Point(89, 464)
        username.Name = "username"
        username.Size = New Size(81, 21)
        username.TabIndex = 20
        username.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(8, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 21)
        Label3.TabIndex = 19
        Label3.Text = "Welcome :"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(27, 391)
        PictureBox6.Margin = New Padding(0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(43, 39)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 16
        PictureBox6.TabStop = False
        ' 
        ' logout
        ' 
        logout.BackColor = Color.Transparent
        logout.FlatAppearance.BorderSize = 0
        logout.FlatStyle = FlatStyle.Flat
        logout.Font = New Font("Segoe UI", 12.25F)
        logout.ForeColor = Color.White
        logout.Location = New Point(69, 391)
        logout.Margin = New Padding(0)
        logout.Name = "logout"
        logout.Size = New Size(136, 40)
        logout.TabIndex = 15
        logout.Text = "Logout"
        logout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(27, 342)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 39)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' records
        ' 
        records.BackColor = Color.Transparent
        records.FlatAppearance.BorderSize = 0
        records.FlatStyle = FlatStyle.Flat
        records.Font = New Font("Segoe UI", 12.25F)
        records.ForeColor = Color.White
        records.Location = New Point(69, 342)
        records.Margin = New Padding(2)
        records.Name = "records"
        records.Size = New Size(136, 40)
        records.TabIndex = 13
        records.Text = "Records"
        records.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(27, 296)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(43, 39)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 12
        PictureBox8.TabStop = False
        ' 
        ' reports
        ' 
        reports.BackColor = Color.Transparent
        reports.FlatAppearance.BorderSize = 0
        reports.FlatStyle = FlatStyle.Flat
        reports.Font = New Font("Segoe UI", 12.25F)
        reports.ForeColor = Color.White
        reports.Location = New Point(75, 295)
        reports.Margin = New Padding(2)
        reports.Name = "reports"
        reports.Size = New Size(130, 40)
        reports.TabIndex = 11
        reports.Text = "Reports"
        reports.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(31, 248)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' admin
        ' 
        admin.BackColor = Color.Transparent
        admin.FlatAppearance.BorderSize = 0
        admin.FlatStyle = FlatStyle.Flat
        admin.Font = New Font("Segoe UI", 12.25F)
        admin.ForeColor = Color.White
        admin.Location = New Point(69, 248)
        admin.Margin = New Padding(2)
        admin.Name = "admin"
        admin.Size = New Size(136, 40)
        admin.TabIndex = 9
        admin.Text = " Administration"
        admin.TextAlign = ContentAlignment.MiddleRight
        admin.TextImageRelation = TextImageRelation.ImageAboveText
        admin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(27, 201)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 39)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' billing
        ' 
        billing.BackColor = Color.Transparent
        billing.FlatAppearance.BorderSize = 0
        billing.FlatStyle = FlatStyle.Flat
        billing.Font = New Font("Segoe UI", 12.25F)
        billing.ForeColor = Color.White
        billing.Location = New Point(69, 201)
        billing.Margin = New Padding(2)
        billing.Name = "billing"
        billing.Size = New Size(136, 40)
        billing.TabIndex = 7
        billing.Text = "Billing"
        billing.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(27, 154)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 39)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' master
        ' 
        master.BackColor = Color.Transparent
        master.FlatAppearance.BorderSize = 0
        master.FlatStyle = FlatStyle.Flat
        master.Font = New Font("Segoe UI", 12.25F)
        master.ForeColor = Color.White
        master.Location = New Point(69, 153)
        master.Margin = New Padding(2)
        master.Name = "master"
        master.Size = New Size(136, 40)
        master.TabIndex = 5
        master.Text = "Master"
        master.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Location = New Point(8, 95)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(192, 6)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.9F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(98, 48)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 2
        Label2.Text = "RESTAURANT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.9F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(89, 24)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 28)
        Label1.TabIndex = 1
        Label1.Text = "FAST FOOD"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 10)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel2.Controls.Add(Button2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(205, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(646, 35)
        Panel2.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Panel23)
        Panel3.Controls.Add(Panel22)
        Panel3.Controls.Add(Panel21)
        Panel3.Controls.Add(Panel20)
        Panel3.Controls.Add(Panel19)
        Panel3.Controls.Add(Panel16)
        Panel3.Controls.Add(Panel13)
        Panel3.Controls.Add(Panel10)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel5)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(205, 35)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(646, 480)
        Panel3.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(56, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 55)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel23
        ' 
        Panel23.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel23.Controls.Add(PictureBox13)
        Panel23.Font = New Font("Segoe UI", 9F)
        Panel23.Location = New Point(364, 246)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(75, 52)
        Panel23.TabIndex = 8
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(10, 3)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(54, 46)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 7
        PictureBox13.TabStop = False
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel22.Controls.Add(PictureBox12)
        Panel22.Font = New Font("Segoe UI", 9F)
        Panel22.Location = New Point(162, 246)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(75, 52)
        Panel22.TabIndex = 8
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(10, 3)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(54, 46)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 7
        PictureBox12.TabStop = False
        ' 
        ' Panel21
        ' 
        Panel21.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel21.Controls.Add(PictureBox11)
        Panel21.Location = New Point(449, 82)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(75, 52)
        Panel21.TabIndex = 8
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(10, 3)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(54, 46)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 7
        PictureBox11.TabStop = False
        ' 
        ' Panel20
        ' 
        Panel20.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel20.Controls.Add(PictureBox10)
        Panel20.Location = New Point(257, 82)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(75, 52)
        Panel20.TabIndex = 8
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(1, -6)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(72, 63)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 7
        PictureBox10.TabStop = False
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel19.Controls.Add(PictureBox9)
        Panel19.Location = New Point(63, 82)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(75, 52)
        Panel19.TabIndex = 7
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(10, 3)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(54, 46)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 7
        PictureBox9.TabStop = False
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel16.Controls.Add(Label9)
        Panel16.Controls.Add(Panel17)
        Panel16.Controls.Add(Panel18)
        Panel16.Font = New Font("Segoe UI", 9F)
        Panel16.Location = New Point(352, 277)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(140, 91)
        Panel16.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(21, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 17)
        Label9.TabIndex = 7
        Label9.Text = "Rejected orders"
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel17.Location = New Point(260, 182)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(168, 105)
        Panel17.TabIndex = 5
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel18.Location = New Point(72, 182)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(168, 105)
        Panel18.TabIndex = 4
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel13.Controls.Add(Label8)
        Panel13.Controls.Add(Panel14)
        Panel13.Controls.Add(Panel15)
        Panel13.Font = New Font("Segoe UI", 9F)
        Panel13.Location = New Point(150, 277)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(140, 91)
        Panel13.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(22, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 17)
        Label8.TabIndex = 7
        Label8.Text = "Delivered orders"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel14.Location = New Point(260, 182)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(168, 105)
        Panel14.TabIndex = 5
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel15.Location = New Point(72, 182)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(168, 105)
        Panel15.TabIndex = 4
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel10.Controls.Add(Label7)
        Panel10.Controls.Add(Panel11)
        Panel10.Controls.Add(Panel12)
        Panel10.Location = New Point(437, 114)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(140, 91)
        Panel10.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(22, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 17)
        Label7.TabIndex = 7
        Label7.Text = "Pending orders"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel11.Location = New Point(260, 182)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(168, 105)
        Panel11.TabIndex = 5
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel12.Location = New Point(72, 182)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(168, 105)
        Panel12.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel9)
        Panel4.Location = New Point(244, 114)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(140, 91)
        Panel4.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(24, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 17)
        Label6.TabIndex = 7
        Label6.Text = "Total sales"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel6.Location = New Point(260, 182)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(168, 105)
        Panel6.TabIndex = 5
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel9.Location = New Point(72, 182)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(168, 105)
        Panel9.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(21, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 28)
        Label4.TabIndex = 3
        Label4.Text = "Dashboard"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Panel8)
        Panel5.Location = New Point(51, 114)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(140, 91)
        Panel5.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(22, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 17)
        Label5.TabIndex = 6
        Label5.Text = "Total orders"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel7.Location = New Point(260, 182)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(168, 105)
        Panel7.TabIndex = 5
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(4), CByte(24), CByte(30))
        Panel8.Location = New Point(72, 182)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(168, 105)
        Panel8.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(851, 515)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel23.ResumeLayout(False)
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        Panel22.ResumeLayout(False)
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel21.ResumeLayout(False)
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        Panel20.ResumeLayout(False)
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        Panel19.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents master As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents billing As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents admin As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents logout As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents records As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents reports As Button
    Friend WithEvents username As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents side As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Panel20 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents dashboard As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class

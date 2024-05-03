<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signout))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(249), CByte(127), CByte(0))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(397, 35)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(38, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 21)
        Label2.TabIndex = 7
        Label2.Text = "FAST FOOD"
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
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13F)
        Button1.Location = New Point(50, 152)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 32)
        Button1.TabIndex = 10
        Button1.Text = "Yes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Brown
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 13F)
        Button3.Location = New Point(252, 152)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 32)
        Button3.TabIndex = 11
        Button3.Text = "No"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(32, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 28)
        Label1.TabIndex = 12
        Label1.Text = "Are you sure to exit from this account"
        ' 
        ' signout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 227)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "signout"
        Text = "Form2"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        txtUsername = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        txtPassword = New TextBox()
        PictureBox3 = New PictureBox()
        btnLogin = New Button()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user_icon
        PictureBox1.Location = New Point(165, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(201, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 30)
        Label1.TabIndex = 1
        Label1.Text = "SIgn In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(81, 284)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 58)
        Panel1.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(53, 17)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(252, 22)
        txtUsername.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.usename_icon
        PictureBox2.Location = New Point(7, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(81, 348)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 58)
        Panel2.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(53, 17)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(252, 22)
        txtPassword.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.lock_icon
        PictureBox3.Location = New Point(7, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(81, 462)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(323, 45)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.Location = New Point(81, 513)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(323, 45)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Logout"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(199), CByte(215))
        ClientSize = New Size(491, 656)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        btnProductList = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        btnInventoryList = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Panel1.Controls.Add(btnProductList)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(46, 150)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 95)
        Panel1.TabIndex = 0
        ' 
        ' btnProductList
        ' 
        btnProductList.BackgroundImage = My.Resources.Resources.list_icon__1_
        btnProductList.Location = New Point(289, 0)
        btnProductList.Name = "btnProductList"
        btnProductList.Size = New Size(95, 95)
        btnProductList.TabIndex = 1
        btnProductList.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(29, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 50)
        Label1.TabIndex = 0
        Label1.Text = "Product List"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btnInventoryList)
        Panel2.Location = New Point(46, 356)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(384, 95)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.list_icon__1_
        Button1.Location = New Point(289, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 95)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnInventoryList
        ' 
        btnInventoryList.AutoSize = True
        btnInventoryList.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnInventoryList.ForeColor = Color.White
        btnInventoryList.Location = New Point(23, 20)
        btnInventoryList.Name = "btnInventoryList"
        btnInventoryList.Size = New Size(239, 50)
        btnInventoryList.TabIndex = 0
        btnInventoryList.Text = "Invetory List"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(199), CByte(215))
        ClientSize = New Size(495, 660)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProductList As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInventoryList As Label
End Class

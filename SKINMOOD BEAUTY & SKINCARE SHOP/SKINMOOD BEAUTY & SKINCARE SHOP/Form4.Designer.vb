<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button1 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.back_icon__1_
        Button1.Location = New Point(828, 507)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 60)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(41, 279)
        Button5.Name = "Button5"
        Button5.Size = New Size(129, 47)
        Button5.TabIndex = 6
        Button5.Text = "Delete"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(41, 131)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 47)
        Button3.TabIndex = 5
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(41, 55)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 47)
        Button2.TabIndex = 4
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(14), CByte(23), CByte(44))
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(41, 205)
        Button4.Name = "Button4"
        Button4.Size = New Size(129, 47)
        Button4.TabIndex = 7
        Button4.Text = "Relocate"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(210, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(678, 393)
        DataGridView1.TabIndex = 8
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(199), CByte(215))
        ClientSize = New Size(900, 579)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

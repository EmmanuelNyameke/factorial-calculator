<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactorial
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
        lblHeading = New Label()
        lstFactorials = New ListBox()
        btnFactorial = New Button()
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(0, 39)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(273, 29)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Factorial Calculator"
        ' 
        ' lstFactorials
        ' 
        lstFactorials.Font = New Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lstFactorials.FormattingEnabled = True
        lstFactorials.ItemHeight = 25
        lstFactorials.Items.AddRange(New Object() {"Factorials"})
        lstFactorials.Location = New Point(39, 198)
        lstFactorials.Name = "lstFactorials"
        lstFactorials.Size = New Size(180, 79)
        lstFactorials.TabIndex = 1
        ' 
        ' btnFactorial
        ' 
        btnFactorial.BackColor = Color.White
        btnFactorial.Font = New Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnFactorial.Location = New Point(39, 116)
        btnFactorial.Name = "btnFactorial"
        btnFactorial.Size = New Size(188, 35)
        btnFactorial.TabIndex = 2
        btnFactorial.Text = "Select a number"
        btnFactorial.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(914, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(180, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' frmFactorial
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.factorial
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 420)
        Controls.Add(btnFactorial)
        Controls.Add(lstFactorials)
        Controls.Add(lblHeading)
        Controls.Add(MenuStrip1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "frmFactorial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Factorial Calculator"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lstFactorials As ListBox
    Friend WithEvents btnFactorial As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem

End Class

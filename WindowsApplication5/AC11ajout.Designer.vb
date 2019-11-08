<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC11ajout
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AC11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJOUTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPRIMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 19)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AC12 - Organiser les tournées - Ajouter une Tournée "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AC11ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AC11ToolStripMenuItem
        '
        Me.AC11ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AJOUTERToolStripMenuItem, Me.MODIFIERToolStripMenuItem, Me.SUPRIMERToolStripMenuItem})
        Me.AC11ToolStripMenuItem.Name = "AC11ToolStripMenuItem"
        Me.AC11ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AC11ToolStripMenuItem.Text = "Accueil"
        '
        'AJOUTERToolStripMenuItem
        '
        Me.AJOUTERToolStripMenuItem.Name = "AJOUTERToolStripMenuItem"
        Me.AJOUTERToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AJOUTERToolStripMenuItem.Text = "AJOUTER"
        '
        'MODIFIERToolStripMenuItem
        '
        Me.MODIFIERToolStripMenuItem.Name = "MODIFIERToolStripMenuItem"
        Me.MODIFIERToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.MODIFIERToolStripMenuItem.Text = "MODIFIER"
        '
        'SUPRIMERToolStripMenuItem
        '
        Me.SUPRIMERToolStripMenuItem.Name = "SUPRIMERToolStripMenuItem"
        Me.SUPRIMERToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SUPRIMERToolStripMenuItem.Text = "SUPRIMER"
        '
        'AC11ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "AC11ajout"
        Me.Text = "AC11ajout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AC11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AJOUTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUPRIMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Connexion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ErreurCo = New System.Windows.Forms.Label()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom d'utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Login.Location = New System.Drawing.Point(28, 308)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(363, 23)
        Me.Login.TabIndex = 4
        Me.Login.Text = "PPE"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(28, 381)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(363, 23)
        Me.Password.TabIndex = 5
        Me.Password.Text = "estran"
        '
        'ErreurCo
        '
        Me.ErreurCo.AutoSize = True
        Me.ErreurCo.ForeColor = System.Drawing.Color.Red
        Me.ErreurCo.Location = New System.Drawing.Point(238, 122)
        Me.ErreurCo.Name = "ErreurCo"
        Me.ErreurCo.Size = New System.Drawing.Size(0, 13)
        Me.ErreurCo.TabIndex = 7
        '
        'Connexion
        '
        Me.Connexion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Connexion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Connexion.Location = New System.Drawing.Point(99, 449)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(230, 38)
        Me.Connexion.TabIndex = 9
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = False
        '
        'Page_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PPE_Mesguen_Lourd.My.Resources.Resources.Connexion
        Me.ClientSize = New System.Drawing.Size(425, 580)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.ErreurCo)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Page_Connexion"
        Me.Text = "Page de connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents ErreurCo As System.Windows.Forms.Label
    Friend WithEvents Connexion As System.Windows.Forms.Button

End Class

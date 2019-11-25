<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13M
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
        Me.AC13M_DateTimePicker_PEC = New System.Windows.Forms.DateTimePicker()
        Me.AC13M_Label_PEC = New System.Windows.Forms.Label()
        Me.AC13M_RichTextBox_Commentaire = New System.Windows.Forms.RichTextBox()
        Me.AC13M_DateTimePicker_RDV2 = New System.Windows.Forms.DateTimePicker()
        Me.AC13M_DateTimePicker_RDV = New System.Windows.Forms.DateTimePicker()
        Me.AC13M_ComboBox_Lieu = New System.Windows.Forms.ComboBox()
        Me.AC13M_Button_Annuler = New System.Windows.Forms.Button()
        Me.AC13M_Button_Valider = New System.Windows.Forms.Button()
        Me.AC13M_Label_Commentaire = New System.Windows.Forms.Label()
        Me.AC13M_Label_RDV2 = New System.Windows.Forms.Label()
        Me.AC13M_Label_RDV = New System.Windows.Forms.Label()
        Me.AC13M_Label_Lieu = New System.Windows.Forms.Label()
        Me.AC13M_Label_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AC13M_DateTimePicker_PEC
        '
        Me.AC13M_DateTimePicker_PEC.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13M_DateTimePicker_PEC.Enabled = False
        Me.AC13M_DateTimePicker_PEC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13M_DateTimePicker_PEC.Location = New System.Drawing.Point(274, 263)
        Me.AC13M_DateTimePicker_PEC.Name = "AC13M_DateTimePicker_PEC"
        Me.AC13M_DateTimePicker_PEC.Size = New System.Drawing.Size(200, 20)
        Me.AC13M_DateTimePicker_PEC.TabIndex = 38
        '
        'AC13M_Label_PEC
        '
        Me.AC13M_Label_PEC.AutoSize = True
        Me.AC13M_Label_PEC.Location = New System.Drawing.Point(65, 269)
        Me.AC13M_Label_PEC.Name = "AC13M_Label_PEC"
        Me.AC13M_Label_PEC.Size = New System.Drawing.Size(95, 13)
        Me.AC13M_Label_PEC.TabIndex = 37
        Me.AC13M_Label_PEC.Text = "Pris en charge le : "
        '
        'AC13M_RichTextBox_Commentaire
        '
        Me.AC13M_RichTextBox_Commentaire.Location = New System.Drawing.Point(274, 314)
        Me.AC13M_RichTextBox_Commentaire.Name = "AC13M_RichTextBox_Commentaire"
        Me.AC13M_RichTextBox_Commentaire.Size = New System.Drawing.Size(200, 96)
        Me.AC13M_RichTextBox_Commentaire.TabIndex = 36
        Me.AC13M_RichTextBox_Commentaire.Text = ""
        '
        'AC13M_DateTimePicker_RDV2
        '
        Me.AC13M_DateTimePicker_RDV2.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13M_DateTimePicker_RDV2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13M_DateTimePicker_RDV2.Location = New System.Drawing.Point(274, 209)
        Me.AC13M_DateTimePicker_RDV2.Name = "AC13M_DateTimePicker_RDV2"
        Me.AC13M_DateTimePicker_RDV2.Size = New System.Drawing.Size(200, 20)
        Me.AC13M_DateTimePicker_RDV2.TabIndex = 35
        '
        'AC13M_DateTimePicker_RDV
        '
        Me.AC13M_DateTimePicker_RDV.AllowDrop = True
        Me.AC13M_DateTimePicker_RDV.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13M_DateTimePicker_RDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13M_DateTimePicker_RDV.Location = New System.Drawing.Point(274, 153)
        Me.AC13M_DateTimePicker_RDV.Name = "AC13M_DateTimePicker_RDV"
        Me.AC13M_DateTimePicker_RDV.Size = New System.Drawing.Size(200, 20)
        Me.AC13M_DateTimePicker_RDV.TabIndex = 34
        '
        'AC13M_ComboBox_Lieu
        '
        Me.AC13M_ComboBox_Lieu.DisplayMember = "LIEUNOM"
        Me.AC13M_ComboBox_Lieu.FormattingEnabled = True
        Me.AC13M_ComboBox_Lieu.Location = New System.Drawing.Point(274, 99)
        Me.AC13M_ComboBox_Lieu.Name = "AC13M_ComboBox_Lieu"
        Me.AC13M_ComboBox_Lieu.Size = New System.Drawing.Size(200, 21)
        Me.AC13M_ComboBox_Lieu.TabIndex = 33
        Me.AC13M_ComboBox_Lieu.ValueMember = "LIEUNOM"
        '
        'AC13M_Button_Annuler
        '
        Me.AC13M_Button_Annuler.Location = New System.Drawing.Point(399, 432)
        Me.AC13M_Button_Annuler.Name = "AC13M_Button_Annuler"
        Me.AC13M_Button_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.AC13M_Button_Annuler.TabIndex = 32
        Me.AC13M_Button_Annuler.Text = "Annuler"
        Me.AC13M_Button_Annuler.UseVisualStyleBackColor = True
        '
        'AC13M_Button_Valider
        '
        Me.AC13M_Button_Valider.Location = New System.Drawing.Point(68, 432)
        Me.AC13M_Button_Valider.Name = "AC13M_Button_Valider"
        Me.AC13M_Button_Valider.Size = New System.Drawing.Size(75, 23)
        Me.AC13M_Button_Valider.TabIndex = 31
        Me.AC13M_Button_Valider.Text = "Valider"
        Me.AC13M_Button_Valider.UseVisualStyleBackColor = True
        '
        'AC13M_Label_Commentaire
        '
        Me.AC13M_Label_Commentaire.AutoSize = True
        Me.AC13M_Label_Commentaire.Location = New System.Drawing.Point(65, 317)
        Me.AC13M_Label_Commentaire.Name = "AC13M_Label_Commentaire"
        Me.AC13M_Label_Commentaire.Size = New System.Drawing.Size(77, 13)
        Me.AC13M_Label_Commentaire.TabIndex = 30
        Me.AC13M_Label_Commentaire.Text = "Commentaire : "
        '
        'AC13M_Label_RDV2
        '
        Me.AC13M_Label_RDV2.AutoSize = True
        Me.AC13M_Label_RDV2.Location = New System.Drawing.Point(65, 215)
        Me.AC13M_Label_RDV2.Name = "AC13M_Label_RDV2"
        Me.AC13M_Label_RDV2.Size = New System.Drawing.Size(26, 13)
        Me.AC13M_Label_RDV2.TabIndex = 29
        Me.AC13M_Label_RDV2.Text = "Et : "
        '
        'AC13M_Label_RDV
        '
        Me.AC13M_Label_RDV.AutoSize = True
        Me.AC13M_Label_RDV.Location = New System.Drawing.Point(65, 159)
        Me.AC13M_Label_RDV.Name = "AC13M_Label_RDV"
        Me.AC13M_Label_RDV.Size = New System.Drawing.Size(106, 13)
        Me.AC13M_Label_RDV.TabIndex = 28
        Me.AC13M_Label_RDV.Text = "Rendez-vous entre : "
        '
        'AC13M_Label_Lieu
        '
        Me.AC13M_Label_Lieu.AutoSize = True
        Me.AC13M_Label_Lieu.Location = New System.Drawing.Point(65, 102)
        Me.AC13M_Label_Lieu.Name = "AC13M_Label_Lieu"
        Me.AC13M_Label_Lieu.Size = New System.Drawing.Size(36, 13)
        Me.AC13M_Label_Lieu.TabIndex = 27
        Me.AC13M_Label_Lieu.Text = "Lieu : "
        '
        'AC13M_Label_Title
        '
        Me.AC13M_Label_Title.AutoSize = True
        Me.AC13M_Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC13M_Label_Title.Location = New System.Drawing.Point(143, 42)
        Me.AC13M_Label_Title.Name = "AC13M_Label_Title"
        Me.AC13M_Label_Title.Size = New System.Drawing.Size(262, 24)
        Me.AC13M_Label_Title.TabIndex = 26
        Me.AC13M_Label_Title.Text = "MESGUEN - AC13 Modifier"
        '
        'AC13M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 496)
        Me.Controls.Add(Me.AC13M_DateTimePicker_PEC)
        Me.Controls.Add(Me.AC13M_Label_PEC)
        Me.Controls.Add(Me.AC13M_RichTextBox_Commentaire)
        Me.Controls.Add(Me.AC13M_DateTimePicker_RDV2)
        Me.Controls.Add(Me.AC13M_DateTimePicker_RDV)
        Me.Controls.Add(Me.AC13M_ComboBox_Lieu)
        Me.Controls.Add(Me.AC13M_Button_Annuler)
        Me.Controls.Add(Me.AC13M_Button_Valider)
        Me.Controls.Add(Me.AC13M_Label_Commentaire)
        Me.Controls.Add(Me.AC13M_Label_RDV2)
        Me.Controls.Add(Me.AC13M_Label_RDV)
        Me.Controls.Add(Me.AC13M_Label_Lieu)
        Me.Controls.Add(Me.AC13M_Label_Title)
        Me.Name = "AC13M"
        Me.Text = "AC13M"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AC13M_DateTimePicker_PEC As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13M_Label_PEC As System.Windows.Forms.Label
    Friend WithEvents AC13M_RichTextBox_Commentaire As System.Windows.Forms.RichTextBox
    Friend WithEvents AC13M_DateTimePicker_RDV2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13M_DateTimePicker_RDV As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13M_ComboBox_Lieu As System.Windows.Forms.ComboBox
    Friend WithEvents AC13M_Button_Annuler As System.Windows.Forms.Button
    Friend WithEvents AC13M_Button_Valider As System.Windows.Forms.Button
    Friend WithEvents AC13M_Label_Commentaire As System.Windows.Forms.Label
    Friend WithEvents AC13M_Label_RDV2 As System.Windows.Forms.Label
    Friend WithEvents AC13M_Label_RDV As System.Windows.Forms.Label
    Friend WithEvents AC13M_Label_Lieu As System.Windows.Forms.Label
    Friend WithEvents AC13M_Label_Title As System.Windows.Forms.Label
End Class

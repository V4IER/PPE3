<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13A
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
        Me.components = New System.ComponentModel.Container()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.AC13A_Label_PEC = New System.Windows.Forms.Label()
        Me.AC13A_RichTextBox_Commentaire = New System.Windows.Forms.RichTextBox()
        Me.DataTable2TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.AC13A_DateTimePicker_RDV2 = New System.Windows.Forms.DateTimePicker()
        Me.AC13A_DateTimePicker_RDV = New System.Windows.Forms.DateTimePicker()
        Me.DataTable3TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable3TableAdapter()
        Me.AC13A_Label_Title = New System.Windows.Forms.Label()
        Me.AC13A_DateTimePicker_PEC = New System.Windows.Forms.DateTimePicker()
        Me.AC13A_ComboBox_Lieu = New System.Windows.Forms.ComboBox()
        Me.DataTable3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC13A_Button_Valider = New System.Windows.Forms.Button()
        Me.AC13A_Button_Annuler = New System.Windows.Forms.Button()
        Me.AC13A_Label_Commentaire = New System.Windows.Forms.Label()
        Me.AC13A_Label_RDV2 = New System.Windows.Forms.Label()
        Me.AC13A_Label_RDV = New System.Windows.Forms.Label()
        Me.AC13A_Label_Lieu = New System.Windows.Forms.Label()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AC13A_Label_PEC
        '
        Me.AC13A_Label_PEC.AutoSize = True
        Me.AC13A_Label_PEC.Location = New System.Drawing.Point(32, 225)
        Me.AC13A_Label_PEC.Name = "AC13A_Label_PEC"
        Me.AC13A_Label_PEC.Size = New System.Drawing.Size(95, 13)
        Me.AC13A_Label_PEC.TabIndex = 24
        Me.AC13A_Label_PEC.Text = "Pris en charge le : "
        '
        'AC13A_RichTextBox_Commentaire
        '
        Me.AC13A_RichTextBox_Commentaire.Location = New System.Drawing.Point(144, 270)
        Me.AC13A_RichTextBox_Commentaire.Name = "AC13A_RichTextBox_Commentaire"
        Me.AC13A_RichTextBox_Commentaire.Size = New System.Drawing.Size(200, 96)
        Me.AC13A_RichTextBox_Commentaire.TabIndex = 23
        Me.AC13A_RichTextBox_Commentaire.Text = ""
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'AC13A_DateTimePicker_RDV2
        '
        Me.AC13A_DateTimePicker_RDV2.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13A_DateTimePicker_RDV2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13A_DateTimePicker_RDV2.Location = New System.Drawing.Point(144, 165)
        Me.AC13A_DateTimePicker_RDV2.Name = "AC13A_DateTimePicker_RDV2"
        Me.AC13A_DateTimePicker_RDV2.Size = New System.Drawing.Size(200, 20)
        Me.AC13A_DateTimePicker_RDV2.TabIndex = 22
        '
        'AC13A_DateTimePicker_RDV
        '
        Me.AC13A_DateTimePicker_RDV.AllowDrop = True
        Me.AC13A_DateTimePicker_RDV.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13A_DateTimePicker_RDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13A_DateTimePicker_RDV.Location = New System.Drawing.Point(144, 109)
        Me.AC13A_DateTimePicker_RDV.Name = "AC13A_DateTimePicker_RDV"
        Me.AC13A_DateTimePicker_RDV.Size = New System.Drawing.Size(200, 20)
        Me.AC13A_DateTimePicker_RDV.TabIndex = 21
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'AC13A_Label_Title
        '
        Me.AC13A_Label_Title.AutoSize = True
        Me.AC13A_Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC13A_Label_Title.Location = New System.Drawing.Point(116, 9)
        Me.AC13A_Label_Title.Name = "AC13A_Label_Title"
        Me.AC13A_Label_Title.Size = New System.Drawing.Size(254, 24)
        Me.AC13A_Label_Title.TabIndex = 13
        Me.AC13A_Label_Title.Text = "MESGUEN - AC13 Ajouter"
        '
        'AC13A_DateTimePicker_PEC
        '
        Me.AC13A_DateTimePicker_PEC.CustomFormat = "dd/M/yy hh:mm:ss"
        Me.AC13A_DateTimePicker_PEC.Enabled = False
        Me.AC13A_DateTimePicker_PEC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AC13A_DateTimePicker_PEC.Location = New System.Drawing.Point(144, 219)
        Me.AC13A_DateTimePicker_PEC.Name = "AC13A_DateTimePicker_PEC"
        Me.AC13A_DateTimePicker_PEC.Size = New System.Drawing.Size(200, 20)
        Me.AC13A_DateTimePicker_PEC.TabIndex = 25
        '
        'AC13A_ComboBox_Lieu
        '
        Me.AC13A_ComboBox_Lieu.DataSource = Me.DataTable3BindingSource
        Me.AC13A_ComboBox_Lieu.DisplayMember = "LIEUNOM"
        Me.AC13A_ComboBox_Lieu.FormattingEnabled = True
        Me.AC13A_ComboBox_Lieu.Location = New System.Drawing.Point(144, 55)
        Me.AC13A_ComboBox_Lieu.Name = "AC13A_ComboBox_Lieu"
        Me.AC13A_ComboBox_Lieu.Size = New System.Drawing.Size(200, 21)
        Me.AC13A_ComboBox_Lieu.TabIndex = 20
        Me.AC13A_ComboBox_Lieu.ValueMember = "LIEUNOM"
        '
        'DataTable3BindingSource
        '
        Me.DataTable3BindingSource.DataMember = "DataTable3"
        Me.DataTable3BindingSource.DataSource = Me.DataSet1
        '
        'AC13A_Button_Valider
        '
        Me.AC13A_Button_Valider.Location = New System.Drawing.Point(35, 388)
        Me.AC13A_Button_Valider.Name = "AC13A_Button_Valider"
        Me.AC13A_Button_Valider.Size = New System.Drawing.Size(75, 23)
        Me.AC13A_Button_Valider.TabIndex = 18
        Me.AC13A_Button_Valider.Text = "Valider"
        Me.AC13A_Button_Valider.UseVisualStyleBackColor = True
        '
        'AC13A_Button_Annuler
        '
        Me.AC13A_Button_Annuler.Location = New System.Drawing.Point(269, 388)
        Me.AC13A_Button_Annuler.Name = "AC13A_Button_Annuler"
        Me.AC13A_Button_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.AC13A_Button_Annuler.TabIndex = 19
        Me.AC13A_Button_Annuler.Text = "Annuler"
        Me.AC13A_Button_Annuler.UseVisualStyleBackColor = True
        '
        'AC13A_Label_Commentaire
        '
        Me.AC13A_Label_Commentaire.AutoSize = True
        Me.AC13A_Label_Commentaire.Location = New System.Drawing.Point(32, 273)
        Me.AC13A_Label_Commentaire.Name = "AC13A_Label_Commentaire"
        Me.AC13A_Label_Commentaire.Size = New System.Drawing.Size(77, 13)
        Me.AC13A_Label_Commentaire.TabIndex = 17
        Me.AC13A_Label_Commentaire.Text = "Commentaire : "
        '
        'AC13A_Label_RDV2
        '
        Me.AC13A_Label_RDV2.AutoSize = True
        Me.AC13A_Label_RDV2.Location = New System.Drawing.Point(32, 171)
        Me.AC13A_Label_RDV2.Name = "AC13A_Label_RDV2"
        Me.AC13A_Label_RDV2.Size = New System.Drawing.Size(26, 13)
        Me.AC13A_Label_RDV2.TabIndex = 16
        Me.AC13A_Label_RDV2.Text = "Et : "
        '
        'AC13A_Label_RDV
        '
        Me.AC13A_Label_RDV.AutoSize = True
        Me.AC13A_Label_RDV.Location = New System.Drawing.Point(32, 115)
        Me.AC13A_Label_RDV.Name = "AC13A_Label_RDV"
        Me.AC13A_Label_RDV.Size = New System.Drawing.Size(106, 13)
        Me.AC13A_Label_RDV.TabIndex = 15
        Me.AC13A_Label_RDV.Text = "Rendez-vous entre : "
        '
        'AC13A_Label_Lieu
        '
        Me.AC13A_Label_Lieu.AutoSize = True
        Me.AC13A_Label_Lieu.Location = New System.Drawing.Point(32, 58)
        Me.AC13A_Label_Lieu.Name = "AC13A_Label_Lieu"
        Me.AC13A_Label_Lieu.Size = New System.Drawing.Size(36, 13)
        Me.AC13A_Label_Lieu.TabIndex = 14
        Me.AC13A_Label_Lieu.Text = "Lieu : "
        '
        'AC13A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 439)
        Me.Controls.Add(Me.AC13A_Label_PEC)
        Me.Controls.Add(Me.AC13A_RichTextBox_Commentaire)
        Me.Controls.Add(Me.AC13A_DateTimePicker_RDV2)
        Me.Controls.Add(Me.AC13A_DateTimePicker_RDV)
        Me.Controls.Add(Me.AC13A_Label_Title)
        Me.Controls.Add(Me.AC13A_DateTimePicker_PEC)
        Me.Controls.Add(Me.AC13A_ComboBox_Lieu)
        Me.Controls.Add(Me.AC13A_Button_Valider)
        Me.Controls.Add(Me.AC13A_Button_Annuler)
        Me.Controls.Add(Me.AC13A_Label_Commentaire)
        Me.Controls.Add(Me.AC13A_Label_RDV2)
        Me.Controls.Add(Me.AC13A_Label_RDV)
        Me.Controls.Add(Me.AC13A_Label_Lieu)
        Me.Name = "AC13A"
        Me.Text = "AC13"
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents AC13A_Label_PEC As System.Windows.Forms.Label
    Friend WithEvents AC13A_RichTextBox_Commentaire As System.Windows.Forms.RichTextBox
    Friend WithEvents DataTable2TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents AC13A_DateTimePicker_RDV2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13A_DateTimePicker_RDV As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataTable3TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable3TableAdapter
    Friend WithEvents AC13A_Label_Title As System.Windows.Forms.Label
    Friend WithEvents AC13A_DateTimePicker_PEC As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13A_ComboBox_Lieu As System.Windows.Forms.ComboBox
    Friend WithEvents DataTable3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC13A_Button_Valider As System.Windows.Forms.Button
    Friend WithEvents AC13A_Button_Annuler As System.Windows.Forms.Button
    Friend WithEvents AC13A_Label_Commentaire As System.Windows.Forms.Label
    Friend WithEvents AC13A_Label_RDV2 As System.Windows.Forms.Label
    Friend WithEvents AC13A_Label_RDV As System.Windows.Forms.Label
    Friend WithEvents AC13A_Label_Lieu As System.Windows.Forms.Label
End Class

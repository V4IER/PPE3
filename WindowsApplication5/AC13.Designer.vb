<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelLieu = New System.Windows.Forms.Label()
        Me.comboBoxLieu = New System.Windows.Forms.ComboBox()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIEUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.labelRdvEntre = New System.Windows.Forms.Label()
        Me.labelRdvEt = New System.Windows.Forms.Label()
        Me.DateTimePickerRdvEt = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerRdvEntre = New System.Windows.Forms.DateTimePicker()
        Me.labelCom = New System.Windows.Forms.Label()
        Me.TextBoxCom = New System.Windows.Forms.TextBox()
        Me.LIEUTableAdapter = New WindowsApplication5.DataSet1TableAdapters.LIEUTableAdapter()
        Me.DataTable1TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.DataTable1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonAC13Valider = New System.Windows.Forms.Button()
        Me.ButtonAC13Annuler = New System.Windows.Forms.Button()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIEUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MESGUEN - AC13"
        '
        'labelLieu
        '
        Me.labelLieu.AutoSize = True
        Me.labelLieu.Location = New System.Drawing.Point(12, 93)
        Me.labelLieu.Name = "labelLieu"
        Me.labelLieu.Size = New System.Drawing.Size(36, 13)
        Me.labelLieu.TabIndex = 1
        Me.labelLieu.Text = "Lieu : "
        '
        'comboBoxLieu
        '
        Me.comboBoxLieu.DataSource = Me.DataTable1BindingSource3
        Me.comboBoxLieu.DisplayMember = "LIEUNOM"
        Me.comboBoxLieu.FormattingEnabled = True
        Me.comboBoxLieu.Location = New System.Drawing.Point(123, 90)
        Me.comboBoxLieu.Name = "comboBoxLieu"
        Me.comboBoxLieu.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxLieu.TabIndex = 2
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.DataSet1BindingSource
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'LIEUBindingSource
        '
        Me.LIEUBindingSource.DataMember = "LIEU"
        Me.LIEUBindingSource.DataSource = Me.DataSet1
        '
        'labelRdvEntre
        '
        Me.labelRdvEntre.AutoSize = True
        Me.labelRdvEntre.Location = New System.Drawing.Point(12, 138)
        Me.labelRdvEntre.Name = "labelRdvEntre"
        Me.labelRdvEntre.Size = New System.Drawing.Size(106, 13)
        Me.labelRdvEntre.TabIndex = 3
        Me.labelRdvEntre.Text = "Rendez-vous entre : "
        '
        'labelRdvEt
        '
        Me.labelRdvEt.AutoSize = True
        Me.labelRdvEt.Location = New System.Drawing.Point(12, 177)
        Me.labelRdvEt.Name = "labelRdvEt"
        Me.labelRdvEt.Size = New System.Drawing.Size(26, 13)
        Me.labelRdvEt.TabIndex = 5
        Me.labelRdvEt.Text = "Et : "
        '
        'DateTimePickerRdvEt
        '
        Me.DateTimePickerRdvEt.Location = New System.Drawing.Point(123, 171)
        Me.DateTimePickerRdvEt.Name = "DateTimePickerRdvEt"
        Me.DateTimePickerRdvEt.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerRdvEt.TabIndex = 6
        '
        'DateTimePickerRdvEntre
        '
        Me.DateTimePickerRdvEntre.Location = New System.Drawing.Point(123, 135)
        Me.DateTimePickerRdvEntre.Name = "DateTimePickerRdvEntre"
        Me.DateTimePickerRdvEntre.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerRdvEntre.TabIndex = 7
        '
        'labelCom
        '
        Me.labelCom.AutoSize = True
        Me.labelCom.Location = New System.Drawing.Point(12, 219)
        Me.labelCom.Name = "labelCom"
        Me.labelCom.Size = New System.Drawing.Size(77, 13)
        Me.labelCom.TabIndex = 8
        Me.labelCom.Text = "Commentaire : "
        '
        'TextBoxCom
        '
        Me.TextBoxCom.Location = New System.Drawing.Point(123, 216)
        Me.TextBoxCom.Name = "TextBoxCom"
        Me.TextBoxCom.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxCom.TabIndex = 9
        '
        'LIEUTableAdapter
        '
        Me.LIEUTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'DataTable1BindingSource2
        '
        Me.DataTable1BindingSource2.DataMember = "DataTable1"
        Me.DataTable1BindingSource2.DataSource = Me.DataSet1BindingSource
        '
        'DataTable1BindingSource3
        '
        Me.DataTable1BindingSource3.DataMember = "DataTable1"
        Me.DataTable1BindingSource3.DataSource = Me.DataSet1BindingSource
        '
        'ButtonAC13Valider
        '
        Me.ButtonAC13Valider.Location = New System.Drawing.Point(12, 271)
        Me.ButtonAC13Valider.Name = "ButtonAC13Valider"
        Me.ButtonAC13Valider.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAC13Valider.TabIndex = 10
        Me.ButtonAC13Valider.Text = "Valider"
        Me.ButtonAC13Valider.UseVisualStyleBackColor = True
        '
        'ButtonAC13Annuler
        '
        Me.ButtonAC13Annuler.Location = New System.Drawing.Point(123, 271)
        Me.ButtonAC13Annuler.Name = "ButtonAC13Annuler"
        Me.ButtonAC13Annuler.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAC13Annuler.TabIndex = 11
        Me.ButtonAC13Annuler.Text = "Annuler"
        Me.ButtonAC13Annuler.UseVisualStyleBackColor = True
        '
        'AC13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 463)
        Me.Controls.Add(Me.ButtonAC13Annuler)
        Me.Controls.Add(Me.ButtonAC13Valider)
        Me.Controls.Add(Me.TextBoxCom)
        Me.Controls.Add(Me.labelCom)
        Me.Controls.Add(Me.DateTimePickerRdvEntre)
        Me.Controls.Add(Me.DateTimePickerRdvEt)
        Me.Controls.Add(Me.labelRdvEt)
        Me.Controls.Add(Me.labelRdvEntre)
        Me.Controls.Add(Me.comboBoxLieu)
        Me.Controls.Add(Me.labelLieu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AC13"
        Me.Text = "AC13"
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIEUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelLieu As System.Windows.Forms.Label
    Friend WithEvents comboBoxLieu As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents LIEUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIEUTableAdapter As WindowsApplication5.DataSet1TableAdapters.LIEUTableAdapter
    Friend WithEvents labelRdvEntre As System.Windows.Forms.Label
    Friend WithEvents labelRdvEt As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerRdvEt As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerRdvEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelCom As System.Windows.Forms.Label
    Friend WithEvents TextBoxCom As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents DataTable1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonAC13Valider As System.Windows.Forms.Button
    Friend WithEvents ButtonAC13Annuler As System.Windows.Forms.Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC12Ajouter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AC12ANNULER = New System.Windows.Forms.Button()
        Me.AC12VALIDER = New System.Windows.Forms.Button()
        Me.AC12COM = New System.Windows.Forms.Label()
        Me.AC12PEC = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.AC12RMQ = New System.Windows.Forms.Label()
        Me.boxRemorque = New System.Windows.Forms.ComboBox()
        Me.AC12REMMATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.AC12VEH = New System.Windows.Forms.Label()
        Me.boxVehicule = New System.Windows.Forms.ComboBox()
        Me.AC12INMMATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chauffeur = New System.Windows.Forms.Label()
        Me.boxCommentaire = New System.Windows.Forms.TextBox()
        Me.boxChauffeur = New System.Windows.Forms.ComboBox()
        Me.AC12CHFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC12titile = New System.Windows.Forms.Label()
        Me.AC12CHFTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12CHFTableAdapter()
        Me.AC12INMMATTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12INMMATTableAdapter()
        Me.AC12REMMATTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12REMMATTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.AC12REMMATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12INMMATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12CHFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AC12ANNULER)
        Me.GroupBox1.Controls.Add(Me.AC12VALIDER)
        Me.GroupBox1.Controls.Add(Me.AC12COM)
        Me.GroupBox1.Controls.Add(Me.AC12PEC)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.AC12RMQ)
        Me.GroupBox1.Controls.Add(Me.boxRemorque)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.AC12VEH)
        Me.GroupBox1.Controls.Add(Me.boxVehicule)
        Me.GroupBox1.Controls.Add(Me.chauffeur)
        Me.GroupBox1.Controls.Add(Me.boxCommentaire)
        Me.GroupBox1.Controls.Add(Me.boxChauffeur)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 398)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'AC12ANNULER
        '
        Me.AC12ANNULER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12ANNULER.Location = New System.Drawing.Point(118, 363)
        Me.AC12ANNULER.Name = "AC12ANNULER"
        Me.AC12ANNULER.Size = New System.Drawing.Size(91, 29)
        Me.AC12ANNULER.TabIndex = 19
        Me.AC12ANNULER.Text = "ANNULER"
        Me.AC12ANNULER.UseVisualStyleBackColor = True
        '
        'AC12VALIDER
        '
        Me.AC12VALIDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12VALIDER.Location = New System.Drawing.Point(9, 363)
        Me.AC12VALIDER.Name = "AC12VALIDER"
        Me.AC12VALIDER.Size = New System.Drawing.Size(91, 29)
        Me.AC12VALIDER.TabIndex = 18
        Me.AC12VALIDER.Text = "VALIDER"
        Me.AC12VALIDER.UseVisualStyleBackColor = True
        '
        'AC12COM
        '
        Me.AC12COM.AutoSize = True
        Me.AC12COM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12COM.Location = New System.Drawing.Point(6, 239)
        Me.AC12COM.Name = "AC12COM"
        Me.AC12COM.Size = New System.Drawing.Size(168, 18)
        Me.AC12COM.TabIndex = 17
        Me.AC12COM.Text = "Tapez un commentaire :"
        '
        'AC12PEC
        '
        Me.AC12PEC.AutoSize = True
        Me.AC12PEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12PEC.Location = New System.Drawing.Point(6, 195)
        Me.AC12PEC.Name = "AC12PEC"
        Me.AC12PEC.Size = New System.Drawing.Size(126, 18)
        Me.AC12PEC.TabIndex = 16
        Me.AC12PEC.Text = "Pris en charge le :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd  hh:mm:ss"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'AC12RMQ
        '
        Me.AC12RMQ.AutoSize = True
        Me.AC12RMQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12RMQ.Location = New System.Drawing.Point(6, 150)
        Me.AC12RMQ.Name = "AC12RMQ"
        Me.AC12RMQ.Size = New System.Drawing.Size(86, 18)
        Me.AC12RMQ.TabIndex = 14
        Me.AC12RMQ.Text = "Remorque :"
        '
        'boxRemorque
        '
        Me.boxRemorque.DataSource = Me.AC12REMMATBindingSource
        Me.boxRemorque.DisplayMember = "REMMAT"
        Me.boxRemorque.FormattingEnabled = True
        Me.boxRemorque.Location = New System.Drawing.Point(9, 171)
        Me.boxRemorque.Name = "boxRemorque"
        Me.boxRemorque.Size = New System.Drawing.Size(200, 21)
        Me.boxRemorque.TabIndex = 13
        Me.boxRemorque.ValueMember = "REMMAT"
        '
        'AC12REMMATBindingSource
        '
        Me.AC12REMMATBindingSource.DataMember = "AC12REMMAT"
        Me.AC12REMMATBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Date :"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "yyyy-MM-dd  H:mm:ss"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker3.Location = New System.Drawing.Point(9, 37)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 11
        Me.DateTimePicker3.Value = New Date(2019, 10, 18, 9, 51, 48, 0)
        '
        'AC12VEH
        '
        Me.AC12VEH.AutoSize = True
        Me.AC12VEH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12VEH.Location = New System.Drawing.Point(6, 105)
        Me.AC12VEH.Name = "AC12VEH"
        Me.AC12VEH.Size = New System.Drawing.Size(71, 18)
        Me.AC12VEH.TabIndex = 9
        Me.AC12VEH.Text = "Véhicule :"
        '
        'boxVehicule
        '
        Me.boxVehicule.DataSource = Me.AC12INMMATBindingSource
        Me.boxVehicule.DisplayMember = "VEHIMMAT"
        Me.boxVehicule.FormattingEnabled = True
        Me.boxVehicule.Location = New System.Drawing.Point(9, 126)
        Me.boxVehicule.Name = "boxVehicule"
        Me.boxVehicule.Size = New System.Drawing.Size(200, 21)
        Me.boxVehicule.TabIndex = 8
        Me.boxVehicule.ValueMember = "VEHIMMAT"
        '
        'AC12INMMATBindingSource
        '
        Me.AC12INMMATBindingSource.DataMember = "AC12INMMAT"
        Me.AC12INMMATBindingSource.DataSource = Me.DataSet1
        '
        'chauffeur
        '
        Me.chauffeur.AutoSize = True
        Me.chauffeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chauffeur.Location = New System.Drawing.Point(6, 60)
        Me.chauffeur.Name = "chauffeur"
        Me.chauffeur.Size = New System.Drawing.Size(80, 18)
        Me.chauffeur.TabIndex = 7
        Me.chauffeur.Text = "Chauffeur :"
        '
        'boxCommentaire
        '
        Me.boxCommentaire.Location = New System.Drawing.Point(9, 260)
        Me.boxCommentaire.Multiline = True
        Me.boxCommentaire.Name = "boxCommentaire"
        Me.boxCommentaire.Size = New System.Drawing.Size(200, 87)
        Me.boxCommentaire.TabIndex = 6
        '
        'boxChauffeur
        '
        Me.boxChauffeur.DataSource = Me.AC12CHFBindingSource
        Me.boxChauffeur.DisplayMember = "CHFNOM"
        Me.boxChauffeur.FormattingEnabled = True
        Me.boxChauffeur.Location = New System.Drawing.Point(9, 81)
        Me.boxChauffeur.Name = "boxChauffeur"
        Me.boxChauffeur.Size = New System.Drawing.Size(200, 21)
        Me.boxChauffeur.TabIndex = 3
        Me.boxChauffeur.ValueMember = "CHFNOM"
        '
        'AC12CHFBindingSource
        '
        Me.AC12CHFBindingSource.DataMember = "AC12CHF"
        Me.AC12CHFBindingSource.DataSource = Me.DataSet1
        '
        'AC12titile
        '
        Me.AC12titile.AutoSize = True
        Me.AC12titile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AC12titile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC12titile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AC12titile.Location = New System.Drawing.Point(12, 9)
        Me.AC12titile.Name = "AC12titile"
        Me.AC12titile.Size = New System.Drawing.Size(218, 20)
        Me.AC12titile.TabIndex = 22
        Me.AC12titile.Text = "AC12 Ajouter une tournée"
        '
        'AC12CHFTableAdapter
        '
        Me.AC12CHFTableAdapter.ClearBeforeFill = True
        '
        'AC12INMMATTableAdapter
        '
        Me.AC12INMMATTableAdapter.ClearBeforeFill = True
        '
        'AC12REMMATTableAdapter
        '
        Me.AC12REMMATTableAdapter.ClearBeforeFill = True
        '
        'AC12Ajouter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(255, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AC12titile)
        Me.Name = "AC12Ajouter"
        Me.Text = "AC12"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AC12REMMATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12INMMATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12CHFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AC12ANNULER As System.Windows.Forms.Button
    Friend WithEvents AC12VALIDER As System.Windows.Forms.Button
    Friend WithEvents AC12COM As System.Windows.Forms.Label
    Friend WithEvents AC12PEC As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC12RMQ As System.Windows.Forms.Label
    Friend WithEvents boxRemorque As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC12VEH As System.Windows.Forms.Label
    Friend WithEvents boxVehicule As System.Windows.Forms.ComboBox
    Friend WithEvents chauffeur As System.Windows.Forms.Label
    Friend WithEvents boxCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents boxChauffeur As System.Windows.Forms.ComboBox
    Friend WithEvents AC12titile As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents AC12CHFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12CHFTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12CHFTableAdapter
    Friend WithEvents AC12INMMATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12INMMATTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12INMMATTableAdapter
    Friend WithEvents AC12REMMATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12REMMATTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12REMMATTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

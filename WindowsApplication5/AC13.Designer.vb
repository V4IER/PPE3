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
        Me.AC13_labelLieu = New System.Windows.Forms.Label()
        Me.AC13_labelRDVEntre = New System.Windows.Forms.Label()
        Me.AC13_labelEt = New System.Windows.Forms.Label()
        Me.AC13_labelCom = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataTable3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DataTable2TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.DataTable3TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable3TableAdapter()
        Me.AC13_labelPECL = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MESGUEN - AC13"
        '
        'AC13_labelLieu
        '
        Me.AC13_labelLieu.AutoSize = True
        Me.AC13_labelLieu.Location = New System.Drawing.Point(22, 68)
        Me.AC13_labelLieu.Name = "AC13_labelLieu"
        Me.AC13_labelLieu.Size = New System.Drawing.Size(36, 13)
        Me.AC13_labelLieu.TabIndex = 1
        Me.AC13_labelLieu.Text = "Lieu : "
        '
        'AC13_labelRDVEntre
        '
        Me.AC13_labelRDVEntre.AutoSize = True
        Me.AC13_labelRDVEntre.Location = New System.Drawing.Point(22, 125)
        Me.AC13_labelRDVEntre.Name = "AC13_labelRDVEntre"
        Me.AC13_labelRDVEntre.Size = New System.Drawing.Size(106, 13)
        Me.AC13_labelRDVEntre.TabIndex = 2
        Me.AC13_labelRDVEntre.Text = "Rendez-vous entre : "
        '
        'AC13_labelEt
        '
        Me.AC13_labelEt.AutoSize = True
        Me.AC13_labelEt.Location = New System.Drawing.Point(22, 181)
        Me.AC13_labelEt.Name = "AC13_labelEt"
        Me.AC13_labelEt.Size = New System.Drawing.Size(26, 13)
        Me.AC13_labelEt.TabIndex = 3
        Me.AC13_labelEt.Text = "Et : "
        '
        'AC13_labelCom
        '
        Me.AC13_labelCom.AutoSize = True
        Me.AC13_labelCom.Location = New System.Drawing.Point(22, 283)
        Me.AC13_labelCom.Name = "AC13_labelCom"
        Me.AC13_labelCom.Size = New System.Drawing.Size(77, 13)
        Me.AC13_labelCom.TabIndex = 4
        Me.AC13_labelCom.Text = "Commentaire : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataTable3BindingSource
        Me.ComboBox1.DisplayMember = "LIEUNOM"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "LIEUNOM"
        '
        'DataTable3BindingSource
        '
        Me.DataTable3BindingSource.DataMember = "DataTable3"
        Me.DataTable3BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd H:mm:s"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 119)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(134, 175)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(134, 280)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 96)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'AC13_labelPECL
        '
        Me.AC13_labelPECL.AutoSize = True
        Me.AC13_labelPECL.Location = New System.Drawing.Point(22, 235)
        Me.AC13_labelPECL.Name = "AC13_labelPECL"
        Me.AC13_labelPECL.Size = New System.Drawing.Size(95, 13)
        Me.AC13_labelPECL.TabIndex = 11
        Me.AC13_labelPECL.Text = "Pris en charge le : "
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(134, 229)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 12
        '
        'AC13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 444)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.AC13_labelPECL)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AC13_labelCom)
        Me.Controls.Add(Me.AC13_labelEt)
        Me.Controls.Add(Me.AC13_labelRDVEntre)
        Me.Controls.Add(Me.AC13_labelLieu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AC13"
        Me.Text = "AC13"
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AC13_labelLieu As System.Windows.Forms.Label
    Friend WithEvents AC13_labelRDVEntre As System.Windows.Forms.Label
    Friend WithEvents AC13_labelEt As System.Windows.Forms.Label
    Friend WithEvents AC13_labelCom As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents DataTable3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable3TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable3TableAdapter
    Friend WithEvents AC13_labelPECL As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
End Class

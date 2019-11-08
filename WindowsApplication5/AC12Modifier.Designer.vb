<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC12Modifier
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
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.AC12REMMATBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.AC12VEH = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AC12INMMATBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.chauffeur = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AC12CHFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC12titile = New System.Windows.Forms.Label()
        Me.etapes = New System.Windows.Forms.Label()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AC12ETPBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC12ETPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.suppr = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AC12ETPTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12ETPTableAdapter()
        Me.AC12CHFTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12CHFTableAdapter()
        Me.AC12INMMATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC12INMMATTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12INMMATTableAdapter()
        Me.AC12REMMATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AC12REMMATTableAdapter = New WindowsApplication5.DataSet1TableAdapters.AC12REMMATTableAdapter()
        Me.ETPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIEUNOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AC12REMMATBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12INMMATBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12CHFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12ETPBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12ETPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AC12INMMATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AC12REMMATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.AC12VEH)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.chauffeur)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 398)
        Me.GroupBox1.TabIndex = 26
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
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.AC12REMMATBindingSource1
        Me.ComboBox3.DisplayMember = "REMMAT"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(9, 171)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox3.TabIndex = 13
        Me.ComboBox3.ValueMember = "REMMAT"
        '
        'AC12REMMATBindingSource1
        '
        Me.AC12REMMATBindingSource1.DataMember = "AC12REMMAT"
        Me.AC12REMMATBindingSource1.DataSource = Me.DataSet1
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
        Me.DateTimePicker3.CustomFormat = "yyyy-MM-dd  hh:mm:ss"
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
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.AC12INMMATBindingSource1
        Me.ComboBox2.DisplayMember = "VEHIMMAT"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 126)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 8
        Me.ComboBox2.ValueMember = "VEHIMMAT"
        '
        'AC12INMMATBindingSource1
        '
        Me.AC12INMMATBindingSource1.DataMember = "AC12INMMAT"
        Me.AC12INMMATBindingSource1.DataSource = Me.DataSet1
        '
        'chauffeur
        '
        Me.chauffeur.AutoSize = True
        Me.chauffeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chauffeur.Location = New System.Drawing.Point(6, 60)
        Me.chauffeur.Name = "chauffeur"
        Me.chauffeur.Size = New System.Drawing.Size(69, 18)
        Me.chauffeur.TabIndex = 7
        Me.chauffeur.Text = "chauffeur"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 260)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 87)
        Me.TextBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AC12CHFBindingSource
        Me.ComboBox1.DisplayMember = "CHFNOM"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "CHFNOM"
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
        Me.AC12titile.Size = New System.Drawing.Size(240, 20)
        Me.AC12titile.TabIndex = 25
        Me.AC12titile.Text = "AC12 Organiser les tournées"
        '
        'etapes
        '
        Me.etapes.AutoSize = True
        Me.etapes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etapes.Location = New System.Drawing.Point(6, 16)
        Me.etapes.Name = "etapes"
        Me.etapes.Size = New System.Drawing.Size(62, 18)
        Me.etapes.TabIndex = 12
        Me.etapes.Text = "Etapes :"
        '
        'ajouter
        '
        Me.ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter.Location = New System.Drawing.Point(225, 363)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(91, 29)
        Me.ajouter.TabIndex = 18
        Me.ajouter.Text = "AJOUTER"
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ETPIDDataGridViewTextBoxColumn, Me.LIEUNOMDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AC12ETPBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 187)
        Me.DataGridView1.TabIndex = 19
        '
        'AC12ETPBindingSource1
        '
        Me.AC12ETPBindingSource1.DataMember = "AC12ETP"
        Me.AC12ETPBindingSource1.DataSource = Me.DataSet1
        '
        'AC12ETPBindingSource
        '
        Me.AC12ETPBindingSource.DataMember = "AC12ETP"
        Me.AC12ETPBindingSource.DataSource = Me.DataSet1
        '
        'suppr
        '
        Me.suppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppr.Location = New System.Drawing.Point(9, 260)
        Me.suppr.Name = "suppr"
        Me.suppr.Size = New System.Drawing.Size(110, 29)
        Me.suppr.TabIndex = 20
        Me.suppr.Text = "SUPPRIMER"
        Me.suppr.UseVisualStyleBackColor = True
        '
        'modifier
        '
        Me.modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier.Location = New System.Drawing.Point(206, 260)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(110, 29)
        Me.modifier.TabIndex = 21
        Me.modifier.Text = "MODIFIER"
        Me.modifier.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.modifier)
        Me.GroupBox2.Controls.Add(Me.suppr)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.ajouter)
        Me.GroupBox2.Controls.Add(Me.etapes)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 398)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'AC12ETPTableAdapter
        '
        Me.AC12ETPTableAdapter.ClearBeforeFill = True
        '
        'AC12CHFTableAdapter
        '
        Me.AC12CHFTableAdapter.ClearBeforeFill = True
        '
        'AC12INMMATBindingSource
        '
        Me.AC12INMMATBindingSource.DataMember = "AC12INMMAT"
        Me.AC12INMMATBindingSource.DataSource = Me.DataSet1
        '
        'AC12INMMATTableAdapter
        '
        Me.AC12INMMATTableAdapter.ClearBeforeFill = True
        '
        'AC12REMMATBindingSource
        '
        Me.AC12REMMATBindingSource.DataMember = "AC12REMMAT"
        Me.AC12REMMATBindingSource.DataSource = Me.DataSet1
        '
        'AC12REMMATTableAdapter
        '
        Me.AC12REMMATTableAdapter.ClearBeforeFill = True
        '
        'ETPIDDataGridViewTextBoxColumn
        '
        Me.ETPIDDataGridViewTextBoxColumn.DataPropertyName = "ETPID"
        Me.ETPIDDataGridViewTextBoxColumn.HeaderText = "ETPID"
        Me.ETPIDDataGridViewTextBoxColumn.Name = "ETPIDDataGridViewTextBoxColumn"
        '
        'LIEUNOMDataGridViewTextBoxColumn
        '
        Me.LIEUNOMDataGridViewTextBoxColumn.DataPropertyName = "LIEUNOM"
        Me.LIEUNOMDataGridViewTextBoxColumn.HeaderText = "LIEUNOM"
        Me.LIEUNOMDataGridViewTextBoxColumn.Name = "LIEUNOMDataGridViewTextBoxColumn"
        '
        'AC12Modifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(602, 466)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AC12titile)
        Me.Name = "AC12Modifier"
        Me.Text = "AC12Modifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AC12REMMATBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12INMMATBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12CHFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12ETPBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12ETPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AC12INMMATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AC12REMMATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC12VEH As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents chauffeur As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AC12titile As System.Windows.Forms.Label
    Friend WithEvents etapes As System.Windows.Forms.Label
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents suppr As System.Windows.Forms.Button
    Friend WithEvents modifier As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents AC12ETPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12ETPTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12ETPTableAdapter
    Friend WithEvents AC12ETPBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AC12CHFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12CHFTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12CHFTableAdapter
    Friend WithEvents AC12INMMATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12INMMATTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12INMMATTableAdapter
    Friend WithEvents AC12REMMATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AC12REMMATTableAdapter As WindowsApplication5.DataSet1TableAdapters.AC12REMMATTableAdapter
    Friend WithEvents AC12REMMATBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AC12INMMATBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ETPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIEUNOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

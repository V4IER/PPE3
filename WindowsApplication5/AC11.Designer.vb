<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC11
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.DataTable1TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AC11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRNNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNDTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHFPRENOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHIMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEDEPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEARRIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AJOUTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPRIMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRNNUMDataGridViewTextBoxColumn, Me.TRNDTEDataGridViewTextBoxColumn, Me.CHFPRENOMDataGridViewTextBoxColumn, Me.VEHIMMATDataGridViewTextBoxColumn, Me.REMMATDataGridViewTextBoxColumn, Me.ETAPEDEPARTDataGridViewTextBoxColumn, Me.ETAPEARRIVERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.Location = New System.Drawing.Point(12, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AC11ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AC11ToolStripMenuItem
        '
        Me.AC11ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AJOUTERToolStripMenuItem, Me.MODIFIERToolStripMenuItem, Me.SUPRIMERToolStripMenuItem})
        Me.AC11ToolStripMenuItem.Name = "AC11ToolStripMenuItem"
        Me.AC11ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AC11ToolStripMenuItem.Text = "Accueil"
        '
        'TRNNUMDataGridViewTextBoxColumn
        '
        Me.TRNNUMDataGridViewTextBoxColumn.DataPropertyName = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.HeaderText = "Tournée"
        Me.TRNNUMDataGridViewTextBoxColumn.Name = "TRNNUMDataGridViewTextBoxColumn"
        '
        'TRNDTEDataGridViewTextBoxColumn
        '
        Me.TRNDTEDataGridViewTextBoxColumn.DataPropertyName = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TRNDTEDataGridViewTextBoxColumn.Name = "TRNDTEDataGridViewTextBoxColumn"
        '
        'CHFPRENOMDataGridViewTextBoxColumn
        '
        Me.CHFPRENOMDataGridViewTextBoxColumn.DataPropertyName = "CHFPRENOM"
        Me.CHFPRENOMDataGridViewTextBoxColumn.HeaderText = "Chauffeur"
        Me.CHFPRENOMDataGridViewTextBoxColumn.Name = "CHFPRENOMDataGridViewTextBoxColumn"
        '
        'VEHIMMATDataGridViewTextBoxColumn
        '
        Me.VEHIMMATDataGridViewTextBoxColumn.DataPropertyName = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.HeaderText = "Véhicule"
        Me.VEHIMMATDataGridViewTextBoxColumn.Name = "VEHIMMATDataGridViewTextBoxColumn"
        '
        'REMMATDataGridViewTextBoxColumn
        '
        Me.REMMATDataGridViewTextBoxColumn.DataPropertyName = "REMMAT"
        Me.REMMATDataGridViewTextBoxColumn.HeaderText = "Remorque"
        Me.REMMATDataGridViewTextBoxColumn.Name = "REMMATDataGridViewTextBoxColumn"
        '
        'ETAPEDEPARTDataGridViewTextBoxColumn
        '
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_DEPART"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.HeaderText = "Départ"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.Name = "ETAPEDEPARTDataGridViewTextBoxColumn"
        '
        'ETAPEARRIVERDataGridViewTextBoxColumn
        '
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_ARRIVER"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.HeaderText = "Arrivée"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.Name = "ETAPEARRIVERDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 19)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AC11 - Organiser les tournées - Listes des tournées "
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(125, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "AJOUTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(297, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "MODIFIER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(469, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "SUPRIMER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AJOUTERToolStripMenuItem
        '
        Me.AJOUTERToolStripMenuItem.Name = "AJOUTERToolStripMenuItem"
        Me.AJOUTERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AJOUTERToolStripMenuItem.Text = "AJOUTER"
        '
        'MODIFIERToolStripMenuItem
        '
        Me.MODIFIERToolStripMenuItem.Name = "MODIFIERToolStripMenuItem"
        Me.MODIFIERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MODIFIERToolStripMenuItem.Text = "MODIFIER"
        '
        'SUPRIMERToolStripMenuItem
        '
        Me.SUPRIMERToolStripMenuItem.Name = "SUPRIMERToolStripMenuItem"
        Me.SUPRIMERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SUPRIMERToolStripMenuItem.Text = "SUPRIMER"
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 466)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AC11"
        Me.Text = "AC11"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AC11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRNNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNDTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHFPRENOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHIMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEDEPARTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEARRIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AJOUTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUPRIMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New WindowsApplication5.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.TRNNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNDTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHFPRENOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHIMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEDEPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEARRIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRNNUMDataGridViewTextBoxColumn, Me.TRNDTEDataGridViewTextBoxColumn, Me.CHFPRENOMDataGridViewTextBoxColumn, Me.VEHIMMATDataGridViewTextBoxColumn, Me.REMMATDataGridViewTextBoxColumn, Me.ETAPEDEPARTDataGridViewTextBoxColumn, Me.ETAPEARRIVERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1015, 406)
        Me.DataGridView1.TabIndex = 0
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
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TRNNUMDataGridViewTextBoxColumn
        '
        Me.TRNNUMDataGridViewTextBoxColumn.DataPropertyName = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.HeaderText = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.Name = "TRNNUMDataGridViewTextBoxColumn"
        '
        'TRNDTEDataGridViewTextBoxColumn
        '
        Me.TRNDTEDataGridViewTextBoxColumn.DataPropertyName = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.HeaderText = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.Name = "TRNDTEDataGridViewTextBoxColumn"
        '
        'CHFPRENOMDataGridViewTextBoxColumn
        '
        Me.CHFPRENOMDataGridViewTextBoxColumn.DataPropertyName = "CHFPRENOM"
        Me.CHFPRENOMDataGridViewTextBoxColumn.HeaderText = "CHFPRENOM"
        Me.CHFPRENOMDataGridViewTextBoxColumn.Name = "CHFPRENOMDataGridViewTextBoxColumn"
        '
        'VEHIMMATDataGridViewTextBoxColumn
        '
        Me.VEHIMMATDataGridViewTextBoxColumn.DataPropertyName = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.HeaderText = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.Name = "VEHIMMATDataGridViewTextBoxColumn"
        '
        'REMMATDataGridViewTextBoxColumn
        '
        Me.REMMATDataGridViewTextBoxColumn.DataPropertyName = "REMMAT"
        Me.REMMATDataGridViewTextBoxColumn.HeaderText = "REMMAT"
        Me.REMMATDataGridViewTextBoxColumn.Name = "REMMATDataGridViewTextBoxColumn"
        '
        'ETAPEDEPARTDataGridViewTextBoxColumn
        '
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_DEPART"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.HeaderText = "ETAPE_DEPART"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.Name = "ETAPEDEPARTDataGridViewTextBoxColumn"
        '
        'ETAPEARRIVERDataGridViewTextBoxColumn
        '
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_ARRIVER"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.HeaderText = "ETAPE_ARRIVER"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.Name = "ETAPEARRIVERDataGridViewTextBoxColumn"
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 496)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AC11"
        Me.Text = "AC11"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As WindowsApplication5.DataSet1
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As WindowsApplication5.DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents TRNNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNDTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHFPRENOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHIMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEDEPARTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEARRIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

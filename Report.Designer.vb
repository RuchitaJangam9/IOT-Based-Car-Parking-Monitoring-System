<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SlotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New WindowsApplication1.Database1DataSet1()
        Me.Table1TableAdapter1 = New WindowsApplication1.Database1DataSet1TableAdapters.Table1TableAdapter()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.Table1TableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.Table1TableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.VehicleNoaDataGridViewTextBoxColumn, Me.VehicleNobDataGridViewTextBoxColumn, Me.VehicleNocDataGridViewTextBoxColumn, Me.VehicleNodDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.SlotDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 519)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.NameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'VehicleNoaDataGridViewTextBoxColumn
        '
        Me.VehicleNoaDataGridViewTextBoxColumn.DataPropertyName = "VehicleNoa"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.VehicleNoaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.VehicleNoaDataGridViewTextBoxColumn.HeaderText = "VehicleNoa"
        Me.VehicleNoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehicleNoaDataGridViewTextBoxColumn.Name = "VehicleNoaDataGridViewTextBoxColumn"
        Me.VehicleNoaDataGridViewTextBoxColumn.ReadOnly = True
        Me.VehicleNoaDataGridViewTextBoxColumn.Width = 125
        '
        'VehicleNobDataGridViewTextBoxColumn
        '
        Me.VehicleNobDataGridViewTextBoxColumn.DataPropertyName = "VehicleNob"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.VehicleNobDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.VehicleNobDataGridViewTextBoxColumn.HeaderText = "VehicleNob"
        Me.VehicleNobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehicleNobDataGridViewTextBoxColumn.Name = "VehicleNobDataGridViewTextBoxColumn"
        Me.VehicleNobDataGridViewTextBoxColumn.ReadOnly = True
        Me.VehicleNobDataGridViewTextBoxColumn.Width = 125
        '
        'VehicleNocDataGridViewTextBoxColumn
        '
        Me.VehicleNocDataGridViewTextBoxColumn.DataPropertyName = "VehicleNoc"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        Me.VehicleNocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.VehicleNocDataGridViewTextBoxColumn.HeaderText = "VehicleNoc"
        Me.VehicleNocDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehicleNocDataGridViewTextBoxColumn.Name = "VehicleNocDataGridViewTextBoxColumn"
        Me.VehicleNocDataGridViewTextBoxColumn.ReadOnly = True
        Me.VehicleNocDataGridViewTextBoxColumn.Width = 125
        '
        'VehicleNodDataGridViewTextBoxColumn
        '
        Me.VehicleNodDataGridViewTextBoxColumn.DataPropertyName = "VehicleNod"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.VehicleNodDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.VehicleNodDataGridViewTextBoxColumn.HeaderText = "VehicleNod"
        Me.VehicleNodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehicleNodDataGridViewTextBoxColumn.Name = "VehicleNodDataGridViewTextBoxColumn"
        Me.VehicleNodDataGridViewTextBoxColumn.ReadOnly = True
        Me.VehicleNodDataGridViewTextBoxColumn.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        Me.DateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 125
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.TimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeDataGridViewTextBoxColumn.Width = 125
        '
        'SlotDataGridViewTextBoxColumn
        '
        Me.SlotDataGridViewTextBoxColumn.DataPropertyName = "slot"
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.SlotDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.SlotDataGridViewTextBoxColumn.HeaderText = "slot"
        Me.SlotDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SlotDataGridViewTextBoxColumn.Name = "SlotDataGridViewTextBoxColumn"
        Me.SlotDataGridViewTextBoxColumn.ReadOnly = True
        Me.SlotDataGridViewTextBoxColumn.Width = 125
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 519)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents Table1BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As Database1DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleNoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleNobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleNocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleNodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

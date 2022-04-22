<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxControls = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBoxItemList = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelbertsDBDataSet = New SeLLiTPOS.DelbertsDBDataSet()
        Me.ProductDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_DetailsTableAdapter = New SeLLiTPOS.DelbertsDBDataSetTableAdapters.Product_DetailsTableAdapter()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxControls.SuspendLayout()
        Me.GroupBoxItemList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelbertsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxControls
        '
        Me.GroupBoxControls.Controls.Add(Me.btnExit)
        Me.GroupBoxControls.Controls.Add(Me.btnNext)
        Me.GroupBoxControls.Controls.Add(Me.btnPrevious)
        Me.GroupBoxControls.Location = New System.Drawing.Point(12, 372)
        Me.GroupBoxControls.Name = "GroupBoxControls"
        Me.GroupBoxControls.Size = New System.Drawing.Size(717, 66)
        Me.GroupBoxControls.TabIndex = 0
        Me.GroupBoxControls.TabStop = False
        Me.GroupBoxControls.Text = "CONTROLS"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(598, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(200, 30)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(70, 30)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'GroupBoxItemList
        '
        Me.GroupBoxItemList.Controls.Add(Me.DataGridView1)
        Me.GroupBoxItemList.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxItemList.Name = "GroupBoxItemList"
        Me.GroupBoxItemList.Size = New System.Drawing.Size(717, 354)
        Me.GroupBoxItemList.TabIndex = 1
        Me.GroupBoxItemList.TabStop = False
        Me.GroupBoxItemList.Text = "ITEM LIST"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(711, 335)
        Me.DataGridView1.TabIndex = 0
        '
        'DelbertsDBDataSet
        '
        Me.DelbertsDBDataSet.DataSetName = "DelbertsDBDataSet"
        Me.DelbertsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDetailsBindingSource
        '
        Me.ProductDetailsBindingSource.DataMember = "Product_Details"
        Me.ProductDetailsBindingSource.DataSource = Me.DelbertsDBDataSet
        '
        'Product_DetailsTableAdapter
        '
        Me.Product_DetailsTableAdapter.ClearBeforeFill = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmViewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 450)
        Me.Controls.Add(Me.GroupBoxItemList)
        Me.Controls.Add(Me.GroupBoxControls)
        Me.Name = "frmViewStock"
        Me.Text = "Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBoxControls.ResumeLayout(False)
        Me.GroupBoxItemList.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelbertsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControls As GroupBox
    Friend WithEvents GroupBoxItemList As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelbertsDBDataSet As DelbertsDBDataSet
    Friend WithEvents ProductDetailsBindingSource As BindingSource
    Friend WithEvents Product_DetailsTableAdapter As DelbertsDBDataSetTableAdapters.Product_DetailsTableAdapter
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

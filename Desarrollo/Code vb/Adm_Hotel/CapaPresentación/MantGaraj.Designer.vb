<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantGaraj
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
        Me.dgv_garaj = New System.Windows.Forms.DataGridView()
        Me.CB_slot = New System.Windows.Forms.ComboBox()
        Me.GARAJEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_HOTELDataSet = New CapaPresentación.DB_HOTELDataSet()
        Me.LISTCBSLOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_HOTELDataSet1 = New CapaPresentación.DB_HOTELDataSet1()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_liberar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GARAJETableAdapter = New CapaPresentación.DB_HOTELDataSetTableAdapters.GARAJETableAdapter()
        Me.LISTCBSLOTTableAdapter = New CapaPresentación.DB_HOTELDataSet1TableAdapters.LISTCBSLOTTableAdapter()
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GARAJEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_HOTELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTCBSLOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_HOTELDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_garaj
        '
        Me.dgv_garaj.AllowUserToAddRows = False
        Me.dgv_garaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_garaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_garaj.Location = New System.Drawing.Point(141, 12)
        Me.dgv_garaj.Name = "dgv_garaj"
        Me.dgv_garaj.ReadOnly = True
        Me.dgv_garaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_garaj.Size = New System.Drawing.Size(443, 231)
        Me.dgv_garaj.TabIndex = 2
        '
        'CB_slot
        '
        Me.CB_slot.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GARAJEBindingSource, "SLOT", True))
        Me.CB_slot.DataSource = Me.LISTCBSLOTBindingSource
        Me.CB_slot.DisplayMember = "SLOT"
        Me.CB_slot.FormattingEnabled = True
        Me.CB_slot.Location = New System.Drawing.Point(6, 31)
        Me.CB_slot.Name = "CB_slot"
        Me.CB_slot.Size = New System.Drawing.Size(46, 21)
        Me.CB_slot.TabIndex = 3
        Me.CB_slot.ValueMember = "SLOT"
        '
        'GARAJEBindingSource
        '
        Me.GARAJEBindingSource.DataMember = "GARAJE"
        Me.GARAJEBindingSource.DataSource = Me.DB_HOTELDataSet
        '
        'DB_HOTELDataSet
        '
        Me.DB_HOTELDataSet.DataSetName = "DB_HOTELDataSet"
        Me.DB_HOTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LISTCBSLOTBindingSource
        '
        Me.LISTCBSLOTBindingSource.DataMember = "LISTCBSLOT"
        Me.LISTCBSLOTBindingSource.DataSource = Me.DB_HOTELDataSet1
        '
        'DB_HOTELDataSet1
        '
        Me.DB_HOTELDataSet1.DataSetName = "DB_HOTELDataSet1"
        Me.DB_HOTELDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(6, 71)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 20)
        Me.txt_placa.TabIndex = 4
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(6, 110)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Slot"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btn_liberar)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_Añadir)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_slot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_placa)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 237)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Garaje"
        '
        'btn_liberar
        '
        Me.btn_liberar.Location = New System.Drawing.Point(6, 196)
        Me.btn_liberar.Name = "btn_liberar"
        Me.btn_liberar.Size = New System.Drawing.Size(100, 23)
        Me.btn_liberar.TabIndex = 11
        Me.btn_liberar.Text = "Liberar"
        Me.btn_liberar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(6, 166)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(100, 23)
        Me.btn_actualizar.TabIndex = 10
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(6, 137)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(100, 23)
        Me.btn_Añadir.TabIndex = 9
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Placa"
        '
        'GARAJETableAdapter
        '
        Me.GARAJETableAdapter.ClearBeforeFill = True
        '
        'LISTCBSLOTTableAdapter
        '
        Me.LISTCBSLOTTableAdapter.ClearBeforeFill = True
        '
        'MantGaraj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 257)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_garaj)
        Me.Name = "MantGaraj"
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GARAJEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_HOTELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTCBSLOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_HOTELDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_garaj As DataGridView
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DB_HOTELDataSet As DB_HOTELDataSet
    Friend WithEvents GARAJEBindingSource As BindingSource
    Friend WithEvents GARAJETableAdapter As DB_HOTELDataSetTableAdapters.GARAJETableAdapter
    Friend WithEvents DB_HOTELDataSet1 As DB_HOTELDataSet1
    Friend WithEvents LISTCBSLOTBindingSource As BindingSource
    Friend WithEvents LISTCBSLOTTableAdapter As DB_HOTELDataSet1TableAdapters.LISTCBSLOTTableAdapter
    Friend WithEvents btn_liberar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_Añadir As Button
    Private WithEvents CB_slot As ComboBox
End Class

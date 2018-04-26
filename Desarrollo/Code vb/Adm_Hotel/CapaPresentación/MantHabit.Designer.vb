<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantHabit
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_liberar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_slot = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.dgv_garaj = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btn_liberar)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_slot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_placa)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(168, 292)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitaciones"
        '
        'btn_liberar
        '
        Me.btn_liberar.Location = New System.Drawing.Point(8, 241)
        Me.btn_liberar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_liberar.Name = "btn_liberar"
        Me.btn_liberar.Size = New System.Drawing.Size(133, 28)
        Me.btn_liberar.TabIndex = 11
        Me.btn_liberar.Text = "Liberar"
        Me.btn_liberar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(8, 204)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(133, 28)
        Me.btn_actualizar.TabIndex = 10
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Habitación"
        '
        'CB_slot
        '
        Me.CB_slot.DisplayMember = "SLOT"
        Me.CB_slot.FormattingEnabled = True
        Me.CB_slot.Location = New System.Drawing.Point(8, 38)
        Me.CB_slot.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_slot.Name = "CB_slot"
        Me.CB_slot.Size = New System.Drawing.Size(60, 24)
        Me.CB_slot.TabIndex = 3
        Me.CB_slot.ValueMember = "SLOT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Estado"
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(8, 87)
        Me.txt_placa.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(132, 22)
        Me.txt_placa.TabIndex = 4
        '
        'dgv_garaj
        '
        Me.dgv_garaj.AllowUserToAddRows = False
        Me.dgv_garaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_garaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_garaj.Location = New System.Drawing.Point(182, 13)
        Me.dgv_garaj.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_garaj.Name = "dgv_garaj"
        Me.dgv_garaj.ReadOnly = True
        Me.dgv_garaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_garaj.Size = New System.Drawing.Size(591, 284)
        Me.dgv_garaj.TabIndex = 8
        '
        'MantHabit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 312)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_garaj)
        Me.Name = "MantHabit"
        Me.Text = "MantHabit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_liberar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents CB_slot As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents dgv_garaj As DataGridView
End Class

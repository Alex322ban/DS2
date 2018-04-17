<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantCli
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
        Me.dgv_cli = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_deltcli = New System.Windows.Forms.Button()
        Me.BTN_updcli = New System.Windows.Forms.Button()
        Me.BTN_addcli = New System.Windows.Forms.Button()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_nomb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_cli
        '
        Me.dgv_cli.AllowUserToAddRows = False
        Me.dgv_cli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cli.Location = New System.Drawing.Point(173, 11)
        Me.dgv_cli.Name = "dgv_cli"
        Me.dgv_cli.ReadOnly = True
        Me.dgv_cli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cli.Size = New System.Drawing.Size(393, 213)
        Me.dgv_cli.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTN_deltcli)
        Me.GroupBox1.Controls.Add(Me.BTN_updcli)
        Me.GroupBox1.Controls.Add(Me.BTN_addcli)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.txt_ape)
        Me.GroupBox1.Controls.Add(Me.txt_nomb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 222)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_deltcli
        '
        Me.BTN_deltcli.Location = New System.Drawing.Point(7, 194)
        Me.BTN_deltcli.Name = "BTN_deltcli"
        Me.BTN_deltcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_deltcli.TabIndex = 12
        Me.BTN_deltcli.Text = "Eliminar"
        Me.BTN_deltcli.UseVisualStyleBackColor = True
        '
        'BTN_updcli
        '
        Me.BTN_updcli.Location = New System.Drawing.Point(7, 168)
        Me.BTN_updcli.Name = "BTN_updcli"
        Me.BTN_updcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_updcli.TabIndex = 11
        Me.BTN_updcli.Text = "Actualizar"
        Me.BTN_updcli.UseVisualStyleBackColor = True
        '
        'BTN_addcli
        '
        Me.BTN_addcli.Location = New System.Drawing.Point(7, 141)
        Me.BTN_addcli.Name = "BTN_addcli"
        Me.BTN_addcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_addcli.TabIndex = 10
        Me.BTN_addcli.Text = "Añadir"
        Me.BTN_addcli.UseVisualStyleBackColor = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(6, 38)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(143, 20)
        Me.txt_dni.TabIndex = 9
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(6, 115)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(143, 20)
        Me.txt_ape.TabIndex = 8
        '
        'txt_nomb
        '
        Me.txt_nomb.Location = New System.Drawing.Point(6, 77)
        Me.txt_nomb.Name = "txt_nomb"
        Me.txt_nomb.Size = New System.Drawing.Size(143, 20)
        Me.txt_nomb.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DNI"
        '
        'MantCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 234)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_cli)
        Me.Name = "MantCli"
        Me.TransparencyKey = System.Drawing.Color.Indigo
        CType(Me.dgv_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_cli As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_deltcli As Button
    Friend WithEvents BTN_updcli As Button
    Friend WithEvents BTN_addcli As Button
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents txt_nomb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

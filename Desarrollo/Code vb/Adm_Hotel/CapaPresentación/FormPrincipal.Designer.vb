<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStripBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_HOTELDataSet3 = New CapaPresentación.DB_HOTELDataSet3()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTableAdapter = New CapaPresentación.DB_HOTELDataSet3TableAdapters.MenuStripTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MenuStripBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_HOTELDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.MenuStripBindingSource, "NOMBRE", True))
        Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuStripBindingSource, "NOMBRE", True))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.GarajeToolStripMenuItem, Me.HabitaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(825, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStripBindingSource
        '
        Me.MenuStripBindingSource.DataMember = "MenuStrip"
        Me.MenuStripBindingSource.DataSource = Me.DB_HOTELDataSet3
        '
        'DB_HOTELDataSet3
        '
        Me.DB_HOTELDataSet3.DataSetName = "DB_HOTELDataSet3"
        Me.DB_HOTELDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'GarajeToolStripMenuItem
        '
        Me.GarajeToolStripMenuItem.Name = "GarajeToolStripMenuItem"
        Me.GarajeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.GarajeToolStripMenuItem.Text = "Garaje"
        '
        'HabitaciónToolStripMenuItem
        '
        Me.HabitaciónToolStripMenuItem.Name = "HabitaciónToolStripMenuItem"
        Me.HabitaciónToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.HabitaciónToolStripMenuItem.Text = "Habitación"
        '
        'MenuStripTableAdapter
        '
        Me.MenuStripTableAdapter.ClearBeforeFill = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(825, 500)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MenuStripBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_HOTELDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DB_HOTELDataSet3 As DB_HOTELDataSet3
    Friend WithEvents MenuStripBindingSource As BindingSource
    Friend WithEvents MenuStripTableAdapter As DB_HOTELDataSet3TableAdapters.MenuStripTableAdapter
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HabitaciónToolStripMenuItem As ToolStripMenuItem
End Class

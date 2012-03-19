<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmObjetosMibs
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DGVMibs = New System.Windows.Forms.DataGridView()
        Me.IdentificadorMib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathHumano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdObj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Objetos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Arbol_RDBMS_Mib = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxOid = New System.Windows.Forms.GroupBox()
        Me.TextBoxOid = New System.Windows.Forms.TextBox()
        Me.GroupBoxAcceso = New System.Windows.Forms.GroupBox()
        Me.TextBoxAcceso = New System.Windows.Forms.TextBox()
        Me.GroupBoxSyntaxis = New System.Windows.Forms.GroupBox()
        Me.TextBoxSyntaxis = New System.Windows.Forms.TextBox()
        Me.GroupBoxEstado = New System.Windows.Forms.GroupBox()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.RichTextBMib = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DGVMibs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxOid.SuspendLayout()
        Me.GroupBoxAcceso.SuspendLayout()
        Me.GroupBoxSyntaxis.SuspendLayout()
        Me.GroupBoxEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DGVMibs)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1370, 740)
        Me.SplitContainer2.SplitterDistance = 119
        Me.SplitContainer2.TabIndex = 3
        Me.SplitContainer2.TabStop = False
        '
        'DGVMibs
        '
        Me.DGVMibs.AllowUserToAddRows = False
        Me.DGVMibs.AllowUserToDeleteRows = False
        Me.DGVMibs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMibs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorMib, Me.Nombre, Me.PathHumano, Me.IdObj, Me.Objetos})
        Me.DGVMibs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVMibs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVMibs.Location = New System.Drawing.Point(0, 0)
        Me.DGVMibs.Name = "DGVMibs"
        Me.DGVMibs.ReadOnly = True
        Me.DGVMibs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMibs.Size = New System.Drawing.Size(1370, 119)
        Me.DGVMibs.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DGVMibs, "Seleccione un registro y presione enter o doble Click.")
        '
        'IdentificadorMib
        '
        Me.IdentificadorMib.DataPropertyName = "IdentificadorMib"
        Me.IdentificadorMib.HeaderText = "IdentificadorMib"
        Me.IdentificadorMib.Name = "IdentificadorMib"
        Me.IdentificadorMib.ReadOnly = True
        Me.IdentificadorMib.ToolTipText = "Seleccione un registro y presione enter o doble Click."
        Me.IdentificadorMib.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.ToolTipText = "Seleccione un registro y presione enter o doble Click."
        '
        'PathHumano
        '
        Me.PathHumano.DataPropertyName = "PathHumano"
        Me.PathHumano.HeaderText = "Path legible Humano"
        Me.PathHumano.Name = "PathHumano"
        Me.PathHumano.ReadOnly = True
        Me.PathHumano.ToolTipText = "Seleccione un registro y presione enter o doble Click."
        Me.PathHumano.Width = 500
        '
        'IdObj
        '
        Me.IdObj.DataPropertyName = "IdObj"
        Me.IdObj.HeaderText = "Identificador de Objeto"
        Me.IdObj.Name = "IdObj"
        Me.IdObj.ReadOnly = True
        Me.IdObj.ToolTipText = "Seleccione un registro y presione enter o doble Click."
        '
        'Objetos
        '
        Me.Objetos.DataPropertyName = "Objetos"
        Me.Objetos.HeaderText = "Objetos"
        Me.Objetos.Name = "Objetos"
        Me.Objetos.ReadOnly = True
        Me.Objetos.ToolTipText = "Seleccione un registro y presione enter o doble Click."
        Me.Objetos.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Arbol_RDBMS_Mib)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1370, 617)
        Me.SplitContainer1.SplitterDistance = 680
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.TabStop = False
        '
        'Arbol_RDBMS_Mib
        '
        Me.Arbol_RDBMS_Mib.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Arbol_RDBMS_Mib.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Arbol_RDBMS_Mib.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arbol_RDBMS_Mib.Location = New System.Drawing.Point(0, 0)
        Me.Arbol_RDBMS_Mib.Name = "Arbol_RDBMS_Mib"
        Me.Arbol_RDBMS_Mib.Size = New System.Drawing.Size(680, 617)
        Me.Arbol_RDBMS_Mib.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 70)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.RichTextBMib)
        Me.SplitContainer3.Size = New System.Drawing.Size(686, 617)
        Me.SplitContainer3.SplitterDistance = 166
        Me.SplitContainer3.TabIndex = 0
        Me.SplitContainer3.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxOid, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxAcceso, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxSyntaxis, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxEstado, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(686, 166)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxOid
        '
        Me.GroupBoxOid.Controls.Add(Me.TextBoxOid)
        Me.GroupBoxOid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxOid.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxOid.Name = "GroupBoxOid"
        Me.GroupBoxOid.Size = New System.Drawing.Size(337, 77)
        Me.GroupBoxOid.TabIndex = 8
        Me.GroupBoxOid.TabStop = False
        Me.GroupBoxOid.Text = "Identificador de Objeto"
        '
        'TextBoxOid
        '
        Me.TextBoxOid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOid.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxOid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxOid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOid.Location = New System.Drawing.Point(34, 25)
        Me.TextBoxOid.Name = "TextBoxOid"
        Me.TextBoxOid.ReadOnly = True
        Me.TextBoxOid.Size = New System.Drawing.Size(280, 26)
        Me.TextBoxOid.TabIndex = 2
        Me.TextBoxOid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBoxOid, "Identificador de objeto")
        '
        'GroupBoxAcceso
        '
        Me.GroupBoxAcceso.Controls.Add(Me.TextBoxAcceso)
        Me.GroupBoxAcceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAcceso.Location = New System.Drawing.Point(346, 3)
        Me.GroupBoxAcceso.Name = "GroupBoxAcceso"
        Me.GroupBoxAcceso.Size = New System.Drawing.Size(337, 77)
        Me.GroupBoxAcceso.TabIndex = 9
        Me.GroupBoxAcceso.TabStop = False
        Me.GroupBoxAcceso.Text = "Acceso"
        '
        'TextBoxAcceso
        '
        Me.TextBoxAcceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAcceso.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAcceso.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAcceso.Location = New System.Drawing.Point(30, 25)
        Me.TextBoxAcceso.Name = "TextBoxAcceso"
        Me.TextBoxAcceso.ReadOnly = True
        Me.TextBoxAcceso.Size = New System.Drawing.Size(280, 26)
        Me.TextBoxAcceso.TabIndex = 3
        Me.TextBoxAcceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBoxSyntaxis
        '
        Me.GroupBoxSyntaxis.Controls.Add(Me.TextBoxSyntaxis)
        Me.GroupBoxSyntaxis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxSyntaxis.Location = New System.Drawing.Point(3, 86)
        Me.GroupBoxSyntaxis.Name = "GroupBoxSyntaxis"
        Me.GroupBoxSyntaxis.Size = New System.Drawing.Size(337, 77)
        Me.GroupBoxSyntaxis.TabIndex = 10
        Me.GroupBoxSyntaxis.TabStop = False
        Me.GroupBoxSyntaxis.Text = "Sintaxis"
        '
        'TextBoxSyntaxis
        '
        Me.TextBoxSyntaxis.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSyntaxis.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSyntaxis.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxSyntaxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSyntaxis.Location = New System.Drawing.Point(34, 25)
        Me.TextBoxSyntaxis.Name = "TextBoxSyntaxis"
        Me.TextBoxSyntaxis.ReadOnly = True
        Me.TextBoxSyntaxis.Size = New System.Drawing.Size(280, 26)
        Me.TextBoxSyntaxis.TabIndex = 4
        Me.TextBoxSyntaxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBoxEstado
        '
        Me.GroupBoxEstado.Controls.Add(Me.TextBoxEstado)
        Me.GroupBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxEstado.Location = New System.Drawing.Point(346, 86)
        Me.GroupBoxEstado.Name = "GroupBoxEstado"
        Me.GroupBoxEstado.Size = New System.Drawing.Size(337, 77)
        Me.GroupBoxEstado.TabIndex = 11
        Me.GroupBoxEstado.TabStop = False
        Me.GroupBoxEstado.Text = "Estado"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEstado.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEstado.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEstado.Location = New System.Drawing.Point(30, 25)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.ReadOnly = True
        Me.TextBoxEstado.Size = New System.Drawing.Size(280, 26)
        Me.TextBoxEstado.TabIndex = 5
        Me.TextBoxEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBMib
        '
        Me.RichTextBMib.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBMib.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBMib.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBMib.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBMib.HideSelection = False
        Me.RichTextBMib.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBMib.Name = "RichTextBMib"
        Me.RichTextBMib.ReadOnly = True
        Me.RichTextBMib.Size = New System.Drawing.Size(686, 447)
        Me.RichTextBMib.TabIndex = 6
        Me.RichTextBMib.Text = ""
        '
        'FrmObjetosMibs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 740)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "FrmObjetosMibs"
        Me.Text = "Navegador Mibs"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DGVMibs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxOid.ResumeLayout(False)
        Me.GroupBoxOid.PerformLayout()
        Me.GroupBoxAcceso.ResumeLayout(False)
        Me.GroupBoxAcceso.PerformLayout()
        Me.GroupBoxSyntaxis.ResumeLayout(False)
        Me.GroupBoxSyntaxis.PerformLayout()
        Me.GroupBoxEstado.ResumeLayout(False)
        Me.GroupBoxEstado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Arbol_RDBMS_Mib As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents RichTextBMib As System.Windows.Forms.RichTextBox
    Friend WithEvents DGVMibs As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBoxOid As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxAcceso As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxAcceso As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxSyntaxis As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxSyntaxis As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents IdentificadorMib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathHumano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdObj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Objetos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

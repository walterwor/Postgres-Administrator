<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRediseño
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBoxConexion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxOID = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CboBoxDuracion = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxComunidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboBoxVersion = New System.Windows.Forms.ComboBox()
        Me.TextBoxPuerto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboBoxFrecuencia = New System.Windows.Forms.ComboBox()
        Me.TextBoxResultados = New System.Windows.Forms.TextBox()
        Me.GroupBoxSalir = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonGet = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonDetener = New System.Windows.Forms.Button()
        Me.ButtonGetNext = New System.Windows.Forms.Button()
        Me.GroupBoxMib = New System.Windows.Forms.GroupBox()
        Me.LabelMasInf = New System.Windows.Forms.Label()
        Me.Arbol_RDBMS_Mib = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBoxOperaciones = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxConexion.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBoxSalir.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxMib.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxConexion
        '
        Me.GroupBoxConexion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxConexion.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBoxConexion.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxConexion.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxConexion.Name = "GroupBoxConexion"
        Me.GroupBoxConexion.Size = New System.Drawing.Size(772, 229)
        Me.GroupBoxConexion.TabIndex = 45
        Me.GroupBoxConexion.TabStop = False
        Me.GroupBoxConexion.Text = "Datos de conexión"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(766, 210)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxOID, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CboBoxDuracion, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(386, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(377, 204)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Duración"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Identificador de Objetos"
        '
        'TextBoxOID
        '
        Me.TextBoxOID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxOID.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxOID.Location = New System.Drawing.Point(200, 3)
        Me.TextBoxOID.Multiline = True
        Me.TextBoxOID.Name = "TextBoxOID"
        Me.TextBoxOID.Size = New System.Drawing.Size(164, 95)
        Me.TextBoxOID.TabIndex = 28
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(85, 48)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(84, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(84, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'CboBoxDuracion
        '
        Me.CboBoxDuracion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CboBoxDuracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBoxDuracion.FormattingEnabled = True
        Me.CboBoxDuracion.Location = New System.Drawing.Point(200, 142)
        Me.CboBoxDuracion.Name = "CboBoxDuracion"
        Me.CboBoxDuracion.Size = New System.Drawing.Size(164, 21)
        Me.CboBoxDuracion.TabIndex = 33
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.80208!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.19792!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxHost, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxComunidad, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.CboBoxVersion, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxPuerto, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.CboBoxFrecuencia, 1, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(377, 204)
        Me.TableLayoutPanel3.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Frecuencia"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Host"
        '
        'TextBoxHost
        '
        Me.TextBoxHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxHost.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxHost.Location = New System.Drawing.Point(149, 10)
        Me.TextBoxHost.Name = "TextBoxHost"
        Me.TextBoxHost.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxHost.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Puerto"
        '
        'TextBoxComunidad
        '
        Me.TextBoxComunidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxComunidad.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxComunidad.Location = New System.Drawing.Point(149, 130)
        Me.TextBoxComunidad.Name = "TextBoxComunidad"
        Me.TextBoxComunidad.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxComunidad.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cadena de comunidad"
        '
        'CboBoxVersion
        '
        Me.CboBoxVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBoxVersion.FormattingEnabled = True
        Me.CboBoxVersion.Location = New System.Drawing.Point(149, 89)
        Me.CboBoxVersion.Name = "CboBoxVersion"
        Me.CboBoxVersion.Size = New System.Drawing.Size(225, 21)
        Me.CboBoxVersion.TabIndex = 28
        '
        'TextBoxPuerto
        '
        Me.TextBoxPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPuerto.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxPuerto.Location = New System.Drawing.Point(149, 50)
        Me.TextBoxPuerto.Name = "TextBoxPuerto"
        Me.TextBoxPuerto.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxPuerto.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Version"
        '
        'CboBoxFrecuencia
        '
        Me.CboBoxFrecuencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboBoxFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBoxFrecuencia.FormattingEnabled = True
        Me.CboBoxFrecuencia.Location = New System.Drawing.Point(149, 171)
        Me.CboBoxFrecuencia.Name = "CboBoxFrecuencia"
        Me.CboBoxFrecuencia.Size = New System.Drawing.Size(225, 21)
        Me.CboBoxFrecuencia.TabIndex = 37
        '
        'TextBoxResultados
        '
        Me.TextBoxResultados.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultados.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResultados.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultados.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxResultados.Multiline = True
        Me.TextBoxResultados.Name = "TextBoxResultados"
        Me.TextBoxResultados.ReadOnly = True
        Me.TextBoxResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxResultados.Size = New System.Drawing.Size(586, 415)
        Me.TextBoxResultados.TabIndex = 8
        '
        'GroupBoxSalir
        '
        Me.GroupBoxSalir.Controls.Add(Me.ButtonSalir)
        Me.GroupBoxSalir.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBoxSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxSalir.Location = New System.Drawing.Point(781, 659)
        Me.GroupBoxSalir.Name = "GroupBoxSalir"
        Me.GroupBoxSalir.Size = New System.Drawing.Size(586, 88)
        Me.GroupBoxSalir.TabIndex = 62
        Me.GroupBoxSalir.TabStop = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(451, 38)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 13
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(91, 38)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(160, 23)
        Me.ButtonLimpiar.TabIndex = 12
        Me.ButtonLimpiar.Text = "Limpiar resultados"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxResultados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(781, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 415)
        Me.Panel1.TabIndex = 61
        '
        'ButtonGet
        '
        Me.ButtonGet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonGet.Location = New System.Drawing.Point(50, 38)
        Me.ButtonGet.Name = "ButtonGet"
        Me.ButtonGet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGet.TabIndex = 9
        Me.ButtonGet.Text = "Get"
        Me.ButtonGet.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ButtonDetener
        '
        Me.ButtonDetener.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDetener.Location = New System.Drawing.Point(335, 38)
        Me.ButtonDetener.Name = "ButtonDetener"
        Me.ButtonDetener.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDetener.TabIndex = 10
        Me.ButtonDetener.Text = "Detener"
        Me.ButtonDetener.UseVisualStyleBackColor = True
        '
        'ButtonGetNext
        '
        Me.ButtonGetNext.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonGetNext.Enabled = False
        Me.ButtonGetNext.Location = New System.Drawing.Point(620, 38)
        Me.ButtonGetNext.Name = "ButtonGetNext"
        Me.ButtonGetNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetNext.TabIndex = 11
        Me.ButtonGetNext.Text = "GetNext"
        Me.ButtonGetNext.UseVisualStyleBackColor = True
        '
        'GroupBoxMib
        '
        Me.GroupBoxMib.Controls.Add(Me.LabelMasInf)
        Me.GroupBoxMib.Controls.Add(Me.Arbol_RDBMS_Mib)
        Me.GroupBoxMib.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMib.Location = New System.Drawing.Point(781, 3)
        Me.GroupBoxMib.Name = "GroupBoxMib"
        Me.GroupBoxMib.Size = New System.Drawing.Size(586, 229)
        Me.GroupBoxMib.TabIndex = 47
        Me.GroupBoxMib.TabStop = False
        Me.GroupBoxMib.Text = "rdbms - Mib"
        '
        'LabelMasInf
        '
        Me.LabelMasInf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMasInf.AutoSize = True
        Me.LabelMasInf.Location = New System.Drawing.Point(448, 213)
        Me.LabelMasInf.Name = "LabelMasInf"
        Me.LabelMasInf.Size = New System.Drawing.Size(122, 13)
        Me.LabelMasInf.TabIndex = 24
        Me.LabelMasInf.Text = "Click aqui para más inf..."
        '
        'Arbol_RDBMS_Mib
        '
        Me.Arbol_RDBMS_Mib.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Arbol_RDBMS_Mib.Location = New System.Drawing.Point(19, 37)
        Me.Arbol_RDBMS_Mib.Name = "Arbol_RDBMS_Mib"
        Me.Arbol_RDBMS_Mib.Size = New System.Drawing.Size(551, 157)
        Me.Arbol_RDBMS_Mib.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86131!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.13869!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxConexion, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMib, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxOperaciones, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxSalir, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.84559!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.15441!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1370, 750)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 2
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin3
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 238)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(772, 415)
        Me.Chart1.TabIndex = 48
        Me.Chart1.TabStop = False
        Me.Chart1.Text = "Chart1"
        '
        'GroupBoxOperaciones
        '
        Me.GroupBoxOperaciones.Controls.Add(Me.ButtonGetNext)
        Me.GroupBoxOperaciones.Controls.Add(Me.ButtonDetener)
        Me.GroupBoxOperaciones.Controls.Add(Me.ButtonGet)
        Me.GroupBoxOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxOperaciones.Location = New System.Drawing.Point(3, 659)
        Me.GroupBoxOperaciones.Name = "GroupBoxOperaciones"
        Me.GroupBoxOperaciones.Size = New System.Drawing.Size(772, 88)
        Me.GroupBoxOperaciones.TabIndex = 59
        Me.GroupBoxOperaciones.TabStop = False
        Me.GroupBoxOperaciones.Text = "Operaciones"
        '
        'FrmRediseño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmRediseño"
        Me.Text = "Operaciones con Graficos"
        Me.GroupBoxConexion.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBoxSalir.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxMib.ResumeLayout(False)
        Me.GroupBoxMib.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxConexion As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxResultados As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxSalir As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.Button
    Friend WithEvents ButtonGet As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonDetener As System.Windows.Forms.Button
    Friend WithEvents ButtonGetNext As System.Windows.Forms.Button
    Friend WithEvents GroupBoxMib As System.Windows.Forms.GroupBox
    Friend WithEvents LabelMasInf As System.Windows.Forms.Label
    Friend WithEvents Arbol_RDBMS_Mib As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBoxOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOID As System.Windows.Forms.TextBox
    Friend WithEvents CboBoxDuracion As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxComunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboBoxVersion As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxPuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboBoxFrecuencia As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

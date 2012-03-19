Imports System.IO
Imports Negocios.Negocios
Imports Entidades
Imports System
Imports SnmpSharpNet
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmRediseño

#Region "Definiciones"
    Dim vNombreNodoSelect As String
    Private Reloj As New Timer
    Dim vControlador As Double
    Private Property ValorMinimo As Date
    Private Property ValorMaximo As Date
    Dim ObjLectorArchivo As StreamReader
    Dim strRutaLocal As String
    Dim ArchivoStream As FileStream
#End Region

#Region "Eventos"

    Private Sub ButtonGet_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGet.Click
        If TextBoxOID.Text = "" Or TextBoxComunidad.Text = "" Or TextBoxPuerto.Text = "" Or TextBoxHost.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation)
        Else
            ButtonGet.Enabled = False
            ButtonDetener.Enabled = True
            ConfigChart()
            InicioConteo()
        End If
    End Sub

    'Private Sub TextBoxResultados_DoubleClick(sender As Object, e As System.EventArgs) Handles TextBoxResultados.DoubleClick
    '    Select Case Arbol_RDBMS_Mib.SelectedNode.Name
    '        Case "rdbmsMIB" '+
    '            TextBoxOID.Text = "1.3.6.1.2.1.39"
    '        Case "rdbmsObjects" '++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1"
    '        Case "rdbmsDbTable" '+++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1"
    '        Case "rdbmsDbEntry" '++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1"
    '        Case "rdbmsDbIndex" '+++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1.1"
    '        Case "rdbmsDbPrivateMibOID" '+++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1.2"
    '        Case "rdbmsDbVendorName" '+++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1.3"
    '        Case "rdbmsDbName" '+++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1.4"
    '        Case "rdbmsDbContact" '+++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.1.1.5"
    '        Case "rdbmsDbInfoTable" '+++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2"
    '        Case "rdbmsDbInfoEntry" '++++
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1"
    '        Case "rdbmsDbInfoProductName"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.1"
    '        Case "rdbmsDbInfoVersion"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.2"
    '        Case "rdbmsDbInfoSizeUnits"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.3"
    '        Case "rdbmsDbInfoSizeAllocated"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.4"
    '        Case "rdbmsDbInfoSizeUsed"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.5"
    '        Case "rdbmsDbInfoLastBackup"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.6"
    '        Case "rdbmsDbParamTable"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3"
    '        Case "rdbmsDbParamEntry"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1"
    '        Case "rdbmsDbParamName"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1.1"
    '        Case "rdbmsDbParamSubIndex"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1.2"
    '        Case "rdbmsDbParamID"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1.3"
    '        Case "rdbmsDbParamCurrValue"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1.4"
    '        Case "rdbmsDbParamComment"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.3.1.5"
    '        Case "rdbmsDbLimitedResourceTable"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4"
    '        Case "rdbmsDbLimitedResourceEntry"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1"
    '        Case "rdbmsDbLimitedResourceName"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.1"
    '        Case "rdbmsDbLimitedResourceID"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.2"
    '        Case "rdbmsDbLimitedResourceLimit"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.3"
    '        Case "rdbmsDbLimitedResourceCurrent"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.4"
    '        Case "rdbmsDbLimitedResourceHighwater"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.5"
    '        Case "rdbmsDbLimitedResourceFailures"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.6"
    '        Case "rdbmsDbLimitedResourceDescription"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.4.1.7"
    '        Case "rdbmsSrvTable"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5"
    '        Case "rdbmsSrvEntry"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5.1"
    '        Case "rdbmsSrvPrivateMibOID"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5.1.1"
    '        Case "rdbmsSrvVendorName"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5.1.2"
    '        Case "rdbmsSrvProductName"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5.1.3"
    '        Case "rdbmsSrvContact"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.5.1.4"
    '        Case "rdbmsSrvInfoTable"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6"
    '        Case "rdbmsSrvInfoEntry"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6.1"
    '        Case "rdbmsSrvInfoStartupTime"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6.1.1"
    '        Case "rdbmsSrvInfoHandledRequests"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6.1.10"
    '        Case "rdbmsSrvInfoRequestRecvs"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6.1.11"
    '        Case "rdbmsSrvInfoRequestSends"
    '            TextBoxOID.Text = "1.3.6.1.2.1.39.1.6.1.12"
    '            'Case ""
    '            '    TextBoxOid.Text = "Identificador de Objeto: ====>" & Chr(10) & "1.3.6.1.2.1.39.1.6.1.12"
    '            '    RichTextBMib.SelectionStart = RichTextBMib.Find("")
    '    End Select
    'End Sub

    Private Sub ButtonLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLimpiar.Click
        TextBoxResultados.Clear()
    End Sub

    Private Sub EventoTick()
        vControlador += Val(CboBoxFrecuencia.SelectedItem) * 1000
        If (Val(CboBoxDuracion.SelectedItem) * 60) * 1000 <> vControlador Then
            OperacionGet()
        Else
            OperacionGet()
            Reloj.Enabled = False ' Reloj.Stop()
            ButtonGet.Enabled = True
            ButtonDetener.Enabled = False
        End If
    End Sub

    Private Sub FrmRediseño_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If TextBoxOID.Text <> "" Or TextBoxComunidad.Text <> "" Or TextBoxPuerto.Text <> "" Or TextBoxHost.Text <> "" Then
            MDIsnmp.SaveAsToolStripMenuItem.Enabled = False
            MDIsnmp.SaveToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub FrmRediseño_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = False
        MDIsnmp.SaveToolStripMenuItem.Enabled = False
        If Not ObjLectorArchivo Is Nothing Then ObjLectorArchivo.Close()
    End Sub

    Private Sub FrmRediseño_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'CargarComboVersion()
        ArmarArbol()
    End Sub

    Private Sub Arbol_RDBMS_Mib_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles Arbol_RDBMS_Mib.AfterSelect
        Try
            'ANALIZAR PARA LOS DATOS DE TIPO COUNTER32 
            TextBoxOID.Clear()
            If IsNothing((CType(e.Node.Tag, Objetos).IdObj)) = False And (CType(e.Node.Tag, Objetos).Sintaxis).ToString.StartsWith("INTEGER") = False Then
                MsgBox("Seleccione un Identificador de Objeto de tipo Integer", MsgBoxStyle.Exclamation)
            Else
                TextBoxOID.Text = (CType(e.Node.Tag, Objetos).IdObj)
                If IsNothing((CType(e.Node.Tag, Objetos).Nombre)) = False Then vNombreNodoSelect = (CType(e.Node.Tag, Objetos).Nombre)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonDetener_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDetener.Click
        ButtonGet.Enabled = True
        Reloj.Enabled = False
    End Sub

    Private Sub ButtonSalir_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub TextBoxOID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOID.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBoxPuerto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPuerto.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBoxPuerto_TextChanged(sender As Object, e As System.EventArgs) Handles TextBoxPuerto.TextChanged
        If Val(TextBoxPuerto.Text) > 0 And Val(TextBoxPuerto.Text) < 65536 Then
        Else
            MsgBox("El nro. de puerto debe estar comprendido entre 0 y 65536")
        End If
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBoxHost_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxHost.TextChanged
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBoxComunidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxComunidad.TextChanged
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBoxOID_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxOID.TextChanged
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        On Error Resume Next
        Select Case Me.ActiveControl.Name
            Case "TextBoxHost"
                Clipboard.SetText(Me.TextBoxHost.SelectedText)
            Case "TextBoxOID"
                Clipboard.SetText(Me.TextBoxOID.SelectedText)
            Case "TextBoxPuerto"
                Clipboard.SetText(Me.TextBoxPuerto.SelectedText)
            Case "TextBoxResultados"
                Clipboard.SetText(Me.TextBoxResultados.SelectedText)
            Case "TextBoxComunidad"
                Clipboard.SetText(Me.TextBoxComunidad.SelectedText)
            Case "Arbol_RDBMS_Mib"
                Clipboard.SetText(vNombreNodoSelect) 'Me.Arbol_RDBMS_Mib.SelectedNode.Name.ToString)
        End Select
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        On Error Resume Next
        Select Case Me.ActiveControl.Name
            Case "TextBoxHost"
                Me.TextBoxHost.Text = Clipboard.GetText
            Case "TextBoxOID"
                Me.TextBoxOID.Text = Clipboard.GetText
            Case "TextBoxPuerto"
                Me.TextBoxPuerto.Text = Clipboard.GetText
            Case "TextBoxComunidad"
                Me.TextBoxComunidad.Text = Clipboard.GetText
        End Select

    End Sub


#End Region

#Region "Operaciones"

    Private Sub CargarComboVersion()
        Dim I As Integer
        For I = 0 To 2
            If I = 1 Then
                CboBoxVersion.Items.Insert(I, I + 1 & "c")
            Else
                CboBoxVersion.Items.Insert(I, I + 1)
            End If
        Next I
        CboBoxVersion.SelectedIndex = 0
    End Sub

    Public Sub CargarComboFre()
        Dim I, J As Integer
        J = 0
        For I = 0 To 9
            J = 30 * (I + 1)
            CboBoxFrecuencia.Items.Insert(I, J & "  Seg.") 'Cada 30 seg
        Next I
        CboBoxFrecuencia.SelectedIndex = 0
    End Sub

    Public Sub CargarComboDur()
        Dim I, J As Integer
        J = 0
        For I = 0 To 29
            J = I + 1 ' 30 ' * (I + 1)
            CboBoxDuracion.Items.Insert(I, J & "  Min.") 'Cada 30 seg
        Next I
        CboBoxDuracion.SelectedIndex = 0
    End Sub

    Private Sub ConfigChart()


        'Predefine el area de vista del objeto chart 
        ValorMinimo = DateTime.Now
        ValorMaximo = ValorMinimo.AddSeconds(120)

        'Chart1.ChartAreas(0).AxisX.IntervalOffsetType = DateTimeIntervalType.Seconds
        Chart1.ChartAreas(0).AxisX.Minimum = ValorMinimo.ToOADate()
        Chart1.ChartAreas(0).AxisX.Maximum = ValorMaximo.ToOADate()
        'Chart1.ChartAreas(0).AxisX.IsStartedFromZero = True

        'borra las series por defecto del objeto chart.
        Chart1.Series.Clear()

        'creo la serie personalizada
        Dim newSeries As New Series("Series1")
        newSeries.ChartType = SeriesChartType.Spline 'line
        newSeries.BorderWidth = 2
        'newSeries.Color = Color.Bisque
        newSeries.XValueType = ChartValueType.Time
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm:ss" ' area.AxisX.LabelStyle.Format = "HH:mm:ss"
        Chart1.Series.Add(newSeries)
    End Sub

    Private Sub OperacionGet()
        Try
            'Dim TiempoFuera As Integer = 2500 '2500 ms = 2,5 min
            Dim Host As String = TextBoxHost.Text
            Dim Community As String = TextBoxComunidad.Text '"public"
            Dim Puerto As String = TextBoxPuerto.Text
            Dim RequestOid() As String
            Dim Result As Dictionary(Of Oid, AsnType)
            Dim ObjIden As Oid = New Oid(TextBoxOID.Text)
            RequestOid = New String() {ObjIden.ToString}
            Dim snmp As SimpleSnmp = New SimpleSnmp(Host, Puerto, Community) ', TiempoFuera, 0) 'Timeout value in milliseconds, 0(cero) equivale a una(1) retransmicion
            Result = snmp.Get(CboBoxVersion.SelectedIndex, RequestOid) 'Result = snmp.Get(SnmpVersion.Ver2 , RequestOid)
            If Result IsNot Nothing Then
                Dim kvp As KeyValuePair(Of Oid, AsnType)
                TextBoxResultados.AppendText(vbCrLf)
                TextBoxResultados.AppendText("-- Operacion Get --")
                For Each kvp In Result
                    TextBoxResultados.AppendText(SnmpConstants.GetTypeName(kvp.Value.Type) & vbCrLf) 'Chr(10))
                    TextBoxResultados.AppendText(kvp.Value.ToString() & vbCrLf) 'Chr(10))
                    TextBoxResultados.AppendText("---" & vbCrLf) 'Chr(10))
                    If kvp.Value.ToString Is "null" Then
                        kvp.Value.ToString()

                    End If
                    Dim timeStamp As DateTime = DateTime.Now
                    Dim ptSeries As Series
                    For Each ptSeries In Chart1.Series
                        'AddNewPoint(Cronometro.ElapsedMilliseconds, ptSeries, kvp.Value.ToString)
                        'AddNewPoint(valor, ptSeries, CDbl(kvp.Value.ToString))
                        AddNewPoint(timeStamp, ptSeries, CDbl(kvp.Value.ToString))
                    Next ptSeries
                Next
            Else
                TextBoxResultados.Text = ("Sin resultados.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AddNewPoint(timeStamp As DateTime, ptSeries As System.Windows.Forms.DataVisualization.Charting.Series, ByVal MibVal As Double)
        Dim newVal As Double = 0
        If ptSeries.Points.Count > 0 Then
            newVal = ptSeries.Points((ptSeries.Points.Count - 1)).YValues(0) + (MibVal) '(indice * 2 - 1)
        End If

        ptSeries.Points.AddXY(timeStamp.ToOADate, MibVal)

        'remueve todos los puntos de la serie mayores a 1.5 minutos --------------------
        Dim removeBefore As Double = timeStamp.AddSeconds((CDbl(90) * -1)).ToOADate()
        'remove oldest values to maintain a constant number of data points
        While ptSeries.Points(0).XValue < removeBefore
            ptSeries.Points.RemoveAt(0)
        End While
        ' fin remove ------------------------------------------------------------------
        Chart1.ChartAreas(0).AxisX.Minimum = ptSeries.Points(0).XValue
        Chart1.ChartAreas(0).AxisX.Maximum = DateTime.FromOADate(ptSeries.Points(0).XValue).AddMinutes(2).ToOADate()
        Chart1.Invalidate()

    End Sub 'AddNewPoint

    Private Sub InicioConteo()
        AddHandler Reloj.Tick, AddressOf EventoTick
        Reloj.Interval = CDbl(Val(CboBoxFrecuencia.SelectedItem)) * 1000 'paso el valor del combo a milisegundos, con esta prop le digo la frecuencia con la que de desencadena el evento tick
        Reloj.Enabled = True ' .Start() 'enabled
        OperacionGet()
    End Sub

    Private Sub ArmarArbol()
        Dim llamar As New ArmarArboles
        llamar.Armar(".1.3.6.1.2.1.39", Arbol_RDBMS_Mib)
    End Sub

    Public Sub GuardarComo()
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de PostgresAdministrator (*.pgadmg)|*.pgadmg|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            'FrmDos.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Using outfile As New StreamWriter(SaveFileDialog.FileName, False)
                outfile.WriteLine("---------------------------------------------------------------------------------")
                outfile.WriteLine(" ---PARAMETROS Y RESULTADOS UTILIZADOS EN LA EJECUCION DE OPERACIONES SNMP---")
                outfile.WriteLine("----ATENCION: No modifique este archivo, de lo contrario no podra utilizarlo-----")
                outfile.WriteLine("Formulario: Operaciones")
                outfile.WriteLine("Host: " & TextBoxHost.Text)
                outfile.WriteLine("Puerto: " & TextBoxPuerto.Text)
                outfile.WriteLine("Versión SNMP: " & CboBoxVersion.SelectedItem)
                outfile.WriteLine("Cadena de Comunidad: " & TextBoxComunidad.Text)
                outfile.WriteLine("Identificador de Objeto Evaluado: " & TextBoxOID.Text)
                outfile.WriteLine("Frecuencia: " & CboBoxFrecuencia.SelectedItem)
                outfile.WriteLine("Duracion: " & CboBoxDuracion.SelectedItem)
                outfile.WriteLine("--------------------------------------------------------------------------------")
                outfile.WriteLine("Resultados de la ejecucion: ")
                'Dim I As Integer = 0
                For Each linea In TextBoxResultados.Lines
                    outfile.WriteLine(linea.ToString) 'outfile.WriteLine(I & " " & linea.ToString)
                Next
                outfile.WriteLine("--------------------------------------------------------------------------------")
                outfile.WriteLine("---ATENCION: No modifique este archivo, de lo contrario no podra utilizarlo-----")
                outfile.WriteLine(Now)
            End Using
        End If
    End Sub

    Public Sub GuardarArchivo()
        If ObjLectorArchivo Is Nothing Then
            GuardarComo()
        Else
            ObjLectorArchivo.Dispose() 'libero al archivo asociado al objeto streamreader de modo que permita al streamWriter siguiente poder escribir el archivo
            Using outfile As New StreamWriter(strRutaLocal, False) 'Using outfile As New StreamWriter(ArchivoStream) '(SaveFileDialog.FileName , True)
                outfile.WriteLine("---------------------------------------------------------------------------------")
                outfile.WriteLine(" ---PARAMETROS Y RESULTADOS UTILIZADOS EN LA EJECUCION DE OPERACIONES SNMP---")
                outfile.WriteLine("----ATENCION: No modifique este archivo, de lo contrario no podra utilizarlo-----")
                outfile.WriteLine("Formulario: Operaciones")
                outfile.WriteLine("Host: " & TextBoxHost.Text)
                outfile.WriteLine("Puerto: " & TextBoxPuerto.Text)
                outfile.WriteLine("Versión SNMP: " & CboBoxVersion.SelectedItem)
                outfile.WriteLine("Cadena de Comunidad: " & TextBoxComunidad.Text)
                outfile.WriteLine("Identificador de Objeto Evaluado: " & TextBoxOID.Text)
                outfile.WriteLine("Frecuencia: " & CboBoxFrecuencia.SelectedItem)
                outfile.WriteLine("Duracion: " & CboBoxDuracion.SelectedItem)
                outfile.WriteLine("--------------------------------------------------------------------------------")
                outfile.WriteLine("Resultados de la ejecucion: ")
                'Dim I As Integer = 0
                For Each linea In TextBoxResultados.Lines
                    outfile.WriteLine(linea.ToString) '(I & " " & linea.ToString)
                Next
                outfile.WriteLine("--------------------------------------------------------------------------------")
                outfile.WriteLine("---ATENCION: No modifique este archivo, de lo contrario no podra utilizarlo-----")
                outfile.WriteLine(Now)
            End Using
        End If
    End Sub

    Public Function AbrirArchivo() As Boolean
        Dim listaLine As New List(Of String)
        Dim contLinea As Int32 = 1
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.pgadmg)|*.pgadmg"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                strRutaLocal = OpenFileDialog.FileName 'rescato el nombre del archivo que sera utilizado en el streamWriter al momento de guardar.
                ArchivoStream = File.Open(OpenFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read) 'abre el archivo y detecta cualesquiera errores mediante un controlador 
                ObjLectorArchivo = New StreamReader(ArchivoStream)
                Dim StrLinea As String = Nothing
                Cursor = Cursors.WaitCursor

                Do Until ObjLectorArchivo.EndOfStream = True
                    StrLinea = ObjLectorArchivo.ReadLine()
                    If StrLinea.Length = 0 Then
                        StrLinea = " "
                    End If
                    Select Case contLinea
                        Case 5
                            TextBoxHost.Text = Mid(StrLinea, 7, StrLinea.Length - 6)
                        Case 6
                            TextBoxPuerto.Text = Mid(StrLinea, 9, StrLinea.Length - 8)
                        Case 7
                            If CboBoxVersion.Items.Count = 0 Then CargarComboVersion()
                            CboBoxVersion.SelectedItem = Mid(StrLinea, 15, StrLinea.Length - 14)
                        Case 8
                            TextBoxComunidad.Text = Mid(StrLinea, 22, StrLinea.Length - 21)
                        Case 9
                            TextBoxOID.Text = Mid(StrLinea, 35, StrLinea.Length - 34)
                        Case 10
                            If CboBoxFrecuencia.Items.Count = 0 Then CargarComboFre()
                            CboBoxFrecuencia.SelectedItem = Mid(StrLinea, 13, StrLinea.Length - 12)
                        Case 11
                            If CboBoxDuracion.Items.Count = 0 Then CargarComboDur()
                            CboBoxDuracion.SelectedItem = Mid(StrLinea, 11, StrLinea.Length - 10)
                        Case Is > 12

                            listaLine.Add(Mid(StrLinea, 1, StrLinea.Length - 1))
                    End Select
                    contLinea += 1
                Loop
                TextBoxResultados.Clear()
                Dim J As Integer
                For J = 1 To listaLine.Count - 4 'ArrayResult 'descarto las ultimas 3 lineas de ya q son las que contienen la advertencia y la fecha
                    TextBoxResultados.AppendText(listaLine.Item(J).ToString & vbCrLf)
                Next
                Return True
            Catch exec As Exception
                MsgBox(exec.Message & Chr(13) & exec.StackTrace, MsgBoxStyle.Critical)
                ObjLectorArchivo.Dispose()
                Return False
            Finally
                Cursor = Cursors.Default
            End Try
        Else
            Return False
        End If
    End Function

#End Region

End Class
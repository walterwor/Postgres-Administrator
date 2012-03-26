Imports System.IO
Imports System
Imports SnmpSharpNet 'libreria necesaria para poder ejecutar las operaciones snmp
Imports Negocios.Negocios
Imports Entidades

Public Class FrmOperaciones

#Region "Definiciones"
    'TextBoxOID.Text = "1.3.6.1.2.1.39.1.2.1.5.16384"
    Dim vNombreNodoSelect As String
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
            OperacionGet()
            ButtonGet.Enabled = True
        End If
    End Sub

    Private Sub ButtonSet_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSet.Click
        If TextBoxOID.Text = "" Or TextBoxComunidad.Text = "" Or TextBoxPuerto.Text = "" Or TextBoxHost.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation)
        Else
            OperacionSet()
        End If
    End Sub

    Private Sub ButtonGetNext_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGetNext.Click
        If TextBoxOID.Text = "" Or TextBoxComunidad.Text = "" Or TextBoxPuerto.Text = "" Or TextBoxHost.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation)
        Else
            ButtonGetNext.Enabled = False
            OperacionGetNext()
            ButtonGetNext.Enabled = True
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLimpiar.Click
        TextBoxResultados.Clear()
    End Sub

    Private Sub FrmOperaciones_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If TextBoxOID.Text <> "" Or TextBoxComunidad.Text <> "" Or TextBoxPuerto.Text <> "" Or TextBoxHost.Text <> "" Then
            MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
            MDIsnmp.SaveToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub FrmOperaciones_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = False
        MDIsnmp.SaveToolStripMenuItem.Enabled = False
        If Not ObjLectorArchivo Is Nothing Then ObjLectorArchivo.Close()
      

    End Sub

    Private Sub FrmOperaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ArmarArbol()
        'CargarComboVersion()
    End Sub

    Private Sub Arbol_RDBMS_Mib_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles Arbol_RDBMS_Mib.AfterSelect
        Try
            TextBoxOID.Clear()
            If IsNothing((CType(e.Node.Tag, Objetos).IdObj)) = False Then TextBoxOID.Text = (CType(e.Node.Tag, Objetos).IdObj)
            If IsNothing((CType(e.Node.Tag, Objetos).Nombre)) = False Then vNombreNodoSelect = (CType(e.Node.Tag, Objetos).Nombre)
        Catch ex As Exception

        End Try
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

    Private Sub TextBoxPuerto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxPuerto.TextChanged
        If Val(TextBoxPuerto.Text) > 0 And Val(TextBoxPuerto.Text) < 65536 Then
        Else
            MsgBox("El nro. de puerto debe estar comprendido entre 0 y 65536")
        End If
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ButtonSalir_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub TextBoxHost_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxHost.TextChanged
        MDIsnmp.SaveAsToolStripMenuItem.Enabled = True
        MDIsnmp.SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBoxComunidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxComunidad.TextChanged
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

    Private Sub OperacionGetNext()
        Cursor = Cursors.WaitCursor
        Dim Host As String = TextBoxHost.Text
        Dim Community As String = TextBoxComunidad.Text '"public"
        Dim Puerto As String = TextBoxPuerto.Text
        Dim RequestOid() As String
        Dim Result As Dictionary(Of Oid, AsnType)
        Dim rootOid As Oid = New Oid(TextBoxOID.Text) '("1.3.6.1.2.1.39.1.6") '("1.3.6.1.2.1.1")
        Dim nextOid As Oid = rootOid
        Dim CtrlItera As Boolean = True
        RequestOid = New String() {rootOid.ToString()}
        Dim tiempo As Integer = 3500

        Dim snmp As SimpleSnmp = New SimpleSnmp(Host, Puerto, Community, tiempo, 2)
        If Not snmp.Valid Then
            MsgBox("Invalid hostname/community.")
            Exit Sub
        End If
        TextBoxResultados.AppendText(vbCrLf)
        TextBoxResultados.AppendText("-- Operacion GetNext --")
        While CtrlItera
            Result = snmp.GetNext(CboBoxVersion.SelectedIndex, New String() {nextOid.ToString()}) 'Result = snmp.GetNext(SnmpVersion.Ver2, New String() {nextOid.ToString()})
            If Result IsNot Nothing Then

                'Dim octeto As Oid = New Oid(TextBoxOID.Text) 'analizo esto xq para una operacon next es necesario que el nodo seleccionado tenga hojas
                'If rootOid.IsRootOf(octeto) = False Then 'no funciona analizando esto, 
                '    TextBoxResultados.AppendText("-- Seleccione un nodo del arbol que posea ramas. --")
                '    Exit While
                'End If
                Dim kvp As KeyValuePair(Of Oid, AsnType)
                For Each kvp In Result
                    If rootOid.IsRootOf(kvp.Key) Then
                        TextBoxResultados.AppendText(vbCrLf)
                        TextBoxResultados.AppendText("--" & "|| " & kvp.Key.ToString() & " ||" & _
                                              SnmpConstants.GetTypeName(kvp.Value.Type) & "||" & _
                                              kvp.Value.ToString() & vbCrLf) 'Chr(10))
                        TextBoxResultados.AppendText("---" & vbCrLf) '  Chr(10))
                        nextOid = kvp.Key
                    Else

                        CtrlItera = False
                    End If
                Next
            Else
                MsgBox("No results received.")
                CtrlItera = False
            End If
        End While
        Cursor = Cursors.Default
    End Sub

    Private Sub OperacionGet()
        Cursor = Cursors.WaitCursor
        Dim Host As String = TextBoxHost.Text
        Dim Community As String = TextBoxComunidad.Text '"public"
        Dim Puerto As String = TextBoxPuerto.Text
        Dim RequestOid() As String
        Dim Result As Dictionary(Of Oid, AsnType)
        Dim ObjIden As Oid = New Oid(TextBoxOID.Text)
        RequestOid = New String() {ObjIden.ToString}
        Dim snmp As SimpleSnmp = New SimpleSnmp(Host, Puerto, Community) 'Timeout value in milliseconds
        'Result = snmp.Get(Version, RequestOid) 'Result = snmp.Get(SnmpVersion.Ver2, RequestOid)
        Result = snmp.Get(CboBoxVersion.SelectedIndex, RequestOid)
        If Result IsNot Nothing Then
            Dim kvp As KeyValuePair(Of Oid, AsnType)
            TextBoxResultados.AppendText(vbCrLf)
            TextBoxResultados.AppendText("-- Operacion Get --")
            For Each kvp In Result
                'TextBoxResultados.AppendText("{0}: ({1}) {2}" & kvp.Key.ToString() & SnmpConstants.GetTypeName(kvp.Value.Type) & kvp.Value.ToString())
                TextBoxResultados.AppendText("--" & "|| " & kvp.Key.ToString() & " ||" & _
                                             SnmpConstants.GetTypeName(kvp.Value.Type) & " = " & _
                                             kvp.Value.ToString() & vbCrLf) 'Chr(10))
                TextBoxResultados.AppendText("---" & vbCrLf) 'Chr(10))
            Next
        Else
            TextBoxResultados.Text = ("Sin resultados.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub OperacionSet()
        'Dim target = New UdpTarget(New IpAddress("some-host"), 161, 1000, 0)
        Dim Objetivo = New UdpTarget(New IpAddress(TextBoxHost.Text), TextBoxPuerto.Text, 1000, 0) ' preparar el objetivo - Prepare target
        Dim pdu = New Pdu(PduType.Set) ' crear una PDU para una operacion SET 
        'pdu.VbList.Add(New Oid("1.3.6.1.2.1.1.6.0"), New OctetString("Test description"))' Set sysLocation.0 to a new string
        pdu.VbList.Add(New Oid(TextBoxOID.Text), New OctetString("Admini")) 'crea la variable Binding con el Par de valores OID = Valor - 
        ' Set Agent security parameters
        'Dim aparam = New AgentParameters(SnmpVersion.Ver2, New OctetString("private"))
        Dim Param = New AgentParameters(CboBoxVersion.SelectedIndex, New OctetString(TextBoxComunidad.Text))
        ' Response packet
        Dim response As SnmpV2Packet
        Try
            ' Send request and wait for response
            response = Objetivo.Request(pdu, Param)
        Catch ex As Exception
            ' If exception happens, it will be returned here
            MsgBox(String.Format("Exception: {0}", ex.Message), MsgBoxStyle.Critical)
            Objetivo.Close()
            Return
        End Try
        TextBoxResultados.AppendText("-- Operacion Set --")
        ' Make sure we received a response
        If response Is Nothing Then
            MsgBox("Error en el envío de la solicitud SNMP.")
        Else
            ' Check if we received an SNMP error from the agent
            If response.Pdu.ErrorStatus <> 0 Then
                MsgBox(String.Format("El agente SNMP devolvió un error {0} en el indice {1}", response.Pdu.ErrorStatus, response.Pdu.ErrorIndex))
            Else
                ' Everything is ok. Agent will return the new value for the OID we changed
                'MsgBox(String.Format("Agent response {0}: {1}", response.Pdu(0).Oid.ToString(), response.Pdu(0).Value.ToString()))
                TextBoxResultados.AppendText("---*** Valor establecido ***---" & Chr(10))
                TextBoxResultados.AppendText("--" & "||" & response.Pdu(0).Oid.ToString() & "||" & _
                                            response.Pdu(0).Value.ToString() & " = ")
                TextBoxResultados.AppendText("---" & Chr(10))
            End If
        End If
        Objetivo.Close()
    End Sub

    Private Sub ArmarArbol()
        Dim llamar As New ArmarArboles
        llamar.Armar(".1.3.6.1.2.1.39", Arbol_RDBMS_Mib)
    End Sub

    Public Sub CargarComboVersion()
        Dim I As Integer
        For I = 0 To 2
            If I = 1 Then
                CboBoxVersion.Items.Insert(I, I + 1 & "c") 'SnmpVersion.Ver1 = 0 - SnmpVersion.Ver2 = 1 - SnmpVersion.Ver3 = 2
            Else
                CboBoxVersion.Items.Insert(I, I + 1)
            End If
        Next I
        CboBoxVersion.SelectedIndex = 0
    End Sub

    Public Sub GuardarComo()
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de PostgresAdministrator (*.pgadmo)|*.pgadmo|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

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

    Public Function AbrirArchivo() As Boolean
        Dim listaLine As New List(Of String)
        Dim contLinea As Int32 = 1
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.pgadmo)|*.pgadmo"
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
                        Case Is > 10

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
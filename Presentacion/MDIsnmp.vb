Imports System.Windows.Forms
Imports System.IO
Public Class MDIsnmp

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub ResultadoOperacionesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ResultadoOperacionesToolStripMenuItem1.Click
        ResultadoOperacionesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ResultadoOperGraficasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ResultadoOperGraficasToolStripMenuItem1.Click
        ResultadoOperGraficasToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ResultadoOperacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResultadoOperacionesToolStripMenuItem.Click
        'Dim frmOp As New FrmOperaciones
        If FrmOperaciones.AbrirArchivo() = True Then
            FrmOperaciones.MdiParent = Me
            FrmOperaciones.WindowState = FormWindowState.Maximized
            m_ChildFormNumber += 1
            FrmOperaciones.Show()
        End If

    End Sub

    Private Sub ResultadoOperGraficasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResultadoOperGraficasToolStripMenuItem.Click
        If FrmRediseño.AbrirArchivo() = True Then
            FrmRediseño.MdiParent = Me
            FrmRediseño.WindowState = FormWindowState.Maximized
            m_ChildFormNumber += 1
            FrmRediseño.Show()
        End If
    End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
    'Dim contLinea As Int32 = 1
    'Dim VblForm As String = ""
    'Dim VblHost As String = ""
    'Dim VblPuerto As String = ""
    'Dim VblVersion As String = ""
    'Dim VblCadCom As String = ""
    'Dim VblIdObj As String = ""
    ''StrRutaTXT = OpenFileDialog1.FileName
    ''StrNbreArchTXT = OpenFileDialog1.SafeFileName

    'Dim OpenFileDialog As New OpenFileDialog
    'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    'OpenFileDialog.Filter = "Archivos de texto (*.pgadm)|*.pgadm"
    'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '    'Dim FileName As String = OpenFileDialog.FileName
    '    'Dim objReader As New StreamReader(FileName)
    '    StrRuta = OpenFileDialog.FileName
    '    StrNbreArch = OpenFileDialog.SafeFileName
    '    ObjLectorArchivo = New StreamReader(StrRuta)
    '    Dim StrLinea As String = Nothing
    '    Cursor = Cursors.WaitCursor
    '    Try
    '        Do Until ObjLectorArchivo.EndOfStream = True
    '            StrLinea = ObjLectorArchivo.ReadLine()
    '            Select Case contLinea
    '                Case 4
    '                    VblForm = Mid(StrLinea, 13, StrLinea.Length - 12)
    '                Case 5
    '                    VblHost = Mid(StrLinea, 7, StrLinea.Length - 6)
    '                Case 6
    '                    VblPuerto = Mid(StrLinea, 9, StrLinea.Length - 8)
    '                Case 7
    '                    VblVersion = Mid(StrLinea, 15, StrLinea.Length - 14)
    '                Case 8
    '                    VblCadCom = Mid(StrLinea, 22, StrLinea.Length - 21)
    '                Case 9
    '                    VblIdObj = Mid(StrLinea, 35, StrLinea.Length - 34)
    '                Case Is > 9

    '            End Select
    '            contLinea += 1
    '        Loop
    '        Select Case VblForm
    '            Case "Operaciones"
    '                Dim frmOp As New FrmOperaciones
    '                frmOp.TextBoxHost.Text = VblHost
    '                frmOp.TextBoxPuerto.Text = VblPuerto
    '                frmOp.CargarComboVersion()
    '                frmOp.CboBoxVersion.SelectedItem = VblVersion
    '                frmOp.TextBoxComunidad.Text = VblCadCom
    '                frmOp.TextBoxOID.Text = VblIdObj
    '                'frmOp.AbrirArchivo(StrRuta, StrNbreArch)
    '                frmOp.MdiParent = Me
    '                frmOp.WindowState = FormWindowState.Maximized
    '                m_ChildFormNumber += 1
    '                frmOp.Show()
    '                'frmOp.BringToFront()
    '            Case "Operaciones Graficas"

    '            Case Else
    '                Throw New Exception("Nombre de Formulario erroneo")
    '        End Select

    '    Catch exec As Exception
    '        MsgBox(exec.Message & Chr(13) & exec.StackTrace, MsgBoxStyle.Critical)
    '    Finally
    '        Cursor = Cursors.Default
    '    End Try
    'End If
    'End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        Select Case ActiveMdiChild.Name
            Case "FrmOperaciones"
                FrmOperaciones.GuardarArchivo()

            Case "FrmRediseño"
                FrmRediseño.GuardarArchivo()

        End Select
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        On Error Resume Next
        Select Case ActiveMdiChild.Name
            Case "FrmOperaciones"
                FrmOperaciones.GuardarComo()
                
            Case "FrmRediseño"
                FrmRediseño.GuardarComo()
                
        End Select
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
        On Error Resume Next
        Select Case ActiveMdiChild.Name 'PRESTAR ATENCION PORQUE ES CASE SENSITIVE
            Case "FrmOperaciones"
                Select Case FrmOperaciones.ActiveControl.Name
                    Case "TextBoxHost"
                        FrmOperaciones.TextBoxHost.SelectAll()
                        Clipboard.SetText(FrmOperaciones.TextBoxHost.Text)
                    Case "TextBoxOID"
                        FrmOperaciones.TextBoxOID.SelectAll()
                        Clipboard.SetText(FrmOperaciones.TextBoxOID.Text)
                    Case "TextBoxPuerto"
                        FrmOperaciones.TextBoxPuerto.SelectAll()
                        Clipboard.SetText(FrmOperaciones.TextBoxPuerto.Text)
                    Case "TextBoxResultados"
                        FrmOperaciones.TextBoxResultados.SelectAll()
                        Clipboard.SetText(FrmOperaciones.TextBoxResultados.Text)
                    Case "TextBoxComunidad"
                        FrmOperaciones.TextBoxComunidad.SelectAll()
                        Clipboard.SetText(FrmOperaciones.TextBoxComunidad.Text)
                End Select
            Case "FrmRediseño"
                Select Case FrmRediseño.ActiveControl.Name
                    Case "TextBoxHost"
                        FrmRediseño.TextBoxHost.SelectAll()
                        Clipboard.SetText(FrmRediseño.TextBoxHost.Text)
                    Case "TextBoxOID"
                        FrmRediseño.TextBoxOID.SelectAll()
                        Clipboard.SetText(FrmRediseño.TextBoxOID.Text)
                    Case "TextBoxPuerto"
                        FrmRediseño.TextBoxPuerto.SelectAll()
                        Clipboard.SetText(FrmRediseño.TextBoxPuerto.Text)
                    Case "TextBoxResultados"
                        FrmRediseño.TextBoxResultados.SelectAll()
                        Clipboard.SetText(FrmRediseño.TextBoxResultados.Text)
                    Case "TextBoxComunidad"
                        FrmRediseño.TextBoxComunidad.SelectAll()
                        Clipboard.SetText(FrmRediseño.TextBoxComunidad.Text)
                End Select
            Case "FrmObjetosMibs"
                Select Case FrmObjetosMibs.ActiveControl.Name
                    Case "TextBoxOID"
                        FrmObjetosMibs.TextBoxOid.SelectAll()
                        Clipboard.SetText(FrmObjetosMibs.TextBoxOid.Text)
                    Case "TextBoxAcceso"
                        FrmObjetosMibs.TextBoxAcceso.SelectAll()
                        Clipboard.SetText(FrmObjetosMibs.TextBoxAcceso.Text)
                    Case "TextBoxSyntaxis"
                        FrmObjetosMibs.TextBoxSyntaxis.SelectAll()
                        Clipboard.SetText(FrmObjetosMibs.TextBoxSyntaxis.Text)
                    Case "TextBoxEstado"
                        FrmObjetosMibs.TextBoxEstado.SelectAll()
                        Clipboard.SetText(FrmObjetosMibs.TextBoxEstado.Text)
                End Select
        End Select
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
        On Error Resume Next
        Select Case ActiveMdiChild.Name 'PRESTAR ATENCION PORQUE ES CASE SENSITIVE
            Case "FrmOperaciones"
                Select Case FrmOperaciones.ActiveControl.Name
                    Case "TextBoxHost"
                        FrmOperaciones.TextBoxHost.Text = Clipboard.GetText
                    Case "TextBoxOID"
                        FrmOperaciones.TextBoxOID.Text = Clipboard.GetText
                    Case "TextBoxPuerto"
                        FrmOperaciones.TextBoxPuerto.Text = Clipboard.GetText
                    Case "TextBoxComunidad"
                        FrmOperaciones.TextBoxComunidad.Text = Clipboard.GetText
                End Select
            Case "FrmRediseño"
                Select Case FrmRediseño.ActiveControl.Name
                    Case "TextBoxHost"
                        FrmRediseño.TextBoxHost.Text = Clipboard.GetText
                    Case "TextBoxOID"
                        FrmRediseño.TextBoxOID.Text = Clipboard.GetText
                    Case "TextBoxPuerto"
                        FrmRediseño.TextBoxPuerto.Text = Clipboard.GetText
                    Case "TextBoxComunidad"
                        FrmRediseño.TextBoxComunidad.Text = Clipboard.GetText
                End Select
            Case "FrmObjetosMibs"
                Select Case FrmObjetosMibs.ActiveControl.Name
                    Case "TextBoxOID"
                        FrmObjetosMibs.TextBoxOid.Text = Clipboard.GetText
                    Case "TextBoxAcceso"
                        FrmObjetosMibs.TextBoxAcceso.Text = Clipboard.GetText
                    Case "TextBoxSyntaxis"
                        FrmObjetosMibs.TextBoxSyntaxis.Text = Clipboard.GetText
                    Case "TextBoxEstado"
                        FrmObjetosMibs.TextBoxEstado.Text = Clipboard.GetText
                End Select
        End Select

    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OperaciónesSNMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperacionesSNMPToolStripMenuItem.Click
        FrmOperaciones.MdiParent = Me
        FrmOperaciones.WindowState = FormWindowState.Maximized
        m_ChildFormNumber += 1
        FrmOperaciones.CargarComboVersion()
        FrmOperaciones.Show()
    End Sub

    Private Sub MibRdbmsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MibRdbmsToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        'Dim FrmMib As New FrmRDBMS_Mib
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        FrmObjetosMibs.MdiParent = Me
        FrmObjetosMibs.WindowState = FormWindowState.Maximized
        m_ChildFormNumber += 1
        'FrmMib.Text = "Ventana " & m_ChildFormNumber
        FrmObjetosMibs.Show()
    End Sub

    Private Sub GraficasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraficasToolStripMenuItem.Click
        FrmRediseño.MdiParent = Me
        FrmRediseño.WindowState = FormWindowState.Maximized
        m_ChildFormNumber += 1
        FrmRediseño.CargarComboDur()
        FrmRediseño.CargarComboFre()
        FrmRediseño.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSetupToolStripMenuItem.Click
        Dim OpenFileDialog As New PrintDialog
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        On Error Resume Next
        Select Case ActiveMdiChild.Name 'PRESTAR ATENCION PORQUE ES CASE SENSITIVE
            Case "FrmOperaciones"
                FrmOperaciones.TextBoxResultados.SelectAll()
            Case "FrmRediseño"
                FrmRediseño.TextBoxResultados.SelectAll()
            Case "FrmObjetosMibs"
                FrmObjetosMibs.RichTextBMib.SelectAll()
        End Select
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        On Error Resume Next
        Cursor = Cursors.WaitCursor
        Select Case ActiveMdiChild.Name
            Case "FrmOperaciones"
                Dim cris As New CrysRepOper
                cris.SetDataSource(CargarTabla(FrmOperaciones.TextBoxResultados).Tables(1)) 'cris.SetDataSource(DatoSet.Tables(1))
                FrmVImpOper.CrystalReportViewer1.ReportSource = cris
                cris.SetParameterValue("FieldNombreFrm", "Operaciones")
                cris.SetParameterValue("pHost", FrmOperaciones.TextBoxHost.Text)
                cris.SetParameterValue("pCadenaComunidad", FrmOperaciones.TextBoxComunidad.Text)
                cris.SetParameterValue("pPuerto", FrmOperaciones.TextBoxPuerto.Text)
                cris.SetParameterValue("pOID", FrmOperaciones.TextBoxOID.Text)
                cris.SetParameterValue("pVersion", FrmOperaciones.CboBoxVersion.SelectedItem)
                cris.SetParameterValue("pOIDNombre", FrmOperaciones.Arbol_RDBMS_Mib.SelectedNode.Text)

                FrmVImpOper.MdiParent = Me
                FrmVImpOper.WindowState = FormWindowState.Maximized
                m_ChildFormNumber += 1
                FrmVImpOper.CrystalReportViewer1.ShowRefreshButton = False
                FrmVImpOper.Show()
                'FrmOperaciones.VistaPrevia()
            Case "FrmRediseño"
                Dim cris As New CrysRepOper
                cris.SetDataSource(CargarTabla(FrmRediseño.TextBoxResultados).Tables(1)) 'cris.SetDataSource(DatoSet.Tables(1))
                FrmVImpOper.CrystalReportViewer1.ReportSource = cris
                cris.SetParameterValue("FieldNombreFrm", "FrmRediseño")
                cris.SetParameterValue("pHost", FrmRediseño.TextBoxHost.Text)
                cris.SetParameterValue("pCadenaComunidad", FrmRediseño.TextBoxComunidad.Text)
                cris.SetParameterValue("pPuerto", FrmRediseño.TextBoxPuerto.Text)
                cris.SetParameterValue("pOID", FrmRediseño.TextBoxOID.Text)
                cris.SetParameterValue("pVersion", FrmRediseño.CboBoxVersion.SelectedItem)
                cris.SetParameterValue("pOIDNombre", FrmRediseño.Arbol_RDBMS_Mib.SelectedNode.Text)

                FrmVImpOper.MdiParent = Me
                FrmVImpOper.WindowState = FormWindowState.Maximized
                m_ChildFormNumber += 1
                FrmVImpOper.CrystalReportViewer1.ShowRefreshButton = False
                FrmVImpOper.Show()
            Case "FrmObjetosMibs"
                Dim rep As New CrysRepNav
                FrmVImpNavegador.CrystalReportViewer1.ReportSource = rep
                rep.SetParameterValue("pNombreObjeto", FrmObjetosMibs.Arbol_RDBMS_Mib.SelectedNode.Text)
                rep.SetParameterValue("pIdObjeto", FrmObjetosMibs.TextBoxOid.Text)
                rep.SetParameterValue("pEstado", FrmObjetosMibs.TextBoxEstado.Text)
                rep.SetParameterValue("pSintaxis", FrmObjetosMibs.TextBoxSyntaxis.Text)
                rep.SetParameterValue("pAcceso", FrmObjetosMibs.TextBoxAcceso.Text)
                rep.SetParameterValue("pDescripcion", FrmObjetosMibs.RichTextBMib.Text)
                FrmVImpNavegador.MdiParent = Me
                FrmVImpNavegador.WindowState = FormWindowState.Maximized
                m_ChildFormNumber += 1
                FrmVImpNavegador.CrystalReportViewer1.ShowRefreshButton = False
                FrmVImpNavegador.Show()


        End Select
        Cursor = Cursors.Default
    End Sub

    'Private Sub MDIsnmp_MdiChildActivate(sender As Object, e As System.EventArgs) Handles Me.MdiChildActivate
    '    On Error Resume Next
    '    'If Not FrmFocus Is Nothing Then
    '    '    Select Case FrmFocus.Name
    '    '        Case "FrmAfiliado_RecSueldoBIS"
    '    '    End Select
    'End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Dim MsgResultado As MsgBoxResult = MsgBox("¿Imprimir los resultados de la Operación?", MsgBoxStyle.OkCancel)
            If (MsgResultado = MsgBoxResult.Ok) Then
                Cursor = Cursors.WaitCursor
                Select Case ActiveMdiChild.Name
                    Case "FrmOperaciones"
                        Dim cris As New CrysRepOper
                        'Dim arreglostrin() As String = FrmOperaciones.TextBoxResultados.Lines
                        cris.SetDataSource(CargarTabla(FrmOperaciones.TextBoxResultados).Tables(1)) 'cris.SetDataSource(DatoSet.Tables(1))
                        FrmVImpOper.CrystalReportViewer1.ReportSource = cris
                        cris.SetParameterValue("FieldNombreFrm", "Operaciones")
                        cris.SetParameterValue("pHost", FrmOperaciones.TextBoxHost.Text)
                        cris.SetParameterValue("pCadenaComunidad", FrmOperaciones.TextBoxComunidad.Text)
                        cris.SetParameterValue("pPuerto", FrmOperaciones.TextBoxPuerto.Text)
                        cris.SetParameterValue("pOID", FrmOperaciones.TextBoxOID.Text)
                        cris.SetParameterValue("pVersion", FrmOperaciones.CboBoxVersion.SelectedItem)
                        cris.SetParameterValue("pOIDNombre", FrmOperaciones.Arbol_RDBMS_Mib.SelectedNode.Text)
                        'FrmVImpOper.CrystalReportViewer1.Refresh()
                        'FrmVImpOper.Show()
                        FrmVImpOper.CrystalReportViewer1.PrintReport()

                    Case "FrmRediseño"
                        Dim cris As New CrysRepOper
                        cris.SetDataSource(CargarTabla(FrmRediseño.TextBoxResultados).Tables(1))
                        FrmVImpOper.CrystalReportViewer1.ReportSource = cris
                        cris.SetParameterValue("FieldNombreFrm", "FrmRediseño")
                        cris.SetParameterValue("pHost", FrmRediseño.TextBoxHost.Text)
                        cris.SetParameterValue("pCadenaComunidad", FrmRediseño.TextBoxComunidad.Text)
                        cris.SetParameterValue("pPuerto", FrmRediseño.TextBoxPuerto.Text)
                        cris.SetParameterValue("pOID", FrmRediseño.TextBoxOID.Text)
                        cris.SetParameterValue("pVersion", FrmRediseño.CboBoxVersion.SelectedItem)
                        cris.SetParameterValue("pOIDNombre", FrmRediseño.Arbol_RDBMS_Mib.SelectedNode.Text)
                        FrmVImpOper.CrystalReportViewer1.PrintReport()
                        'FrmVImpOper.CrystalReportViewer1.Refresh()
                        'FrmVImpOper.Show()
                    Case "FrmObjetosMibs"
                        Dim rep As New CrysRepNav
                        FrmVImpNavegador.CrystalReportViewer1.ReportSource = rep
                        rep.SetParameterValue("pNombreObjeto", FrmObjetosMibs.Arbol_RDBMS_Mib.SelectedNode.Text)
                        rep.SetParameterValue("pIdObjeto", FrmObjetosMibs.TextBoxOid.Text)
                        rep.SetParameterValue("pEstado", FrmObjetosMibs.TextBoxEstado.Text)
                        rep.SetParameterValue("pSintaxis", FrmObjetosMibs.TextBoxSyntaxis.Text)
                        rep.SetParameterValue("pAcceso", FrmObjetosMibs.TextBoxAcceso.Text)
                        rep.SetParameterValue("pDescripcion", FrmObjetosMibs.RichTextBMib.Text)
                        FrmVImpNavegador.CrystalReportViewer1.PrintReport()
                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function CargarTabla(ByVal TextResult As TextBox) As DataSet
        Dim DatoSet As New DataSetResult
        Dim TResultados As New DataTable
        Dim arreglostrin() As String = TextResult.Lines 'FrmOperaciones.TextBoxResultados.Lines
        TResultados.TableName = "TResultados"
        DatoSet.Tables.Add(TResultados)

        TResultados.Columns.Add("IdResultado", GetType(Integer))
        TResultados.Columns.Add("Resultado", GetType(String))

        Dim Fila As System.Data.DataRow
        Dim I As Int32 = 0
        For j = 0 To arreglostrin.Length - 1
            Fila = TResultados.NewRow
            Fila.Item(0) = I
            Fila.Item(1) = arreglostrin.GetValue(j)
            TResultados.Rows.Add(Fila)
            I += 1
        Next
        Return DatoSet
    End Function

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripButton.Click
        PrintPreviewToolStripMenuItem_Click(sender, e)
    End Sub

End Class

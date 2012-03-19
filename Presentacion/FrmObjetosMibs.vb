Imports Negocios.Negocios
Imports Entidades

Public Class FrmObjetosMibs

#Region "Definiciones"
    Dim vNombreNodoSelect As String
    Dim NodoRaiz As TreeNode
    Dim NodoHoja As TreeNode

#End Region

#Region "Operaciones"

    'Private Sub DGVMibs_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMibs.CellContentDoubleClick
    '    'El recorrido de la mib, para la elaboracion del Arbol, se realiza en profundidad. Otra alternativa seria el recorrido a lo anch
    '    Try
    '        '--------------------------------------------------Limpio el arbol antes de cargarlo----------------------------------------------------
    '        Arbol_RDBMS_Mib.Nodes.Clear()

    '        '-------------------------------------------------------Agrego el Nodo Raiz-------------------------------------------------------------
    '        Dim vMib As Mibs = MibsNegocio.Obtener(DGVMibs.Item(0, DGVMibs.CurrentRow.Index).Value) 'DGVMibs.Item(0, DGVMibs.CurrentRow.Index).Value
    '        Arbol_RDBMS_Mib.Nodes.Insert(0, vMib.Nombre)

    '        '-----------------------------------------------Cargo la tabla de objetos completa -----------------------------------------------------
    '        Dim ListaObjetos As New List(Of Objetos)
    '        ListaObjetos = ObjetosNegocio.Listado

    '        '-------------------------------------------------------Relleno del Arbol---------------------------------------------------------------
    '        Dim ListaObjHijos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = DGVMibs.Item(3, DGVMibs.CurrentRow.Index).Value)
    '        Dim I As Int32 = 0
    '        For Each Hijo As Object In ListaObjHijos
    '            Arbol_RDBMS_Mib.Nodes.Item(0).Nodes.Add(I, ListaObjHijos.Item(I).Nombre)
    '            '------------------------------------------------------------------------------------------------
    '            Dim ListaObjNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjHijos.Item(I).IdObj)
    '            Dim J As Int32 = 0
    '            For Each Nieto As Object In ListaObjNietos
    '                Arbol_RDBMS_Mib.Nodes.Item(0).Nodes.Item(I).Nodes.Add(J, ListaObjNietos.Item(J).Nombre)
    '                '---------------------------------------------------------------------------------------------------
    '                Dim ListaObjBisNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjNietos.Item(J).IdObj)
    '                Dim K As Int32 = 0
    '                For Each BisNieto As Object In ListaObjBisNietos
    '                    Arbol_RDBMS_Mib.Nodes.Item(0).Nodes.Item(I).Nodes.Item(J).Nodes.Add(K, ListaObjBisNietos.Item(K).Nombre)
    '                    '---------------------------------------------------------------------------------------------------------
    '                    Dim ListaObjTataraNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjBisNietos.Item(K).IdObj)
    '                    Dim H As Int32 = 0
    '                    For Each TataraNietos As Object In ListaObjTataraNietos
    '                        '---------------------------------------------------------------------------------------------------------
    '                        Arbol_RDBMS_Mib.Nodes.Item(0).Nodes.Item(I).Nodes.Item(J).Nodes.Item(K).Nodes.Add(H, ListaObjTataraNietos.Item(H).Nombre)
    '                        H += 1
    '                    Next
    '                    K += 1
    '                Next
    '                J += 1
    '            Next
    '            I += 1
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub CargarGrillaMibs()
        Dim MibLista As New List(Of Entidades.Mibs)
        MibLista = MibsNegocio.Listado
        Me.DGVMibs.DataSource = MibLista
    End Sub

    Private Sub ArmarArbol()
        Try
            '------------------------------------------------Limpio el arbol antes de cargarlo----------------------------------------------------
            Arbol_RDBMS_Mib.Nodes.Clear()
            '-----------------------------------------------Cargo la tabla de objetos completa ----------------------------------------------------
            Dim ListaObjetos As New List(Of Objetos)
            ListaObjetos = ObjetosNegocio.Listado
            '-------------------------------------------------------Agrego el Nodo Raiz------------------------------------------------------------
            Dim ObjetoMib = ListaObjetos.Find(Function(d) d.IdObj = DGVMibs.Item(3, DGVMibs.CurrentRow.Index).Value)
            NodoRaiz = New TreeNode
            NodoRaiz.Tag = ObjetoMib 'vMib
            NodoRaiz.Text = ObjetoMib.Nombre
            Arbol_RDBMS_Mib.Nodes.Add(NodoRaiz)
            '--------------------------------------------------------Relleno del Arbol ------------------------------------------------------------
            Dim ListaObjHijos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = DGVMibs.Item(3, DGVMibs.CurrentRow.Index).Value)
            Dim I As Int32 = 0
            For Each Hijo In ListaObjHijos
                NodoHoja = New TreeNode
                NodoHoja.Tag = Hijo 'Cargo el tag con el objeto hijo de manera tal que cada nodo del arbol este relacionado con un obj de la base.
                NodoHoja.Text = Hijo.Nombre 'Especifico lo que se va a mostrar en el arbol.
                NodoRaiz.Nodes.Add(NodoHoja) 'Añado una hoja al nodoRaiz
                '---------------------------------------------------------------------------------------------------------------------------------
                Dim ListaObjNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjHijos.Item(I).IdObj)
                Dim J As Int32 = 0
                For Each Nieto In ListaObjNietos
                    NodoHoja = New TreeNode
                    NodoHoja.Tag = Nieto 'Cargo el tag con el objeto hijo de manera tal que cada nodo del arbol este relacionado con un obj de la base.
                    NodoHoja.Text = Nieto.Nombre 'Especifico lo que se va a mostrar en el arbol.
                    NodoRaiz.Nodes(I).Nodes.Add(NodoHoja)
                    '------------------------------------------------------------------------------------------------------------------------------
                    Dim ListaObjBisNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjNietos.Item(J).IdObj)
                    Dim K As Int32 = 0
                    For Each BisNieto As Object In ListaObjBisNietos
                        NodoHoja = New TreeNode
                        NodoHoja.Tag = BisNieto 'Cargo el tag con el objeto hijo de manera tal que cada nodo del arbol este relacionado con un obj de la base.
                        NodoHoja.Text = BisNieto.Nombre 'Especifico lo que se va a mostrar en el arbol.
                        NodoRaiz.Nodes(I).Nodes(J).Nodes.Add(NodoHoja)
                        '---------------------------------------------------------------------------------------------------------------------------
                        Dim ListaObjTataraNietos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = ListaObjBisNietos.Item(K).IdObj)
                        Dim H As Int32 = 0
                        For Each TataraNietos As Object In ListaObjTataraNietos
                            NodoHoja = New TreeNode
                            NodoHoja.Tag = TataraNietos 'Cargo el tag con el objeto hijo de manera tal que cada nodo del arbol este relacionado con un obj de la base.
                            NodoHoja.Text = TataraNietos.Nombre 'Especifico lo que se va a mostrar en el arbol.
                            NodoRaiz.Nodes(I).Nodes(J).Nodes(K).Nodes.Add(NodoHoja)
                            H += 1
                        Next
                        K += 1
                    Next
                    J += 1
                Next
                I += 1
            Next
            Arbol_RDBMS_Mib.ExpandAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmObjetosMibs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarGrillaMibs()
    End Sub

    Private Sub Arbol_RDBMS_Mib_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles Arbol_RDBMS_Mib.AfterSelect
        On Error Resume Next
        RichTextBMib.Clear()
        TextBoxAcceso.Clear()
        TextBoxEstado.Clear()
        TextBoxOid.Clear()
        TextBoxSyntaxis.Clear()
        'vNombreNodoSelect
        If IsNothing((CType(e.Node.Tag, Objetos).Nombre)) = False Then vNombreNodoSelect = (CType(e.Node.Tag, Objetos).Nombre)
        If IsNothing((CType(e.Node.Tag, Objetos).Descripcion)) = False Then RichTextBMib.Text = (CType(e.Node.Tag, Objetos).Descripcion)
        If IsNothing((CType(e.Node.Tag, Objetos).IdObj)) = False Then TextBoxOid.Text = (CType(e.Node.Tag, Objetos).IdObj)
        If IsNothing((CType(e.Node.Tag, Objetos).Status)) = False Then TextBoxEstado.Text = (CType(e.Node.Tag, Objetos).Status)
        If IsNothing((CType(e.Node.Tag, Objetos).Sintaxis)) = False Then TextBoxSyntaxis.Text = (CType(e.Node.Tag, Objetos).Sintaxis)
        If IsNothing((CType(e.Node.Tag, Objetos).Acceso)) = False Then TextBoxAcceso.Text = (CType(e.Node.Tag, Objetos).Acceso)

    End Sub

    Private Sub DGVMibs_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMibs.CellDoubleClick
        ArmarArbol()
    End Sub

    Private Sub DGVMibs_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DGVMibs.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            ArmarArbol()
        End If
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        On Error Resume Next
        Select Case Me.SplitContainer3.ActiveControl.Name 'Me.ActiveControl.Name
            Case "TextBoxAcceso"
                Clipboard.SetText(Me.TextBoxAcceso.SelectedText)
            Case "TextBoxOid"
                Clipboard.SetText(Me.TextBoxOid.SelectedText)
            Case "TextBoxEstado"
                Clipboard.SetText(Me.TextBoxEstado.SelectedText)
            Case "TextBoxSyntaxis"
                Clipboard.SetText(Me.TextBoxSyntaxis.SelectedText)
            Case "RichTextBMib"
                Clipboard.SetText(Me.RichTextBMib.SelectedText)
            Case "Arbol_RDBMS_Mib"
                Clipboard.SetText(vNombreNodoSelect) 'Me.Arbol_RDBMS_Mib.SelectedNode.Name.ToString)
        End Select
        Select Case Me.SplitContainer1.ActiveControl.Name
            Case "Arbol_RDBMS_Mib"
                Clipboard.SetText(vNombreNodoSelect)
        End Select
        'Select Case Me.SplitContainer2.ActiveControl.Name 'Me.ActiveControl.Name
        '    Case Else
        '        Clipboard.SetText(vNombreNodoSelect)
        'End Select
    End Sub
#End Region

    'Public Overridable Property ActiveControl() As Control
    '    Get
    '        Return GetFocusedControl(Me)
    '    End Get
    '    Set(ByVal value As Control)
    '        If Not value.Focused Then
    '            value.Focus()
    '        End If
    '    End Set
    'End Property

    'Private Function GetFocusedControl(ByVal parent As Control) As Control
    '    If parent.Focused Then
    '        Return parent
    '    End If
    '    For Each ctrl As Control In parent.Controls
    '        Dim temp As Control = GetFocusedControl(ctrl)
    '        If temp IsNot Nothing Then
    '            Return temp
    '        End If
    '    Next
    '    Return Nothing
    'End Function
End Class
Imports Negocios.Negocios
Imports Entidades
Public Class ArmarArboles

#Region "Definiciones"

    Dim NodoRaiz As TreeNode
    Dim NodoHoja As TreeNode
    'Private Arbol As System.Windows.Forms.TreeView

#End Region


    Public Sub Armar(ByVal pIdObj As String, pArbol As TreeView)
        'Try
        '------------------------------------------------Limpio el arbol antes de cargarlo----------------------------------------------------
        'Arbol.Nodes.Clear() Me.Arbol_RDBMS_Mib = New System.Windows.Forms.TreeView()
        'Arbol = New TreeView
        '-----------------------------------------------Cargo la tabla de objetos completa ----------------------------------------------------
        Dim ListaObjetos As New List(Of Objetos)
        ListaObjetos = ObjetosNegocio.Listado
        '-------------------------------------------------------Agrego el Nodo Raiz------------------------------------------------------------
        Dim ObjetoMib = ListaObjetos.Find(Function(d) d.IdObj = pIdObj) 'DGVMibs.Item(3, DGVMibs.CurrentRow.Index).Value)
        NodoRaiz = New TreeNode
        NodoRaiz.Tag = ObjetoMib 'vMib
        NodoRaiz.Text = ObjetoMib.Nombre
        pArbol.Nodes.Add(NodoRaiz)
        '--------------------------------------------------------Relleno del Arbol ------------------------------------------------------------
        Dim ListaObjHijos = ListaObjetos.FindAll(Function(d) d.IdObjPadre = pIdObj) 'DGVMibs.Item(3, DGVMibs.CurrentRow.Index).Value)
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
        'Return Arbol
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

End Class

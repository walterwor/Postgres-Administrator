Imports Entidades
Imports Datos.Repositorios

Namespace Negocios
    Public Class MibsNegocio
        Private Shared _mibRepositorioInstancia As MibRepositorio
        Public Shared ReadOnly Property MibRepositorioInstancia() As MibRepositorio
            Get
                If _mibRepositorioInstancia Is Nothing Then
                    _mibRepositorioInstancia = New MibRepositorio
                End If
                Return _mibRepositorioInstancia
            End Get
        End Property
        Public Shared Function Listado() As List(Of Mibs)
            Return MibRepositorioInstancia.Listar()
        End Function
        Public Shared Function Guardar(pMib As Mibs) As Mibs
            Dim mibb As Mibs = MibRepositorioInstancia.Guardar(pMib)
            MibRepositorioInstancia.GuardarCambios()
            Return mibb
        End Function
        Public Shared Function Obtener(ByVal pIdMib As Int32) As Mibs
            Return MibRepositorioInstancia.Obtener(pIdMib)
        End Function
        Public Shared Function Eliminar(ByVal pIdMib As Int32) As Boolean
            If SePuedeEliminar(pIdMib) = True Then
                MibRepositorioInstancia.Eliminar(pIdMib)
                Try
                    MibRepositorioInstancia.GuardarCambios()
                    Return True
                Catch ex As Exception
                    MsgBox("No se pudo eliminar el registro" & Chr(13) & ex.Message)
                    Return False
                End Try
            Else
                Return False
            End If
        End Function

        Public Shared Function SePuedeEliminar(ByVal pIdMibs As Int32) As Boolean
            Dim Mib As Mibs
            Mib = Obtener(pIdMibs)
            If Mib.Objetos.Count > 0 Then
                Return False
            Else
                Return True
            End If
        End Function


    End Class
End Namespace




Imports Entidades
Imports Datos.Repositorios

Namespace Negocios
    Public Class ObjetosNegocio
        Private Shared _objetoRepositorioInstancia As ObjetoRepositorio
        Public Shared ReadOnly Property ObjetoRepositorioInstancia() As ObjetoRepositorio
            Get
                If _objetoRepositorioInstancia Is Nothing Then
                    _objetoRepositorioInstancia = New ObjetoRepositorio
                End If
                Return _objetoRepositorioInstancia
            End Get
        End Property
        Public Shared Function Listado() As List(Of Objetos)
            Return ObjetoRepositorioInstancia.Listar
        End Function
        Public Shared Function Guardar(pObjeto As Objetos) As Objetos
            Dim Objetito As Objetos = ObjetoRepositorioInstancia.Guardar(pObjeto)
            ObjetoRepositorioInstancia.GuardarCambios()
            Return Objetito
        End Function
        Public Shared Function Obtener(ByVal pObjeto As Int32) As Objetos
            Return ObjetoRepositorioInstancia.Obtener(pObjeto)
        End Function
        Public Shared Function Eliminar(ByVal pObjeto As Int32) As Boolean
            If SePuedeEliminar(pObjeto) = True Then
                ObjetoRepositorioInstancia.Eliminar(pObjeto)
                Try
                    ObjetoRepositorioInstancia.GuardarCambios()
                    Return True
                Catch ex As Exception
                    MsgBox("No se pudo eliminar el registro" & Chr(13) & ex.Message)
                    Return False
                End Try
            Else
                Return False
            End If
        End Function

        Public Shared Function SePuedeEliminar(ByVal pObjeto As Int32) As Boolean
            Dim Objeto As Objetos
            Objeto = Obtener(pObjeto)
            If Objeto.Sintaxis.Count > 0 Then
                Return False
            Else
                Return True
            End If
        End Function

    End Class
End Namespace


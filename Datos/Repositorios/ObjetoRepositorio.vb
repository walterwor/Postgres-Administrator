Imports Datos.Interfaz
Imports Entidades
Namespace Datos.Repositorios
    Public Class ObjetoRepositorio
        Inherits RepositorioBase
        Implements IObjetoRepositorio

        Public Function Eliminar(IdObjElm As Integer) As Boolean Implements Interfaz.IObjetoRepositorio.Eliminar
            Dim objetox As Objetos
            objetox = Obtener(IdObjElm)
            Contexto.Objetos.DeleteObject(objetox)
        End Function

        Public Function Guardar(IdObjGua As Entidades.Objetos) As Objetos Implements Interfaz.IObjetoRepositorio.Guardar
            If IdObjGua.IdentificadorObjeto = 0 Then
                'crear
                Contexto.Objetos.AddObject(IdObjGua)
            Else
                Contexto.Objetos.ApplyCurrentValues(IdObjGua)
            End If
            Return IdObjGua
        End Function

        Public Function Listar() As System.Collections.Generic.List(Of Objetos) Implements Interfaz.IObjetoRepositorio.Listar
            'Consulta Linq
            Dim qObjetoOrderIdObj = From Objeto In Contexto.Objetos _
            Order By Objeto.IdObj Select Objeto
            Return qObjetoOrderIdObj.ToList
        End Function

        Public Function Obtener(IdObjObt As Integer) As Objetos Implements Interfaz.IObjetoRepositorio.Obtener
            Return Contexto.Objetos.First(Function(m) m.IdentificadorObjeto = IdObjObt)
        End Function
    End Class
End Namespace


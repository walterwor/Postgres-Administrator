Imports Datos.Interfaz
Imports Entidades
Namespace Datos.Repositorios
    Public Class MibRepositorio
        Inherits RepositorioBase
        Implements IMibRepositorio

        Public Function Eliminar(IdMibElm As Integer) As Boolean Implements Interfaz.IMibRepositorio.Eliminar
            Dim Mib As Mibs
            Mib = Obtener(IdMibElm)
            Contexto.Mibs.DeleteObject(Mib)
            Return True
        End Function

        Public Function Guardar(MibGua As Entidades.Mibs) As Entidades.Mibs Implements Interfaz.IMibRepositorio.Guardar
            If MibGua.IdentificadorMib = 0 Then
                'crear
                Contexto.Mibs.AddObject(MibGua)
            Else
                Contexto.Mibs.ApplyCurrentValues(MibGua)
            End If
            Return MibGua
        End Function

        Public Function Listar() As System.Collections.Generic.List(Of Entidades.Mibs) Implements Interfaz.IMibRepositorio.Listar
            'Consulta Linq
            Dim qMibOrderIdObj = From Mib In Contexto.Mibs _
            Order By Mib.IdObj Select Mib
            Return qMibOrderIdObj.ToList
        End Function

        Public Function Obtener(IdentMib As Integer) As Entidades.Mibs Implements Interfaz.IMibRepositorio.Obtener
            Return Contexto.Mibs.First(Function(m) m.IdentificadorMib = IdentMib) 'VER BIEN LA COMPARACION =
        End Function
    End Class
End Namespace


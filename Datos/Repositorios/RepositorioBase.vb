Imports Entidades
Namespace Datos.Repositorios
    Public MustInherit Class RepositorioBase
        Public Shared Property Contexto As rdbmsMibEntities
        Public Sub New()
            If Contexto Is Nothing Then
                Contexto = New rdbmsMibEntities()
            End If
        End Sub

        Public Sub GuardarCambios()
            Contexto.SaveChanges()
        End Sub
        Public Sub CancelarCambios()
            Contexto = New rdbmsMibEntities()
        End Sub
    End Class
End Namespace


Imports Entidades
Namespace Datos.Interfaz
    Public Interface IMibRepositorio
        Function Obtener(IdMibObt As Int32) As Mibs
        Function Guardar(MibGua As Mibs) As Mibs
        Function Eliminar(IdMibElm As Int32) As Boolean
        Function Listar() As List(Of Mibs)
    End Interface
End Namespace


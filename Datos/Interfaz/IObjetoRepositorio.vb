Imports Entidades
Namespace Datos.Interfaz
    Public Interface IObjetoRepositorio
        Function Guardar(IdObjGua As Objetos) As Objetos
        Function Obtener(IdObjObt As Int32) As Objetos
        Function Eliminar(IdObjElm As Int32) As Boolean
        Function Listar() As List(Of Objetos)
    End Interface
End Namespace


Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient

Public Class VbInstaller

    Dim masterConnection As New System.Data.SqlClient.SqlConnection

    Public Sub New()
        MyBase.New()
        'This call is required by the Component Designer.
        InitializeComponent()
    End Sub

    Private Function GetSql(ByVal Name As String) As String
        Try
            ' Gets the current assembly.
            Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly()
            ' Resources are named using a fully qualified name.
            Dim strm As Stream = Asm.GetManifestResourceStream(
              Asm.GetName().Name + "." + Name)
            ' Reads the contents of the embedded file.
            Dim reader As StreamReader = New StreamReader(strm)
            Return reader.ReadToEnd()
        Catch ex As Exception
            MsgBox("In GetSQL: " & ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub ExecuteSql(ByVal DatabaseName As String, ByVal Sql As String)
        Dim Commando As New SqlClient.SqlCommand(Sql, masterConnection)
        'Inicializa la conexion, la abre, y la configura como  "master", pasado como argumento desde addDbTable
        masterConnection.ConnectionString = My.Settings.rdbmsMibConnectionString
        Commando.Connection.Open()
        Commando.Connection.ChangeDatabase(DatabaseName)
        Try
            Commando.ExecuteNonQuery()
        Finally
            ' Closing the connection should be done in a Finally block
            Commando.Connection.Close()
        End Try
    End Sub

    Protected Sub AddDBTable(ByVal strDBName As String)
        Try
            'Verifica la existencia de la base, si esta la elimina y la vuelve a generar.
            ExecuteSql("master", "IF EXISTS (SELECT name FROM sys.databases WHERE name = N'rdbmsMib') DROP DATABASE [rdbmsMib]")
            'Crea la base de datos.
            ExecuteSql("master", "CREATE DATABASE " + "rdbmsMib")
            'Invoca al script para la creacion de las tablas y ejecutar los insert correspondientes.
            ExecuteSql("rdbmsMib", GetSql("sql.txt"))
        Catch ex As Exception
            MsgBox("Se reporto el siguiente error: " & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Install(
        ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)
        AddDBTable(Me.Context.Parameters.Item("dbname"))
    End Sub
End Class

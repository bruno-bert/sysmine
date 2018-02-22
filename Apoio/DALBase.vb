Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.Collections
Imports System.Configuration
Public Class DALBase
    Private connectionString As String

    Public Structure Parametros
        Dim Campo As String
        Dim Conteudo As Object
        Dim Tipo As SqlDbType
    End Structure
    Public Sub New(ByVal myConnectionString As String)
        Try
            connectionString = myConnectionString
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function RetornaConexao() As String
        Return connectionString
    End Function
    Public Function BackupDatabase(ByVal nomeDB As String, ByVal backupFile As String) As String

        Dim cn As New SqlConnection(connectionString)

        Try
            ' comando para fazer o backup do Banco de dados
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & nomeDB & "] TO DISK = '" & backupFile & "' WITH NOFORMAT, INIT,  NAME = N'dbDNPM-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", cn)
            cn.Open()
            cmdBackup.ExecuteNonQuery()
            cn.Close()
            Return ""
        Catch ex As Exception
            Try
                cn.Close()
            Catch ex2 As Exception

            End Try
            Return ex.Message
        End Try
    End Function
    Public Function checkdbStatus(ByVal errorMsg As String) As Boolean

        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlConn.Open()

            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
                errorMsg = ""
                Return True
            Else
                errorMsg = "Erro de conexão não identificado"
                Return False
            End If


            Return True

        Catch ex As Exception
            errorMsg = ex.Message
            If sqlConn.State = ConnectionState.Open Then sqlConn.Close()
            Return False
        End Try

    End Function
   
    Public Function ExecuteSql(ByVal sql As String) As Integer

        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = sql
            sqlCmd.CommandType = CommandType.Text


            sqlConn.Open()

            Return sqlCmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function
    Public Function ExecuteNonQuery(ByVal strProcName As String, _
                                    ByVal sqlParametros() As Parametros) As Integer

        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure

            'Para cada campo adicionar parametro
            For Each Parametro In sqlParametros
                sqlCmd.Parameters.Add(New SqlParameter(Parametro.Campo, Parametro.Tipo))

                Select Case CInt(Parametro.Tipo)

                    Case CInt(SqlDbType.DateTime), CInt(SqlDbType.SmallDateTime), CInt(SqlDbType.Date)

                        If Parametro.Conteudo = "00:00:01" Then
                            sqlCmd.Parameters(Parametro.Campo).Value = CDate("01/01/1900  00:00:01")
                        Else
                            sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo Is Nothing And Not Parametro.Conteudo = CDate("00:00:00"), Parametro.Conteudo, DBNull.Value)
                        End If




                    Case CInt(SqlDbType.VarChar), CInt(SqlDbType.NVarChar), _
                        CInt(SqlDbType.NText), CInt(SqlDbType.Char), CInt(SqlDbType.NChar), CInt(SqlDbType.NText)

                        sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo Is Nothing, Parametro.Conteudo, DBNull.Value)



                    Case CInt(SqlDbType.Int), CInt(SqlDbType.Decimal), CInt(SqlDbType.Real), CInt(SqlDbType.SmallInt), _
                    CInt(SqlDbType.Float), CInt(SqlDbType.BigInt)

                        sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo = -1111111111, Parametro.Conteudo, DBNull.Value)

                End Select
            Next

            sqlConn.Open()

            Return sqlCmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function
    Public Function ExecuteNonQuery(ByVal strProcName As String, _
                                    ByVal sqlCmd As SqlCommand) As Integer

        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure


            sqlConn.Open()

            Return sqlCmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function
    Public Function fillParameters(ByVal procName As String, ByVal parm() As Parametros) As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim sqlCmd As SqlCommand


        Try

            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = procName
            sqlCmd.CommandTimeout = 0
            sqlConn.Open()
            SqlCommandBuilder.DeriveParameters(sqlCmd)

            If Not sqlCmd.Parameters("@RETURN_VALUE") Is Nothing Then
                sqlCmd.Parameters.Remove(sqlCmd.Parameters("@RETURN_VALUE"))
            End If


            For Each p As Parametros In parm
                sqlCmd.Parameters(p.Campo).Value = p.Conteudo
            Next

            'Joga nulo nos parâmetros que não foram enviados
            For Each p As SqlParameter In sqlCmd.Parameters
                If p.Value Is Nothing Then p.Value = System.DBNull.Value
            Next

            Return sqlCmd

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function
    Public Function ExecuteScalar(ByVal strProcName As String, _
                                    ByVal sqlParametros() As Parametros) As Integer

        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure

            'Para cada campo adicionar parametro
            For Each Parametro In sqlParametros

                sqlCmd.Parameters.Add(New SqlParameter(Parametro.Campo, Parametro.Tipo))
                sqlCmd.Parameters(Parametro.Campo).Value = Parametro.Conteudo

            Next

            sqlConn.Open()

            Return sqlCmd.ExecuteScalar


        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function
    Public Function ExecuteScalar(ByVal strProcName As String, _
                                   ByVal sqlCmd As SqlCommand) As Integer


        Dim sqlConn As SqlConnection = Nothing

        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlConn.Open()

            Return sqlCmd.ExecuteScalar


        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function

    Public Function SelectDataSet(ByVal strProcName As String) As DataSet


        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim ds As New DataSet


        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure



            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o DataSet conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(ds)



            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function
    Public Function SelectDataSet(ByVal strProcName As String, _
                                   ByVal sqlParametros() As Parametros) As DataSet


        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim ds As New DataSet


        Try

            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure

            For Each Parametro In sqlParametros

                sqlCmd.Parameters.Add(New SqlParameter(Parametro.Campo, Parametro.Tipo))
                sqlCmd.Parameters(Parametro.Campo).Value = Parametro.Conteudo

            Next


            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o DataSet conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(ds)



            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function

    Public Function SelectDataTable(ByVal strProcName As String, _
                                ByVal sqlParametros() As Parametros) As DataTable

        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure

            'Para cada campo adicionar parametro
            For Each Parametro In sqlParametros

                sqlCmd.Parameters.Add(New SqlParameter(Parametro.Campo, Parametro.Tipo))

                Select Case CInt(Parametro.Tipo)

                    Case CInt(SqlDbType.VarChar), CInt(SqlDbType.NVarChar), _
                        CInt(SqlDbType.NText), CInt(SqlDbType.Char), CInt(SqlDbType.NChar), CInt(SqlDbType.NText)

                        sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo Is Nothing, Parametro.Conteudo, DBNull.Value)

                    Case CInt(SqlDbType.DateTime), CInt(SqlDbType.SmallDateTime)
                        sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo Is Nothing And Parametro.Conteudo <> CDate("00:00:00"), Parametro.Conteudo, DBNull.Value)



                    Case CInt(SqlDbType.Int), CInt(SqlDbType.Decimal), CInt(SqlDbType.Real), CInt(SqlDbType.SmallInt), _
                    CInt(SqlDbType.Float), CInt(SqlDbType.BigInt)

                        sqlCmd.Parameters(Parametro.Campo).Value = IIf(Not Parametro.Conteudo = -1111111111, Parametro.Conteudo, DBNull.Value)

                End Select

            Next

            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o datatable conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function SelectDataTable2(ByVal strProcName As String) As DataTable
        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn

            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure

            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o datatable conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function
    Public Function SelectDataTable(ByVal strSQL As String) As DataTable
        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = strSQL
            sqlCmd.CommandType = CommandType.Text

            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o datatable conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function SelectDataTable(ByVal commandSQL As String, ByVal type As CommandType) As DataTable
        Dim da As New SqlDataAdapter
        Dim sqlCmd As SqlCommand
        Dim sqlConn As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd = New SqlCommand
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandTimeout = 0
            sqlCmd.CommandText = commandSQL
            sqlCmd.CommandType = type

            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o datatable conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function SelectDataTable(ByVal strProcName As String, ByVal sqlCmd As SqlCommand) As DataTable
        Dim da As New SqlDataAdapter
        Dim sqlConn As SqlConnection = Nothing
        Dim dt As New DataTable
        Try
            'estabelece a conexão		
            sqlConn = New SqlConnection(connectionString)
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = strProcName
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandTimeout = 0
            'abre a conexão com o banco de dados			
            sqlConn.Open()

            'executa o reader			
            da.SelectCommand = sqlCmd

            ' Preenche o datatable conforme a página solicitada
            ' e a quantidade de registros por página
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function
End Class

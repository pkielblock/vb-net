Module Module1
    Public resp, diretorio As String
    Public db As New ADODB.Connection 'Variavel de conexão com o db
    Public rs As New ADODB.Recordset 'Variavel de Tabelas do db
    Public sql As String

    Sub connectDb()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-OSTAHAP;Initial Catalog=cadastro;trusted_connection=YES;")
            MsgBox("Connected", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub
End Module

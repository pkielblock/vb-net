Module [Module]
    Public db As New ADODB.Connection 'Variavel conexao db
    Public rs As New ADODB.Recordset 'Variavel tabela db
    Public sql, resp As String 'Querys do CRUD, leitura e escrita

    Sub ConectarBanco()
        'Tratamento de Erro
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-V8UQ96A;Initial Catalog=cadastroClientes;trusted_connection=YES")
            MsgBox("Conexão Efetuada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro - Conexão Não Efetuada", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub LimparCadastro()
        With Form1
            .txtCPF.Clear()
            .txtNome.Clear()
            .txtEmail.Clear()
            .txtCPF.Focus()
            .btnDeletar.Enabled = False
        End With
    End Sub
End Module

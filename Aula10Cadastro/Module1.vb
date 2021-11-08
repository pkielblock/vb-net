Module Module1
    Public resp, diretorio As String
    Public db As New ADODB.Connection 'Variavel de conexão com o db
    Public rs As New ADODB.Recordset 'Variavel de Tabelas do db
    Public sql As String
    Public cont As Integer

    Sub connectDb()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-OSTAHAP;Initial Catalog=cadastro;trusted_connection=YES;")
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Sub limparCadastro()
        Try
            With frmClientes
                .txtCPF.Clear()
                .txtDataNasc.Text = Date.Now
                .txtNome.Clear()
                .txtCEP.Clear()
                .txtEndereco.Clear()
                .txtComplemento.Clear()
                .txtBairro.Clear()
                .txtCidade.Clear()
                .txtUF.Clear()
                .txtTelefone.Clear()
                .txtCelular.Clear()
                .txtEmail.Clear()
                .imgFoto.Load(Application.StartupPath & "\Photos\novoUser.png")
                .txtCPF.Focus()
            End With
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Sub carregarDados()
        Try
            sql = "select * from tbCadastro order by nome asc"
            rs = db.Execute(UCase(sql))

            With frmClientes.dgvDados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub
End Module

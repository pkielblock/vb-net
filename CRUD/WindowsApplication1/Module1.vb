Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, aux_cpf As String
    Public resp, diretorio As String
    Public cont As Integer
    Public conexao = Application.StartupPath & "\Banco_Dados\cadastro.mdb"

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & conexao)
            MsgBox("Conexão bem sucedida!!!")
        Catch ex As Exception
            MsgBox("Falha ao conectar!!!")
        End Try

        'Conexão com MySql
        'db=CreateObject("ADODB.Connection")
        'db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=nome_banco;UID=root;PWD=root")

        'Conexão com SQLServer
        'db=CreateObject("ADODB.Connection")
        'db.Open("Provider=SQLOLEDB;Data Source=nome_servidor;Initial Catalog=nome_banco;trusted_connection=yes;")
    End Sub

    Sub limpar_cadastro()
        With frm_cadastro
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_datanasc.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_comp.Clear()
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_uf.Clear()
            .txt_foneres.Clear()
            .txt_celular.Clear()
            .txt_email.Clear()
            .img_foto.Load(Application.StartupPath & "\imagens\foto_branco.png")
            .txt_cpf.Focus()
        End With
    End Sub

    Sub carregar_dados_grid()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            With frm_cadastro.dgv_dados
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
        
    End Sub

    Sub carrega_tipo()
        Try
            With frm_cadastro.cmb_tipo.Items
                .Clear()
                .Add("CPF")
                .Add("Nome")
            End With
            frm_cadastro.cmb_tipo.SelectedIndex = 1

        Catch ex As Exception
            Exit Sub
        End Try
            End Sub

End Module

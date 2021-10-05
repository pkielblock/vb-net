Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            sql = "select * from tbClientes where cpf ='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir cpf na tabela
                sql = "update tbClientes set nome ='" & txtNome.Text & "', email='" & txtEmail.Text & "' where cpf= '" & txtCPF.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Atualizados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                sql = "insert into tbClientes values ('" & txtCPF.Text & "','" & txtNome.Text & "','" & txtEmail.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro Efetuado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                LimparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro, cadastro não efetuado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Try
            sql = "select * from tbClientes where cpf='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtNome.Text = rs.Fields(1).Value
                txtEmail.Text = rs.Fields(2).Value
                btnDeletar.Enabled = True
            Else
                btnDeletar.Enabled = False
                MsgBox("CPF: " & txtCPF.Text & " Não Localizado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txtCPF_DoubleClick(sender As Object, e As EventArgs) Handles txtCPF.DoubleClick
        LimparCadastro()
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            sql = "select * from tbClientes where cpf ='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                resp = MsgBox("Deseja Excluir o CPF: " & txtCPF.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tbClientes where cpf ='" & txtCPF.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Registro Excluido.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    LimparCadastro()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao deletar.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
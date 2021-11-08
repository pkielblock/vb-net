Public Class frmClientes
    Private Sub imgFoto_Click(sender As Object, e As EventArgs) Handles imgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione Uma Foto"
                .InitialDirectory = Application.StartupPath & "net5.0-windows\Photos"
                .ShowDialog()
                diretorio = .FileName
                imgFoto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparCadastro()
        carregarDados()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If txtCPF.Text = "" Or
                txtDataNasc.Text = "" Or
                txtNome.Text = "" Or
                txtCEP.Text = "" Or
                txtEndereco.Text = "" Or
                txtComplemento.Text = "" Or
                txtBairro.Text = "" Or
                txtCidade.Text = "" Or
                txtUF.Text = "" Or
                txtTelefone.Text = "" Or
                txtCelular.Text = "" Or
                txtEmail.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "insert into tbCadastro values('" & txtCPF.Text & "', " &
                                                 "'" & txtDataNasc.Text & "', " &
                                                 "'" & txtNome.Text & "', " &
                                                 "'" & txtCEP.Text & "', " &
                                                 "'" & txtEndereco.Text & "', " &
                                                 "'" & txtComplemento.Text & "', " &
                                                 "'" & txtBairro.Text & "', " &
                                                 "'" & txtCidade.Text & "', " &
                                                 "'" & txtUF.Text & "', " &
                                                 "'" & txtTelefone.Text & "', " &
                                                 "'" & txtCelular.Text & "', " &
                                                 "'" & txtEmail.Text & "', " &
                                                 "'" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
                limparCadastro()
                carregarDados()
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCEP.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txtCEP.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtEndereco.Text = rs.Fields(1).Value
                txtCidade.Text = rs.Fields(2).Value
                txtBairro.Text = rs.Fields(3).Value
                txtUF.Text = rs.Fields(4).Value
                txtComplemento.Focus()
            Else
                MsgBox("CEP Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            If txtCPF.Text = "" Then
                MsgBox("Preencha o CPF!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Else
                sql = "delete from tbCadastro values('" & txtCPF.Text & "', " &
                                                 "'" & txtDataNasc.Text & "', " &
                                                 "'" & txtNome.Text & "', " &
                                                 "'" & txtCEP.Text & "', " &
                                                 "'" & txtEndereco.Text & "', " &
                                                 "'" & txtComplemento.Text & "', " &
                                                 "'" & txtBairro.Text & "', " &
                                                 "'" & txtCidade.Text & "', " &
                                                 "'" & txtUF.Text & "', " &
                                                 "'" & txtTelefone.Text & "', " &
                                                 "'" & txtCelular.Text & "', " &
                                                 "'" & txtEmail.Text & "', " &
                                                 "'" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Deletados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Try
            sql = "select * from tbCadastro where nome like '" & txtPesquisar.Text & "%'"
            rs = db.Execute(UCase(sql))

            With dgvDados
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

    Private Sub btnPesquisarCPF_Click(sender As Object, e As EventArgs) Handles btnPesquisarCPF.Click
        Try
            sql = "select * from tbCadastro where cpf='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtDataNasc.Text = rs.Fields(1).Value
                txtNome.Text = rs.Fields(2).Value
                txtCEP.Text = rs.Fields(3).Value
                txtEndereco.Text = rs.Fields(4).Value
                txtComplemento.Text = rs.Fields(5).Value
                txtBairro.Text = rs.Fields(6).Value
                txtCidade.Text = rs.Fields(7).Value
                txtUF.Text = rs.Fields(8).Value
                txtTelefone.Text = rs.Fields(9).Value
                txtCelular.Text = rs.Fields(10).Value
                txtEmail.Text = rs.Fields(11).Value
                diretorio = rs.Fields(12).Value
                imgFoto.Load(diretorio)
            Else
                MsgBox("CPF Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparCadastro()
    End Sub
End Class
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
        connectDb()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
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
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus
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
End Class
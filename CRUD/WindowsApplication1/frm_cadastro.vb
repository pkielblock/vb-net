Public Class frm_cadastro

    
  

    Private Sub img_foto_Click_1(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With carregar_fotos
                .Title = "Selecione uma Foto" 'Título da janela de diálogo
                .InitialDirectory = Application.StartupPath & "\Imagens"
                .ShowDialog() 'Abre a janela de diálogo específica
                diretorio = .FileName 'Armazena caminho da imagem
                img_foto.Load(diretorio) 'Carrega imagem selecionada no objeto
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecta_banco()
        Call carregar_dados_grid()
        Call carrega_tipo()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_cpf.Text = "" Or _
                txt_nome.Text = "" Or _
                txt_datanasc.Text = "" Or _
                txt_cep.Text = "" Or _
                txt_endereco.Text = "" Or _
                txt_comp.Text = "" Or _
                txt_bairro.Text = "" Or _
                txt_cidade.Text = "" Or _
                txt_uf.Text = "" Or _
                txt_foneres.Text = "" Or _
                txt_celular.Text = "" Or _
                txt_email.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', " & _
                    "'" & txt_datanasc.Text & "', '" & txt_cep.Text & "', '" & txt_endereco.Text & "', " & _
                    "'" & txt_comp.Text & "', '" & txt_bairro.Text & "', '" & txt_cidade.Text & "', '" & txt_uf.Text & "', " & _
                    "'" & txt_foneres.Text & "', '" & txt_celular.Text & "', '" & txt_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call carregar_dados_grid()
                Call limpar_cadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cpf_GotFocus(sender As Object, e As EventArgs) Handles txt_cpf.GotFocus
        Call limpar_cadastro()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus

        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(1).Value
                txt_datanasc.Text = rs.Fields(2).Value
                txt_cep.Text = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_comp.Text = rs.Fields(5).Value
                txt_bairro.Text = rs.Fields(6).Value
                txt_cidade.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_foneres.Text = rs.Fields(9).Value
                txt_celular.Text = rs.Fields(10).Value
                txt_email.Text = rs.Fields(11).Value
                img_foto.Load(rs.Fields(12).Value)
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
       
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_cadastro where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)
            With dgv_dados
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

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value.ToString
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_datanasc.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_foneres.Text = rs.Fields(9).Value
                        txt_celular.Text = rs.Fields(10).Value
                        txt_email.Text = rs.Fields(11).Value
                        img_foto.Load(rs.Fields(12).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value.ToString
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_datanasc.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_foneres.Text = rs.Fields(9).Value
                        txt_celular.Text = rs.Fields(10).Value
                        txt_email.Text = rs.Fields(11).Value
                        img_foto.Load(rs.Fields(12).Value)
                        TabControl1.Enabled = False
                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value.ToString
                    resp = MsgBox("Deseja realmente excluir o registro" + vbNewLine + "CPF:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        Call carregar_dados_grid()
                    End If

                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_busca_Click(sender As Object, e As EventArgs) Handles txt_busca.Click

    End Sub
End Class
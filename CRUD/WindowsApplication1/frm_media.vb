Public Class frm_media

    Dim n1, n2, n3, media As Double
    Dim sit As String

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Try
            n1 = CDbl(txt_nota1.Text)
            n2 = CDbl(txt_nota2.Text)
            n3 = CDbl(txt_nota3.Text)
            media = (n1 + n2 + n3) / 3
            If media < 4 Then
                sit = "Reprovado"
            ElseIf media >= 7 Then
                sit = "Aprovado"
            Else
                sit = "Exame"
            End If
            lbl_media.Text = media
            lbl_situacao.Text = sit
        Catch ex As Exception
            MsgBox("Erro ao processar!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_nota1.Clear()
        txt_nota2.Clear()
        txt_nota3.Clear()
        lbl_media.Text = ""
        lbl_situacao.Text = ""
        txt_nota1.Focus()
    End Sub
End Class
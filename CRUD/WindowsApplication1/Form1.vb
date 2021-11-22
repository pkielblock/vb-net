Public Class Form1

    Private Sub CálculoDeMédiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoDeMédiasToolStripMenuItem.Click
        frm_media.ShowDialog()
    End Sub

    Private Sub JoKenPoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JoKenPoToolStripMenuItem.Click
        Shell("E:\Arquivos\SI\Jo-Ken-Po\IuriBenatti_EduardoRosim.bat", AppWinStyle.NormalFocus)
        'Shell chama arquivos externos
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub CadastroClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroClientesToolStripMenuItem.Click
        frm_cadastro.ShowDialog()
    End Sub

    Private Sub GerenciamentoArquivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciamentoArquivosToolStripMenuItem.Click
        Shell("E:\Arquivos\SI\GErenciamentoAqruivo\gerenciamentodearq.bat", AppWinStyle.NormalFocus)
    End Sub

    Private Sub GeniusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeniusToolStripMenuItem.Click
        Shell("E:\Arquivos\SI\Ativs 2\Mestre da Memoria\Iuri Benatti _ Eduardo Rosim.vbs", AppWinStyle.NormalFocus)
    End Sub

    Private Sub ShowDoMIlhãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDoMIlhãoToolStripMenuItem.Click
        Shell("E:\Arquivos\SI\ShowDoMilhao\IuriBenatti_EduardoRosim.vbs", AppWinStyle.NormalFocus)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class

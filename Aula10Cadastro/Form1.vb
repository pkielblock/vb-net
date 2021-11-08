Public Class Form1
    Private Sub menuClientes_Click(sender As Object, e As EventArgs) Handles menuClientes.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub menuCalculadora_Click(sender As Object, e As EventArgs) Handles menuCalculadora.Click
        Shell("calc.exe")
    End Sub

    Private Sub menuSair_Click(sender As Object, e As EventArgs) Handles menuSair.Click
        Try
            resp = MsgBox("Deseja Encerrar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

            If resp = MsgBoxResult.Yes Then
                End
            End If
        Catch ex As Exception
            resp = MsgBox("Erro Ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDb()
    End Sub
End Class
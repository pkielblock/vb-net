<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_media
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_media = New System.Windows.Forms.Label()
        Me.lbl_situacao = New System.Windows.Forms.Label()
        Me.txt_nota1 = New System.Windows.Forms.TextBox()
        Me.txt_nota2 = New System.Windows.Forms.TextBox()
        Me.txt_nota3 = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RENDIMENTO INDIVIDUAL DO ALUNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOTA 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOTA 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NOTA 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MEDIA DO ALUNO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SITUAÇÃO FINAL"
        '
        'lbl_media
        '
        Me.lbl_media.BackColor = System.Drawing.Color.White
        Me.lbl_media.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_media.Location = New System.Drawing.Point(162, 82)
        Me.lbl_media.Name = "lbl_media"
        Me.lbl_media.Size = New System.Drawing.Size(109, 19)
        Me.lbl_media.TabIndex = 6
        Me.lbl_media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_situacao
        '
        Me.lbl_situacao.BackColor = System.Drawing.Color.White
        Me.lbl_situacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_situacao.Location = New System.Drawing.Point(162, 155)
        Me.lbl_situacao.Name = "lbl_situacao"
        Me.lbl_situacao.Size = New System.Drawing.Size(109, 19)
        Me.lbl_situacao.TabIndex = 7
        Me.lbl_situacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nota1
        '
        Me.txt_nota1.Location = New System.Drawing.Point(15, 82)
        Me.txt_nota1.Name = "txt_nota1"
        Me.txt_nota1.Size = New System.Drawing.Size(100, 20)
        Me.txt_nota1.TabIndex = 8
        Me.txt_nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nota2
        '
        Me.txt_nota2.Location = New System.Drawing.Point(15, 154)
        Me.txt_nota2.Name = "txt_nota2"
        Me.txt_nota2.Size = New System.Drawing.Size(100, 20)
        Me.txt_nota2.TabIndex = 9
        Me.txt_nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nota3
        '
        Me.txt_nota3.Location = New System.Drawing.Point(15, 225)
        Me.txt_nota3.Name = "txt_nota3"
        Me.txt_nota3.Size = New System.Drawing.Size(100, 20)
        Me.txt_nota3.TabIndex = 10
        Me.txt_nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(15, 280)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(279, 30)
        Me.btn_calcular.TabIndex = 11
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(15, 316)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(279, 30)
        Me.btn_limpar.TabIndex = 12
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'frm_media
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 361)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_nota3)
        Me.Controls.Add(Me.txt_nota2)
        Me.Controls.Add(Me.txt_nota1)
        Me.Controls.Add(Me.lbl_situacao)
        Me.Controls.Add(Me.lbl_media)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_media"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_media"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_media As System.Windows.Forms.Label
    Friend WithEvents lbl_situacao As System.Windows.Forms.Label
    Friend WithEvents txt_nota1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nota2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nota3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_limpar As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.tbCadastro = New System.Windows.Forms.TabControl()
        Me.tbDadosPessoais = New System.Windows.Forms.TabPage()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.lblNascimento = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.tbListagemClientes = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeletar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblPesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.txtPesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.btnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbCadastro.SuspendLayout()
        Me.tbDadosPessoais.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbListagemClientes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.tbDadosPessoais)
        Me.tbCadastro.Controls.Add(Me.tbListagemClientes)
        Me.tbCadastro.Location = New System.Drawing.Point(0, 24)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.SelectedIndex = 0
        Me.tbCadastro.Size = New System.Drawing.Size(437, 357)
        Me.tbCadastro.TabIndex = 0
        '
        'tbDadosPessoais
        '
        Me.tbDadosPessoais.Controls.Add(Me.txtEmail)
        Me.tbDadosPessoais.Controls.Add(Me.lblEmail)
        Me.tbDadosPessoais.Controls.Add(Me.txtCelular)
        Me.tbDadosPessoais.Controls.Add(Me.lblCelular)
        Me.tbDadosPessoais.Controls.Add(Me.txtTelefone)
        Me.tbDadosPessoais.Controls.Add(Me.lblTelefone)
        Me.tbDadosPessoais.Controls.Add(Me.txtUF)
        Me.tbDadosPessoais.Controls.Add(Me.lblUF)
        Me.tbDadosPessoais.Controls.Add(Me.txtCidade)
        Me.tbDadosPessoais.Controls.Add(Me.lblCidade)
        Me.tbDadosPessoais.Controls.Add(Me.txtBairro)
        Me.tbDadosPessoais.Controls.Add(Me.lblBairro)
        Me.tbDadosPessoais.Controls.Add(Me.txtComplemento)
        Me.tbDadosPessoais.Controls.Add(Me.lblComplemento)
        Me.tbDadosPessoais.Controls.Add(Me.txtEndereco)
        Me.tbDadosPessoais.Controls.Add(Me.lblEndereco)
        Me.tbDadosPessoais.Controls.Add(Me.txtCEP)
        Me.tbDadosPessoais.Controls.Add(Me.lblCEP)
        Me.tbDadosPessoais.Controls.Add(Me.txtNome)
        Me.tbDadosPessoais.Controls.Add(Me.lblNome)
        Me.tbDadosPessoais.Controls.Add(Me.txtDataNasc)
        Me.tbDadosPessoais.Controls.Add(Me.lblNascimento)
        Me.tbDadosPessoais.Controls.Add(Me.lblCPF)
        Me.tbDadosPessoais.Controls.Add(Me.txtCPF)
        Me.tbDadosPessoais.Controls.Add(Me.imgFoto)
        Me.tbDadosPessoais.Location = New System.Drawing.Point(4, 24)
        Me.tbDadosPessoais.Name = "tbDadosPessoais"
        Me.tbDadosPessoais.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDadosPessoais.Size = New System.Drawing.Size(429, 329)
        Me.tbDadosPessoais.TabIndex = 0
        Me.tbDadosPessoais.Text = "Dados Pessoais"
        Me.tbDadosPessoais.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(258, 267)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(165, 23)
        Me.txtEmail.TabIndex = 10
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(258, 249)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Email:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(158, 267)
        Me.txtCelular.Mask = "(99) 99999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(94, 23)
        Me.txtCelular.TabIndex = 9
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(158, 249)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(47, 15)
        Me.lblCelular.TabIndex = 21
        Me.lblCelular.Text = "Celular:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(58, 267)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(94, 23)
        Me.txtTelefone.TabIndex = 8
        Me.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(58, 249)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(54, 15)
        Me.lblTelefone.TabIndex = 19
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(8, 267)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(45, 23)
        Me.txtUF.TabIndex = 7
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(8, 249)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 15)
        Me.lblUF.TabIndex = 17
        Me.lblUF.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(293, 205)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(129, 23)
        Me.txtCidade.TabIndex = 6
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(293, 187)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(47, 15)
        Me.lblCidade.TabIndex = 15
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(151, 205)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(129, 23)
        Me.txtBairro.TabIndex = 5
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(151, 187)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(41, 15)
        Me.lblBairro.TabIndex = 13
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(7, 205)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(129, 23)
        Me.txtComplemento.TabIndex = 4
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(7, 187)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(87, 15)
        Me.lblComplemento.TabIndex = 11
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(105, 145)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(317, 23)
        Me.txtEndereco.TabIndex = 3
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(105, 127)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(59, 15)
        Me.lblEndereco.TabIndex = 9
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(7, 145)
        Me.txtCEP.Mask = "99999-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(83, 23)
        Me.txtCEP.TabIndex = 2
        Me.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(7, 127)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 15)
        Me.lblCEP.TabIndex = 7
        Me.lblCEP.Text = "CEP:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(7, 86)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(294, 23)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(7, 68)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(83, 15)
        Me.lblNome.TabIndex = 5
        Me.lblNome.Text = "Nome Cliente:"
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNasc.Location = New System.Drawing.Point(165, 27)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(136, 23)
        Me.txtDataNasc.TabIndex = 4
        Me.txtDataNasc.Value = New Date(2021, 10, 19, 0, 0, 0, 0)
        '
        'lblNascimento
        '
        Me.lblNascimento.AutoSize = True
        Me.lblNascimento.Location = New System.Drawing.Point(180, 9)
        Me.lblNascimento.Name = "lblNascimento"
        Me.lblNascimento.Size = New System.Drawing.Size(104, 15)
        Me.lblNascimento.TabIndex = 3
        Me.lblNascimento.Text = "Data Nascimento: "
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(7, 9)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(31, 15)
        Me.lblCPF.TabIndex = 2
        Me.lblCPF.Text = "CPF:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(7, 27)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(129, 23)
        Me.txtCPF.TabIndex = 0
        Me.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'imgFoto
        '
        Me.imgFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgFoto.Image = CType(resources.GetObject("imgFoto.Image"), System.Drawing.Image)
        Me.imgFoto.Location = New System.Drawing.Point(322, 6)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(100, 103)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto.TabIndex = 0
        Me.imgFoto.TabStop = False
        '
        'tbListagemClientes
        '
        Me.tbListagemClientes.Controls.Add(Me.DataGridView1)
        Me.tbListagemClientes.Location = New System.Drawing.Point(4, 24)
        Me.tbListagemClientes.Name = "tbListagemClientes"
        Me.tbListagemClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbListagemClientes.Size = New System.Drawing.Size(429, 329)
        Me.tbListagemClientes.TabIndex = 1
        Me.tbListagemClientes.Text = "Listagem de Clientes"
        Me.tbListagemClientes.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(409, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalvar, Me.ToolStripSeparator2, Me.btnDeletar, Me.ToolStripSeparator3, Me.lblPesquisar, Me.txtPesquisar, Me.btnPesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(433, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalvar
        '
        Me.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(23, 22)
        Me.btnSalvar.Text = "ToolStripButton1"
        Me.btnSalvar.ToolTipText = "Salvar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDeletar
        '
        Me.btnDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(23, 22)
        Me.btnDeletar.Text = "ToolStripButton2"
        Me.btnDeletar.ToolTipText = "Deletar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'lblPesquisar
        '
        Me.lblPesquisar.Name = "lblPesquisar"
        Me.lblPesquisar.Size = New System.Drawing.Size(63, 22)
        Me.lblPesquisar.Text = "Pesquisar: "
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(100, 25)
        '
        'btnPesquisar
        '
        Me.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(23, 22)
        Me.btnPesquisar.Text = "ToolStripButton3"
        Me.btnPesquisar.ToolTipText = "Pesquisar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 347)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbCadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Clientes"
        Me.tbCadastro.ResumeLayout(False)
        Me.tbDadosPessoais.ResumeLayout(False)
        Me.tbDadosPessoais.PerformLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbListagemClientes.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCadastro As TabControl
    Friend WithEvents tbDadosPessoais As TabPage
    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents tbListagemClientes As TabPage
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtDataNasc As DateTimePicker
    Friend WithEvents lblNascimento As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtUF As TextBox
    Friend WithEvents lblUF As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnDeletar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents lblPesquisar As ToolStripLabel
    Friend WithEvents txtPesquisar As ToolStripTextBox
    Friend WithEvents btnPesquisar As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

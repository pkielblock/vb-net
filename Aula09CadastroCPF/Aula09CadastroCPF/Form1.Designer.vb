<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.btnDeletar = New System.Windows.Forms.ToolStripButton()
        Me.btnProcurar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(12, 36)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(31, 15)
        Me.lblCPF.TabIndex = 0
        Me.lblCPF.Text = "CPF:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(12, 65)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 94)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(61, 33)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(104, 23)
        Me.txtCPF.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(61, 62)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 23)
        Me.txtNome.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(61, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 23)
        Me.txtEmail.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdicionar, Me.btnDeletar, Me.btnProcurar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(306, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(23, 22)
        Me.btnAdicionar.Text = "Cadastrar"
        '
        'btnDeletar
        '
        Me.btnDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletar.Enabled = False
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(23, 22)
        Me.btnDeletar.Text = "Remover"
        '
        'btnProcurar
        '
        Me.btnProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProcurar.Image = CType(resources.GetObject("btnProcurar.Image"), System.Drawing.Image)
        Me.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(23, 22)
        Me.btnProcurar.Text = "Procurar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 127)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCPF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCPF As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdicionar As ToolStripButton
    Friend WithEvents btnDeletar As ToolStripButton
    Friend WithEvents btnProcurar As ToolStripButton
End Class

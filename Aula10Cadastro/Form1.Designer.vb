<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFuncionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGerenciamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuContas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCriarConta = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlterarConta = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAplicativos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCalculadora = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEncerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastro, Me.menuGerenciamento, Me.menuAplicativos, Me.menuEncerrar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(430, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuCadastro
        '
        Me.menuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuClientes, Me.FuncionariosToolStripMenuItem, Me.menuFuncionarios})
        Me.menuCadastro.Image = CType(resources.GetObject("menuCadastro.Image"), System.Drawing.Image)
        Me.menuCadastro.Name = "menuCadastro"
        Me.menuCadastro.Size = New System.Drawing.Size(95, 20)
        Me.menuCadastro.Text = "&CADASTRO"
        '
        'menuClientes
        '
        Me.menuClientes.Image = CType(resources.GetObject("menuClientes.Image"), System.Drawing.Image)
        Me.menuClientes.Name = "menuClientes"
        Me.menuClientes.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.menuClientes.Size = New System.Drawing.Size(161, 22)
        Me.menuClientes.Text = "Clientes"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(158, 6)
        '
        'menuFuncionarios
        '
        Me.menuFuncionarios.Image = CType(resources.GetObject("menuFuncionarios.Image"), System.Drawing.Image)
        Me.menuFuncionarios.Name = "menuFuncionarios"
        Me.menuFuncionarios.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.menuFuncionarios.Size = New System.Drawing.Size(161, 22)
        Me.menuFuncionarios.Text = "Funcionários"
        '
        'menuGerenciamento
        '
        Me.menuGerenciamento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuContas})
        Me.menuGerenciamento.Image = CType(resources.GetObject("menuGerenciamento.Image"), System.Drawing.Image)
        Me.menuGerenciamento.Name = "menuGerenciamento"
        Me.menuGerenciamento.Size = New System.Drawing.Size(130, 20)
        Me.menuGerenciamento.Text = "&GERENCIAMENTO"
        '
        'menuContas
        '
        Me.menuContas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCriarConta, Me.menuAlterarConta})
        Me.menuContas.Image = CType(resources.GetObject("menuContas.Image"), System.Drawing.Image)
        Me.menuContas.Name = "menuContas"
        Me.menuContas.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.menuContas.Size = New System.Drawing.Size(130, 22)
        Me.menuContas.Text = "Contas"
        '
        'menuCriarConta
        '
        Me.menuCriarConta.Image = CType(resources.GetObject("menuCriarConta.Image"), System.Drawing.Image)
        Me.menuCriarConta.Name = "menuCriarConta"
        Me.menuCriarConta.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.menuCriarConta.Size = New System.Drawing.Size(163, 22)
        Me.menuCriarConta.Text = "Criar Conta"
        '
        'menuAlterarConta
        '
        Me.menuAlterarConta.Image = CType(resources.GetObject("menuAlterarConta.Image"), System.Drawing.Image)
        Me.menuAlterarConta.Name = "menuAlterarConta"
        Me.menuAlterarConta.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.menuAlterarConta.Size = New System.Drawing.Size(163, 22)
        Me.menuAlterarConta.Text = "Alterar Conta"
        '
        'menuAplicativos
        '
        Me.menuAplicativos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCalculadora})
        Me.menuAplicativos.Image = CType(resources.GetObject("menuAplicativos.Image"), System.Drawing.Image)
        Me.menuAplicativos.Name = "menuAplicativos"
        Me.menuAplicativos.Size = New System.Drawing.Size(105, 20)
        Me.menuAplicativos.Text = "&APLICATIVOS"
        '
        'menuCalculadora
        '
        Me.menuCalculadora.Image = CType(resources.GetObject("menuCalculadora.Image"), System.Drawing.Image)
        Me.menuCalculadora.Name = "menuCalculadora"
        Me.menuCalculadora.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.menuCalculadora.Size = New System.Drawing.Size(156, 22)
        Me.menuCalculadora.Text = "Calculadora"
        '
        'menuEncerrar
        '
        Me.menuEncerrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSair})
        Me.menuEncerrar.Image = CType(resources.GetObject("menuEncerrar.Image"), System.Drawing.Image)
        Me.menuEncerrar.Name = "menuEncerrar"
        Me.menuEncerrar.Size = New System.Drawing.Size(93, 20)
        Me.menuEncerrar.Text = "&ENCERRAR"
        '
        'menuSair
        '
        Me.menuSair.Image = CType(resources.GetObject("menuSair.Image"), System.Drawing.Image)
        Me.menuSair.Name = "menuSair"
        Me.menuSair.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.menuSair.Size = New System.Drawing.Size(173, 22)
        Me.menuSair.Text = "Sair do Sistema"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 357)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuCadastro As ToolStripMenuItem
    Friend WithEvents menuClientes As ToolStripMenuItem
    Friend WithEvents menuGerenciamento As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As ToolStripSeparator
    Friend WithEvents menuFuncionarios As ToolStripMenuItem
    Friend WithEvents menuContas As ToolStripMenuItem
    Friend WithEvents menuCriarConta As ToolStripMenuItem
    Friend WithEvents menuAlterarConta As ToolStripMenuItem
    Friend WithEvents menuAplicativos As ToolStripMenuItem
    Friend WithEvents menuCalculadora As ToolStripMenuItem
    Friend WithEvents menuEncerrar As ToolStripMenuItem
    Friend WithEvents menuSair As ToolStripMenuItem
End Class
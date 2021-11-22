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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROGRAMASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoKenPoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoArquivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeniusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDoMIlhãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualBasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BásicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CálculoDeMédiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvançadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCERRARPROGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROGRAMASToolStripMenuItem, Me.ENCERRARPROGRAMAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROGRAMASToolStripMenuItem
        '
        Me.PROGRAMASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BatchToolStripMenuItem, Me.VBScriptToolStripMenuItem, Me.VisualBasicToolStripMenuItem})
        Me.PROGRAMASToolStripMenuItem.Name = "PROGRAMASToolStripMenuItem"
        Me.PROGRAMASToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PROGRAMASToolStripMenuItem.Text = "&PROGRAMAS"
        '
        'BatchToolStripMenuItem
        '
        Me.BatchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JoKenPoToolStripMenuItem, Me.GerenciamentoArquivosToolStripMenuItem})
        Me.BatchToolStripMenuItem.Image = CType(resources.GetObject("BatchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem"
        Me.BatchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BatchToolStripMenuItem.Text = "Batch"
        '
        'JoKenPoToolStripMenuItem
        '
        Me.JoKenPoToolStripMenuItem.Name = "JoKenPoToolStripMenuItem"
        Me.JoKenPoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JoKenPoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.JoKenPoToolStripMenuItem.Text = "Jo-Ken-Po"
        '
        'GerenciamentoArquivosToolStripMenuItem
        '
        Me.GerenciamentoArquivosToolStripMenuItem.Name = "GerenciamentoArquivosToolStripMenuItem"
        Me.GerenciamentoArquivosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GerenciamentoArquivosToolStripMenuItem.Text = "Gerenciamento Arquivos"
        '
        'VBScriptToolStripMenuItem
        '
        Me.VBScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeniusToolStripMenuItem, Me.ShowDoMIlhãoToolStripMenuItem})
        Me.VBScriptToolStripMenuItem.Name = "VBScriptToolStripMenuItem"
        Me.VBScriptToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VBScriptToolStripMenuItem.Text = "VBScript"
        '
        'GeniusToolStripMenuItem
        '
        Me.GeniusToolStripMenuItem.Name = "GeniusToolStripMenuItem"
        Me.GeniusToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GeniusToolStripMenuItem.Text = "Genius"
        '
        'ShowDoMIlhãoToolStripMenuItem
        '
        Me.ShowDoMIlhãoToolStripMenuItem.Name = "ShowDoMIlhãoToolStripMenuItem"
        Me.ShowDoMIlhãoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowDoMIlhãoToolStripMenuItem.Text = "Show do MIlhão"
        '
        'VisualBasicToolStripMenuItem
        '
        Me.VisualBasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BásicoToolStripMenuItem, Me.IntermediarioToolStripMenuItem, Me.AvançadoToolStripMenuItem})
        Me.VisualBasicToolStripMenuItem.Name = "VisualBasicToolStripMenuItem"
        Me.VisualBasicToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VisualBasicToolStripMenuItem.Text = "Visual Basic"
        '
        'BásicoToolStripMenuItem
        '
        Me.BásicoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoDeMédiasToolStripMenuItem})
        Me.BásicoToolStripMenuItem.Name = "BásicoToolStripMenuItem"
        Me.BásicoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BásicoToolStripMenuItem.Text = "Básico"
        '
        'CálculoDeMédiasToolStripMenuItem
        '
        Me.CálculoDeMédiasToolStripMenuItem.Name = "CálculoDeMédiasToolStripMenuItem"
        Me.CálculoDeMédiasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.CálculoDeMédiasToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CálculoDeMédiasToolStripMenuItem.Text = "Cálculo de Médias"
        Me.CálculoDeMédiasToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'IntermediarioToolStripMenuItem
        '
        Me.IntermediarioToolStripMenuItem.Name = "IntermediarioToolStripMenuItem"
        Me.IntermediarioToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.IntermediarioToolStripMenuItem.Text = "Intermediário"
        '
        'AvançadoToolStripMenuItem
        '
        Me.AvançadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroClientesToolStripMenuItem})
        Me.AvançadoToolStripMenuItem.Name = "AvançadoToolStripMenuItem"
        Me.AvançadoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.AvançadoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AvançadoToolStripMenuItem.Text = "Avançado"
        '
        'ENCERRARPROGRAMAToolStripMenuItem
        '
        Me.ENCERRARPROGRAMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ENCERRARPROGRAMAToolStripMenuItem.Name = "ENCERRARPROGRAMAToolStripMenuItem"
        Me.ENCERRARPROGRAMAToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.ENCERRARPROGRAMAToolStripMenuItem.Text = "&ENCERRAR PROGRAMA"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'CadastroClientesToolStripMenuItem
        '
        Me.CadastroClientesToolStripMenuItem.Name = "CadastroClientesToolStripMenuItem"
        Me.CadastroClientesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CadastroClientesToolStripMenuItem.Text = "Cadastro Clientes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PROGRAMASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JoKenPoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerenciamentoArquivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeniusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDoMIlhãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualBasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BásicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntermediarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvançadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENCERRARPROGRAMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CálculoDeMédiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtkotae = New System.Windows.Forms.TextBox()
        Me.txtatai1 = New System.Windows.Forms.TextBox()
        Me.txtatai2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btndevide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtkotae
        '
        Me.txtkotae.Location = New System.Drawing.Point(200, 55)
        Me.txtkotae.Name = "txtkotae"
        Me.txtkotae.Size = New System.Drawing.Size(130, 19)
        Me.txtkotae.TabIndex = 0
        '
        'txtatai1
        '
        Me.txtatai1.Location = New System.Drawing.Point(107, 142)
        Me.txtatai1.Name = "txtatai1"
        Me.txtatai1.Size = New System.Drawing.Size(115, 19)
        Me.txtatai1.TabIndex = 1
        '
        'txtatai2
        '
        Me.txtatai2.Location = New System.Drawing.Point(323, 142)
        Me.txtatai2.Name = "txtatai2"
        Me.txtatai2.Size = New System.Drawing.Size(115, 19)
        Me.txtatai2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "値１"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "値２"
        '
        'btnplus
        '
        Me.btnplus.Location = New System.Drawing.Point(78, 274)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(71, 61)
        Me.btnplus.TabIndex = 5
        Me.btnplus.Text = "＋"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'btnminus
        '
        Me.btnminus.Location = New System.Drawing.Point(176, 274)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(71, 61)
        Me.btnminus.TabIndex = 6
        Me.btnminus.Text = "－"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btnmulti
        '
        Me.btnmulti.Location = New System.Drawing.Point(281, 274)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(71, 61)
        Me.btnmulti.TabIndex = 7
        Me.btnmulti.Text = "＊"
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btndevide
        '
        Me.btndevide.Location = New System.Drawing.Point(367, 274)
        Me.btndevide.Name = "btndevide"
        Me.btndevide.Size = New System.Drawing.Size(71, 61)
        Me.btndevide.TabIndex = 8
        Me.btndevide.Text = "÷"
        Me.btndevide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 457)
        Me.Controls.Add(Me.btndevide)
        Me.Controls.Add(Me.btnmulti)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtatai2)
        Me.Controls.Add(Me.txtatai1)
        Me.Controls.Add(Me.txtkotae)
        Me.Name = "Form1"
        Me.Text = "電卓"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtkotae As TextBox
    Friend WithEvents txtatai1 As TextBox
    Friend WithEvents txtatai2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnplus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btndevide As Button
End Class

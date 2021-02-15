<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.RecordFormButton = New System.Windows.Forms.Button()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EndButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppTitle
        '
        Me.AppTitle.AutoSize = True
        Me.AppTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AppTitle.Font = New System.Drawing.Font("游明朝 Demibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AppTitle.Location = New System.Drawing.Point(25, 28)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(376, 39)
        Me.AppTitle.TabIndex = 0
        Me.AppTitle.Text = "会計仕訳ソフト　T-Journal"
        '
        'RecordFormButton
        '
        Me.RecordFormButton.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RecordFormButton.Location = New System.Drawing.Point(272, 81)
        Me.RecordFormButton.Name = "RecordFormButton"
        Me.RecordFormButton.Size = New System.Drawing.Size(129, 66)
        Me.RecordFormButton.TabIndex = 1
        Me.RecordFormButton.Text = "仕訳登録"
        Me.RecordFormButton.UseVisualStyleBackColor = True
        '
        'CheckButton
        '
        Me.CheckButton.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckButton.Location = New System.Drawing.Point(272, 170)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(129, 66)
        Me.CheckButton.TabIndex = 2
        Me.CheckButton.Text = "仕訳確認"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'EndButton
        '
        Me.EndButton.Font = New System.Drawing.Font("游ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EndButton.Location = New System.Drawing.Point(308, 256)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(93, 36)
        Me.EndButton.TabIndex = 4
        Me.EndButton.Text = "終了"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 321)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.RecordFormButton)
        Me.Controls.Add(Me.AppTitle)
        Me.Name = "Menu"
        Me.Text = "メニュー"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AppTitle As Label
    Friend WithEvents RecordFormButton As Button
    Friend WithEvents CheckButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EndButton As Button
End Class

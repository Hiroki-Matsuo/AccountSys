<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VoucherBaseForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.DebitAmount1 = New System.Windows.Forms.TextBox()
        Me.CreditAmount1 = New System.Windows.Forms.TextBox()
        Me.DebitSubject1 = New System.Windows.Forms.ComboBox()
        Me.CreditSubject1 = New System.Windows.Forms.ComboBox()
        Me.DebitAmount2 = New System.Windows.Forms.TextBox()
        Me.CreditAmount2 = New System.Windows.Forms.TextBox()
        Me.DebitSubject2 = New System.Windows.Forms.ComboBox()
        Me.CreditSubject2 = New System.Windows.Forms.ComboBox()
        Me.DebitAmount3 = New System.Windows.Forms.TextBox()
        Me.CreditAmount3 = New System.Windows.Forms.TextBox()
        Me.DebitSubject3 = New System.Windows.Forms.ComboBox()
        Me.CreditSubject3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DebitGroup3Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.CreditGroup3Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.DebitGroup2Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.CreditGroup2Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.DebitGroup1Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.CreditGroup1Combo = New ACCOUNT_SYSTEM.AccountGroupCombobox()
        Me.MyComboBoxItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyComboBoxItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MyComboBoxItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyComboBoxItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "伝票日"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(473, 84)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(147, 19)
        Me.DateTimePicker1.TabIndex = 50
        '
        'EndButton
        '
        Me.EndButton.Font = New System.Drawing.Font("游ゴシック", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EndButton.Location = New System.Drawing.Point(12, 375)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(108, 39)
        Me.EndButton.TabIndex = 49
        Me.EndButton.Text = "終了"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'DebitAmount1
        '
        Me.DebitAmount1.Location = New System.Drawing.Point(205, 197)
        Me.DebitAmount1.Name = "DebitAmount1"
        Me.DebitAmount1.Size = New System.Drawing.Size(116, 19)
        Me.DebitAmount1.TabIndex = 30
        '
        'CreditAmount1
        '
        Me.CreditAmount1.Location = New System.Drawing.Point(504, 197)
        Me.CreditAmount1.Name = "CreditAmount1"
        Me.CreditAmount1.Size = New System.Drawing.Size(116, 19)
        Me.CreditAmount1.TabIndex = 31
        '
        'DebitSubject1
        '
        Me.DebitSubject1.DataSource = Me.MyComboBoxItemBindingSource
        Me.DebitSubject1.DisplayMember = "Name"
        Me.DebitSubject1.FormattingEnabled = True
        Me.DebitSubject1.Location = New System.Drawing.Point(115, 196)
        Me.DebitSubject1.Name = "DebitSubject1"
        Me.DebitSubject1.Size = New System.Drawing.Size(84, 20)
        Me.DebitSubject1.TabIndex = 32
        Me.DebitSubject1.ValueMember = "Id"
        '
        'CreditSubject1
        '
        Me.CreditSubject1.DataSource = Me.MyComboBoxItemBindingSource
        Me.CreditSubject1.DisplayMember = "Name"
        Me.CreditSubject1.FormattingEnabled = True
        Me.CreditSubject1.Location = New System.Drawing.Point(422, 196)
        Me.CreditSubject1.Name = "CreditSubject1"
        Me.CreditSubject1.Size = New System.Drawing.Size(76, 20)
        Me.CreditSubject1.TabIndex = 34
        Me.CreditSubject1.ValueMember = "Id"
        '
        'DebitAmount2
        '
        Me.DebitAmount2.Location = New System.Drawing.Point(205, 234)
        Me.DebitAmount2.Name = "DebitAmount2"
        Me.DebitAmount2.Size = New System.Drawing.Size(116, 19)
        Me.DebitAmount2.TabIndex = 36
        '
        'CreditAmount2
        '
        Me.CreditAmount2.Location = New System.Drawing.Point(504, 234)
        Me.CreditAmount2.Name = "CreditAmount2"
        Me.CreditAmount2.Size = New System.Drawing.Size(116, 19)
        Me.CreditAmount2.TabIndex = 37
        '
        'DebitSubject2
        '
        Me.DebitSubject2.FormattingEnabled = True
        Me.DebitSubject2.Location = New System.Drawing.Point(115, 233)
        Me.DebitSubject2.Name = "DebitSubject2"
        Me.DebitSubject2.Size = New System.Drawing.Size(84, 20)
        Me.DebitSubject2.TabIndex = 38
        '
        'CreditSubject2
        '
        Me.CreditSubject2.FormattingEnabled = True
        Me.CreditSubject2.Location = New System.Drawing.Point(422, 233)
        Me.CreditSubject2.Name = "CreditSubject2"
        Me.CreditSubject2.Size = New System.Drawing.Size(76, 20)
        Me.CreditSubject2.TabIndex = 40
        '
        'DebitAmount3
        '
        Me.DebitAmount3.Location = New System.Drawing.Point(205, 271)
        Me.DebitAmount3.Name = "DebitAmount3"
        Me.DebitAmount3.Size = New System.Drawing.Size(116, 19)
        Me.DebitAmount3.TabIndex = 42
        '
        'CreditAmount3
        '
        Me.CreditAmount3.Location = New System.Drawing.Point(504, 271)
        Me.CreditAmount3.Name = "CreditAmount3"
        Me.CreditAmount3.Size = New System.Drawing.Size(116, 19)
        Me.CreditAmount3.TabIndex = 43
        '
        'DebitSubject3
        '
        Me.DebitSubject3.FormattingEnabled = True
        Me.DebitSubject3.Location = New System.Drawing.Point(115, 270)
        Me.DebitSubject3.Name = "DebitSubject3"
        Me.DebitSubject3.Size = New System.Drawing.Size(84, 20)
        Me.DebitSubject3.TabIndex = 44
        '
        'CreditSubject3
        '
        Me.CreditSubject3.FormattingEnabled = True
        Me.CreditSubject3.Location = New System.Drawing.Point(422, 270)
        Me.CreditSubject3.Name = "CreditSubject3"
        Me.CreditSubject3.Size = New System.Drawing.Size(76, 20)
        Me.CreditSubject3.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "科目種別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "科目種別"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "金額"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "勘定科目"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(543, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "金額"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "勘定科目"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("游ゴシック", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 40)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "仕訳"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 28
        Me.LineShape1.X2 = 645
        Me.LineShape1.Y1 = 170
        Me.LineShape1.Y2 = 170
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 338
        Me.LineShape2.X2 = 338
        Me.LineShape2.Y1 = 169
        Me.LineShape2.Y2 = 304
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(676, 426)
        Me.ShapeContainer1.TabIndex = 59
        Me.ShapeContainer1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "借方"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "貸方"
        '
        'DebitGroup3Combo
        '
        Me.DebitGroup3Combo.FormattingEnabled = True
        Me.DebitGroup3Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.DebitGroup3Combo.Location = New System.Drawing.Point(47, 270)
        Me.DebitGroup3Combo.Name = "DebitGroup3Combo"
        Me.DebitGroup3Combo.Size = New System.Drawing.Size(62, 20)
        Me.DebitGroup3Combo.TabIndex = 47
        '
        'CreditGroup3Combo
        '
        Me.CreditGroup3Combo.FormattingEnabled = True
        Me.CreditGroup3Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.CreditGroup3Combo.Location = New System.Drawing.Point(354, 270)
        Me.CreditGroup3Combo.Name = "CreditGroup3Combo"
        Me.CreditGroup3Combo.Size = New System.Drawing.Size(62, 20)
        Me.CreditGroup3Combo.TabIndex = 45
        '
        'DebitGroup2Combo
        '
        Me.DebitGroup2Combo.FormattingEnabled = True
        Me.DebitGroup2Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.DebitGroup2Combo.Location = New System.Drawing.Point(47, 233)
        Me.DebitGroup2Combo.Name = "DebitGroup2Combo"
        Me.DebitGroup2Combo.Size = New System.Drawing.Size(62, 20)
        Me.DebitGroup2Combo.TabIndex = 41
        '
        'CreditGroup2Combo
        '
        Me.CreditGroup2Combo.FormattingEnabled = True
        Me.CreditGroup2Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.CreditGroup2Combo.Location = New System.Drawing.Point(354, 233)
        Me.CreditGroup2Combo.Name = "CreditGroup2Combo"
        Me.CreditGroup2Combo.Size = New System.Drawing.Size(62, 20)
        Me.CreditGroup2Combo.TabIndex = 39
        '
        'DebitGroup1Combo
        '
        Me.DebitGroup1Combo.FormattingEnabled = True
        Me.DebitGroup1Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.DebitGroup1Combo.Location = New System.Drawing.Point(47, 196)
        Me.DebitGroup1Combo.Name = "DebitGroup1Combo"
        Me.DebitGroup1Combo.Size = New System.Drawing.Size(62, 20)
        Me.DebitGroup1Combo.TabIndex = 35
        '
        'CreditGroup1Combo
        '
        Me.CreditGroup1Combo.FormattingEnabled = True
        Me.CreditGroup1Combo.Items.AddRange(New Object() {"", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用", "", "資産", "負債", "純資産", "収益", "費用"})
        Me.CreditGroup1Combo.Location = New System.Drawing.Point(354, 196)
        Me.CreditGroup1Combo.Name = "CreditGroup1Combo"
        Me.CreditGroup1Combo.Size = New System.Drawing.Size(62, 20)
        Me.CreditGroup1Combo.TabIndex = 33
        '
        'MyComboBoxItemBindingSource
        '
        Me.MyComboBoxItemBindingSource.DataSource = GetType(ACCOUNT_SYSTEM.MyComboBoxItem)
        '
        'MyComboBoxItemBindingSource1
        '
        Me.MyComboBoxItemBindingSource1.DataSource = GetType(ACCOUNT_SYSTEM.MyComboBoxItem)
        '
        'VoucherBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 426)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DebitGroup3Combo)
        Me.Controls.Add(Me.CreditSubject3)
        Me.Controls.Add(Me.CreditGroup3Combo)
        Me.Controls.Add(Me.DebitSubject3)
        Me.Controls.Add(Me.CreditAmount3)
        Me.Controls.Add(Me.DebitAmount3)
        Me.Controls.Add(Me.DebitGroup2Combo)
        Me.Controls.Add(Me.CreditSubject2)
        Me.Controls.Add(Me.CreditGroup2Combo)
        Me.Controls.Add(Me.DebitSubject2)
        Me.Controls.Add(Me.CreditAmount2)
        Me.Controls.Add(Me.DebitAmount2)
        Me.Controls.Add(Me.DebitGroup1Combo)
        Me.Controls.Add(Me.CreditSubject1)
        Me.Controls.Add(Me.CreditGroup1Combo)
        Me.Controls.Add(Me.DebitSubject1)
        Me.Controls.Add(Me.CreditAmount1)
        Me.Controls.Add(Me.DebitAmount1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "VoucherBaseForm"
        Me.Text = "Form1"
        CType(Me.MyComboBoxItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyComboBoxItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents EndButton As Button
    Friend WithEvents DebitAmount1 As TextBox
    Friend WithEvents CreditAmount1 As TextBox
    Friend WithEvents DebitSubject1 As ComboBox
    Friend WithEvents CreditGroup1Combo As AccountGroupCombobox
    Friend WithEvents CreditSubject1 As ComboBox
    Friend WithEvents DebitGroup1Combo As AccountGroupCombobox
    Friend WithEvents DebitAmount2 As TextBox
    Friend WithEvents CreditAmount2 As TextBox
    Friend WithEvents DebitSubject2 As ComboBox
    Friend WithEvents CreditGroup2Combo As AccountGroupCombobox
    Friend WithEvents CreditSubject2 As ComboBox
    Friend WithEvents DebitGroup2Combo As AccountGroupCombobox
    Friend WithEvents DebitAmount3 As TextBox
    Friend WithEvents CreditAmount3 As TextBox
    Friend WithEvents DebitSubject3 As ComboBox
    Friend WithEvents CreditGroup3Combo As AccountGroupCombobox
    Friend WithEvents CreditSubject3 As ComboBox
    Friend WithEvents DebitGroup3Combo As AccountGroupCombobox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Protected WithEvents Label9 As Label
    Protected WithEvents Label10 As Label
    Protected WithEvents Label1 As Label
    Friend WithEvents MyComboBoxItemBindingSource As BindingSource
    Friend WithEvents MyComboBoxItemBindingSource1 As BindingSource
End Class

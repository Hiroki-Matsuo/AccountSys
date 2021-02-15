Public Class AccountGroupCombobox
    Inherits ComboBox

    ''' <summary>
    ''' 選択肢を追加する
    ''' </summary>
    Protected Overrides Sub InitLayout()

        MyBase.InitLayout()

        Me.Items.Clear()

        '勘定科目種別
        Dim arrayAccountGroup() As String = {"", "資産", "負債", "純資産", "収益", "費用"}

        For i = 0 To arrayAccountGroup.Length - 1
            '1つずつ追加
            Me.Items.Add(arrayAccountGroup(i))

        Next

    End Sub


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        MyBase.OnPaint(e)

    End Sub

End Class

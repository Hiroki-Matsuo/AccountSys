Public Class RegisterForm

    Const TITLE_REG_FORM As String = "仕訳登録"

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' 登録ボタンを押す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        '各ジャーナルの構造体を格納する配列を生成
        Dim journals = New List(Of VoucherRecord)

        Dim journalNo As Integer = 1

        'Amountに入力があれば構造体を作成し配列に格納する
        If DebitAmount1.TextLength > 0 Then

            Dim dAmount1 As Integer = Integer.Parse(DebitAmount1.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, True, DebitSubject1.SelectedIndex, dAmount1))

            journalNo += 1

        End If

        If DebitAmount2.TextLength > 0 Then

            Dim dAmount2 As Integer = Integer.Parse(DebitAmount2.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, True, DebitSubject2.SelectedIndex, dAmount2))

            journalNo += 1

        End If

        If DebitAmount3.TextLength > 0 Then

            Dim dAmount3 As Integer = Integer.Parse(DebitAmount3.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, True, DebitSubject3.SelectedIndex, dAmount3))

            journalNo += 1

        End If

        If CreditAmount1.TextLength > 0 Then

            Dim cAmount1 As Integer = Integer.Parse(CreditAmount1.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, False, CreditSubject1.SelectedIndex, cAmount1))

            journalNo += 1

        End If

        If CreditAmount2.TextLength > 0 Then

            Dim camount2 As Integer = Integer.Parse(CreditAmount2.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, False, CreditSubject2.SelectedIndex, camount2))

            journalNo += 1

        End If


        If CreditAmount3.TextLength > 0 Then

            Dim camount3 As Integer = Integer.Parse(CreditAmount3.Text)

            journals.Add(New VoucherRecord _
                         (journalNo, False, CreditSubject3.SelectedIndex, camount3))

            journalNo += 1

        End If

        'DAOインスタンスを生成
        Dim jounalVoucherDao = New JounalVoucherDao

        'DB挿入
        jounalVoucherDao.InsertJounalVoucher(JounalTextBox.Text, journals)

        '本来は結果によって変えないといけない
        MsgBox("完了", vbOKOnly)

    End Sub
End Class
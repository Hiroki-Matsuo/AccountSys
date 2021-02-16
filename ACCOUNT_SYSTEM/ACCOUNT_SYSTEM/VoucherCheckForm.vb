''' <summary>
''' 仕訳確認画面
''' </summary>
Public Class VoucherCheckForm

    ''' <summary>
    ''' Daoを使ってDBからデータを取得する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OutputButton_Click(sender As Object, e As EventArgs) Handles OutputButton.Click

        Dim jounalVoucherDao As New JounalVoucherDao

        Dim voucherData As DataTable

        'Daoより取得
        voucherData = jounalVoucherDao.GetJounalDetail

        Call OutputVoucherData(voucherData)

    End Sub

    ''' <summary>
    ''' コンボボックスとテキストを書き換え不可にする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VoucherCheckForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MakeWindowDataReadonly()

    End Sub


    ''' <summary>
    ''' 画面に取得した仕訳伝票情報を出力する
    ''' </summary>
    ''' <param name="dTable"></param>
    Private Sub OutputVoucherData(dTable As DataTable)

        Dim accountSub As DataTable
        accountSub = DataStore.AccountSubjects

        '借方データ出力
        Dim queryDebit = From dtcode In dTable.AsEnumerable()
                         Where dtcode.Field(Of Int16)("A_CODE") _
                          = dTable.Rows(FLG_DEBIT).Item("A_CODE")

        '貸方データ出力
        Dim queryCredit = From dtcode In dTable.AsEnumerable()
                          Where dtcode.Field(Of Int16)("A_CODE") _
                          = dTable.Rows(FLG_CREDIT).Item("A_CODE")

        '借方科目名
        Dim debitAccountIds() = queryDebit.Select(Function(x) x("A_CODE")).ToArray

        '借方金額
        Dim debitAmounts = queryDebit.Select(Function(x) x("AMOUNT")).ToArray

        '貸方科目名
        Dim creditAccountIds = queryCredit.Select(Function(x) x("A_CODE")).ToArray

        '貸方金額
        Dim creditAmounts = queryCredit.Select(Function(x) x("AMOUNT")).ToArray

        '借方１行目
        DebitGroup1Combo.SelectedIndex = ConvertAccountSubToGroupId(debitAccountIds(0))
        DebitSubject1.SelectedValue = debitAccountIds(0).ToString
        DebitAmount1.Text = debitAmounts(0)

        If debitAccountIds.Count > 1 Then
            '借方２行目
            DebitGroup2Combo.SelectedIndex = ConvertAccountSubToGroupId(debitAccountIds(1))
            DebitSubject2.SelectedIndex = debitAccountIds(1)
            DebitAmount2.Text = debitAmounts(1)

        End If

        If debitAccountIds.Count > 2 Then
            '借方３行目
            DebitGroup3Combo.SelectedIndex = ConvertAccountSubToGroupId(debitAccountIds(2))
            DebitSubject3.SelectedIndex = debitAccountIds(2)
            DebitAmount3.Text = debitAmounts(2)

        End If

        '貸方１行目
        CreditGroup1Combo.SelectedIndex = ConvertAccountSubToGroupId(creditAccountIds(0))
        CreditSubject1.SelectedValue = creditAccountIds(0).ToString
        CreditAmount1.Text = creditAmounts(0)

        If creditAccountIds.Count > 1 Then
            '貸方２行目
            CreditGroup2Combo.SelectedIndex = ConvertAccountSubToGroupId(creditAccountIds(1))
            CreditSubject2.SelectedItem = creditAccountIds(1)
            CreditAmount2.Text = creditAmounts(1)

        End If

        If creditAccountIds.Count > 2 Then
            '貸方３行目
            CreditGroup3Combo.SelectedIndex = ConvertAccountSubToGroupId(creditAccountIds(2))
            CreditSubject3.SelectedItem = creditAccountIds(2)
            CreditAmount3.Text = creditAmounts(2)

        End If

    End Sub

End Class
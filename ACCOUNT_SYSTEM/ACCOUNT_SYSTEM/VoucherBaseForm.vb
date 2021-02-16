Public Class VoucherBaseForm

    '借方・貸方フラグ（DB）
    Protected Const FLG_DEBIT As Integer = 0
    Protected Const FLG_CREDIT As Integer = 1

    Protected Const FIRST_ROW As Integer = 0

    ''' <summary>
    ''' 勘定科目一覧
    ''' </summary>
    ''' <returns></returns>
    Protected Friend Property DataStore As DataStore


    Private Sub VoucherBaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' 画面を閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' コンボボックスReadonly処理
    ''' </summary>
    Protected Sub MakeWindowDataReadonly()

        DebitGroup1Combo.DropDownStyle = ComboBoxStyle.DropDownList

        DebitSubject1.DropDownStyle = ComboBoxStyle.DropDownList

        DebitGroup2Combo.DropDownStyle = ComboBoxStyle.DropDownList

        DebitSubject2.DropDownStyle = ComboBoxStyle.DropDownList


        DebitGroup3Combo.DropDownStyle = ComboBoxStyle.DropDownList

        DebitSubject3.DropDownStyle = ComboBoxStyle.DropDownList

        DebitAmount1.ReadOnly = True

        DebitAmount2.ReadOnly = True

        DebitAmount3.ReadOnly = True

        CreditGroup1Combo.DropDownStyle = ComboBoxStyle.DropDownList

        CreditSubject1.DropDownStyle = ComboBoxStyle.DropDownList

        CreditGroup2Combo.DropDownStyle = ComboBoxStyle.DropDownList

        CreditSubject2.DropDownStyle = ComboBoxStyle.DropDownList


        CreditGroup3Combo.DropDownStyle = ComboBoxStyle.DropDownList

        CreditSubject3.DropDownStyle = ComboBoxStyle.DropDownList


        CreditAmount1.ReadOnly = True

        CreditAmount2.ReadOnly = True

        CreditAmount3.ReadOnly = True

    End Sub

    ''' <summary>
    ''' 種別コンボのSelectedが変わったら科目の選択肢を変える
    ''' </summary>
    Protected Sub DebitGroup1SelectedChanged() Handles DebitGroup1Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(DebitGroup1Combo, DebitSubject1)

    End Sub

    Protected Sub DebitGroup2SelectedChanged() Handles DebitGroup2Combo.SelectedIndexChanged


    End Sub

    Protected Sub DebitGroup3SelectedChanged() Handles DebitGroup3Combo.SelectedIndexChanged


    End Sub

    Protected Sub creditGroup1SelectedChanged() Handles CreditGroup1Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(CreditGroup1Combo, CreditSubject1)

    End Sub

    ''' <summary>
    ''' 科目コンボボックスの選択肢を種別に合わせて変更・出力する
    ''' </summary>
    ''' <param name="groupCombo">科目種別コンボ</param>
    ''' <param name="subjectCombo">科目名コンボ</param>
    Protected Sub OutputSelectInAccountGroup(ByVal groupCombo As AccountGroupCombobox,
                                             ByVal subjectCombo As ComboBox)

        '選択肢全部をクリアする
        'subjectCombo.Items.Clear()

        '勘定科目データを取得
        Dim accountSub As DataTable
        accountSub = DataStore.AccountSubjects

        '種別コンボのインデックスで検索
        Dim querySearchSubject = From dtcode In accountSub.AsEnumerable()
                                 Where dtcode.Field(Of Int16)("A_GROUP_CODE") _
                                 = groupCombo.SelectedIndex

        Dim subjectList = New List(Of MyComboBoxItem)
        'IDを取得
        Dim accountIds() = querySearchSubject.Select(Function(x) x("A_CODE")).ToArray

        '科目リストを取得
        Dim accountNames() = querySearchSubject.Select(Function(x) x("A_NAME")).ToArray

        For i = 0 To accountIds.Length - 1
            '勘定科目IDと科目名リストを追加していく
            Dim item = New MyComboBoxItem(accountIds(i), accountNames(i))

            subjectList.Add(item)

        Next i

        subjectCombo.DataSource = subjectList

    End Sub

    ''' <summary>
    ''' 勘定科目コードを元に種別IDを取得する
    ''' </summary>
    ''' <param name="subjectCode"></param>
    ''' <returns></returns>
    Protected Function ConvertAccountSubToGroupId(ByVal subjectCode As Integer) As Integer

        Dim accountSub As DataTable = DataStore.AccountSubjects

        Dim query = From dtcode In accountSub.AsEnumerable()
                    Where dtcode.Field(Of Int16)("A_CODE") = subjectCode

        Return query.Select(Function(x) x("A_GROUP_CODE")).First

    End Function

    Private Sub DebitGroup1SelectedChanged(sender As Object, e As EventArgs) Handles DebitGroup1Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(CreditGroup1Combo, CreditSubject1)

    End Sub

    Private Sub DebitGroup3SelectedChanged(sender As Object, e As EventArgs) Handles DebitGroup3Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(DebitGroup3Combo, DebitSubject3)

    End Sub

    Private Sub DebitGroup2SelectedChanged(sender As Object, e As EventArgs) Handles DebitGroup2Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(DebitGroup2Combo, DebitSubject2)

    End Sub

    Private Sub CreditGroup1SelectedChanged(sender As Object, e As EventArgs) Handles CreditGroup1Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(CreditGroup1Combo, CreditSubject1)

    End Sub

    Private Sub CreditGroup2SelectedChanged(sender As Object, e As EventArgs) Handles CreditGroup2Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(CreditGroup2Combo, CreditSubject2)

    End Sub

    Private Sub CreditGroup3SelectedChanged(sender As Object, e As EventArgs) Handles CreditGroup3Combo.SelectedIndexChanged

        OutputSelectInAccountGroup(CreditGroup3Combo, CreditSubject3)

    End Sub

End Class
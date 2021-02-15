''' <summary>
''' 勘定科目データをDBから取得する
''' </summary>
Public Class Menu

    'インターフェースを使えばこれができる
    ''' <summary>
    ''' データ保存オブジェクト
    ''' </summary>
    ''' <returns></returns>
    Private Property dataStore As DataStore

    Private Property accountNameDao As AccountNameDao
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '起動処理
        Call InitializeAccountSystem()

    End Sub

    ''' <summary>
    ''' システム起動に必要なデータをDBから取得する
    ''' </summary>
    Private Sub InitializeAccountSystem()

        dataStore = New DataStore

        accountNameDao = New AccountNameDao

        '勘定科目データを取得
        dataStore.AccountSubjects = accountNameDao.GetAccountNameList()

    End Sub

    ''' <summary>
    ''' Screen transition to RecordForm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RecordFormButton_Click(sender As Object, e As EventArgs) Handles RecordFormButton.Click

        Dim registerForm As New RegisterForm

        registerForm.DataStore = dataStore

        registerForm.Show()

    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click

        '勘定科目データのメモリを開放する

        Me.Close()

    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

        Dim voucherCheckForm As New VoucherCheckForm

        voucherCheckForm.DataStore = dataStore

        voucherCheckForm.Show()

    End Sub
End Class

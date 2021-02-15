Imports System.Data.OleDb

Public Class AccountNameDao

    'DBから勘定科目を取得

    Public Function GetAccountNameList() As DataTable
        Dim dt As DataTable = New DataTable()
        'Accessへの接続情報の設定をします。
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = "Microsoft.ACE.OLEDB.16.0"
        'Accessファイルへのパスを設定します。
        builder.DataSource = "D:\main_ac_db.accdb"
        '接続情報を使ってコネクションを生成します。
        Using conn As New OleDbConnection(builder.ConnectionString)
            'SQL文とコネクションを設定します。
            Using cmd As New OleDbCommand("SELECT * FROM ACCOUNT_NAME", conn)
                'Accessファイルへの橋渡しのアダプターを設定します。
                Dim odda As OleDbDataAdapter = New OleDbDataAdapter()
                'SELECTコマンドを設定します。
                odda.SelectCommand = cmd
                'SELECTの実行及びフェッチ
                odda.Fill(dt)
                'プロパティに出力します。
                Return dt
            End Using
        End Using

    End Function

End Class

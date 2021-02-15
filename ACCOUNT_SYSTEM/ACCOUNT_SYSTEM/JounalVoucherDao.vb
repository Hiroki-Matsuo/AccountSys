Imports System.Data.OleDb

Public Class JounalVoucherDao

    Function GetJounalDetail() As DataTable

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
            Using cmd As New OleDbCommand("SELECT * FROM JOURNAL LEFT JOIN VOUCHER ON VOUCHER.VOUCHER_NO = JOURNAL.VOUCHER_NO WHERE VOUCHER.VOUCHER_NO = 1;", conn)
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

    Sub InsertJounalVoucher(voucherNo As Integer, journals As List(Of VoucherRecord))

        Dim nowDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")

        'まず伝票を挿入
        Dim queryVoucher As New System.Text.StringBuilder

        queryVoucher.Append("INSERT INTO VOUCHER")
        queryVoucher.Append("( VOUCHER_NO, RECORD_DATE, [MEMO], UPDATE_DATE, UPDATE_ID )")
        queryVoucher.Append("VALUES(")
        queryVoucher.Append(voucherNo & ", #" & nowDate & "#,'テスト', #" & nowDate & "#, '101');")

        Call ExecuteInsert(queryVoucher)

        For Each journal In journals

            'まず伝票を挿入
            Dim queryJournal As New System.Text.StringBuilder

            queryJournal.Append("INSERT INTO JOURNAL")
            queryJournal.Append("( VOUCHER_NO, JOURNAL_NO, DEBIT, A_CODE, AMOUNT )")
            queryJournal.Append("VALUES(")
            queryJournal.Append(voucherNo & ", " & journal.JournalNo & ", " & journal.FlgDebit & ", ")
            queryJournal.Append(journal.Subject & ", " & journal.Amount & ");")

            Call ExecuteInsert(queryJournal)

        Next

    End Sub

    ''' <summary>
    ''' インサート処理　※本来は結果とか戻すと良いんだけども
    ''' </summary>
    ''' <param name="query"></param>
    Private Sub ExecuteInsert(query As Text.StringBuilder)

        'Accessへの接続情報の設定をします。
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = "Microsoft.ACE.OLEDB.16.0"
        'Accessファイルへのパスを設定します。
        builder.DataSource = "D:\main_ac_db.accdb"
        '接続情報を使ってコネクションを生成します。
        Using conn As New OleDbConnection(builder.ConnectionString)
            conn.Open()
            'SQL文とコネクションを設定します。
            Using cmd As New OleDbCommand(query.ToString, conn)
                'Accessファイルへの橋渡しのアダプターを設定します。
                Dim odda As OleDbDataAdapter = New OleDbDataAdapter()
                'INSERTコマンドを設定します。
                odda.InsertCommand = cmd
                'INSERTの実行及びフェッチ
                odda.InsertCommand.ExecuteNonQuery()
                'プロパティに出力します。
            End Using
        End Using

    End Sub



End Class

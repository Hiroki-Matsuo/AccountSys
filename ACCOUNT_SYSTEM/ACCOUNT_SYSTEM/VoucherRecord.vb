
''' <summary>
''' 仕訳データ構造体
''' </summary>
Public Structure VoucherRecord

    Public JournalNo As Integer
    Public FlgDebit As Boolean
    Public Subject As Integer
    Public Amount As Integer

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="_subject">科目名</param>
    ''' <param name="_amount">金額名</param>
    Public Sub New(Byval _journalNo As Integer, ByVal _flgDebit As Boolean, ByVal _subject As Integer, ByVal _amount As Integer)

        JournalNo = _journalNo
        FlgDebit = _flgDebit
        Subject = _subject
        Amount = _amount

    End Sub

End Structure


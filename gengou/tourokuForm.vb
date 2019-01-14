''' <summary>
''' 和暦と西暦を相互に変換する練習
''' </summary>
Public Class tourokuForm
    ''' <summary>
    ''' 西暦変換ボタン処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub seirekiBtn_Click(sender As Object, e As EventArgs) Handles seirekiHenkanBtn.Click
        'ja-JPカルチャで、現地時間として、文字列をDateTime値に変換する
        Dim ci As New System.Globalization.CultureInfo("ja-JP")

        ' 元号＋年＋月＋日を結合する。
        Dim wareki As String
        wareki = gengouCmb.Text & yearText.Text & "年" & monthText.Text & "月" & dayText.Text & "日"

        '和暦を変換する
        Dim dt1 As DateTime
        Try
            dt1 = DateTime.Parse(wareki, ci,
            System.Globalization.DateTimeStyles.AssumeLocal)
        Catch
            ' 存在しない年（昭和100年など）のチェックは省略しています。
            MsgBox("和暦年月日の入力に誤りがあります。")
            Exit Sub
        End Try

        Me.seirekiLbl.Text = dt1

    End Sub

    ''' <summary>
    ''' 和暦変換ボタン処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub warekiHenkanBtn_Click(sender As Object, e As EventArgs) Handles warekiHenkanBtn.Click
        'ja-JPカルチャで、現地時間として、文字列をDateTime値に変換する
        Dim ci As New System.Globalization.CultureInfo("ja-JP")

        '西暦を変換する
        ci.DateTimeFormat.Calendar = New System.Globalization.JapaneseCalendar
        Me.warekiLbl.Text = seirekiDtp.Value.ToString("ggyy年MM月dd日", ci)

    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tourokuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.seirekiHenkanBtn = New System.Windows.Forms.Button()
        Me.seirekiLbl = New System.Windows.Forms.Label()
        Me.gengouCmb = New System.Windows.Forms.ComboBox()
        Me.yearText = New System.Windows.Forms.MaskedTextBox()
        Me.yearLbl = New System.Windows.Forms.Label()
        Me.monthLbl = New System.Windows.Forms.Label()
        Me.dayLbl = New System.Windows.Forms.Label()
        Me.monthText = New System.Windows.Forms.MaskedTextBox()
        Me.dayText = New System.Windows.Forms.MaskedTextBox()
        Me.seirekiDtp = New System.Windows.Forms.DateTimePicker()
        Me.warekiLbl = New System.Windows.Forms.Label()
        Me.warekiHenkanBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'seirekiHenkanBtn
        '
        Me.seirekiHenkanBtn.Location = New System.Drawing.Point(50, 185)
        Me.seirekiHenkanBtn.Name = "seirekiHenkanBtn"
        Me.seirekiHenkanBtn.Size = New System.Drawing.Size(75, 23)
        Me.seirekiHenkanBtn.TabIndex = 0
        Me.seirekiHenkanBtn.Text = "西暦変換"
        Me.seirekiHenkanBtn.UseVisualStyleBackColor = True
        '
        'seirekiLbl
        '
        Me.seirekiLbl.AutoSize = True
        Me.seirekiLbl.Location = New System.Drawing.Point(54, 136)
        Me.seirekiLbl.Name = "seirekiLbl"
        Me.seirekiLbl.Size = New System.Drawing.Size(67, 15)
        Me.seirekiLbl.TabIndex = 1
        Me.seirekiLbl.Text = "西暦表示"
        '
        'gengouCmb
        '
        Me.gengouCmb.FormattingEnabled = True
        Me.gengouCmb.Items.AddRange(New Object() {"明治", "大正", "昭和", "平成"})
        Me.gengouCmb.Location = New System.Drawing.Point(29, 51)
        Me.gengouCmb.Name = "gengouCmb"
        Me.gengouCmb.Size = New System.Drawing.Size(73, 23)
        Me.gengouCmb.TabIndex = 2
        '
        'yearText
        '
        Me.yearText.Location = New System.Drawing.Point(108, 52)
        Me.yearText.Mask = "90"
        Me.yearText.Name = "yearText"
        Me.yearText.Size = New System.Drawing.Size(33, 22)
        Me.yearText.TabIndex = 3
        '
        'yearLbl
        '
        Me.yearLbl.AutoSize = True
        Me.yearLbl.Location = New System.Drawing.Point(142, 59)
        Me.yearLbl.Name = "yearLbl"
        Me.yearLbl.Size = New System.Drawing.Size(22, 15)
        Me.yearLbl.TabIndex = 4
        Me.yearLbl.Text = "年"
        '
        'monthLbl
        '
        Me.monthLbl.AutoSize = True
        Me.monthLbl.Location = New System.Drawing.Point(200, 59)
        Me.monthLbl.Name = "monthLbl"
        Me.monthLbl.Size = New System.Drawing.Size(22, 15)
        Me.monthLbl.TabIndex = 5
        Me.monthLbl.Text = "月"
        '
        'dayLbl
        '
        Me.dayLbl.AutoSize = True
        Me.dayLbl.Location = New System.Drawing.Point(268, 59)
        Me.dayLbl.Name = "dayLbl"
        Me.dayLbl.Size = New System.Drawing.Size(22, 15)
        Me.dayLbl.TabIndex = 6
        Me.dayLbl.Text = "日"
        '
        'monthText
        '
        Me.monthText.Location = New System.Drawing.Point(166, 52)
        Me.monthText.Mask = "90"
        Me.monthText.Name = "monthText"
        Me.monthText.Size = New System.Drawing.Size(33, 22)
        Me.monthText.TabIndex = 7
        '
        'dayText
        '
        Me.dayText.Location = New System.Drawing.Point(229, 52)
        Me.dayText.Mask = "90"
        Me.dayText.Name = "dayText"
        Me.dayText.Size = New System.Drawing.Size(33, 22)
        Me.dayText.TabIndex = 8
        '
        'seirekiDtp
        '
        Me.seirekiDtp.Location = New System.Drawing.Point(347, 53)
        Me.seirekiDtp.Name = "seirekiDtp"
        Me.seirekiDtp.Size = New System.Drawing.Size(200, 22)
        Me.seirekiDtp.TabIndex = 10
        '
        'warekiLbl
        '
        Me.warekiLbl.AutoSize = True
        Me.warekiLbl.Location = New System.Drawing.Point(344, 136)
        Me.warekiLbl.Name = "warekiLbl"
        Me.warekiLbl.Size = New System.Drawing.Size(67, 15)
        Me.warekiLbl.TabIndex = 11
        Me.warekiLbl.Text = "和暦表示"
        '
        'warekiHenkanBtn
        '
        Me.warekiHenkanBtn.Location = New System.Drawing.Point(347, 185)
        Me.warekiHenkanBtn.Name = "warekiHenkanBtn"
        Me.warekiHenkanBtn.Size = New System.Drawing.Size(75, 23)
        Me.warekiHenkanBtn.TabIndex = 12
        Me.warekiHenkanBtn.Text = "和暦変換"
        Me.warekiHenkanBtn.UseVisualStyleBackColor = True
        '
        'tourokuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 318)
        Me.Controls.Add(Me.warekiHenkanBtn)
        Me.Controls.Add(Me.warekiLbl)
        Me.Controls.Add(Me.seirekiDtp)
        Me.Controls.Add(Me.dayText)
        Me.Controls.Add(Me.monthText)
        Me.Controls.Add(Me.dayLbl)
        Me.Controls.Add(Me.monthLbl)
        Me.Controls.Add(Me.yearLbl)
        Me.Controls.Add(Me.yearText)
        Me.Controls.Add(Me.gengouCmb)
        Me.Controls.Add(Me.seirekiLbl)
        Me.Controls.Add(Me.seirekiHenkanBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tourokuForm"
        Me.Text = "和暦と西暦を相互変換する練習"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents seirekiHenkanBtn As Button
    Friend WithEvents seirekiLbl As Label
    Friend WithEvents gengouCmb As ComboBox
    Friend WithEvents yearText As MaskedTextBox
    Friend WithEvents yearLbl As Label
    Friend WithEvents monthLbl As Label
    Friend WithEvents dayLbl As Label
    Friend WithEvents monthText As MaskedTextBox
    Friend WithEvents dayText As MaskedTextBox
    Friend WithEvents seirekiDtp As DateTimePicker
    Friend WithEvents warekiLbl As Label
    Friend WithEvents warekiHenkanBtn As Button
End Class

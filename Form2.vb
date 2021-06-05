Public Class Form2

    Dim MyPath As String = System.Windows.Forms.Application.StartupPath

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("作成する大会名を入力してください", "警告",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim result As DialogResult =
            MessageBox.Show("新規大会フォルダ[" & TextBox1.Text & "]を作成します" & vbCrLf & "よろしいですか？", "確認",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        Dim NewFolderPath As String = MyPath & "\" & TextBox1.Text

        If result = vbYes Then

            If IO.Directory.Exists(NewFolderPath) Then
                MessageBox.Show("すでに[" & TextBox1.Text & "]は存在しています", "警告",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim di As System.IO.DirectoryInfo =
                    System.IO.Directory.CreateDirectory(NewFolderPath)
                MessageBox.Show("新規大会フォルダ[" & TextBox1.Text & "]が作成されました", "フォルダ作成完了",
                MessageBoxButtons.OK)
                Form1.Visible = True
                Me.Hide()
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.Visible = True
        Me.Hide()

    End Sub

End Class
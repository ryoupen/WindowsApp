
Class Form1

    Dim MyPath As String = System.Windows.Forms.Application.StartupPath

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Dim F2 As New Form2
        F2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("大会名を選択してください" & vbCrLf & "ない場合は、[新規大会作成]ボタンより作成下さい", "警告",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Call Form1_Load(sender, e)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ComboBox1.Items.Clear()

        Dim subFolders As IEnumerable(Of String) =
            System.IO.Directory.EnumerateDirectories(
            MyPath & "\", "*", System.IO.SearchOption.AllDirectories)

        Dim AddFolder As String
        For Each subFolder As String In subFolders
            AddFolder = System.IO.Path.GetFileName(subFolder)
            ComboBox1.Items.Add(AddFolder)
        Next

    End Sub

End Class


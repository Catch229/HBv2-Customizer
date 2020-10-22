Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.IO.Ports
Imports System.Threading

Public Class HotBoxApp

    Dim byteData As Byte()

    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()

        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
        End Using

        Return bitmapBytes

    End Function

    Private Sub ImageSelectBtn_Click(sender As Object, e As EventArgs) Handles ImageSelectBtn.Click

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim newLogo As New Bitmap(OpenFileDialog1.FileName)
                If (newLogo IsNot Nothing) Then
                    OLEDImageBox.Show()
                    OLEDImageBox.ImageLocation = OpenFileDialog1.FileName
                    OLEDImageBox.Load()

                    byteData = BmpToBytes_Unsafe(newLogo)
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If

    End Sub

    Private Function BmpToBytes_Unsafe(bmp As Bitmap) As Byte()
        Dim bData As System.Drawing.Imaging.BitmapData = bmp.LockBits(New Rectangle(New Point(), bmp.Size),
        ImageLockMode.ReadOnly,
        PixelFormat.Format1bppIndexed)
        'number of bytes in the bitmap
        Dim byteCount As Integer = bData.Stride * bmp.Height
        Dim bmpBytes(byteCount - 1) As Byte

        'Copy the locked bytes from memory
        Marshal.Copy(bData.Scan0, bmpBytes, 0, byteCount)

        For i As Integer = 0 To byteCount - 1
            bmpBytes(i) = Not bmpBytes(i)
        Next

        'don 't forget to unlock the bitmap!!
        bmp.UnlockBits(bData)

        Return bmpBytes
    End Function

    Private Sub UploadImageBtn_Click(sender As Object, e As EventArgs) Handles UploadImageBtn.Click
        If (byteData IsNot Nothing) Then
            SerialSendImage(byteData)
        Else
            MessageBox.Show("Please select an image to upload first.")
        End If
    End Sub

    Sub SerialSendImage(b As Byte())
        Dim dataLen As Integer = b.Length
        Dim dataByte As Byte = 255

        Select Case dataLen
            Case 128
                dataByte = 2
            Case 256
                dataByte = 1
            Case 1024
                dataByte = 0
        End Select

        If PortListBox.SelectedItem = "" Then
            MessageBox.Show("Please select the COM port of the HotBox before uploading.")
        ElseIf dataByte = 255 Then
            MessageBox.Show("Image size is not supported. " & Environment.NewLine & "Please use 128x64 px for loading screens and 128x16 px for banners.")
        Else
            Dim serial = New SerialPort()
            Try
                Me.Cursor = Cursors.WaitCursor
                serial.BaudRate = 9600
                serial.PortName = PortListBox.SelectedItem
                serial.WriteTimeout = 1000
                serial.ReadTimeout = 1000
                serial.WriteBufferSize = 8192

                Dim singleByte() As Byte = New Byte() {255}

                serial.Open()

                serial.Write(dataByte)

                For i As Integer = 0 To b.Length - 1
                    singleByte(0) = b(i)
                    serial.Write(singleByte, 0, 1)
                Next
                MessageBox.Show("Image uploaded to HotBox successfully.")
            Catch ex As System.IO.IOException
                MessageBox.Show("HotBox is not responding. " & Environment.NewLine & "Is it in programming mode with the correct communication port selected?")
            Finally
                If serial IsNot Nothing Then serial.Close()
                Me.Cursor = Cursors.Default
            End Try
        End If

    End Sub

    Sub GetSerialPortNames()
        ' Show all available COM ports.
        PortListBox.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            PortListBox.Items.Add(sp)
        Next
    End Sub

    Private Sub UploadSettingBtn_Click(sender As Object, e As EventArgs) Handles UploadSettingBtn.Click

        Dim dataByte As Byte = 2

        If PortListBox.SelectedItem = "" Then
            MessageBox.Show("Please select the COM port of the HotBox before uploading.")
        Else
            Dim serial = New SerialPort()
            Try
                Me.Cursor = Cursors.WaitCursor
                serial.BaudRate = 9600
                serial.PortName = PortListBox.SelectedItem
                serial.WriteTimeout = 10000
                serial.ReadTimeout = 1000
                serial.WriteBufferSize = 8192

                serial.Open()
                If vOffsetCheck.CheckState Then
                    serial.Write(dataByte)
                    serial.Write((VoltOffset.Value * 100).ToString() + "+")
                End If

                dataByte = 3
                serial.Write(dataByte)
                serial.Write((LVSetPoint.Value * 100).ToString() + "+")
                serial.Write((HVSetPoint.Value * 100).ToString() + "+")

                MessageBox.Show("Data uploaded to HotBox successfully.")
            Catch ex As System.IO.IOException
                MessageBox.Show("HotBox is not responding. " & Environment.NewLine & "Is it in programming mode with the correct communication port selected?")
            Finally
                If serial IsNot Nothing Then serial.Close()
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub HotBoxApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
    End Sub

    Private Sub PortScanButton_Click(sender As Object, e As EventArgs) Handles PortScanButton.Click
        GetSerialPortNames()
    End Sub

    Private Sub LinkBtn_Click(sender As Object, e As EventArgs) Handles LinkBtn.Click
        Try
            Process.Start("https://drive.google.com/drive/u/2/folders/1aJN_ry_Iarbecj09Pa8w2D3gtPAhEx6G")
        Catch ex As Exception

        End Try
    End Sub
End Class

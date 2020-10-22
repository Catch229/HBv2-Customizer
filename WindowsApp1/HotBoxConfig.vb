Public Class HotBoxConfig


    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()

        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
        End Using

        Return bitmapBytes

    End Function
End Class

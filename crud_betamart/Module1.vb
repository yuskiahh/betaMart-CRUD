Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public ketemu As Boolean

    Public koneksi As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=db_crud.accdb")

    Sub konek()
        Try
            koneksi.Open()
            ' MsgBox("Koneksi Berhasil")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Koneksi Gagal")
        End Try
    End Sub

    Sub diskonek()
        koneksi.Close()
    End Sub
End Module

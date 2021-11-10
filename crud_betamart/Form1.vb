Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Sub tampilData()
        konek()
        da = New OleDbDataAdapter(" SELECT * from tBetaMart", koneksi)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
        diskonek()
    End Sub

    Private Sub bCreate_Click(sender As Object, e As EventArgs) Handles bCreate.Click
        If ketemu = False Then
            'Simpan Data Baru
            konek()
            cmd = New OleDbCommand("INSERT INTO tBetaMart VALUES('" & tNama.Text & "', '" & tKategori.Text & "', '" & tHarga.Text & "', '" & tStok.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
            diskonek()

        End If

        bClear_Click(sender, e)
        tampilData()

    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        tNama.Text = ""
        tKategori.Text = ""
        tHarga.Text = ""
        tStok.Text = ""
        tNama.Focus()
    End Sub

    Private Sub tNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tNama.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()
            cmd = New OleDbCommand("SELECT * FROM tBetaMart WHERE Nama_barang = '" & tNama.Text & "' ", koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tKategori.Text = dr.Item(1)
                tHarga.Text = dr.Item(2)
                tStok.Text = dr.Item(3)
                ketemu = True
            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                ketemu = False
            End If

            diskonek()


        End If

    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        konek()
        cmd = New OleDbCommand("UPDATE tBetaMart set Harga = '" & tHarga.Text & "', Stok = '" & tStok.Text & "', Kategori = '" & tKategori.Text & "' WHERE Nama_barang = '" & tNama.Text & "' ", koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Ubah!")
        diskonek()

        bClear_Click(sender, e)
        tampilData()

    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim pilih = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Perhatian!", MessageBoxButtons.YesNo)
        If pilih = vbYes Then
            konek()
            cmd = New OleDbCommand("DELETE FROM tBetaMart WHERE Nama_barang = '" & tNama.Text & "' ", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus!")
            diskonek()

            tampilData()
            bClear_Click(sender, e)

        End If
    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        konek()
        da = New OleDbDataAdapter("SELECT * FROM tBetaMart WHERE Nama_barang = '" & tSearch.Text & "' ", koneksi)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
        diskonek()

    End Sub
End Class

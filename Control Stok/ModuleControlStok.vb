Imports System.Data
Imports MySql.Data.MySqlClient
Module ModuleControlStok
    Public connect As String = "server=localhost;user=root;database=controlstok"
    Public hubung As MySqlConnection = New MySqlConnection(connect)
    Public mda As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As New MySqlCommand
    Public dt As DataTable
    Public dr As MySqlDataReader
    Public Function koneksi() As Boolean
        Try
            If hubung.State = ConnectionState.Closed Then
                hubung.Open()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("hubungsi ke database bermasalah,Periksa hubungsi jaringan..", 48, "Perhatian")
            Return False

        End Try
    End Function
    Sub simpandata(ByVal sqlisi As String)
        Try
            Call koneksi()
            Using cmd As New MySqlCommand

                cmd.CommandText = sqlisi
                cmd.Connection = hubung
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Errorki")
        End Try
    End Sub
    Sub editdata(ByVal SQLEDIT As String)
        Try
            Call koneksi()
            Using cmd As New MySqlCommand
                cmd.Connection = hubung
                cmd.CommandText = SQLEDIT
                cmd.ExecuteNonQuery()
                'Call tampilandata()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Errorki")
            'MsgBox("Gagal mengupdate data",16,"Errorki")
        End Try

    End Sub
    Sub HAPUSDATA(ByVal SQLHAPUS As String)
        Try
            Call koneksi()
            Using cmd As New MySqlCommand
                cmd.Connection = hubung
                cmd.CommandText = SQLHAPUS
                cmd.ExecuteNonQuery()
                'Call tampiLdata()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Errorki")
        End Try

    End Sub
    Sub tampildata(ByVal sqldata As String, ByVal sqltabel As String)
        Try
            mda = New MySqlDataAdapter(sqldata, hubung)
            ds = New DataSet
            ds.Clear()
            mda.Fill(ds, sqltabel)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Module


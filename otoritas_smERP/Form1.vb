Imports System.Data.OleDb
Imports adodb

Public Class Form1
    Dim Conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim LokasiDB As String


    Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_sample.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from role_menu order by ID asc", Conn)
        ds = New DataSet
        ds.Clear()

        Dim vNamaMenu, vNamaChx, vHierar As String
        Dim x, y, z, a, b, c, d, f, g As Integer


        Using ds As New DataSet()
            da.Fill(ds)
            For Each row As DataRow In ds.Tables(0).Rows

                vNamaMenu = row("menu_name").ToString()
                vNamaChx = row("NameChx").ToString()
                vHierar = row("hierar").ToString()

                Dim checkBox2 = New CheckBox()

                If Len(vHierar) > 1 Then

                    If vHierar.Substring(0, 2) = "0." Or vHierar.Substring(0, 2) = "00" Then

                        ''1
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "0." And y >= (TabPage2.Size.Height - 100) And a = 0 Then
                            x = 210
                            y = 0
                            a = 1
                        End If
                        If vHierar.Substring(0, 2) = "00" And y >= (TabPage2.Size.Height - 100) And a = 0 Then
                            x = 235
                            y = 0
                            a = 1
                        End If
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "0." And y >= (TabPage2.Size.Height - 100) And a = 1 Then
                            x = 415
                            y = 0
                            a = 2
                        End If
                        If vHierar.Substring(0, 2) = "00" And y >= (TabPage2.Size.Height - 100) And a = 1 Then
                            x = 440
                            y = 0
                            a = 2
                        End If
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "0." And y >= (TabPage2.Size.Height - 100) And a = 2 Then
                            x = 620
                            y = 0
                            a = 3
                        End If
                        If vHierar.Substring(0, 2) = "00" And y >= (TabPage2.Size.Height - 100) And a = 2 Then
                            x = 645
                            y = 0
                            a = 3
                        End If
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "0." And y >= (TabPage2.Size.Height - 100) And a = 3 Then
                            x = 825
                            y = 0
                            a = 4
                        End If
                        If vHierar.Substring(0, 2) = "00" And y >= (TabPage2.Size.Height - 100) And a = 3 Then
                            x = 850
                            y = 0
                            a = 4
                        End If
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "0." And y >= (TabPage2.Size.Height - 100) And a = 4 Then
                            x = 1030
                            y = 0
                            a = 5
                        End If
                        If vHierar.Substring(0, 2) = "00" And y >= (TabPage2.Size.Height - 100) And a = 4 Then
                            x = 1055
                            y = 0
                            a = 5
                        End If
                        If vHierar.Substring(0, 2) = "0." And y < (TabPage2.Size.Height - 100) And a = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "00" And y < (TabPage2.Size.Height - 100) And a = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage2.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If

                    If vHierar.Substring(0, 2) = "1." Or vHierar.Substring(0, 2) = "01" Then
                        If y > 0 And z = 0 Then
                            y = 0
                        End If
                        z = 1
                        ''1
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage3.Size.Height - 100) And b = 0 Then
                            x = 210
                            y = 0
                            b = 1
                        End If
                        If vHierar.Substring(0, 2) = "01" And y >= (TabPage3.Size.Height - 100) And b = 0 Then
                            x = 235
                            y = 0
                            b = 1
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage3.Size.Height - 100) And b = 1 Then
                            x = 415
                            y = 0
                            b = 2
                        End If
                        If vHierar.Substring(0, 2) = "01" And y >= (TabPage3.Size.Height - 100) And b = 1 Then
                            x = 440
                            y = 0
                            b = 2
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage3.Size.Height - 100) And b = 2 Then
                            x = 620
                            y = 0
                            b = 3
                        End If
                        If vHierar.Substring(0, 2) = "01" And y >= (TabPage3.Size.Height - 100) And b = 2 Then
                            x = 645
                            y = 0
                            b = 3
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage3.Size.Height - 100) And b = 3 Then
                            x = 825
                            y = 0
                            b = 4
                        End If
                        If vHierar.Substring(0, 2) = "01" And y >= (TabPage3.Size.Height - 100) And b = 3 Then
                            x = 850
                            y = 0
                            b = 4
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage3.Size.Height - 100) And b = 4 Then
                            x = 1030
                            y = 0
                            b = 5
                        End If
                        If vHierar.Substring(0, 2) = "01" And y >= (TabPage3.Size.Height - 100) And b = 4 Then
                            x = 1055
                            y = 0
                            b = 5
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage3.Size.Height - 100) And b = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "01" And y < (TabPage3.Size.Height - 100) And b = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage3.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If

                    If vHierar.Substring(0, 2) = "2." Or vHierar.Substring(0, 2) = "02" Then
                        If y > 0 And z = 1 Then
                            y = 0
                        End If
                        z = 2
                        ''1
                        If vHierar.Substring(0, 2) = "2." And y < (TabPage4.Size.Height - 100) And c = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "2." And y >= (TabPage4.Size.Height - 100) And c = 0 Then
                            x = 210
                            y = 0
                            c = 1
                        End If
                        If vHierar.Substring(0, 2) = "02" And y >= (TabPage4.Size.Height - 100) And c = 0 Then
                            x = 235
                            y = 0
                            c = 1
                        End If
                        If vHierar.Substring(0, 2) = "2." And y < (TabPage4.Size.Height - 100) And c = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "2." And y >= (TabPage4.Size.Height - 100) And c = 1 Then
                            x = 415
                            y = 0
                            c = 2
                        End If
                        If vHierar.Substring(0, 2) = "02" And y >= (TabPage4.Size.Height - 100) And c = 1 Then
                            x = 440
                            y = 0
                            c = 2
                        End If
                        If vHierar.Substring(0, 2) = "2." And y < (TabPage4.Size.Height - 100) And c = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage4.Size.Height - 100) And c = 2 Then
                            x = 620
                            y = 0
                            c = 3
                        End If
                        If vHierar.Substring(0, 2) = "02" And y >= (TabPage4.Size.Height - 100) And c = 2 Then
                            x = 645
                            y = 0
                            c = 3
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage4.Size.Height - 100) And c = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage4.Size.Height - 100) And c = 3 Then
                            x = 825
                            y = 0
                            c = 4
                        End If
                        If vHierar.Substring(0, 2) = "02" And y >= (TabPage4.Size.Height - 100) And c = 3 Then
                            x = 850
                            y = 0
                            c = 4
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage4.Size.Height - 100) And c = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage4.Size.Height - 100) And c = 4 Then
                            x = 1030
                            y = 0
                            c = 5
                        End If
                        If vHierar.Substring(0, 2) = "02" And y >= (TabPage4.Size.Height - 100) And c = 4 Then
                            x = 1055
                            y = 0
                            c = 5
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage4.Size.Height - 100) And c = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "02" And y < (TabPage4.Size.Height - 100) And c = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage4.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If

                    If vHierar.Substring(0, 2) = "3." Or vHierar.Substring(0, 2) = "03" Then
                        If y > 0 And z = 2 Then
                            y = 0
                        End If
                        z = 3
                        ''1
                        If vHierar.Substring(0, 2) = "3." And y < (TabPage5.Size.Height - 100) And d = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "3." And y >= (TabPage5.Size.Height - 100) And d = 0 Then
                            x = 210
                            y = 0
                            d = 1
                        End If
                        If vHierar.Substring(0, 2) = "03" And y >= (TabPage5.Size.Height - 100) And d = 0 Then
                            x = 235
                            y = 0
                            d = 1
                        End If
                        If vHierar.Substring(0, 2) = "3." And y < (TabPage5.Size.Height - 100) And d = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "3." And y >= (TabPage5.Size.Height - 100) And d = 1 Then
                            x = 415
                            y = 0
                            d = 2
                        End If
                        If vHierar.Substring(0, 2) = "03" And y >= (TabPage5.Size.Height - 100) And d = 1 Then
                            x = 440
                            y = 0
                            d = 2
                        End If
                        If vHierar.Substring(0, 2) = "3." And y < (TabPage5.Size.Height - 100) And d = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage5.Size.Height - 100) And d = 2 Then
                            x = 620
                            y = 0
                            d = 3
                        End If
                        If vHierar.Substring(0, 2) = "03" And y >= (TabPage5.Size.Height - 100) And d = 2 Then
                            x = 645
                            y = 0
                            d = 3
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage5.Size.Height - 100) And d = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage5.Size.Height - 100) And d = 3 Then
                            x = 825
                            y = 0
                            d = 4
                        End If
                        If vHierar.Substring(0, 2) = "03" And y >= (TabPage5.Size.Height - 100) And d = 3 Then
                            x = 850
                            y = 0
                            d = 4
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage5.Size.Height - 100) And d = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage5.Size.Height - 100) And d = 4 Then
                            x = 1030
                            y = 0
                            d = 5
                        End If
                        If vHierar.Substring(0, 2) = "03" And y >= (TabPage5.Size.Height - 100) And d = 4 Then
                            x = 1055
                            y = 0
                            d = 5
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage5.Size.Height - 100) And d = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "03" And y < (TabPage5.Size.Height - 100) And d = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage5.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If

                    If vHierar.Substring(0, 2) = "4." Or vHierar.Substring(0, 2) = "04" Then
                        If y > 0 And z = 3 Then
                            y = 0
                        End If
                        z = 4
                        ''1
                        If vHierar.Substring(0, 2) = "4." And y < (TabPage6.Size.Height - 100) And f = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "4." And y >= (TabPage6.Size.Height - 100) And f = 0 Then
                            x = 210
                            y = 0
                            f = 1
                        End If
                        If vHierar.Substring(0, 2) = "04" And y >= (TabPage6.Size.Height - 100) And f = 0 Then
                            x = 235
                            y = 0
                            f = 1
                        End If
                        If vHierar.Substring(0, 2) = "4." And y < (TabPage6.Size.Height - 100) And f = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "4." And y >= (TabPage6.Size.Height - 100) And f = 1 Then
                            x = 415
                            y = 0
                            f = 2
                        End If
                        If vHierar.Substring(0, 2) = "04" And y >= (TabPage6.Size.Height - 100) And f = 1 Then
                            x = 440
                            y = 0
                            f = 2
                        End If
                        If vHierar.Substring(0, 2) = "4." And y < (TabPage6.Size.Height - 100) And f = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage6.Size.Height - 100) And f = 2 Then
                            x = 620
                            y = 0
                            f = 3
                        End If
                        If vHierar.Substring(0, 2) = "04" And y >= (TabPage6.Size.Height - 100) And f = 2 Then
                            x = 645
                            y = 0
                            f = 3
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage6.Size.Height - 100) And f = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage6.Size.Height - 100) And f = 3 Then
                            x = 825
                            y = 0
                            f = 4
                        End If
                        If vHierar.Substring(0, 2) = "04" And y >= (TabPage6.Size.Height - 100) And f = 3 Then
                            x = 850
                            y = 0
                            f = 4
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage6.Size.Height - 100) And f = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage6.Size.Height - 100) And f = 4 Then
                            x = 1030
                            y = 0
                            f = 5
                        End If
                        If vHierar.Substring(0, 2) = "04" And y >= (TabPage6.Size.Height - 100) And f = 4 Then
                            x = 1055
                            y = 0
                            f = 5
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage6.Size.Height - 100) And f = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "04" And y < (TabPage6.Size.Height - 100) And f = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage6.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If

                    If vHierar.Substring(0, 2) = "5." Or vHierar.Substring(0, 2) = "05" Then
                        If y > 0 And z = 4 Then
                            y = 0
                        End If
                        z = 5
                        ''1
                        If vHierar.Substring(0, 2) = "5." And y < (TabPage7.Size.Height - 100) And g = 0 Then
                            x = 5
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 0 Then
                            x = 30
                        End If

                        ''2
                        If vHierar.Substring(0, 2) = "5." And y >= (TabPage7.Size.Height - 100) And g = 0 Then
                            x = 210
                            y = 0
                            g = 1
                        End If
                        If vHierar.Substring(0, 2) = "05" And y >= (TabPage7.Size.Height - 100) And g = 0 Then
                            x = 235
                            y = 0
                            g = 1
                        End If
                        If vHierar.Substring(0, 2) = "5." And y < (TabPage7.Size.Height - 100) And g = 1 Then
                            x = 210
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 1 Then
                            x = 235
                        End If

                        ''3
                        If vHierar.Substring(0, 2) = "5." And y >= (TabPage7.Size.Height - 100) And g = 1 Then
                            x = 415
                            y = 0
                            g = 2
                        End If
                        If vHierar.Substring(0, 2) = "05" And y >= (TabPage7.Size.Height - 100) And g = 1 Then
                            x = 440
                            y = 0
                            g = 2
                        End If
                        If vHierar.Substring(0, 2) = "5." And y < (TabPage7.Size.Height - 100) And g = 2 Then
                            x = 415
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 2 Then
                            x = 440
                        End If

                        ''4
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage7.Size.Height - 100) And g = 2 Then
                            x = 620
                            y = 0
                            g = 3
                        End If
                        If vHierar.Substring(0, 2) = "05" And y >= (TabPage7.Size.Height - 100) And g = 2 Then
                            x = 645
                            y = 0
                            g = 3
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage7.Size.Height - 100) And g = 3 Then
                            x = 620
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 3 Then
                            x = 645
                        End If

                        ''5
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage7.Size.Height - 100) And g = 3 Then
                            x = 825
                            y = 0
                            g = 4
                        End If
                        If vHierar.Substring(0, 2) = "05" And y >= (TabPage7.Size.Height - 100) And g = 3 Then
                            x = 850
                            y = 0
                            g = 4
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage7.Size.Height - 100) And g = 4 Then
                            x = 825
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 4 Then
                            x = 850
                        End If

                        ''6
                        If vHierar.Substring(0, 2) = "1." And y >= (TabPage7.Size.Height - 100) And g = 4 Then
                            x = 1030
                            y = 0
                            g = 5
                        End If
                        If vHierar.Substring(0, 2) = "05" And y >= (TabPage7.Size.Height - 100) And g = 4 Then
                            x = 1055
                            y = 0
                            g = 5
                        End If
                        If vHierar.Substring(0, 2) = "1." And y < (TabPage7.Size.Height - 100) And g = 5 Then
                            x = 1030
                        End If
                        If vHierar.Substring(0, 2) = "05" And y < (TabPage7.Size.Height - 100) And g = 5 Then
                            x = 1055
                        End If

                        checkBox2.Text = vNamaMenu
                        checkBox2.Name = vNamaChx
                        checkBox2.Checked = True
                        checkBox2.Size = New Size(155, 20)
                        checkBox2.Location = New Point(x, y)

                        TabPage7.Controls.Add(checkBox2)

                        y = y + 20
                        AddHandler checkBox2.CheckedChanged, AddressOf ChkBox_CheckedChanged
                    End If
                End If




            Next
        End Using


    End Sub




    Private Sub ChkBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim chkBox As CheckBox = TryCast(sender, CheckBox)

        If chkBox IsNot Nothing Then

            MessageBox.Show(chkBox.CheckState & " " & chkBox.Name & " " & chkBox.Text)

        End If
    End Sub

End Class
'' [[ DESKRIPSI ]]
' TAZPA Software
' Program untuk interface dengan TAZPA
' Copyright (c) 2016 Muhammad Wahyudin. All rights reserved
' http://hyuwah.github.io/TAZPASoftware

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.


'' [[ Library ]]
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.IO.Ports
Imports FileHelpers                 'Nuget FileHelpers
Imports MaterialSkin                'Nuget MaterialSkin
Imports MaterialSkin.Controls       'Nuget MaterialSkin
Imports LiveCharts                  'Nuget LiveCharts
Imports LiveCharts.Wpf              'Nuget LiveCharts
Imports LiveCharts.Configurations   'Nuget LiveCharts

Public Class Form1 : Inherits MaterialForm

    '' [[ DEKLARASI VARIABEL ]]

    ' Deklarasi Engine Filehelpers
    Private engine As New FileHelperEngine(GetType(data))           ' Engine data pengukuran
    Private engineParam As New FileHelperEngine(GetType(param))     ' Engine parameter pengukuran

    'List object untuk data dan parameter
    Private arrData As New List(Of data)
    Private arrParam As New List(Of param)

    ' Deklarasi nilai X (waktu) dan Y (Dummy Data)
    Private valXStart As DateTime
    Private valXDur As TimeSpan
    Private valX As DateTime
    Private valY As Double
    Private serdata As Double
    Private constEQ As Double = 0

    Dim myPort As Array
    Delegate Sub ReceivedTextDelegate(ByVal text As String) 'Mencegah threading errors saat menerima data
    Delegate Sub ReceivedDoubleDelegate(ByVal valY As Double) 'Mencegah threading errors saat menerima of data

    ' Variabel Parameter
    Dim paramNama As String
    Dim paramJE As Double
    Dim paramFVP As Double
    Dim paramPB As Double
    Dim paramDP As Double
    Dim paramDM As Double
    Dim paramPG As Double
    Dim paramV As Double
    Dim paramKB As Double
    Dim paramPV As Double = 0.00000000000885434 ' Permitivitas Vakum

    ' Variabel hasil
    Dim varEZ As Double
    Dim varES As Double

    ' MCU control toggle
    Dim toggleSmooth As Char

    Dim appPath As String

    'LIVECHARTS
    Dim dayConfig = Mappers.Xy(Of MeasureModel)().X(Function(dayModel) dayModel.DateTime.Ticks).Y(Function(dayModel) dayModel.Value)
    Dim seriCollection = New LiveCharts.SeriesCollection(dayConfig)

    ' Dummy data ketika form load
    Dim introSeries = New LineSeries() With {
    .Title = "Potensial Zeta",
    .Values = New ChartValues(Of MeasureModel) From {
    New MeasureModel() With {.DateTime = "00:00", .Value = 1},
    New MeasureModel() With {.DateTime = "00:01", .Value = 3},
    New MeasureModel() With {.DateTime = "00:02", .Value = 3},
    New MeasureModel() With {.DateTime = "00:03", .Value = 5}
    }}


    '' [[ FORM SETTING ]]
    ' Form LOAD
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        UpdateToolStrip()

        ' Serial Prep
        myPort = SerialPort.GetPortNames() 'Mendeteksi COM Port
        tscbbBaud.Items.Add(9600)     'mengisi baud rate di tscbbBaud Combo box

        ' Mengisi port COM yang terdeteksi di tscbbPort
        Try
            For i = 0 To UBound(myPort)
                tscbbPort.Items.Add(myPort(i))
            Next
            tscbbPort.Text = tscbbPort.Items.Item(0)    'Set tscbbPort text ke port COM yang terdeteksi pertamakali
        Catch ex As Exception
            MsgBox("Tak ada port serial yang terdeteksi", MsgBoxStyle.Exclamation)
        End Try
        tscbbBaud.Text = tscbbBaud.Items.Item(0)    'Set tscbbBaud text ke baud rate pertama di daftar

        ' Parameter prep
        btnParamEdit.Enabled = False
        btnParamSave.Enabled = False
        tsbtnConnectionAlt.Enabled = False

        'Contoh Param Air
        tbNama.Text = "Air"
        tbDM.Text = 1
        tbDP.Text = 1.01
        tbFVP.Text = 100
        tbJE.Text = 0.02
        tbKB.Text = 0.025
        tbPB.Text = 80.1
        tbPG.Text = 9.81
        tbV.Text = 0.00089

        'disable save data button
        btnSaveData.Enabled = False

        '' [[ HELP Browser ]]
        appPath = Application.StartupPath
        Console.WriteLine(appPath)
        wbHelp.Navigate(appPath & ".\help.html") ' Load file help.html


        '' [[ LiveCharts Settings ]]
        seriCollection.Add(introSeries)

        liveChart1.Series = seriCollection
        liveChart1.LegendLocation = LegendLocation.Top
        liveChart1.AxisY.Clear()
        liveChart1.AxisX.Clear()

        liveChart1.AxisY.Add(New Wpf.Axis() With {
                             .Title = "Ez (mV)",
                             .Foreground = New Windows.Media.SolidColorBrush(Windows.Media.Color.FromRgb(10, 10, 10))
                             })
        liveChart1.AxisX.Add(New Wpf.Axis() With {
                             .Title = "Waktu",
                             .DisableAnimations = False,
                             .LabelFormatter = Function(value) New DateTime(CLng(value)).ToString("mm:ss"),
                             .Foreground = New Windows.Media.SolidColorBrush(Windows.Media.Color.FromRgb(10, 10, 10))
                             })


    End Sub


    ' Toolstrip connect update
    Public Sub UpdateToolStrip()

        If SerialPort1.IsOpen = False And btnParamSet.Enabled = False Then
            ' Connect
            tsbtnConnectionAlt.Enabled = True
            tsbtnConnectionAlt.Text = "Connect"
            tslblStatusAlt.Text = "No board connected"
            tslblStatusAlt.BackColor = Color.LightPink
            tscbbPort.Enabled = True
            tscbbBaud.Enabled = True
            btnParamEdit.Enabled = True
            btnSaveData.Enabled = True


        ElseIf SerialPort1.IsOpen = True Then
            ' Disconnect
            tsbtnConnectionAlt.Enabled = True
            tsbtnConnectionAlt.Text = "Disconnect"
            tslblStatusAlt.Text = SerialPort1.PortName & " is connected"
            tslblStatusAlt.BackColor = Color.LightGreen
            tscbbPort.Enabled = False
            tscbbBaud.Enabled = False
            btnParamEdit.Enabled = False
            btnSaveData.Enabled = True
        Else
            ' Form load
            tsbtnConnectionAlt.Enabled = False
            tsbtnConnectionAlt.Text = "Connect"
            tslblStatusAlt.Text = "No board connected"
            tslblStatusAlt.BackColor = Color.LightPink
            tscbbPort.Enabled = True
            tscbbBaud.Enabled = True
        End If
    End Sub

    ' Timer buat pewaktuan dan jam
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtClockAlt.Text = TimeString
    End Sub

    '' [[ SERIAL COM ]]
    ' COM BUTTON
    Private Sub tsbtnConnectionAlt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbtnConnectionAlt.Click
        'Connect Clicked
        If tsbtnConnectionAlt.Text = "Connect" Then
            SerialPort1.PortName = tscbbPort.Text         'Set SerialPort1 ke COM port yang dipilih
            SerialPort1.BaudRate = tscbbBaud.Text         'Set Baud rate yang dipilih

            'Other Serial Port Property
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Encoding = System.Text.Encoding.Default
            Try
                arrData.Clear() ' Clear arrayData
                SerialPort1.Open()  ' Buka Com
                Chart1.Series(0).Points.Clear() 'Clear grafik system
                liveChart1.Series(0).Values.Clear() 'Clear LiveCharts
                MaterialListView1.Items.Clear() 'Clear ListView
                valXStart = Now   'Start time
                SerialPort1.Write(toggleSmooth) 'Kirim Mode Command (Default Smooth)
            Catch ex As Exception
                MsgBox("Tak bisa terhubung ke " + tscbbPort.Text + vbNewLine + "Silahkan coba lagi.", MsgBoxStyle.Exclamation, "Port sedang sibuk")
                SerialPort1.Close()
                Exit Sub
            End Try
            UpdateToolStrip()
        Else
            'Disconnect Clicked
            SerialPort1.Write("0") 'Kirim Stop Command (Standby Mode)
            SerialPort1.Close()
            UpdateToolStrip()
        End If
    End Sub

    'Refresh Com Port
    Private Sub tsbtnRefresh_Click(sender As Object, e As EventArgs) Handles tsbtnRefresh.Click
        ' Serial Prep
        myPort = SerialPort.GetPortNames() 'Ambil com port yang tersedia
        tscbbPort.Items.Clear()
        Try
            For i = 0 To UBound(myPort)
                tscbbPort.Items.Add(myPort(i))
            Next
            tscbbPort.Text = tscbbPort.Items.Item(0)
        Catch ex As Exception
            MessageBox.Show("Tak ada port serial yang terdeteksi")
        End Try
        tscbbBaud.Text = tscbbBaud.Items.Item(0)


    End Sub

    ' Listen data yang diterima
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            ReceivedText(SerialPort1.ReadLine()) 'Panggil rutin ReceivedText kalau ada "line" data masuk
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub

    ' Rutin ReceivedText / Terima Data
    Private Sub ReceivedText(ByVal text As String)
        Console.WriteLine(text)
        Try
            serdata = Convert.ToDouble(text) ' konversi string data ke double
        Catch err As Exception
            Exit Sub
        End Try

        valXDur = Now.Subtract(valXStart) ' Durasi waktu berjalan
        valX = Date.Parse(Convert.ToString(valXDur)) ' stopwatch
        valY = serdata  ' Data serial
        varES = valY 'Sedimentasi Potensial ES

        If Not Double.IsInfinity(constEQ / valY) Then 'skip kalo div by zero
            'Tambah ke arrData
            arrData.Add(New data() With {.dataX = valX, .dataES = varES, .dataEZ = (constEQ / valY)})

            ' Isi listview
            If Me.MaterialListView1.InvokeRequired Then
            Else
                Dim listData = New ListViewItem({
                                                valX.ToString("mm:ss.ff"),
                                                String.Format("{0:N2}", varES),
                                                String.Format("{0:N5}", constEQ / valY)
                                                })
                MaterialListView1.Items.Add(listData)

                listData.EnsureVisible()
                listData = Nothing
            End If

            ' Gambar grafik
            If Chart1.InvokeRequired Then
                Dim d As New ReceivedDoubleDelegate(AddressOf ReceivedText)
                BeginInvoke(d, New Object() {valY})
            Else
                'Livechart
                liveChart1.Series(0).Values.Add(New MeasureModel() With {.DateTime = valX, .Value = constEQ / valY})

                'Hanya tampilkan 60 data terkini
                If liveChart1.Series(0).Values.Count > 60 Then
                    liveChart1.Series(0).Values.RemoveAt(0)
                End If

                'grafik system
                Chart1.Series("Potensial Zeta").Points.AddXY(valX, constEQ / valY)

            End If

        End If

    End Sub


    '' [[ GRAFIK System]]
    ' Settingan Grafik System
    Private Sub Graph_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Chart1.Series(0).XValueType = ChartValueType.Time
        With Chart1.ChartAreas(0)
            .AxisX.LabelStyle.Format = "mm:ss"
            .AxisX.ScaleView.Zoomable = True
            .AxisY.ScaleView.Zoomable = True
            .CursorX.IsUserSelectionEnabled = True
            .CursorY.IsUserSelectionEnabled = True
            .CursorX.AutoScroll = True
            .CursorY.AutoScroll = True
            .CursorX.IsUserEnabled = True
            .CursorX.IntervalType = DateTimeIntervalType.Seconds
            .CursorX.Interval = 1D
            .AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Seconds
            .AxisX.ScaleView.SmallScrollSize = 1D
        End With
    End Sub

    ' Interaktif Hover
    Private Sub Chart1_MouseMove(sender As Object, e As MouseEventArgs)
        ' Call HitTest
        Dim result As HitTestResult = Chart1.HitTest(e.X, e.Y)

        ' Reset Data Point Attributes
        Dim point As DataPoint
        For Each point In Chart1.Series(0).Points
            point.BackSecondaryColor = Color.Black
            point.BackHatchStyle = ChartHatchStyle.None
            point.MarkerSize = 8
            point.MarkerColor = Color.Empty
        Next

        ' Mouse hover ke titik data
        If result.ChartElementType = ChartElementType.DataPoint Then
            ' tampilkan nilai data yang dipilih
            Dim pointInt As DataPoint = Chart1.Series(0).Points(result.PointIndex)

            ' tampilan titik data
            pointInt.BackSecondaryColor = Color.White
            pointInt.BackHatchStyle = ChartHatchStyle.Percent25
            pointInt.MarkerSize = 10
            pointInt.MarkerColor = Color.Red

        Else
            ' Set default cursor
            Me.Cursor = Cursors.Default
        End If
    End Sub


    '' [[ CSV DATA PROCESS ]]
    ' Write to CSV
    Sub writedata(ByVal filename As String)
        engine.HeaderText = """Waktu"";""Es(mV)"";""Ez(mV)"""
        engine.GetFileHeader()
        'write the file
        engine.WriteFile(filename, arrData)
        MessageBox.Show("File created" & vbNewLine & "Do not open the file yet.")

    End Sub
    ' Read from CSV
    Sub readdata(ByVal filename As String)
        Dim dataRead = CType(CommonEngine.ReadFile(GetType(data), filename), data())
        For Each dat As data In dataRead
            Console.WriteLine(dat.dataX.ToString("HH:mm:ss") & " | " & dat.dataES & " | " & dat.dataEZ)
        Next

    End Sub

    ' Save File
    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        If arrData.Count = 0 Then
            MessageBox.Show("Belum ada data")
            Exit Sub
        End If
        sfdData.Filter = "CSV Files (*.csv*)|*.csv"
        If sfdData.ShowDialog = DialogResult.OK _
      Then
            writedata(sfdData.FileName)
            Console.WriteLine("File : " & sfdData.FileName)
            Console.WriteLine("Waktu | Es (mV) | Ez (mV)")
            readdata(sfdData.FileName)
            Console.WriteLine("-----------------------------")

            'Prepend details

            Dim mytext As String
            Dim content As String
            Using reader As StreamReader = File.OpenText(sfdData.FileName)
                content = reader.ReadToEnd
            End Using
            mytext = "sep=;" & vbCrLf & "Timestamp;" & Date.Today & vbCrLf & "Sampel;" & paramNama & vbCrLf & content
            Using writer As New StreamWriter(sfdData.FileName) 'True for append mode
                writer.Write(mytext)
            End Using
            MessageBox.Show("Prepend details on file, done" & vbNewLine & "You can open the file now")
        End If
    End Sub

    '' [[ PARAMETER ]]
    ' Set Button
    Private Sub btnParamSet_Click(sender As Object, e As EventArgs) Handles btnParamSet.Click

        ' textbox validation pastikan 0 bukan null
        Try
            paramDM = Convert.ToDouble(tbDM.Text)
            paramDP = Convert.ToDouble(tbDP.Text)
            paramFVP = Convert.ToDouble(tbFVP.Text)
            paramJE = Convert.ToDouble(tbJE.Text)
            paramKB = Convert.ToDouble(tbKB.Text)
            paramPB = Convert.ToDouble(tbPB.Text)
            paramPG = Convert.ToDouble(tbPG.Text)
            paramV = Convert.ToDouble(tbV.Text)
            paramNama = tbNama.Text

            'Permitivitas Bahan Relatif to Permitivitas Bahan
            paramPB = paramPB * paramPV

            ' konversi satuan densitas
            paramDM = paramDM * 1000
            paramDP = paramDP * 1000

            'konversi wt%
            paramFVP = paramFVP / 100

        Catch ex As Exception
            MsgBox("Isi semua parameter dengan angka")
        End Try


        Try
            ' Sample name check
            If tbNama.Text = "" Then
                MessageBox.Show("Isi nama sampel")
                Exit Try
            End If

            ' Rumus konstanta pengali data
            constEQ = (paramV * paramKB * paramJE) / (paramPB * paramFVP * paramPG * (paramDP - paramDM))

            TextBox1.Text = constEQ

            ' Avoid 0 and Infinity ConstEQ
            If constEQ = 0 Or Double.IsInfinity(constEQ) Or Double.IsNaN(constEQ) Then
                Exit Try
            End If

            ' Enable COM Button
            tsbtnConnectionAlt.Enabled = True

            btnParamEdit.Enabled = True
            btnParamSave.Enabled = True
            btnParamLoad.Enabled = False
            btnParamSet.Enabled = False

            'Disable TBs
            Dim textboxes As Control
            For Each textboxes In TableLayoutPanel1.Controls
                If (textboxes.GetType Is GetType(TextBox)) Then
                    Dim txt As TextBox = CType(textboxes, TextBox)
                    txt.Enabled = False
                End If
            Next
            tbNama.Enabled = False

            rbRaw.Enabled = False
            rbSmooth.Enabled = False

        Catch ex As Exception
            MsgBox("Pastikan parameter berformat angka desimal")
        End Try

    End Sub

    ' Edit Button
    Private Sub btnParamEdit_Click(sender As Object, e As EventArgs) Handles btnParamEdit.Click
        btnParamSet.Enabled = True
        btnParamEdit.Enabled = False
        btnParamSave.Enabled = False
        btnParamLoad.Enabled = True
        tsbtnConnectionAlt.Enabled = False

        'Reset constEQ
        constEQ = 0
        TextBox1.Text = constEQ

        'Enable TBs
        Dim textboxes As Control
        For Each textboxes In TableLayoutPanel1.Controls
            If (textboxes.GetType Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(textboxes, TextBox)
                txt.Enabled = True
            End If
        Next
        tbNama.Enabled = True

        rbRaw.Enabled = True
        rbSmooth.Enabled = True

    End Sub

    ' Write to CSV
    Sub writeparam(ByVal filename As String)
        engineParam.HeaderText = """Nama"";""JE"";""FVP"";""PB"";""DP"";""DM"";""G"";""V"";""KB"""
        engineParam.GetFileHeader()
        arrParam.Add(New param() With {
                     .param_nama = tbNama.Text,
                     .param_JE = Convert.ToDouble(tbJE.Text),
                     .param_FVP = Convert.ToDouble(tbFVP.Text),
                     .param_PB = Convert.ToDouble(tbPB.Text),
                     .param_DP = Convert.ToDouble(tbDP.Text),
                     .param_DM = Convert.ToDouble(tbDM.Text),
                     .param_G = Convert.ToDouble(tbPG.Text),
                     .param_V = Convert.ToDouble(tbV.Text),
                     .param_KB = Convert.ToDouble(tbKB.Text)})
        'write the file
        engineParam.WriteFile(filename, arrParam)
    End Sub

    ' Read from CSV
    Sub readparam(ByVal filename As String)
        Dim dataRead = CType(CommonEngine.ReadFile(GetType(param), filename), param())
        For Each dat As param In dataRead
            tbNama.Text = dat.param_nama
            tbDM.Text = dat.param_DM

            tbDP.Text = dat.param_DP
            tbFVP.Text = dat.param_FVP
            tbJE.Text = dat.param_JE
            tbKB.Text = dat.param_KB
            tbPB.Text = dat.param_PB
            tbPG.Text = dat.param_G
            tbV.Text = dat.param_V
        Next
    End Sub

    'Save button
    Private Sub btnParamSave_Click(sender As Object, e As EventArgs) Handles btnParamSave.Click
        sfdParam.Filter = "TAZPA Parameter Files (*.zpp*)|*.zpp"
        If sfdParam.ShowDialog = DialogResult.OK _
      Then
            writeparam(sfdParam.FileName)
            MessageBox.Show("Parameter Saved")
        End If
    End Sub

    'Load Button
    Private Sub btnParamLoad_Click(sender As Object, e As EventArgs) Handles btnParamLoad.Click
        ofdParam.Filter = "TAZPA Parameter Files (*.zpp*)|*.zpp"
        If ofdParam.ShowDialog = DialogResult.OK _
      Then
            readparam(ofdParam.FileName)
            MessageBox.Show("Parameter Loaded")
        End If
    End Sub

    '' [[ MCU Control ]]
    'Mode Raw
    Private Sub rbRaw_CheckedChanged(sender As Object, e As EventArgs) Handles rbRaw.CheckedChanged
        toggleSmooth = "1"
    End Sub
    'Mode EMA Smooth
    Private Sub rbSmooth_CheckedChanged(sender As Object, e As EventArgs) Handles rbSmooth.CheckedChanged
        toggleSmooth = "2"
    End Sub

    '' [[ HELP BROWSER ]]
    Private Sub wbHelp_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbHelp.DocumentCompleted
        OpenAllInBrowser = True
    End Sub

    Private OpenAllInBrowser As Boolean = False

    ' Batalkan navigasi didalam komponen browser internal, redirect ke default system web browser
    Private Sub wbHelp_Navigating(ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs) Handles wbHelp.Navigating
        If OpenAllInBrowser Then
            Process.Start(e.Url.ToString())
            e.Cancel = True
        End If
    End Sub

    '' [[ FORM CLOSE ]]
    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.FormClosing
        OpenAllInBrowser = False

        ' Serial reset
        If SerialPort1.IsOpen = True Then
            SerialPort1.Write("0")
            SerialPort1.Close()
        End If
    End Sub
End Class

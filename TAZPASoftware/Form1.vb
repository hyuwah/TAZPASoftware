'' [[ DESKRIPSI ]]
' TAZPA Software
' Program untuk interface dengan TAZPA
' Copyright (c) 2016 Muhammad Wahyudin. All rights reserved
' http://www.hyuwah.me/skripsi

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


'' [[ TODO ]]
'' Parameter
''     Nama sampel, tgl?
''     Set, Edit, Save, Load
'' Validasi Parameter sebelum konek port
''     bisa konek kalo udah set, kalo udah set belum konek bisa edit
'' Save data serial ke csv
''     ValX, ValY Raw, ValY processed
'' Load data only dan tampil di grafik sama terminal
'' 

'' Alur:    1. Set Parameter
''          2. COM / LOAD
''          3. Terminal + Monitor

'' [[ Library ]]
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections.Generic
Imports System.IO
Imports FileHelpers
Imports System.IO.Ports

Public Class Form1
    '' [[ DEKLARASI VARIABEL ]]

    ' Filehelpers
    Private engine As New FileHelperEngine(GetType(data))

    'Create a list of objects to persist
    Private arrObjects As New List(Of data)

    ' Deklarasi nilai X (waktu) dan Y (Dummy Data)
    Private valXStart As DateTime
    Private valXDur As TimeSpan
    Private valX As DateTime
    Private valY As Double = CDec(Math.Floor((100 - -100 + 1) * Rnd())) + -100
    Private serdata As Double
    Private constEQ As Double = 0

    Dim myPort As Array
    Delegate Sub ReceivedTextDelegate(ByVal text As String) 'Added to prevent threading errors during receiveing of data
    Delegate Sub ReceivedDoubleDelegate(ByVal valY As Double) 'Added to prevent threading errors during receiveing of data

    ' Variabel Parameter
    Dim paramJE As Double
    Dim paramFVP As Double
    Dim paramPB As Double
    Dim paramDP As Double
    Dim paramDM As Double
    Dim paramPG As Double
    Dim paramV As Double
    Dim paramKB As Double

    ' Variabel hasil
    Dim varZP As Double
    Dim varSP As Double

    '' [[ Form Setting ]]
    ' Form LOAD
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateToolStrip()

        ' Serial Prep
        myPort = SerialPort.GetPortNames() 'Get all com ports available
        tscbbBaud.Items.Add(9600)     'Populate the tscbbBaud Combo box to common baud rates used
        tscbbBaud.Items.Add(19200)
        tscbbBaud.Items.Add(38400)
        tscbbBaud.Items.Add(57600)
        tscbbBaud.Items.Add(115200)
        For i = 0 To UBound(myPort)
            tscbbPort.Items.Add(myPort(i))
        Next
        tscbbPort.Text = tscbbPort.Items.Item(0)    'Set tscbbPort text to the first COM port detected
        tscbbBaud.Text = tscbbBaud.Items.Item(0)    'Set tscbbBaud text to the first Baud rate on the list

        ' Parameter prep
        btnParamEdit.Enabled = False
        btnParamSave.Enabled = False
        tsbtnConnection.Enabled = False

        'Contoh Param
        tbDM.Text = 998.2
        tbDP.Text = 2600
        tbFVP.Text = 0.1
        tbJE.Text = 0.1
        tbKB.Text = 0.127
        tbPB.Text = 0.0000000007100908
        tbPG.Text = 9.81
        tbV.Text = 0.001

    End Sub

    ' Toolstrip connect update
    Public Sub UpdateToolStrip()

        If SerialPort1.IsOpen = False And btnParamSet.Enabled = False Then
            ' Connect
            tsbtnConnection.Enabled = True
            tsbtnConnection.Text = "Connect"
            tslblStatus.Text = ""
            tslblStatus.BackColor = Color.Green
            tscbbPort.Enabled = True
            tscbbBaud.Enabled = True

        ElseIf SerialPort1.IsOpen = True Then
            ' Disconnect
            tsbtnConnection.Enabled = True
            tsbtnConnection.Text = "Disconnect"
            ' Need a property of FirmataVB to get port name in use
            tslblStatus.Text = SerialPort1.PortName & " is connected"
            tslblStatus.BackColor = Color.LightPink
            tscbbPort.Enabled = False
            tscbbBaud.Enabled = False
        Else
            ' Initial
            tsbtnConnection.Enabled = False
            tsbtnConnection.Text = "Connect"
            tslblStatus.Text = ""
            tslblStatus.BackColor = Color.Green
            tscbbPort.Enabled = True
            tscbbBaud.Enabled = True
        End If
    End Sub

    'Toolstrip Exit
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        SerialPort1.Close()
        Me.Close()
    End Sub
    'Toolstrip About
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        Process.Start("http://www.acraigie.com/programming/firmatavb/default.html")
    End Sub
    'Toolstrip Help
    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Process.Start("http://www.acraigie.com/programming/firmatavb/default.html")
    End Sub

    ' Timer buat pewaktuan dan jam
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtClock.Text = TimeString
    End Sub

    '' [[ SERIAL COM ]]
    ' COM BUTTON
    Private Sub tsbtnConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbtnConnection.Click
        If tsbtnConnection.Text = "Connect" Then
            SerialPort1.PortName = tscbbPort.Text         'Set SerialPort1 to the selected COM port at startup
            SerialPort1.BaudRate = tscbbBaud.Text         'Set Baud rate to the selected value on

            'Other Serial Port Property
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8            'Open our serial port
            SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
            Try
                SerialPort1.Open()
                rtbReceived.ResetText() ' clear terminal
                Chart1.Series("Series1").Points.Clear() ' clear grafik
                rtbReceived.Focus()
                valXStart = Now   'Start time
            Catch ex As Exception
                MsgBox("Can't connect to " + tscbbPort.Text + vbNewLine + "Please try again.", MsgBoxStyle.Exclamation, "Port is busy")
            End Try
            UpdateToolStrip()
        Else
            SerialPort1.Close()
            UpdateToolStrip()
        End If
    End Sub

    ' Terima data serial
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadLine())    'Automatically called every time a data is received at the serialPort

    End Sub

    Private Sub ReceivedText(ByVal text As String)
        Console.WriteLine(text)
        serdata = Convert.ToDouble(text)

        valXDur = Now.Subtract(valXStart)
        valX = Date.Parse(Convert.ToString(valXDur))
        'valY = constEQ / serdata
        valY = serdata

        If Not Double.IsInfinity(constEQ / valY) Then 'skip kalo div by zero
            arrObjects.Add(New data() With {.dataX = valX, .dataY = (constEQ / valY)})

            'compares the ID of the creating Thread to the ID of the calling Thread
            If Me.rtbReceived.InvokeRequired Then
                'Dim x As New ReceivedTextDelegate(AddressOf Me.ReceivedText)
                'Me.BeginInvoke(x, New Object() {text})
            Else
                'Me.rtbReceived.Text = Now.ToLongTimeString & " | " & text & vbNewLine & Me.rtbReceived.Text 'ScrollUp
                Me.rtbReceived.AppendText(valX.ToString("HH:mm:ss") & " | " & String.Format("{0:N4}", constEQ / valY) & vbNewLine) 'ScrollDown

            End If

            If Chart1.InvokeRequired Then
                Dim d As New ReceivedDoubleDelegate(AddressOf ReceivedText)
                BeginInvoke(d, New Object() {valY})
            Else
                Chart1.Series("Series1").Points.AddXY(valX, constEQ / valY)
            End If
        End If

    End Sub

    '' [[ TESTING ]]
    Dim j As Integer = 0 'debugging
    ' Tambah dummy data manual
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        valX = valX.AddSeconds(1)

        valY = constEQ / (CDec(Math.Floor((100 - -100 + 1) * Rnd())) + -100)
        Chart1.Series("Series1").Points.AddXY(valX, valY)

        'Add data Buat CSV
        arrObjects.Add(New data() With {.dataX = valX, .dataY = valY})

        'debugging
        Console.WriteLine(arrObjects.Item(j).dataX)
        Console.WriteLine(arrObjects.Item(j).dataY)
        Console.WriteLine("-----------")
        Console.WriteLine(engine.WriteString(arrObjects))
        Console.WriteLine("============")

        j = j + 1

    End Sub

    '' [[ GRAFIK ]]
    ' Settingan Grafik
    Private Sub Graph_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Chart1.Series(0).XValueType = ChartValueType.Time
        With Chart1.ChartAreas(0)
            .AxisX.LabelStyle.Format = "HH:mm:ss"
            .AxisX.ScaleView.Zoomable = True
            '.AxisY.ScaleView.Zoomable = True
            .CursorX.IsUserSelectionEnabled = True
            '.CursorY.IsUserSelectionEnabled = True
            .CursorX.AutoScroll = True
            '.CursorY.AutoScroll = True
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

        ' If the mouse if over a data point
        If result.ChartElementType = ChartElementType.DataPoint Then
            ' Find selected data point
            Dim pointInt As DataPoint = Chart1.Series(0).Points(result.PointIndex)

            ' Change the appearance of the data point
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
        engine.HeaderText = """Waktu"",""Zeta Potensial(mV)"""
        engine.GetFileHeader()
        'write the file
        engine.WriteFile(filename, arrObjects)
        MessageBox.Show("File created" & vbNewLine & "Do not open the file yet.")

    End Sub
    ' Read from CSV
    Sub readdata(ByVal filename As String)
        Dim dataRead = CType(CommonEngine.ReadFile(GetType(data), filename), data())
        For Each dat As data In dataRead
            Console.WriteLine(dat.dataX.ToString("HH:mm:ss") & " | " & dat.dataY)
        Next
        MessageBox.Show("Console Read Done")
    End Sub

    ' Save File
    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        sfdData.Filter = "CSV Files (*.csv*)|*.csv"
        If sfdData.ShowDialog = DialogResult.OK _
      Then
            writedata(sfdData.FileName)
            Console.WriteLine("File : " & sfdData.FileName)
            Console.WriteLine("Waktu | Zeta Potensial (mV)")
            readdata(sfdData.FileName)
            Console.WriteLine("-----------------------------")

            'Prepend details
            Dim paramSampel As String = "nama sampel"
            Dim mytext As String
            Dim content As String
            Using reader As StreamReader = File.OpenText(sfdData.FileName)
                content = reader.ReadToEnd
            End Using
            mytext = "Timestamp," & Date.Today & vbCrLf & "Sampel," & paramSampel & vbCrLf & content
            Using writer As New StreamWriter(sfdData.FileName) 'True for append mode
                writer.Write(mytext)
            End Using
            MessageBox.Show("Prepend details on file, done" & vbNewLine & "You can open the file now")
        End If
    End Sub

    '' [[ PARAMETER ]]
    ' Set Button
    Private Sub btnParamSet_Click(sender As Object, e As EventArgs) Handles btnParamSet.Click
        ' Need textbox validation (Double not null)
        Try
            paramDM = Convert.ToDouble(tbDM.Text)
            paramDP = Convert.ToDouble(tbDP.Text)
            paramFVP = Convert.ToDouble(tbFVP.Text)
            paramJE = Convert.ToDouble(tbJE.Text)
            paramKB = Convert.ToDouble(tbKB.Text)
            paramPB = Convert.ToDouble(tbPB.Text)
            paramPG = Convert.ToDouble(tbPG.Text)
            paramV = Convert.ToDouble(tbV.Text)
        Catch ex As Exception
            MsgBox("Isi semua parameter dengan angka")
        End Try


        Try
            ' Rumus konstanta pengali data
            constEQ = (paramV * paramKB * paramJE) / (paramPB * paramFVP * paramPG * (paramDP - paramDM))
            TextBox1.Text = constEQ
            ' Enable COM Button
            tsbtnConnection.Enabled = True
        Catch ex As Exception
            MsgBox("Pastikan parameter berformat angka desimal")
        End Try

    End Sub
End Class

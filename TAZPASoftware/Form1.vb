' Arduino <> Firmata <> Visual Basic .NET 
' TAZPA Software
' Program to demonstrate the use of FirmataVB, DigitalPinControl
' and AnalogPinControl components
' The program communicates with an Arduino Diecimila 
' running the freely available Standard Firmata Library (see links below
' for info on Firmata)
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


Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections.Generic
Imports System.IO

'-> Never forget:  Imports FileHelpers
Imports FileHelpers
Imports System.IO.Ports

Public Class Form1

    ' Filehelpers
    Private engine As New FileHelperEngine(GetType(data))
    'Create a list of objects to persist
    Private arrObjects As New List(Of data)

    'fill the list of objects
    Private item As New data

    ' Deklarasi nilai X (waktu) dan Y (Dummy Data)
    Private valXStart As DateTime
    Private valXDur As TimeSpan
    Private valX As DateTime
    Private valY As Decimal = CDec(Math.Floor((100 - -100 + 1) * Rnd())) + -100
    Private serdata As Decimal

    Dim myPort As Array
    Delegate Sub ReceivedTextDelegate(ByVal text As String) 'Added to prevent threading errors during receiveing of data
    Delegate Sub ReceivedDecimalDelegate(ByVal valY As Decimal) 'Added to prevent threading errors during receiveing of data

    ' Form LOAD
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateToolStrip()

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

    End Sub

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

    Public Sub UpdateToolStrip()

        If SerialPort1.IsOpen = False Then
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

    ' Terima data serial
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadLine())    'Automatically called every time a data is received at the serialPort

    End Sub

    Private Sub ReceivedText(ByVal text As String)
        Console.WriteLine(text)
        serdata = Convert.ToDecimal(text)

        valXDur = Now.Subtract(valXStart)
        valX = Date.Parse(Convert.ToString(valXDur))
        valY = serdata

        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            'Dim x As New ReceivedTextDelegate(AddressOf Me.ReceivedText)
            'Me.BeginInvoke(x, New Object() {text})
        Else
            'Me.rtbReceived.Text = Now.ToLongTimeString & " | " & text & vbNewLine & Me.rtbReceived.Text 'ScrollUp
            Me.rtbReceived.AppendText(valX.ToString("HH:mm:ss") & " | " & text + vbNewLine) 'ScrollDown

        End If
        'txtLastData.Text = text


        If Chart1.InvokeRequired Then
            Dim d As New ReceivedDecimalDelegate(AddressOf ReceivedText)
            BeginInvoke(d, New Object() {valY})
        Else
            Chart1.Series("Series1").Points.AddXY(valX, valY)
        End If
    End Sub



    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        SerialPort1.Close()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        Process.Start("http://www.acraigie.com/programming/firmatavb/default.html")
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Process.Start("http://www.acraigie.com/programming/firmatavb/default.html")
    End Sub


    ' Timer buat pewaktuan dan jam
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtClock.Text = TimeString
    End Sub

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

    Dim j As Integer = 0 'debugging
    ' Tambah dummy data manual
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        valX = valX.AddSeconds(1)

        valY = CDec(Math.Floor((100 - -100 + 1) * Rnd())) + -100
        Chart1.Series("Series1").Points.AddXY(valX, valY)

        'Buat CSV
        item.dataX = valX
        item.dataY = valY
        arrObjects.Add(item)

        'debugging
        Console.WriteLine(arrObjects.Item(j).dataX)
        Console.WriteLine(arrObjects.Item(j).dataY)
        Console.WriteLine("============")
        Console.WriteLine(engine.WriteString(arrObjects))
        j = j + 1
    End Sub

    ' == Interaktif Hover ==
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

    ' CSV DATA PROCESS
    Sub rwengine()

        'Dim subdata As data()

        'If File.Exists("C:\Users\Hyuwah\Documents\dataout.txt") Then File.Delete("C:\Users\Hyuwah\Documents\dataout.txt")

        'write the file
        engine.WriteFile("C:\Users\Hyuwah\Documents\dataout.txt", arrObjects)

        MessageBox.Show("File created")


        'subdata = CType(engine.ReadFile("C:\Users\Hyuwah\Documents\customerin.txt"), data())
        'For Each cli As data In subdata
        'Console.WriteLine()
        'Console.WriteLine("Data X: " + cli.dataX.ToString("hh:mm:ss"))
        'Console.WriteLine("Data Y: " + cli.dataY.ToString())
        'Console.WriteLine()
        'Console.WriteLine("-----------------------------")
        'Next

        ' To Write Use
        'engine.WriteFile("C:\Users\Hyuwah\Documents\customerout.txt", subdata)
        'Console.WriteLine()
        'Console.WriteLine("Data Successful written !!!")
    End Sub
    Private Sub btnCSVTest_Click(sender As Object, e As EventArgs) Handles btnCSVTest.Click
        rwengine()
    End Sub


End Class

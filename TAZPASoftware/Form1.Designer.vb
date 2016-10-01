<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tscbbPort = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tscbbBaud = New System.Windows.Forms.ToolStripComboBox()
        Me.TabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabMonitor = New System.Windows.Forms.TabPage()
        Me.MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbParameter = New System.Windows.Forms.GroupBox()
        Me.rbSmooth = New System.Windows.Forms.RadioButton()
        Me.rbRaw = New System.Windows.Forms.RadioButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.lblNamaSampel = New System.Windows.Forms.Label()
        Me.ParamPanel = New System.Windows.Forms.Panel()
        Me.btnParamSet = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnParamEdit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnParamLoad = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnParamSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblParam2 = New System.Windows.Forms.Label()
        Me.lblParam1 = New System.Windows.Forms.Label()
        Me.lblParam3 = New System.Windows.Forms.Label()
        Me.lblParam4 = New System.Windows.Forms.Label()
        Me.lblParam5 = New System.Windows.Forms.Label()
        Me.lblParam6 = New System.Windows.Forms.Label()
        Me.lblParam7 = New System.Windows.Forms.Label()
        Me.lblParam8 = New System.Windows.Forms.Label()
        Me.tbJE = New System.Windows.Forms.TextBox()
        Me.tbFVP = New System.Windows.Forms.TextBox()
        Me.tbPB = New System.Windows.Forms.TextBox()
        Me.tbDP = New System.Windows.Forms.TextBox()
        Me.tbDM = New System.Windows.Forms.TextBox()
        Me.tbPG = New System.Windows.Forms.TextBox()
        Me.tbV = New System.Windows.Forms.TextBox()
        Me.tbKB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbGrafik = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaveData = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.wbHelp = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.sfdData = New System.Windows.Forms.SaveFileDialog()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tsbtnConnectionAlt = New MaterialSkin.Controls.MaterialFlatButton()
        Me.tslblStatusAlt = New MaterialSkin.Controls.MaterialLabel()
        Me.tsbtnRefresh = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.sfdParam = New System.Windows.Forms.SaveFileDialog()
        Me.ofdParam = New System.Windows.Forms.OpenFileDialog()
        Me.txtClockAlt = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabMonitor.SuspendLayout()
        Me.gbParameter.SuspendLayout()
        Me.ParamPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbGrafik.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.tscbbPort, Me.ToolStripLabel3, Me.tscbbBaud})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 570)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(503, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripLabel1.Text = "Board Connection:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel2.Text = "COM Port:"
        '
        'tscbbPort
        '
        Me.tscbbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tscbbPort.Name = "tscbbPort"
        Me.tscbbPort.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel3.Text = "Baud Rate:"
        '
        'tscbbBaud
        '
        Me.tscbbBaud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tscbbBaud.Name = "tscbbBaud"
        Me.tscbbBaud.Size = New System.Drawing.Size(121, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabMonitor)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Depth = 0
        Me.TabControl1.Location = New System.Drawing.Point(5, 90)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(10)
        Me.TabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(950, 470)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 33
        '
        'tabMonitor
        '
        Me.tabMonitor.Controls.Add(Me.MaterialListView1)
        Me.tabMonitor.Controls.Add(Me.gbParameter)
        Me.tabMonitor.Controls.Add(Me.gbGrafik)
        Me.tabMonitor.Location = New System.Drawing.Point(4, 22)
        Me.tabMonitor.Name = "tabMonitor"
        Me.tabMonitor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMonitor.Size = New System.Drawing.Size(942, 444)
        Me.tabMonitor.TabIndex = 0
        Me.tabMonitor.Text = "Monitor"
        Me.tabMonitor.UseVisualStyleBackColor = True
        '
        'MaterialListView1
        '
        Me.MaterialListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.MaterialListView1.Depth = 0
        Me.MaterialListView1.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MaterialListView1.FullRowSelect = True
        Me.MaterialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MaterialListView1.Location = New System.Drawing.Point(701, 3)
        Me.MaterialListView1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialListView1.Name = "MaterialListView1"
        Me.MaterialListView1.OwnerDraw = True
        Me.MaterialListView1.Size = New System.Drawing.Size(235, 437)
        Me.MaterialListView1.TabIndex = 45
        Me.MaterialListView1.UseCompatibleStateImageBehavior = False
        Me.MaterialListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Waktu"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Es(mV)"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ZP(mV)"
        Me.ColumnHeader3.Width = 84
        '
        'gbParameter
        '
        Me.gbParameter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbParameter.BackColor = System.Drawing.Color.White
        Me.gbParameter.Controls.Add(Me.rbSmooth)
        Me.gbParameter.Controls.Add(Me.rbRaw)
        Me.gbParameter.Controls.Add(Me.MaterialDivider1)
        Me.gbParameter.Controls.Add(Me.tbNama)
        Me.gbParameter.Controls.Add(Me.lblNamaSampel)
        Me.gbParameter.Controls.Add(Me.ParamPanel)
        Me.gbParameter.Controls.Add(Me.TextBox1)
        Me.gbParameter.Controls.Add(Me.TableLayoutPanel1)
        Me.gbParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbParameter.Location = New System.Drawing.Point(8, 6)
        Me.gbParameter.Name = "gbParameter"
        Me.gbParameter.Size = New System.Drawing.Size(225, 438)
        Me.gbParameter.TabIndex = 43
        Me.gbParameter.TabStop = False
        Me.gbParameter.Text = "Parameter Pengukuran"
        '
        'rbSmooth
        '
        Me.rbSmooth.AutoSize = True
        Me.rbSmooth.Location = New System.Drawing.Point(6, 391)
        Me.rbSmooth.Name = "rbSmooth"
        Me.rbSmooth.Size = New System.Drawing.Size(99, 17)
        Me.rbSmooth.TabIndex = 12
        Me.rbSmooth.TabStop = True
        Me.rbSmooth.Text = "Smoothed Data"
        Me.rbSmooth.UseVisualStyleBackColor = True
        '
        'rbRaw
        '
        Me.rbRaw.AutoSize = True
        Me.rbRaw.Location = New System.Drawing.Point(6, 370)
        Me.rbRaw.Name = "rbRaw"
        Me.rbRaw.Size = New System.Drawing.Size(73, 17)
        Me.rbRaw.TabIndex = 11
        Me.rbRaw.TabStop = True
        Me.rbRaw.Text = "Raw Data"
        Me.rbRaw.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 332)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(200, 1)
        Me.MaterialDivider1.TabIndex = 10
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(91, 22)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(128, 20)
        Me.tbNama.TabIndex = 9
        '
        'lblNamaSampel
        '
        Me.lblNamaSampel.AutoSize = True
        Me.lblNamaSampel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaSampel.Location = New System.Drawing.Point(6, 24)
        Me.lblNamaSampel.Name = "lblNamaSampel"
        Me.lblNamaSampel.Size = New System.Drawing.Size(79, 13)
        Me.lblNamaSampel.TabIndex = 8
        Me.lblNamaSampel.Text = "Nama Sampel :"
        '
        'ParamPanel
        '
        Me.ParamPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ParamPanel.Controls.Add(Me.btnParamSet)
        Me.ParamPanel.Controls.Add(Me.btnParamEdit)
        Me.ParamPanel.Controls.Add(Me.btnParamLoad)
        Me.ParamPanel.Controls.Add(Me.btnParamSave)
        Me.ParamPanel.Location = New System.Drawing.Point(8, 284)
        Me.ParamPanel.Name = "ParamPanel"
        Me.ParamPanel.Size = New System.Drawing.Size(208, 36)
        Me.ParamPanel.TabIndex = 7
        '
        'btnParamSet
        '
        Me.btnParamSet.AutoSize = True
        Me.btnParamSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParamSet.BackColor = System.Drawing.SystemColors.Control
        Me.btnParamSet.Depth = 0
        Me.btnParamSet.Icon = Nothing
        Me.btnParamSet.Location = New System.Drawing.Point(0, 0)
        Me.btnParamSet.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParamSet.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParamSet.Name = "btnParamSet"
        Me.btnParamSet.Primary = True
        Me.btnParamSet.Size = New System.Drawing.Size(45, 36)
        Me.btnParamSet.TabIndex = 1
        Me.btnParamSet.Text = "Set"
        Me.btnParamSet.UseVisualStyleBackColor = False
        '
        'btnParamEdit
        '
        Me.btnParamEdit.AutoSize = True
        Me.btnParamEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParamEdit.Depth = 0
        Me.btnParamEdit.Icon = Nothing
        Me.btnParamEdit.Location = New System.Drawing.Point(45, 0)
        Me.btnParamEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParamEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParamEdit.Name = "btnParamEdit"
        Me.btnParamEdit.Primary = True
        Me.btnParamEdit.Size = New System.Drawing.Size(50, 36)
        Me.btnParamEdit.TabIndex = 4
        Me.btnParamEdit.Text = "Edit"
        Me.btnParamEdit.UseVisualStyleBackColor = True
        '
        'btnParamLoad
        '
        Me.btnParamLoad.AutoSize = True
        Me.btnParamLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParamLoad.Depth = 0
        Me.btnParamLoad.Icon = Nothing
        Me.btnParamLoad.Location = New System.Drawing.Point(152, 0)
        Me.btnParamLoad.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParamLoad.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParamLoad.Name = "btnParamLoad"
        Me.btnParamLoad.Primary = False
        Me.btnParamLoad.Size = New System.Drawing.Size(56, 36)
        Me.btnParamLoad.TabIndex = 3
        Me.btnParamLoad.Text = "Load"
        Me.btnParamLoad.UseVisualStyleBackColor = True
        '
        'btnParamSave
        '
        Me.btnParamSave.AutoSize = True
        Me.btnParamSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParamSave.Depth = 0
        Me.btnParamSave.Icon = Nothing
        Me.btnParamSave.Location = New System.Drawing.Point(96, 0)
        Me.btnParamSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParamSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParamSave.Name = "btnParamSave"
        Me.btnParamSave.Primary = False
        Me.btnParamSave.Size = New System.Drawing.Size(55, 36)
        Me.btnParamSave.TabIndex = 2
        Me.btnParamSave.Text = "Save"
        Me.btnParamSave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 344)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15094!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.67924!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.69811!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParam8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tbJE, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFVP, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPB, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDP, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDM, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPG, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbV, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tbKB, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 7)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(213, 218)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "m"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam2
        '
        Me.lblParam2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam2.AutoSize = True
        Me.lblParam2.Location = New System.Drawing.Point(5, 28)
        Me.lblParam2.Name = "lblParam2"
        Me.lblParam2.Size = New System.Drawing.Size(73, 26)
        Me.lblParam2.TabIndex = 1
        Me.lblParam2.Text = "Fraksi Volume Partikel (ϕp)"
        Me.lblParam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam1
        '
        Me.lblParam1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam1.AutoSize = True
        Me.lblParam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParam1.Location = New System.Drawing.Point(8, 1)
        Me.lblParam1.Name = "lblParam1"
        Me.lblParam1.Size = New System.Drawing.Size(67, 26)
        Me.lblParam1.TabIndex = 0
        Me.lblParam1.Text = "Jarak Elektroda (L)"
        Me.lblParam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam3
        '
        Me.lblParam3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam3.AutoSize = True
        Me.lblParam3.Location = New System.Drawing.Point(12, 55)
        Me.lblParam3.Name = "lblParam3"
        Me.lblParam3.Size = New System.Drawing.Size(60, 26)
        Me.lblParam3.TabIndex = 2
        Me.lblParam3.Text = "Permitivitas Bahan (εr)"
        Me.lblParam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam4
        '
        Me.lblParam4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam4.AutoSize = True
        Me.lblParam4.Location = New System.Drawing.Point(10, 82)
        Me.lblParam4.Name = "lblParam4"
        Me.lblParam4.Size = New System.Drawing.Size(63, 26)
        Me.lblParam4.TabIndex = 3
        Me.lblParam4.Text = "Densitas Partikel (ρp)"
        Me.lblParam4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam5
        '
        Me.lblParam5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam5.AutoSize = True
        Me.lblParam5.Location = New System.Drawing.Point(12, 109)
        Me.lblParam5.Name = "lblParam5"
        Me.lblParam5.Size = New System.Drawing.Size(59, 26)
        Me.lblParam5.TabIndex = 4
        Me.lblParam5.Text = "Densitas Medium (ρ)"
        Me.lblParam5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam6
        '
        Me.lblParam6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam6.AutoSize = True
        Me.lblParam6.Location = New System.Drawing.Point(10, 136)
        Me.lblParam6.Name = "lblParam6"
        Me.lblParam6.Size = New System.Drawing.Size(63, 26)
        Me.lblParam6.TabIndex = 5
        Me.lblParam6.Text = "Percepatan Gravitasi (g)"
        Me.lblParam6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam7
        '
        Me.lblParam7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam7.AutoSize = True
        Me.lblParam7.Location = New System.Drawing.Point(7, 169)
        Me.lblParam7.Name = "lblParam7"
        Me.lblParam7.Size = New System.Drawing.Size(69, 13)
        Me.lblParam7.TabIndex = 6
        Me.lblParam7.Text = "Viskositas (η)"
        Me.lblParam7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParam8
        '
        Me.lblParam8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblParam8.AutoSize = True
        Me.lblParam8.Location = New System.Drawing.Point(6, 190)
        Me.lblParam8.Name = "lblParam8"
        Me.lblParam8.Size = New System.Drawing.Size(71, 26)
        Me.lblParam8.TabIndex = 7
        Me.lblParam8.Text = "Konduktivitas Bulk (σ∞)"
        Me.lblParam8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbJE
        '
        Me.tbJE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJE.Location = New System.Drawing.Point(87, 4)
        Me.tbJE.Name = "tbJE"
        Me.tbJE.Size = New System.Drawing.Size(75, 20)
        Me.tbJE.TabIndex = 8
        Me.tbJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbFVP
        '
        Me.tbFVP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFVP.Location = New System.Drawing.Point(87, 31)
        Me.tbFVP.Name = "tbFVP"
        Me.tbFVP.Size = New System.Drawing.Size(75, 20)
        Me.tbFVP.TabIndex = 9
        Me.tbFVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPB
        '
        Me.tbPB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPB.Location = New System.Drawing.Point(87, 58)
        Me.tbPB.Name = "tbPB"
        Me.tbPB.Size = New System.Drawing.Size(75, 20)
        Me.tbPB.TabIndex = 10
        Me.tbPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDP
        '
        Me.tbDP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDP.Location = New System.Drawing.Point(87, 85)
        Me.tbDP.Name = "tbDP"
        Me.tbDP.Size = New System.Drawing.Size(75, 20)
        Me.tbDP.TabIndex = 11
        Me.tbDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDM
        '
        Me.tbDM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDM.Location = New System.Drawing.Point(87, 112)
        Me.tbDM.Name = "tbDM"
        Me.tbDM.Size = New System.Drawing.Size(75, 20)
        Me.tbDM.TabIndex = 12
        Me.tbDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPG
        '
        Me.tbPG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPG.Location = New System.Drawing.Point(87, 139)
        Me.tbPG.Name = "tbPG"
        Me.tbPG.Size = New System.Drawing.Size(75, 20)
        Me.tbPG.TabIndex = 13
        Me.tbPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbV
        '
        Me.tbV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbV.Location = New System.Drawing.Point(87, 166)
        Me.tbV.Name = "tbV"
        Me.tbV.Size = New System.Drawing.Size(75, 20)
        Me.tbV.TabIndex = 14
        Me.tbV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbKB
        '
        Me.tbKB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKB.Location = New System.Drawing.Point(87, 193)
        Me.tbKB.Name = "tbKB"
        Me.tbKB.Size = New System.Drawing.Size(75, 20)
        Me.tbKB.TabIndex = 15
        Me.tbKB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "C/Vm"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(171, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kg/m³"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Kg/m³"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "m/s²"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(175, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "PaS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(175, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "S/m"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbGrafik
        '
        Me.gbGrafik.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGrafik.BackColor = System.Drawing.Color.White
        Me.gbGrafik.Controls.Add(Me.Panel2)
        Me.gbGrafik.Controls.Add(Me.Chart1)
        Me.gbGrafik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrafik.Location = New System.Drawing.Point(239, 6)
        Me.gbGrafik.Name = "gbGrafik"
        Me.gbGrafik.Size = New System.Drawing.Size(456, 438)
        Me.gbGrafik.TabIndex = 44
        Me.gbGrafik.TabStop = False
        Me.gbGrafik.Text = "Grafik"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnSaveData)
        Me.Panel2.Location = New System.Drawing.Point(6, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 42)
        Me.Panel2.TabIndex = 41
        '
        'btnSaveData
        '
        Me.btnSaveData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveData.AutoSize = True
        Me.btnSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveData.Depth = 0
        Me.btnSaveData.Icon = Nothing
        Me.btnSaveData.Location = New System.Drawing.Point(347, 3)
        Me.btnSaveData.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Primary = True
        Me.btnSaveData.Size = New System.Drawing.Size(94, 36)
        Me.btnSaveData.TabIndex = 40
        Me.btnSaveData.Text = "Save Data"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.Title = "Waktu"
        ChartArea1.AxisX.ToolTip = "Waktu"
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.MinorTickMark.Enabled = True
        ChartArea1.AxisY.MinorTickMark.Size = 0.5!
        ChartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisY.Title = "Potensial Zeta (mV)"
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 19)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.Transparent
        Series1.MarkerSize = 8
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Potensial Zeta"
        Series1.ToolTip = "#VAL{G} mV"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(444, 363)
        Me.Chart1.TabIndex = 38
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Title1.Name = "Title1"
        Title1.Text = "Grafik Potensial Zeta"
        Me.Chart1.Titles.Add(Title1)
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.wbHelp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(942, 444)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Help"
        '
        'wbHelp
        '
        Me.wbHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbHelp.Location = New System.Drawing.Point(3, 3)
        Me.wbHelp.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbHelp.Name = "wbHelp"
        Me.wbHelp.Size = New System.Drawing.Size(936, 438)
        Me.wbHelp.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SerialPort1
        '
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.TabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 60)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(960, 30)
        Me.MaterialTabSelector1.TabIndex = 34
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'tsbtnConnectionAlt
        '
        Me.tsbtnConnectionAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsbtnConnectionAlt.AutoSize = True
        Me.tsbtnConnectionAlt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tsbtnConnectionAlt.Depth = 0
        Me.tsbtnConnectionAlt.Icon = Nothing
        Me.tsbtnConnectionAlt.Location = New System.Drawing.Point(678, 561)
        Me.tsbtnConnectionAlt.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tsbtnConnectionAlt.MouseState = MaterialSkin.MouseState.HOVER
        Me.tsbtnConnectionAlt.Name = "tsbtnConnectionAlt"
        Me.tsbtnConnectionAlt.Primary = True
        Me.tsbtnConnectionAlt.Size = New System.Drawing.Size(84, 36)
        Me.tsbtnConnectionAlt.TabIndex = 35
        Me.tsbtnConnectionAlt.Text = "Connect"
        Me.tsbtnConnectionAlt.UseVisualStyleBackColor = True
        '
        'tslblStatusAlt
        '
        Me.tslblStatusAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tslblStatusAlt.AutoSize = True
        Me.tslblStatusAlt.Depth = 0
        Me.tslblStatusAlt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.tslblStatusAlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tslblStatusAlt.Location = New System.Drawing.Point(789, 569)
        Me.tslblStatusAlt.MouseState = MaterialSkin.MouseState.HOVER
        Me.tslblStatusAlt.Name = "tslblStatusAlt"
        Me.tslblStatusAlt.Size = New System.Drawing.Size(145, 19)
        Me.tslblStatusAlt.TabIndex = 36
        Me.tslblStatusAlt.Text = "No board connected"
        '
        'tsbtnRefresh
        '
        Me.tsbtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsbtnRefresh.AutoSize = True
        Me.tsbtnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tsbtnRefresh.Depth = 0
        Me.tsbtnRefresh.Icon = Nothing
        Me.tsbtnRefresh.Location = New System.Drawing.Point(594, 561)
        Me.tsbtnRefresh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tsbtnRefresh.MouseState = MaterialSkin.MouseState.HOVER
        Me.tsbtnRefresh.Name = "tsbtnRefresh"
        Me.tsbtnRefresh.Primary = False
        Me.tsbtnRefresh.Size = New System.Drawing.Size(79, 36)
        Me.tsbtnRefresh.TabIndex = 41
        Me.tsbtnRefresh.Text = "Refresh"
        Me.tsbtnRefresh.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(0, 561)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(960, 1)
        Me.MaterialDivider2.TabIndex = 11
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'ofdParam
        '
        Me.ofdParam.FileName = "OpenFileDialog1"
        '
        'txtClockAlt
        '
        Me.txtClockAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClockAlt.AutoSize = True
        Me.txtClockAlt.BackColor = System.Drawing.Color.Transparent
        Me.txtClockAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockAlt.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtClockAlt.Location = New System.Drawing.Point(879, 30)
        Me.txtClockAlt.Name = "txtClockAlt"
        Me.txtClockAlt.Size = New System.Drawing.Size(83, 20)
        Me.txtClockAlt.TabIndex = 42
        Me.txtClockAlt.Text = "HH:mm:ss"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.txtClockAlt)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.tsbtnRefresh)
        Me.Controls.Add(Me.tslblStatusAlt)
        Me.Controls.Add(Me.tsbtnConnectionAlt)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(960, 600)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "TAZPA Software"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabMonitor.ResumeLayout(False)
        Me.gbParameter.ResumeLayout(False)
        Me.gbParameter.PerformLayout()
        Me.ParamPanel.ResumeLayout(False)
        Me.ParamPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbGrafik.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscbbPort As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscbbBaud As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tabMonitor As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents sfdData As SaveFileDialog
    Friend WithEvents gbParameter As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblParam2 As Label
    Friend WithEvents lblParam1 As Label
    Friend WithEvents lblParam3 As Label
    Friend WithEvents lblParam4 As Label
    Friend WithEvents lblParam5 As Label
    Friend WithEvents lblParam6 As Label
    Friend WithEvents lblParam7 As Label
    Friend WithEvents lblParam8 As Label
    Friend WithEvents tbJE As TextBox
    Friend WithEvents tbFVP As TextBox
    Friend WithEvents tbPB As TextBox
    Friend WithEvents tbDP As TextBox
    Friend WithEvents tbDM As TextBox
    Friend WithEvents tbPG As TextBox
    Friend WithEvents tbV As TextBox
    Friend WithEvents tbKB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gbGrafik As GroupBox
    Friend WithEvents ParamPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNamaSampel As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents TabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents btnSaveData As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnParamLoad As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnParamSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnParamSet As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnParamEdit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents tsbtnConnectionAlt As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents tslblStatusAlt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents tsbtnRefresh As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents sfdParam As SaveFileDialog
    Friend WithEvents ofdParam As OpenFileDialog
    Friend WithEvents txtClockAlt As Label
    Friend WithEvents rbSmooth As RadioButton
    Friend WithEvents rbRaw As RadioButton
    Friend WithEvents wbHelp As WebBrowser
End Class

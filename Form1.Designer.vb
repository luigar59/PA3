<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ActorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ActorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesDataSet = New PE3.MoviesDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ActorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ImdbRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActorDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActorAgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GreatestPerformanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoldenglobeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OscarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StarAverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActorsTableAdapter = New PE3.MoviesDataSetTableAdapters.ActorsTableAdapter()
        Me.TableAdapterManager = New PE3.MoviesDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.gbxGlobe = New System.Windows.Forms.GroupBox()
        Me.rbtnYes2 = New System.Windows.Forms.RadioButton()
        Me.rbtnNo2 = New System.Windows.Forms.RadioButton()
        Me.gbxOscar = New System.Windows.Forms.GroupBox()
        Me.rbtnYes1 = New System.Windows.Forms.RadioButton()
        Me.rbtnNo1 = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblImdb = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.ActorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActorsBindingNavigator.SuspendLayout()
        CType(Me.ActorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxGlobe.SuspendLayout()
        Me.gbxOscar.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActorsBindingNavigator
        '
        Me.ActorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActorsBindingNavigator.BindingSource = Me.ActorsBindingSource
        Me.ActorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActorsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ActorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActorsBindingNavigatorSaveItem})
        Me.ActorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActorsBindingNavigator.Name = "ActorsBindingNavigator"
        Me.ActorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActorsBindingNavigator.Size = New System.Drawing.Size(1586, 33)
        Me.ActorsBindingNavigator.TabIndex = 0
        Me.ActorsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ActorsBindingSource
        '
        Me.ActorsBindingSource.DataMember = "Actors"
        Me.ActorsBindingSource.DataSource = Me.MoviesDataSet
        '
        'MoviesDataSet
        '
        Me.MoviesDataSet.DataSetName = "MoviesDataSet"
        Me.MoviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ActorsBindingNavigatorSaveItem
        '
        Me.ActorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActorsBindingNavigatorSaveItem.Name = "ActorsBindingNavigatorSaveItem"
        Me.ActorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.ActorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ActorsDataGridView
        '
        Me.ActorsDataGridView.AutoGenerateColumns = False
        Me.ActorsDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.ActorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImdbRatingDataGridViewTextBoxColumn, Me.ActorNameDataGridViewTextBoxColumn, Me.ActorDOBDataGridViewTextBoxColumn, Me.ActorAgeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.GreatestPerformanceDataGridViewTextBoxColumn, Me.GoldenglobeDataGridViewTextBoxColumn, Me.OscarDataGridViewTextBoxColumn, Me.StarAverageDataGridViewTextBoxColumn})
        Me.ActorsDataGridView.DataSource = Me.ActorsBindingSource
        Me.ActorsDataGridView.Location = New System.Drawing.Point(12, 451)
        Me.ActorsDataGridView.Name = "ActorsDataGridView"
        Me.ActorsDataGridView.RowHeadersWidth = 62
        Me.ActorsDataGridView.RowTemplate.Height = 28
        Me.ActorsDataGridView.Size = New System.Drawing.Size(1562, 249)
        Me.ActorsDataGridView.TabIndex = 1
        '
        'ImdbRatingDataGridViewTextBoxColumn
        '
        Me.ImdbRatingDataGridViewTextBoxColumn.DataPropertyName = "imdbRating"
        Me.ImdbRatingDataGridViewTextBoxColumn.HeaderText = "imdbRating"
        Me.ImdbRatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ImdbRatingDataGridViewTextBoxColumn.Name = "ImdbRatingDataGridViewTextBoxColumn"
        Me.ImdbRatingDataGridViewTextBoxColumn.Width = 150
        '
        'ActorNameDataGridViewTextBoxColumn
        '
        Me.ActorNameDataGridViewTextBoxColumn.DataPropertyName = "actorName"
        Me.ActorNameDataGridViewTextBoxColumn.HeaderText = "actorName"
        Me.ActorNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ActorNameDataGridViewTextBoxColumn.Name = "ActorNameDataGridViewTextBoxColumn"
        Me.ActorNameDataGridViewTextBoxColumn.Width = 150
        '
        'ActorDOBDataGridViewTextBoxColumn
        '
        Me.ActorDOBDataGridViewTextBoxColumn.DataPropertyName = "actorDOB"
        Me.ActorDOBDataGridViewTextBoxColumn.HeaderText = "actorDOB"
        Me.ActorDOBDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ActorDOBDataGridViewTextBoxColumn.Name = "ActorDOBDataGridViewTextBoxColumn"
        Me.ActorDOBDataGridViewTextBoxColumn.Width = 150
        '
        'ActorAgeDataGridViewTextBoxColumn
        '
        Me.ActorAgeDataGridViewTextBoxColumn.DataPropertyName = "actorAge"
        Me.ActorAgeDataGridViewTextBoxColumn.HeaderText = "actorAge"
        Me.ActorAgeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ActorAgeDataGridViewTextBoxColumn.Name = "ActorAgeDataGridViewTextBoxColumn"
        Me.ActorAgeDataGridViewTextBoxColumn.Width = 150
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 150
        '
        'GreatestPerformanceDataGridViewTextBoxColumn
        '
        Me.GreatestPerformanceDataGridViewTextBoxColumn.DataPropertyName = "greatestPerformance"
        Me.GreatestPerformanceDataGridViewTextBoxColumn.HeaderText = "greatestPerformance"
        Me.GreatestPerformanceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GreatestPerformanceDataGridViewTextBoxColumn.Name = "GreatestPerformanceDataGridViewTextBoxColumn"
        Me.GreatestPerformanceDataGridViewTextBoxColumn.Width = 150
        '
        'GoldenglobeDataGridViewTextBoxColumn
        '
        Me.GoldenglobeDataGridViewTextBoxColumn.DataPropertyName = "goldenglobe"
        Me.GoldenglobeDataGridViewTextBoxColumn.HeaderText = "goldenglobe"
        Me.GoldenglobeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GoldenglobeDataGridViewTextBoxColumn.Name = "GoldenglobeDataGridViewTextBoxColumn"
        Me.GoldenglobeDataGridViewTextBoxColumn.Width = 150
        '
        'OscarDataGridViewTextBoxColumn
        '
        Me.OscarDataGridViewTextBoxColumn.DataPropertyName = "oscar"
        Me.OscarDataGridViewTextBoxColumn.HeaderText = "oscar"
        Me.OscarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OscarDataGridViewTextBoxColumn.Name = "OscarDataGridViewTextBoxColumn"
        Me.OscarDataGridViewTextBoxColumn.Width = 150
        '
        'StarAverageDataGridViewTextBoxColumn
        '
        Me.StarAverageDataGridViewTextBoxColumn.DataPropertyName = "starAverage"
        Me.StarAverageDataGridViewTextBoxColumn.HeaderText = "starAverage"
        Me.StarAverageDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StarAverageDataGridViewTextBoxColumn.Name = "StarAverageDataGridViewTextBoxColumn"
        Me.StarAverageDataGridViewTextBoxColumn.Width = 150
        '
        'ActorsTableAdapter
        '
        Me.ActorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActorsTableAdapter = Me.ActorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PE3.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnData)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.gbxGlobe)
        Me.GroupBox1.Controls.Add(Me.gbxOscar)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblAverage)
        Me.GroupBox1.Controls.Add(Me.lblPerformance)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblNationality)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblImdb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1555, 378)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert Data"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightYellow
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(1281, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 47)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnData
        '
        Me.btnData.BackColor = System.Drawing.Color.LightYellow
        Me.btnData.ForeColor = System.Drawing.Color.Black
        Me.btnData.Location = New System.Drawing.Point(1031, 249)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(130, 47)
        Me.btnData.TabIndex = 31
        Me.btnData.Text = "Refresh Data"
        Me.btnData.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightYellow
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(1335, 172)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 47)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightYellow
        Me.btnNew.ForeColor = System.Drawing.Color.Blue
        Me.btnNew.Location = New System.Drawing.Point(1177, 174)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 45)
        Me.btnNew.TabIndex = 29
        Me.btnNew.Text = "Add New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightYellow
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(1031, 174)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 43)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.LightYellow
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(1334, 110)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(76, 43)
        Me.btn4.TabIndex = 27
        Me.btn4.Text = ">|"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.LightYellow
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(1233, 110)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 43)
        Me.btn3.TabIndex = 26
        Me.btn3.Text = ">"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.LightYellow
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(1132, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 43)
        Me.btn2.TabIndex = 25
        Me.btn2.Text = "<"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.LightYellow
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(1031, 110)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(84, 43)
        Me.btn1.TabIndex = 24
        Me.btn1.Text = "|<"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'gbxGlobe
        '
        Me.gbxGlobe.Controls.Add(Me.rbtnYes2)
        Me.gbxGlobe.Controls.Add(Me.rbtnNo2)
        Me.gbxGlobe.Location = New System.Drawing.Point(591, 280)
        Me.gbxGlobe.Name = "gbxGlobe"
        Me.gbxGlobe.Size = New System.Drawing.Size(360, 68)
        Me.gbxGlobe.TabIndex = 23
        Me.gbxGlobe.TabStop = False
        Me.gbxGlobe.Text = "Won a Golden Globe?"
        '
        'rbtnYes2
        '
        Me.rbtnYes2.AutoSize = True
        Me.rbtnYes2.Location = New System.Drawing.Point(6, 34)
        Me.rbtnYes2.Name = "rbtnYes2"
        Me.rbtnYes2.Size = New System.Drawing.Size(62, 24)
        Me.rbtnYes2.TabIndex = 20
        Me.rbtnYes2.TabStop = True
        Me.rbtnYes2.Text = "Yes"
        Me.rbtnYes2.UseVisualStyleBackColor = True
        '
        'rbtnNo2
        '
        Me.rbtnNo2.AutoSize = True
        Me.rbtnNo2.Location = New System.Drawing.Point(172, 32)
        Me.rbtnNo2.Name = "rbtnNo2"
        Me.rbtnNo2.Size = New System.Drawing.Size(54, 24)
        Me.rbtnNo2.TabIndex = 19
        Me.rbtnNo2.TabStop = True
        Me.rbtnNo2.Text = "No"
        Me.rbtnNo2.UseVisualStyleBackColor = True
        '
        'gbxOscar
        '
        Me.gbxOscar.Controls.Add(Me.rbtnYes1)
        Me.gbxOscar.Controls.Add(Me.rbtnNo1)
        Me.gbxOscar.Location = New System.Drawing.Point(591, 191)
        Me.gbxOscar.Name = "gbxOscar"
        Me.gbxOscar.Size = New System.Drawing.Size(360, 70)
        Me.gbxOscar.TabIndex = 22
        Me.gbxOscar.TabStop = False
        Me.gbxOscar.Text = "Won an Oscar?"
        '
        'rbtnYes1
        '
        Me.rbtnYes1.AutoSize = True
        Me.rbtnYes1.Location = New System.Drawing.Point(6, 34)
        Me.rbtnYes1.Name = "rbtnYes1"
        Me.rbtnYes1.Size = New System.Drawing.Size(62, 24)
        Me.rbtnYes1.TabIndex = 17
        Me.rbtnYes1.TabStop = True
        Me.rbtnYes1.Text = "Yes"
        Me.rbtnYes1.UseVisualStyleBackColor = True
        '
        'rbtnNo1
        '
        Me.rbtnNo1.AutoSize = True
        Me.rbtnNo1.Location = New System.Drawing.Point(172, 34)
        Me.rbtnNo1.Name = "rbtnNo1"
        Me.rbtnNo1.Size = New System.Drawing.Size(54, 24)
        Me.rbtnNo1.TabIndex = 18
        Me.rbtnNo1.TabStop = True
        Me.rbtnNo1.Text = "No"
        Me.rbtnNo1.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(1189, 51)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(224, 26)
        Me.NumericUpDown2.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(763, 118)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 26)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(727, 51)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(224, 26)
        Me.TextBox4.TabIndex = 15
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(221, 322)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(224, 26)
        Me.NumericUpDown1.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(221, 254)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 26)
        Me.TextBox3.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(221, 193)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 26)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 26)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 26)
        Me.TextBox1.TabIndex = 10
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(1030, 57)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(102, 20)
        Me.lblAverage.TabIndex = 9
        Me.lblAverage.Text = "Star Average"
        '
        'lblPerformance
        '
        Me.lblPerformance.AutoSize = True
        Me.lblPerformance.Location = New System.Drawing.Point(587, 125)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(167, 20)
        Me.lblPerformance.TabIndex = 6
        Me.lblPerformance.Text = "Greatest Performance"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(587, 57)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 20)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(88, 329)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age"
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Location = New System.Drawing.Point(88, 261)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(82, 20)
        Me.lblNationality.TabIndex = 3
        Me.lblNationality.Text = "Nationality"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(88, 193)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(86, 20)
        Me.lblDOB.TabIndex = 2
        Me.lblDOB.Text = "Actor DOB"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(88, 125)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Actor Name"
        '
        'lblImdb
        '
        Me.lblImdb.AutoSize = True
        Me.lblImdb.Location = New System.Drawing.Point(88, 57)
        Me.lblImdb.Name = "lblImdb"
        Me.lblImdb.Size = New System.Drawing.Size(99, 20)
        Me.lblImdb.TabIndex = 0
        Me.lblImdb.Text = "IMDb Rating"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1034, 322)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(217, 26)
        Me.TextBox6.TabIndex = 33
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightYellow
        Me.btnSearch.Location = New System.Drawing.Point(1305, 312)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(108, 39)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1586, 709)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ActorsDataGridView)
        Me.Controls.Add(Me.ActorsBindingNavigator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ActorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActorsBindingNavigator.ResumeLayout(False)
        Me.ActorsBindingNavigator.PerformLayout()
        CType(Me.ActorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxGlobe.ResumeLayout(False)
        Me.gbxGlobe.PerformLayout()
        Me.gbxOscar.ResumeLayout(False)
        Me.gbxOscar.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoviesDataSet As MoviesDataSet
    Friend WithEvents ActorsBindingSource As BindingSource
    Friend WithEvents ActorsTableAdapter As MoviesDataSetTableAdapters.ActorsTableAdapter
    Friend WithEvents TableAdapterManager As MoviesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActorsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ActorsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ActorsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ImdbRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActorDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActorHometownDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActorAgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GreatestPerformanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GoldenglobeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OscarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StarAverageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbxGlobe As GroupBox
    Friend WithEvents gbxOscar As GroupBox
    Friend WithEvents rbtnYes1 As RadioButton
    Friend WithEvents rbtnNo1 As RadioButton
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents rbtnYes2 As RadioButton
    Friend WithEvents rbtnNo2 As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblPerformance As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblNationality As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblImdb As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnData As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox6 As TextBox
End Class

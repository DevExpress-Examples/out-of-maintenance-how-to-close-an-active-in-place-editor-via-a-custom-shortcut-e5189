Namespace DXApplication5
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.dateNavigator = New DevExpress.XtraScheduler.DateNavigator()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerStorage
            ' 
            ' 
            ' dateNavigator
            ' 
            Me.dateNavigator.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateNavigator.Location = New System.Drawing.Point(880, 94)
            Me.dateNavigator.Name = "dateNavigator"
            Me.dateNavigator.SchedulerControl = Me.schedulerControl
            Me.dateNavigator.Size = New System.Drawing.Size(220, 606)
            Me.dateNavigator.TabIndex = 1
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 94)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(880, 606)
            Me.schedulerControl.Start = New Date(2014, 3, 7, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.AllDayAreaScrollBarVisible = False
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.AllDayAreaScrollBarVisible = False
            Me.schedulerControl.Views.TimelineView.TimelineScrollBarVisible = False
            Me.schedulerControl.Views.WorkWeekView.AllDayAreaScrollBarVisible = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(12, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(317, 65)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Select an appointment and press F2 to activate the inplace editor." & ControlChars.CrLf & ControlChars.CrLf & "Press CTRL-" & "S to commit changes and close the editor " & ControlChars.CrLf & "or " & ControlChars.CrLf & "press CTRL-Z to cancel changes a" & "nd close the editor."
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1100, 94)
            Me.panelControl1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1100, 700)
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.dateNavigator)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Custom Inplace Editor Shortcuts "
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private dateNavigator As DevExpress.XtraScheduler.DateNavigator
        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl

    End Class
End Namespace

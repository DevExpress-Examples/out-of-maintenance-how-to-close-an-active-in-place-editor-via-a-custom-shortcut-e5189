namespace DXApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerStorage
            // 
            this.schedulerStorage.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.Storage_AppointmentsChanged);
            // 
            // dateNavigator
            // 
            this.dateNavigator.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator.CellPadding = new System.Windows.Forms.Padding(2);
            this.dateNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator.Location = new System.Drawing.Point(880, 94);
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.SchedulerControl = this.schedulerControl;
            this.dateNavigator.Size = new System.Drawing.Size(220, 606);
            this.dateNavigator.TabIndex = 1;
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 94);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(880, 606);
            this.schedulerControl.Start = new System.DateTime(2014, 3, 7, 0, 0, 0, 0);
            this.schedulerControl.Storage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl.Views.TimelineView.TimelineScrollBarVisible = false;
            this.schedulerControl.Views.WorkWeekView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.InplaceEditorShowing += new DevExpress.XtraScheduler.InplaceEditorEventHandler(this.schedulerControl_InplaceEditorShowing);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(317, 65);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Select an appointment and press F2 to activate the inplace editor.\r\n\r\nPress CTRL-" +
    "S to commit changes and close the editor \r\nor \r\npress CTRL-Z to cancel changes a" +
    "nd close the editor.";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 94);
            this.panelControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.dateNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Custom Inplace Editor Shortcuts ";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}

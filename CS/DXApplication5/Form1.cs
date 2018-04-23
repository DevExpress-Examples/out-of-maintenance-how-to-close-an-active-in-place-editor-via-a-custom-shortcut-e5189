using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System.Diagnostics;


namespace DXApplication5
{
    public partial class Form1 : XtraForm
    {   
        public Form1()
        {
            InitializeComponent();

            schedulerControl.Start = System.DateTime.Now;
            schedulerControl.GroupType = SchedulerGroupType.Resource;

            InitResources();
            InitAppointments();
        }

        BindingList<CustomResource> resources = new BindingList<CustomResource>();
        BindingList<CustomAppointment> eventList = new BindingList<CustomAppointment>();
        private void InitResources()
        {
            ResourceMappingInfo mappings = this.schedulerStorage.Resources.Mappings;
            mappings.Caption = "Name";
            mappings.Id = "ResourceID";
            
            DataHelper.FillResources(resources, 5);
            this.schedulerStorage.Resources.DataSource = resources;
        }
        void InitAppointments()
        {
            AppointmentMappingInfo mappings = this.schedulerStorage.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            
            schedulerStorage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Priority", "Priority"));
            DataHelper.GenerateEvents(eventList, schedulerStorage.Resources.Count, resources);
            this.schedulerStorage.Appointments.DataSource = eventList;
            
        }
        void Storage_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            AppointmentBaseCollection appointments = e.Objects as AppointmentBaseCollection;
            foreach (Appointment appointment in appointments)
            {
                Debug.WriteLine(appointment.Subject);
            }
        }
        #region #InplaceEditorShowing
        private void schedulerControl_InplaceEditorShowing(object sender, DevExpress.XtraScheduler.InplaceEditorEventArgs e)
        {
            e.InplaceEditorEx = new MyInplaceEditor(e.SchedulerInplaceEditorEventArgs);
        }
        #endregion #InplaceEditorShowing
    }
}
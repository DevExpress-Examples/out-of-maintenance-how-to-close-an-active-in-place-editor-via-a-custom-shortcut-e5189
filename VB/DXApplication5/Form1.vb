Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports System.Diagnostics


Namespace DXApplication5
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            schedulerControl.Start = Date.Now
            schedulerControl.GroupType = SchedulerGroupType.Resource

            InitResources()
            InitAppointments()
        End Sub

        Private resources As New BindingList(Of CustomResource)()
        Private eventList As New BindingList(Of CustomAppointment)()
        Private Sub InitResources()
            Dim mappings As ResourceMappingInfo = Me.schedulerStorage.Resources.Mappings
            mappings.Caption = "Name"
            mappings.Id = "ResourceID"

            DataHelper.FillResources(resources, 5)
            Me.schedulerStorage.Resources.DataSource = resources
        End Sub
        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = Me.schedulerStorage.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"


            schedulerStorage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Priority", "Priority"))
            DataHelper.GenerateEvents(eventList, schedulerStorage.Resources.Count, resources)
            Me.schedulerStorage.Appointments.DataSource = eventList

        End Sub
        Private Sub Storage_AppointmentsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsChanged
            Dim appointments As AppointmentBaseCollection = TryCast(e.Objects, AppointmentBaseCollection)
            For Each appointment As Appointment In appointments
                Debug.WriteLine(appointment.Subject)
            Next appointment
        End Sub
        #Region "#InplaceEditorShowing"
        Private Sub schedulerControl_InplaceEditorShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.InplaceEditorEventArgs) Handles schedulerControl.InplaceEditorShowing
            e.InplaceEditorEx = New MyInplaceEditor(e.SchedulerInplaceEditorEventArgs, e.Appointment)
        End Sub
        #End Region ' #InplaceEditorShowing
    End Class
End Namespace
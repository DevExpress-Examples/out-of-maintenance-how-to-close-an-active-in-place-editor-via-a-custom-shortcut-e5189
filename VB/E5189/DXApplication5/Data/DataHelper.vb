Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Namespace DXApplication5
    Public Class DataHelper
        Private Shared rnd As New Random()

        Private Shared Users() As String = { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett", "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" }

        Public Shared Sub FillResources(ByVal resources As BindingList(Of CustomResource), ByVal count As Integer)

            Dim cnt As Integer = Math.Min(count, Users.Length)
            For i As Integer = 1 To cnt
                Dim resource As New CustomResource()
                resource.Name = Users(i - 1)
                resource.ResourceID = i
                resources.Add(resource)
            Next i
        End Sub

        Public Shared Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment), ByVal count As Integer, ByVal resources As BindingList(Of CustomResource))

            For i As Integer = 0 To count - 1
                Dim resource As CustomResource = resources(i)
                Dim subjPrefix As String = resource.Name & "'s "
                eventList.Add(CreateEvent(subjPrefix & "meeting", resource.ResourceID, 2, 5, Priority.High))
                eventList.Add(CreateEvent(subjPrefix & "travel", resource.ResourceID, 3, 6, Priority.Low))
                eventList.Add(CreateEvent(subjPrefix & "phone call", resource.ResourceID, 0, 10, Priority.Medium))
            Next i
        End Sub

        Private Shared Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer, ByVal priority As Priority) As CustomAppointment
            Dim apt As New CustomAppointment()
            apt.Subject = subject
            apt.OwnerId = resourceId
            apt.Priority = priority
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4)))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function
    End Class
End Namespace

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace DXApplication5
{
    public class DataHelper
    {
        private static Random rnd = new Random();

        private static string[] Users = new string[] { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett",
                                                            "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" };

        public static void FillResources( BindingList<CustomResource> resources, int count)
        {
           
            int cnt = Math.Min(count, Users.Length);
            for (int i = 1; i <= cnt; i++)
            {
                CustomResource resource = new CustomResource();
                resource.Name = Users[i - 1];
                resource.ResourceID = i;
                resources.Add(resource);
            }
        }

        public static void GenerateEvents(BindingList<CustomAppointment> eventList, int count, BindingList<CustomResource> resources)
        {

            for (int i = 0; i < count; i++)
            {
                CustomResource resource = resources[i];
                string subjPrefix = resource.Name + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", resource.ResourceID, 2, 5, Priority.High));
                eventList.Add(CreateEvent(subjPrefix + "travel", resource.ResourceID, 3, 6, Priority.Low));
                eventList.Add(CreateEvent(subjPrefix + "phone call", resource.ResourceID, 0, 10, Priority.Medium));
            }
        }

        private static CustomAppointment CreateEvent(string subject, object resourceId, int status, int label, Priority priority)
        {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            apt.Priority = priority;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
    }
}

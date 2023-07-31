using calendarT.Models;
using Google.Apis.Calendar.v3;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarT
{
    public class GetEventsGoogle
    {
        public EventModel getEventGoogleCalendar()
        {
            string jsonFile = "cosmic-stacker-393910-30e34a3dff89.json";
            string calendarId = @"7eb1942465e026e68a53d42358f4531e3d0ceabf6db49846d979142e1498ad7a@group.calendar.google.com";

            string[] Scopes = { CalendarService.Scope.Calendar };

            return new EventModel
            {
                Name = "lala",
                StartDate = new DateTime(),
                EndDate = new DateTime()
            };
        }
    }
}

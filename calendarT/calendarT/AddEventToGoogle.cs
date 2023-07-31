using calendarT.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Soneta.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace calendarT
{
    public class AddEventToGoogle
    {
        Session session { get; set; }

        public AddEventToGoogle(Session session)
            => this.session = session;
        public EventModel AddEventToCalendar(EventModel eventmodel)
        {
            string jsonFile = "cosmic-stacker-393910-30e34a3dff89.json";
            string calendarId = @"7eb1942465e026e68a53d42358f4531e3d0ceabf6db49846d979142e1498ad7a@group.calendar.google.com";

            string[] Scopes = { CalendarService.Scope.CalendarEvents };

            return eventmodel;
        }
    }
}

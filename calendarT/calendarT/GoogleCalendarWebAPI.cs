using calendarT;
using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using calendarT.Interfaces;
using calendarT.Models;
using System.Net;
using Soneta.Core;
using Soneta.Types;
using Soneta.Types.DynamicApi;

[assembly: Service(typeof(IGoogleCalendarAPI), typeof(GoogleCalendarWebAPI), ServiceScope.Session)]
[assembly: DynamicApiController(typeof(IGoogleCalendarAPI), typeof(GoogleCalendarWebAPI))]

namespace calendarT
{
    public class GoogleCalendarWebAPI : IGoogleCalendarAPI
    {
        GetEventInfo GetEvent;

        public GoogleCalendarWebAPI(Session session)
        {
            GetEvent = new GetEventInfo(session);
        }

        public EventModel GetEventsInfo(string _kontrahent)
        {
            var zadania = GetEvent.GetEvents(_kontrahent);
            if (zadania != null)
            {
                if (("" + zadania) == _kontrahent)
                {
                    return new EventModel
                    {
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now
                    };
                }
            }

            return new EventModel
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
        }

    }
}

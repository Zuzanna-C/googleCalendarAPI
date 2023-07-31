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
using Soneta.Zadania;
using static Soneta.Towary.CenyRabatyProgowe;

[assembly: Service(typeof(IGoogleCalendarAPI), typeof(GoogleCalendarWebAPI), ServiceScope.Session)]
[assembly: DynamicApiController(typeof(IGoogleCalendarAPI), typeof(GoogleCalendarWebAPI))]

namespace calendarT
{
    public class GoogleCalendarWebAPI : IGoogleCalendarAPI
    {
        GetEventInfo GetEvent;
        AddEventToGoogle AddEventGoogle;
        GetEventsGoogle GetEventGoogle;

        List<EventModel> zadaniaList = new List<EventModel>();

        public GoogleCalendarWebAPI(Session session)
        {
            GetEvent = new GetEventInfo(session);
            AddEventGoogle = new AddEventToGoogle(session);
            GetEventGoogle = new GetEventsGoogle();
        }

        public List<EventModel> GetEventsInfo(string _kontrahent)
        {
            var zadania = GetEvent.GetEvents(_kontrahent);
            

            if (zadania != null)
            {              
                foreach (Zadanie zadanie in zadania)
                {
                    zadaniaList.Add(
                        new EventModel
                        {
                            Name = zadanie.Nazwa,
                            StartDate = zadanie.Start,
                            EndDate = zadanie.End
                        });                       
                }
            }
            else
            {
                return null;
            }
            return zadaniaList;
        }

        public EventModel AddEventToCalendar()
        {
            GetEventsInfo("abc");
            var test = AddEventGoogle.AddEventToCalendar(zadaniaList[0]);
            return test;
        }

        public EventModel GetEventsGoogle()
        {
            return GetEventGoogle.getEventGoogleCalendar();
        }
    }
}

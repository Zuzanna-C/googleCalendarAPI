using System;
using System.Collections.Generic;
using System.Text;
using calendarT.Models;
using Soneta.Types.DynamicApi;

namespace calendarT.Interfaces
{
    public interface IGoogleCalendarAPI
    {
        [DynamicApiMethod(HttpMethods.GET, nameof(GetEventsInfo), MediaType = "application/json")]
        List<EventModel> GetEventsInfo(string _kontrahent);

        [DynamicApiMethod(HttpMethods.POST, nameof(AddEventToCalendar), MediaType = "application/json")]
        EventModel AddEventToCalendar();

        [DynamicApiMethod(HttpMethods.GET, nameof(GetEventsGoogle), MediaType = "application/json")]
        EventModel GetEventsGoogle();
    }
}

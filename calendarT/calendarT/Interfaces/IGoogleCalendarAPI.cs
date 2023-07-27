using System;
using System.Collections.Generic;
using System.Text;
using calendarT.Models;
using Soneta.Types.DynamicApi;

namespace calendarT.Interfaces
{
    public class IGoogleCalendarAPI
    {
        [DynamicApiMethod(HttpMethods.GET, nameof(GetEventsInfo), MediaType = "application/json")]
        EventModel GetEventsInfo(string _kontrahent);
    }
}

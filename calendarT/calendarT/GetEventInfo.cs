using calendarT.Models;
using Soneta.Business;
using Soneta.CRM;
using Soneta.Zadania;

namespace calendarT
{
    public class GetEventInfo
    {
        Session session { get; set; }

        public GetEventInfo(Session session)
            => this.session = session;
      
        public Zadanie[] GetEvents(string kodkontrahenta)
        {
            Zadanie[] zadania = ZadaniaModule.GetInstance(session).Zadania.WgKontrahent[CRMModule.GetInstance(session).Kontrahenci.WgKodu[kodkontrahenta]].ToArray();
            return zadania;
        }
          
    };   
}

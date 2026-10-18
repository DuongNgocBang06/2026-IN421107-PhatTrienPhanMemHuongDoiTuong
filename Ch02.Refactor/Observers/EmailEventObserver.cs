using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Observers
{
    public class EmailEventObserver : IEventObserver
    {
        public void OnEventCreated(Event ev, Club club, List<Member> members)
        {
            foreach (var m in members.Where(x => x.ClubId == club.Id))
            {
                Console.WriteLine($"Email to {m.Email}: new event '{ev.Title}' at {club.Name}");
            }
        }
    }
}

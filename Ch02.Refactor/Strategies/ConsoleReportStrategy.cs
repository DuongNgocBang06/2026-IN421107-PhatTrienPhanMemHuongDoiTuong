using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Strategies
{
    internal class ConsoleReportStrategy : IReportStrategy
    {
        public void Generate(List<Club> clubs, List<Member> members)
        {
            foreach (var club in clubs)
            {
                var memberCount = members.Count(m => m.ClubId == club.Id);
                Console.WriteLine($"Club: {club.Name} | Members: {memberCount}");
            }
        }
    }
}

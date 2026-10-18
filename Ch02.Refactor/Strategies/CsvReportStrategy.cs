using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Strategies
{
    public class CsvReportStrategy : IReportStrategy
    {
        public void Generate(List<Club> clubs, List<Member> members)
        {
            Console.WriteLine("ClubName,MemberCount");
            foreach (var club in clubs)
            {
                var memberCount = members.Count(m => m.ClubId == club.Id);
                Console.WriteLine($"{club.Name},{memberCount}");
            }
        }
    }
}

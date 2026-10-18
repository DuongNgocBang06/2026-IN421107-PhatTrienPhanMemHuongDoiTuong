using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Strategies
{
    internal interface IReportStrategy
    {
        void Generate(List<Club> clubs, List<Member> members);
    }
}

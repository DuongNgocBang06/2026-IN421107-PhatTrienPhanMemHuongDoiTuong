using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Repositories
{
    public interface IClubRepository 
    {
        void AddClub(Club club);
        List<Club> GetAllClubs();
        Club GetClubById(Guid id);
    }
}

using EduHub.Ch02.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Ch02.Repositories
{
    public class LoggingClubRepository : IClubRepository
    {
        private readonly IClubRepository _innerRepo;
        private readonly string _logFilePath = "club-log.txt";

        public LoggingClubRepository(IClubRepository innerRepo)
        {
            _innerRepo = innerRepo;
        }

        public void AddClub(Club club)
        {
            _innerRepo.AddClub(club);
            File.AppendAllText(_logFilePath, $"[{DateTime.Now}] Club created: {club.Name}\n");
        }

        public List<Club> GetAllClubs()
        {
            return _innerRepo.GetAllClubs();
        }

        public Club GetClubById(Guid id)
        {
            return _innerRepo.GetClubById(id);
        }
    }
}

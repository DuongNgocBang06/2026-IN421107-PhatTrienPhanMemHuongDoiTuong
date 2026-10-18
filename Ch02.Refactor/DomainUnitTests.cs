using System;
using Xunit;
using EduHub.Ch02.Domain;

namespace EduHub.Ch02.Tests
{
    public class DomainUnitTests
    {
        [Fact]
        public void CreateClub_WithValidData_ShouldSucceed()
        {
            // Arrange
            var clubName = "Coding Club";
            var clubDescription = "A club for programming enthusiasts.";

            // Act
            var club = new Club { Id = Guid.NewGuid(), Name = clubName, Description = clubDescription };

            // Assert
            Assert.NotNull(club);
            Assert.Equal(clubName, club.Name);
            Assert.Equal(clubDescription, club.Description);
        }

        [Fact]
        public void Member_Initialization_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var memberId = Guid.NewGuid();
            var clubId = Guid.NewGuid();
            var name = "Nguyen Van A";
            var email = "a@gmail.com";

            // Act
            var member = new Member
            {
                Id = memberId,
                Name = name,
                Email = email,
                ClubId = clubId
            };

            // Assert
            Assert.Equal(memberId, member.Id);
            Assert.Equal(name, member.Name);
            Assert.Equal(email, member.Email);
            Assert.Equal(clubId, member.ClubId);
        }

        [Fact]
        public void Event_Initialization_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var eventId = Guid.NewGuid();
            var clubId = Guid.NewGuid();
            var title = "Workshop C#";
            var date = DateTime.Now.AddDays(5);

            // Act
            var ev = new Event
            {
                Id = eventId,
                ClubId = clubId,
                Title = title,
                Date = date
            };

            // Assert
            Assert.Equal(eventId, ev.Id);
            Assert.Equal(clubId, ev.ClubId);
            Assert.Equal(title, ev.Title);
            Assert.Equal(date, ev.Date);
        }

        [Fact]
        public void Club_Name_CanBeUpdated()
        {
            // Arrange - Thêm Description vào vì là thuộc tính required
            var club = new Club { Name = "Old Name", Description = "Test Description" };

            // Act
            club.Name = "New Name";

            // Assert
            Assert.Equal("New Name", club.Name);
        }

        [Fact]
        public void Member_Email_CanBeUpdated()
        {
            // Arrange - Thêm Name và ClubId vì là thuộc tính required trong Member
            var member = new Member { Name = "Test Member", ClubId = Guid.NewGuid(), Email = "old@gmail.com" };

            // Act
            member.Email = "new@gmail.com";

            // Assert
            Assert.Equal("new@gmail.com", member.Email);
        }

        [Fact]
        public void Event_Title_CanBeUpdated()
        {
            // Arrange
            var ev = new Event { Title = "Old Title" };

            // Act
            ev.Title = "New Title";

            // Assert
            Assert.Equal("New Title", ev.Title);
        }
    }
}
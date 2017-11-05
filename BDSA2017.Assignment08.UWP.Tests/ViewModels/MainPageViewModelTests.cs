using BDSA2017.Assignment08.UWP.ViewModels;
using BDSA2017.Assignment08.UWP;
using Xunit;
using Moq;

using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using BDSA2017.Assignment08.Models;

namespace BDSA2017.Assignment08.UWP.Tests.ViewModels
{
    public class MainPageViewModelTests
    {
        
        [Fact]
        public void RepositoryReturnsSameItemsReturnsTrue()
        {
            var dbItems = new List<TrackDTO>()
            {
                new TrackDTO(){Id = 184, Name ="Hello", LengthInMeters = 100, MaxCars = 50},
                new TrackDTO(){Id = 185, Name = "This", LengthInMeters = 150, MaxCars = 52},
                new TrackDTO(){Id = 186, Name = "Is", LengthInMeters = 200, MaxCars =512},
                new TrackDTO(){Id = 187, Name = "A", LengthInMeters = 250, MaxCars = 5214},
                new TrackDTO(){Id = 188, Name = "Test", LengthInMeters =300, MaxCars = 121}
            };

            var query = (from t in dbItems.AsQueryable()
                        select new TrackViewModel
                        {
                            Id = t.Id,
                            name = t.Name,
                            LengthInMeters = t.LengthInMeters,
                            MaxCars = t.MaxCars
                        }).ToList();

            var mockRepository = new Mock<ITrackRepository>();
            mockRepository.Setup(a => a.Read()).Returns(dbItems.AsQueryable);
            var view = new MainPageViewModel(mockRepository.Object);
            Assert.Equal(new ObservableCollection<TrackViewModel>(query), view.Tracks);

        }
        [Fact]
        public void RepositoryReturnNotSameItemsReturnsFalls()
        {
            var dbItems = new List<TrackDTO>()
            {
                new TrackDTO(){Id = 184, Name ="Hello", LengthInMeters = 100, MaxCars = 50},
                new TrackDTO(){Id = 185, Name = "This", LengthInMeters = 150, MaxCars = 52},
                new TrackDTO(){Id = 186, Name = "Is", LengthInMeters = 200, MaxCars =512},
                new TrackDTO(){Id = 187, Name = "A", LengthInMeters = 250, MaxCars = 5214},
                new TrackDTO(){Id = 188, Name = "Test", LengthInMeters =300, MaxCars = 121}
            };

            var list = new List<TrackViewModel>() { new TrackViewModel() { Id = 200, name = "Falls" } };

            var mockRepository = new Mock<ITrackRepository>();
            mockRepository.Setup(a => a.Read()).Returns(dbItems.AsQueryable);
            var view = new MainPageViewModel(mockRepository.Object);
            Assert.NotEqual(new ObservableCollection<TrackViewModel>(list), view.Tracks);

        }
        
        
    }
}

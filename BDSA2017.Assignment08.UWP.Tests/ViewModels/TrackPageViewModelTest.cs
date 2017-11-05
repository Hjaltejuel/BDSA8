using BDSA2017.Assignment08.Models;
using BDSA2017.Assignment08.UWP.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BDSA2017.Assignment08.UWP.Tests.ViewModels
{
    public class TrackPageViewModelTest
    {
        [Fact]
         public void TestThatThereIsAlways1()
        {
            TrackDTO dto = new TrackDTO() { Id = 42 };
            var mock = new Mock<ITrackRepository>();
            mock.Setup(a => a.Find(42)).ReturnsAsync(dto);
            var view = new TrackPageViewModel(mock.Object);
            view.EmptyAndAdd(42);
            Assert.True(view.Track.Count() == 1);
        }
        [Fact]
        public void TheElementGetsAdded()
        {
            TrackDTO dto = new TrackDTO() { Id = 42 };
            var mock = new Mock<ITrackRepository>();
            mock.Setup(a => a.Find(42)).ReturnsAsync(dto);
            var view = new TrackPageViewModel(mock.Object);
            view.EmptyAndAdd(42);
            Assert.True(view.Track.First().Id==42);
        }

    }
}

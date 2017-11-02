using BDSA2017.Assignment08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSA2017.Assignment08.UWP.ViewModels
{
    public class TrackPageViewModel
    {
        private readonly ITrackRepository _repository;

        public TrackPageViewModel(ITrackRepository repository)
        {
            _repository = repository;
        }

        public async void Initialize(int value)
        {
            await Task.CompletedTask;

            throw new NotImplementedException();
        }
    }
}

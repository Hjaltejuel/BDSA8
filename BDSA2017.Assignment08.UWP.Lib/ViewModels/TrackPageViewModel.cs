using BDSA2017.Assignment08.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSA2017.Assignment08.UWP.ViewModels
{
    public class TrackPageViewModel : BaseViewModel
    {
        private readonly ITrackRepository _repository;

        public ObservableCollection<TrackViewModel> Track { get; set; }

        public TrackPageViewModel(ITrackRepository repository)
        {
            _repository = repository;
            Track = new ObservableCollection<TrackViewModel>();
            
        }

        public void EmptyAndAdd(TrackViewModel model)
        {
            foreach(TrackViewModel view in Track.ToList())
            {
                Track.Remove(view);
            }
            Track.Add(model);
        }




    }
}

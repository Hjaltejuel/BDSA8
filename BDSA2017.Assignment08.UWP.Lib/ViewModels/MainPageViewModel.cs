using BDSA2017.Assignment08.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;

namespace BDSA2017.Assignment08.UWP.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ITrackRepository _repository;

        public ObservableCollection<TrackViewModel> Tracks { get; set; }

        public MainPageViewModel(ITrackRepository repository)
        {
            _repository = repository;

            Initialize();
        }

        private async void Initialize()
        {
            var query = from t in _repository.Read()
                         select new TrackViewModel
                         {
                             Id = t.Id
                         };

            var tracks = await query.ToListAsync();

            Tracks = new ObservableCollection<TrackViewModel>(query);
        }
    }
}

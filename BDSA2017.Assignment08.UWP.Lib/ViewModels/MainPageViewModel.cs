using BDSA2017.Assignment08.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace BDSA2017.Assignment08.UWP.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ITrackRepository _repository;

        public ICommand GoToTrackPage { get; set; }


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
                             Id = t.Id,
                             name = t.Name,
                             LengthInMeters = t.LengthInMeters,
                             MaxCars = t.MaxCars
                         };
            await _repository.Create(new TrackCreateDTO() { Name = "Hello", LengthInMeters = 100, MaxCars = 50 });
            await _repository.Create(new TrackCreateDTO() { Name = "This", LengthInMeters = 150, MaxCars = 52 });
            await _repository.Create(new TrackCreateDTO() { Name = "Is", LengthInMeters = 200, MaxCars = 512 });
            await _repository.Create(new TrackCreateDTO() { Name = "A", LengthInMeters = 250, MaxCars = 5214 });
            await _repository.Create(new TrackCreateDTO() { Name = "Test", LengthInMeters = 300, MaxCars = 121 });
            var tracks = await query.ToListAsync();
    
            /*
            var list = new List<TrackViewModel>();
            for(int i = 0; i<10; i++)
            {
                TrackViewModel TVM = new TrackViewModel()
                {
                    Id = i,
                    name = "Track " + i,
                    BestLapInTicks = i,
                    MaxCars = i,
                    LengthInMeters = 100 * i
                };
                list.Add(TVM);
            }
    */
            Tracks = new ObservableCollection<TrackViewModel>(tracks);

            
        }
    }
}

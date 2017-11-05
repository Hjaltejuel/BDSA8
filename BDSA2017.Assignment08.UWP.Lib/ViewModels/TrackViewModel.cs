using System.Windows.Input;

namespace BDSA2017.Assignment08.UWP.ViewModels
{
    public class TrackViewModel : BaseViewModel
    {

        public int _id;

        public int Id
        {
            get => _id;
            set { if (_id != value) { _id = value; OnPropertyChanged(); } }
        }

        public string _name;

        public string name
        {
            get => _name;
            set { if (_name != value) { _name = value; OnPropertyChanged(); } }
        }
        public double _LengthInMeters;
        public double LengthInMeters
        {
            get => _LengthInMeters;
            set { if (_LengthInMeters != value) { _LengthInMeters = value; OnPropertyChanged(); } }
        }

        public long? _BestLapInTicks
        {
            get => _BestLapInTicks;
            set { if (_BestLapInTicks != value) { _BestLapInTicks = value; OnPropertyChanged(); } }
        }
        public long? BestLapInTicks { get; set; }

        public int _MaxCars;
        public int MaxCars
        {
            get => _MaxCars;
            set { if (_MaxCars != value) { _MaxCars = value; OnPropertyChanged(); } }
        }
    }
}
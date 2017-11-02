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
    }
}
using System;

namespace Ofen_BS
{
    public class MainViewModel : ViewModelBase
    {
        private string _backGroundColourRoehre;

        public string BackGroundColourRoehre
        {
            get
            {
                return _backGroundColourRoehre;
            }
            set
            {
                SetProperty<string>(ref _backGroundColourRoehre, value, nameof(BackGroundColourRoehre));
            }
        }

        private DelegateCommand _startButtonCommand;

        public DelegateCommand StartButtonCommand
        {
            get
            {
                return _startButtonCommand ??= new DelegateCommand(StartButton);
            }
        }

        //private DelegateCommand _mikroWellenBilderCommand;

        //public DelegateCommand MikroWellenBilderCommand
        //{
        //    get
        //    {
        //        return _mikroWellenBilderCommand ??= new DelegateCommand(MikroWellenBilder);
        //    }
        //}

        public MainViewModel()
        {
            _backGroundColourRoehre = "green";
        }

        private void StartButton(object commandParameter)
        {
            var bla = 0;
        }

        //private string MikroWellenBilder(object commandParameter)
        //{
        //    var result = 0;
        //    return "";
        //}
    }
}

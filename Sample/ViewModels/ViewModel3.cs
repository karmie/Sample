using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sample
{
    class ViewModel3 : Update
    {
        public ObservableCollection<Database> color { get; set; }

        public ICommand changeColor { get; set; }

        public ViewModel3()
        {
            color = new ObservableCollection<Database>
            {
                new Database { Color="Red" },
                new Database { Color="Blue" },
                new Database { Color="Yellow" },
                new Database { Color="Black" },
            };

            FontColor = "Blue";

            changeColor = new RelayCommand(changecolor, CanExecute);

        }

        string _FontColor;

        public string FontColor
        {
            get
            {
                return _FontColor;
            }
            set
            {
                if (_FontColor != value)
                {
                    _FontColor = value;


                }
            }
        }


        public ICommand ChangeColor
        {
            get
            {
                return changeColor;
            }
            set
            {
                changeColor = value;
            }
        }

        public void changecolor(object SelectedItem)
        {

            var C = SelectedItem as Database;
            FontColor = C.Color;

            RaisePropertyChanged("FontColor");


        }

        bool CanExecute(object parameter)
        {
            return true;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Threading;
using Models;
using Tool;
using Sample;
using System.Windows;

namespace ViewModels
{
    class ViewModel3 : Basic
    {
        public ObservableCollection<Database> color { get; set; }

        public ICommand changeColor { get; set; }
        public RelayCommand SecondWindows { get; set; }


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
            Value = 0;
            


            changeColor = new RelayCommand(changecolor, CanExecute);
            SecondWindows = new RelayCommand(NextWindow);

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
                    RaisePropertyChanged("FontColor");
                    Mediator.Instance.NotifyColleagues(ViewModelMessages.MessageType1 , value);
                    Mediator.Instance.NotifyColleagues(ViewModelMessages.MessageType2 , value);
                }
            }
        }

        public int _Value;

        public int Value
        {
            get { return this._Value; }
            set
            {
                this._Value = value;
                RaisePropertyChanged("Value");
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
            //Set the value of process.
            SetProgress();

            //Change the color which color I choose. 
            var C = SelectedItem as Database;
            FontColor = C.Color;

            Value = 0;

        }

        bool CanExecute(object parameter)
        {
            return true;
        }

        private void SetProgress()
        {
            int i = 0;

            while (i <= 100)
            {
                Value = i;

                Thread.Sleep(50);
                i += 10;
            }
        }

        void NextWindow(object parameter)
        {
            var win = new SecondWindow();
            win.Show();
            Application.Current.MainWindow.Close();
            //CloseWindow();
        }



    }
}

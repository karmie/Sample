using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;

namespace ViewModels
{
    class ViewModel1 : Basic
    {
        public ViewModel1()
        {
            
            Mediator.Instance.Register(ViewModelMessages.MessageType2, param => { BorderColor = param as string; });
            
        }

        string _BorderColor;

        public string BorderColor
        {
            get
            {
                return _BorderColor;
            }
            set
            {
                if (_BorderColor != value)
                {
                    _BorderColor = value;
                    RaisePropertyChanged("BorderColor");
                }
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class ViewModel1 : Update
    {
        public ViewModel1()
        {
            //BorderColor = "Red";
            Mediator.Instance.Register(ViewModelMessages.MessageType1, param => { BorderColor = param as string; });
            
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

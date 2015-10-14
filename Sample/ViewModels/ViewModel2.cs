using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;

namespace ViewModels
{
    class ViewModel2 : Update
    {
         public ViewModel2()
        {
            //BorderColor = "Red";
            Mediator.Instance.Register(ViewModelMessages.MessageType1, param => { bColor = param as string; });
            
        }

        string _bColor;

        public string bColor
        {
            get
            {
                return _bColor;
            }
            set
            {
                if (_bColor != value)
                {
                    _bColor = value;
                    RaisePropertyChanged("bColor");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class ViewModel3
    {
        public ObservableCollection<Database> color { get; set; }

        public ViewModel3()
        {
            color = new ObservableCollection<Database>
            {
                new Database { Color="Red" },
                new Database { Color="Blue" },
                new Database { Color="Yellow" },
                new Database { Color="Black" },
            };

        }


    }
}

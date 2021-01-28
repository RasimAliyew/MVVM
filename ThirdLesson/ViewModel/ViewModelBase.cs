using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Set<T>(ref T prop,T value,[CallerMemberName] string name ="")
        {
            prop = value;
            PropertyChanged.Invoke(this,new PropertyChangedEventArgs(name) );
        }
    }
}

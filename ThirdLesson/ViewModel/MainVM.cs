

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ThirdLesson.Command;

namespace ThirdLesson.ViewModel
{
    class MainVM : ViewModelBase
    {
          private ViewModelBase currentViewModel;
         
          public Commands FirstButton { get; set; }
          public Commands SecondButton { get; set; }
         
          public ViewModelBase CurrentViewModel { get => currentViewModel; set { Set(ref currentViewModel, value); } }
         
         public MainVM()
         {
              FirstButton = new Commands(x =>First());
              SecondButton = new Commands(x => Second());
         }
         public void First()   
         {
             CurrentViewModel = new FirstVM();
         }
         public void Second()
         {
             CurrentViewModel = new SecondVM();
         }
    }



}
    


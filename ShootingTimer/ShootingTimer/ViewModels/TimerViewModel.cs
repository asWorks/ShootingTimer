using System;
using System.Collections.Generic;
using System.Text;

namespace ShootingTimer.ViewModels
{
   public class TimerViewModel:BaseViewModel
    {



        public TimerViewModel()
        {
            Title = "Timerpage";
            Ooops = "Und auch das funktioniert";
        }



        private string _Ooops;
        public string Ooops
        {
            get { return _Ooops; }
            set { SetProperty(ref this._Ooops, value); }

        }


       
    }
}

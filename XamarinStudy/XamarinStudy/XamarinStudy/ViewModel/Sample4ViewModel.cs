using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinStudy.View;

namespace XamarinStudy.ViewModel
{
    public class Sample4ViewModel : INotifyPropertyChanged
    {
        //public String Text { get; set; }

        private String _text;
        public String Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;

                //RaisePropertyChanged("Text");

                //if (PropertyChanged != null)
                //{
                //    PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                //}
            }
        }
        // Text = "asdf";

        public ICommand SetTextCommand { get; set; }

        public Sample4ViewModel()
        {
            Text = "";
            SetTextCommand = new Command(SetText);
        }

        private void SetText(object obj)
        {
            Text = "Text Notified!!";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string pname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pname));
            }
        }


        //private void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Configurations;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BasarClient
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ApplicationConfigurations _ApplicationConfigurations = new ApplicationConfigurations();
        private delegate void SetTextDelegate(string text);

        public string ServerIpAddresse
        {
            get
            {
                return _ApplicationConfigurations.ServerIpAddresse;
            }
            set
            {
                if(value != _ApplicationConfigurations.ServerIpAddresse)
                {
                    _ApplicationConfigurations.ServerIpAddresse = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("ServerIpAddresse");
                }
            }
        }

        public string ServerPort
        {
            get
            {
                return _ApplicationConfigurations.ServerPort;
            }
            set
            {
                if (value != _ApplicationConfigurations.ServerPort)
                {
                    _ApplicationConfigurations.ServerPort = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("ServerPort");
                }
            }
        }

        public string SellerClientPort
        {
            get
            {
                return _ApplicationConfigurations.SellerClientPort;
            }
            set
            {
                if (value != _ApplicationConfigurations.SellerClientPort)
                {
                    _ApplicationConfigurations.SellerClientPort = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("SellerClientPort");
                }
            }
        }

        public string BasarName
        {
            get
            {
                return _ApplicationConfigurations.BasarName;
            }
            set
            {
                if (value != _ApplicationConfigurations.BasarName)
                {
                    _ApplicationConfigurations.BasarName = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("BasarName");
                }
            }
        }

        public string NextBasarDate
        {
            get
            {
                return _ApplicationConfigurations.NextBasarDate;
            }
            set
            {
                if (value != _ApplicationConfigurations.NextBasarDate)
                {
                    _ApplicationConfigurations.NextBasarDate = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("NextBasarDate");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }
    }
}

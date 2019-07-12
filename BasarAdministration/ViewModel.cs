using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Configurations;
using System.Windows.Forms;

namespace BasarAdministration
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ApplicationConfigurations _ApplicationConfigurations = new ApplicationConfigurations();

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

        public string AdminClientPort
        {
            get
            {
                return _ApplicationConfigurations.AdminClientPort;
            }
            set
            {
                if (value != _ApplicationConfigurations.AdminClientPort)
                {
                    _ApplicationConfigurations.AdminClientPort = value;
                    _ApplicationConfigurations.SaveConfigurations(Application.ExecutablePath);
                    OnPropertyChanged("AdminClientPort");
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

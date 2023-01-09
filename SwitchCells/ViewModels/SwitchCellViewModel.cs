using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCells.ViewModels
{
    internal sealed class SwitchCellViewModel : INotifyPropertyChanged
    {
        private bool switchCellBinding = false;
        public bool SwitchCellBinding
        {
            get
            {
                return this.switchCellBinding;
            }

            set
            {
                if (this.switchCellBinding != value)
                {
                    this.switchCellBinding = value;
                    this.PropertyChanged(this, new PropertyChangedEventArgs("SwitchCellBinding"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

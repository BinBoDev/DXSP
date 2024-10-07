using DX.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX.ViewModel
{
    public class AccountVM : INotifyPropertyChanged
    {
        public ObservableCollection<Account> Accounts { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

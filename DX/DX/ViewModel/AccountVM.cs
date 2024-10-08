using DX.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DX.ViewModel
{
    public class AccountVM : INotifyPropertyChanged
    {

        public ObservableCollection<Account> Accounts { get; set; }
        private Account selectedAccount;

        public Account SelectedAccount
        {
            get { return selectedAccount; }
            set 
            {
                selectedAccount = value; 
                OnPropertyChanged(nameof(SelectedAccount));
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand DelCommand { get; set; }
        public ICommand EditCommand { get; set; }


        public AccountVM()
        {
            
        }




        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DX.Models
{
    /// <summary>
    /// 1.Tạo một lớp Account được coi là một Table trong DXSP
    /// 2.Sử dụng thuộc tính Table để tạo một bảng
    /// </summary>
    /// 

    [Table("Account")]
    public class Account : INotifyPropertyChanged
    {
        private int id;
        [Key] //Thuộc tính Key của trường Id
        public int Id { get; set; }
        [Required] // Khác NULL
        [StringLength(30)] // Trường Usernam có kiểu nVarchar(50)
        private string username;

        public string Username
        {
            get { return username; }
            set 
            { 
                username = value; 
                OnPropertyChanged(nameof(Username));
            
            }
        }

        [Required]
        [StringLength(20)]
        private int password;

        public int Password
        {
            get { return password; }
            set 
            { 
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        [Required]
        private int type;

        public int Type
        {
            get { return type; }
            set 
            {
                type = value;
                OnPropertyChanged(nameof(Type));
            
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

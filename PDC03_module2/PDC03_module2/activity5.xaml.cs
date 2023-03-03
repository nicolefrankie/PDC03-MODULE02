using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PDC03_module2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }
        public activity5()
        {
            InitializeComponent();
            
            lst.ItemsSource = employees;

            employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", ProfileImage = "https://w0.peakpx.com/wallpaper/512/273/HD-wallpaper-svt-joshua-hong-hong-jisoo-music-ot13-vocal-team-kpop-joshua-seventeen-carat-joshua-hong.jpg" });
            employees.Add(new employee { DisplayName = "Peter", Position = "Vice President", ProfileImage = "https://i.pinimg.com/originals/c1/c6/66/c1c666a7461e2271307bb7cd9c8f3234.jpg" });
            employees.Add(new employee { DisplayName = "Mary", Position = "Secretary", ProfileImage = "https://0.soompi.io/wp-content/uploads/2021/07/07193634/jisoo-4.jpeg" });

        }
    }
}
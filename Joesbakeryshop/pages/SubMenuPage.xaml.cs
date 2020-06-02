using Joesbakeryshop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu = Joesbakeryshop.Models.Menu;
namespace Joesbakeryshop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubMenuPage : ContentPage
    {
        public ObservableCollection<SubMenu> SubMenus;
        public SubMenuPage (Menu menu)
        {
            InitializeComponent();
            SubMenus = new ObservableCollection<SubMenu>();
            foreach (var submenu in menu.SubMenus)
            {
                SubMenus.Add(submenu);
            }
              LvSubMenu.ItemsSource = SubMenus;
        }
    }
}
using System.Windows;
using Лабораторная_1.Model;
using Лабораторная_1.ViewModel;

namespace Лабораторная_1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowRole.xaml
    /// </summary>
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel();
        }
    }
}

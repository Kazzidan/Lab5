using System;
using System.Windows;
using Лабораторная_1.ViewModel;
using Лабораторная_1.Model;
using Лабораторная_1.Helper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Лабораторная_1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
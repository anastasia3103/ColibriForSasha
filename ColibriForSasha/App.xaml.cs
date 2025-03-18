using ColibriForSasha.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ColibriForSasha
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static User currentUser;
        public static SevodinKursovayaEntities context = new SevodinKursovayaEntities();
    }
}

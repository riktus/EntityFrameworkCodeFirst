using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using EfCodeFirst.Infrastructure;
using System.Windows;
using EfCodeFirst.Model;

namespace EfCodeFirst.ViewModel
{
    public class MainWindowViewModel
    {
        private MainWindowModel model;
        public MainWindowViewModel()
        {
            model = new MainWindowModel();
        }

        public ICommand CreateDbCommand
        {
            get
            {
                return new RelayCommand(p => 
                {
                    model.CreateDataBase();
                    MessageBox.Show("Database was created successfuly");
                });
            }
        }
    }
}

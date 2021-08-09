using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using AvaloniaMvvm.Main.Models;

namespace AvaloniaMvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() { }
        public string Greeting => "Welcome to Avalonia!";

        public ObservableCollection<MenuItem> MenuItems { get; } = new ObservableCollection<MenuItem>();
    }
}

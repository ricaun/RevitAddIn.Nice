using RevitAddIn.Module.ViewModels;
using System;
using System.Windows;

namespace RevitAddIn.Module.Views
{
    /// <summary>
    /// Interaction logic for ModuleView.xaml
    /// </summary>
    public partial class ModuleView : Window
    {
        public ModuleView(ModuleViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}

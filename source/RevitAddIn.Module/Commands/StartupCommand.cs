using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Module.ViewModels;
using RevitAddIn.Module.Views;

namespace RevitAddIn.Module.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    //[UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var viewModel = new ModuleViewModel();
            var view = new ModuleView(viewModel);
            view.ShowDialog();
        }
    }
}
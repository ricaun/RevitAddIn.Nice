using Autodesk.Revit.UI;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Core.Commands;
using ricaun.Revit.UI;
using RevitAddIn.Module.ViewModels;
using RevitAddIn.Module.Views;

namespace RevitAddIn.Core
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [AppLoader]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            new ModuleView(new ModuleViewModel());
            CreateRibbon();
        }

        public override void OnShutdown()
        {
            panel?.Remove();
        }

        RibbonPanel panel;
        private void CreateRibbon()
        {
            panel = Application.CreatePanel("RevitAddIn.Core");

            panel.CreatePushButton<StartupCommand>("Execute")
                .SetImage("Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("Resources/Icons/RibbonIcon32.png");
        }
    }
}
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using JetBrains.Annotations;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Common;
using System.Collections.Generic;
using System.Linq;

namespace RevitAddIn.Core.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            UIDocument uidoc = UiApplication.ActiveUIDocument;
            Document document = uidoc.Document;
            View view = uidoc.ActiveView;
            Selection selection = uidoc.Selection;

            var elements = selection.GetElementIds().Select(id => document.GetElement(id));

            foreach (var element in elements)
            {
                System.Console.WriteLine(element.AsString());
            }
        }
    }
}
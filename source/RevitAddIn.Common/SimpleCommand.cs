using Autodesk.Revit.Attributes;
using JetBrains.Annotations;
using Nice3point.Revit.Toolkit.External;

namespace RevitAddIn.Common
{
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class SimpleCommand : ExternalCommand
    {
        public override void Execute()
        {

        }
    }
}

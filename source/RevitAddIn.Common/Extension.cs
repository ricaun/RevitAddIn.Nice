using Autodesk.Revit.DB;
using System;

namespace RevitAddIn.Common
{
    public static class Extension
    {
        public static string AsString(this Element element)
        {
            return element.Name;
        }

        public static void Do()
        {
            new ViewModel();
        }
    }
}

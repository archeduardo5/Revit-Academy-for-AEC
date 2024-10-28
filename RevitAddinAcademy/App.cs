#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RevitAddinAcademy
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialogResult taskDialogResult = TaskDialog.Show("Eduardo Ibarra Garcia");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialogResult taskDialogResult = TaskDialog.Show("Eduardo Ibarra Garcia");
            return Result.Succeeded;
        }
    }
}

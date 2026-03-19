#region Namespaces
// For Revit API
using Autodesk.Revit;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.ExtensibleStorage;
using Autodesk.Revit.DB.Plumbing;
using Autodesk.Revit.DB.PointClouds;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Xml.Linq;
using Application = Autodesk.Revit.ApplicationServices.Application;
using MessageBox = System.Windows.MessageBox;
#endregion

namespace VuongLeTools
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd_LenhSo2 : IExternalCommand
    {
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
            ref string message, Autodesk.Revit.DB.ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            //-----------------------------------------------------
            // Code here


            // ► Yêu cầu user click chọn 1 đối tượng bất kỳ
            Reference pickedRef = uidoc.Selection.PickObject(ObjectType.Element, "👉 Hãy click chọn 1 đối tượng trong mô hình");

            // ► Lấy đối tượng từ Reference vừa pick
            Element pickedElement = doc.GetElement(pickedRef);

            // ► Lấy tên và ID của đối tượng
            string tenDoiTuong = pickedElement.Name;
            ElementId idDoiTuong = pickedElement.Id;

            MessageBox.Show("Tên Đối Tượng Là: " + tenDoiTuong + "ID Đối tượng là: " + idDoiTuong);

            //Transaction trans = new Transaction(doc);
            //trans.Start("Testing");



            //trans.Commit();

            return Autodesk.Revit.UI.Result.Succeeded;  // Trả về kết quả thành công.
        }

        //=============================================================
        // FUNCTION HERE








    }
}
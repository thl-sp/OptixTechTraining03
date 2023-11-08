#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.Report;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.DataLogger;
#endregion

public class MyDesignTimeNetLogic : BaseNetLogic
{
    [ExportMethod]
    public void CreateSingleVariable() 
    {
        var myFolder = InformationModel.Make<Folder>("Variables");
        Project.Current.Get("Model").Add(myFolder);
        var myVar = InformationModel.MakeVariable("MotorType", OpcUa.DataTypes.UInt16);
        myFolder.Add(myVar);
    }

    [ExportMethod]
    public void CreateMultipleVariable()
    {
        for (int i = 1; i < 10; i++) 
        {
            var myVar = InformationModel.MakeVariable("MyVariable"+i.ToString(), OpcUa.DataTypes.UInt16);
            Project.Current.Get("Model").Add(myVar);
        }
    }
}

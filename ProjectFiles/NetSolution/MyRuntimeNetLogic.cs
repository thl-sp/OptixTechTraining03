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

public class MyRuntimeNetLogic : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void CalSum()
    {
        var Output = Project.Current.GetVariable("Model/MyVariable3");
        var Input1 = Project.Current.GetVariable("Model/MyVariable1");
        var Input2 = Project.Current.GetVariable("Model/MyVariable2");
        //Output.Value = Input1.Value + Input2.Value;
    }
}

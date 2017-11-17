namespace PlmonFuncTestNunit.TestsInputData.ControlPanel
{
    [PageDataRootElement("inputData")]
    public class InputDataCp : TestData
    {
        [PageDataPropertyElement("txtCustomKey")] public string TxtSearchName { get; set; }
    }
}

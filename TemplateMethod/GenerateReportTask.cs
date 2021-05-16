namespace TemplateMethod
{
    public class GenerateReportTask : Task
    {
        /*
            2. Extending Template
        */
        protected override void DoExecute()
        {
            System.Console.WriteLine("Generate Report Task");
        }
    }
}
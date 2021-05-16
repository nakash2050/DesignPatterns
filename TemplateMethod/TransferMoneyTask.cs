namespace TemplateMethod
{
    /*
        2. Extending Template
        Added additional Final method to finalize the operation. Not part of Template Pattern
    */
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            System.Console.WriteLine("Transfer Money Task");
        }

        public override void Final()
        {
            System.Console.WriteLine("Final in Transfer Money (Derived out of Base Task class)");
        }
    }
}
namespace TemplateMethod
{
    /*
        1. Defining the Template
        This template has one or more common operations (AuditTrial) which needs to be executed along with the the derived implementations
    */
    public abstract class Task
    {
        private readonly AuditTrial _auditTrial;

        public Task()
        {
            _auditTrial = new AuditTrial();
        }

        public void Execute()
        {
            _auditTrial.Execute();
            DoExecute();
            Final();
        }

        protected abstract void DoExecute();

        public virtual void Final()
        {
            System.Console.WriteLine("Final in Task(Base) class");
        }
    }
}
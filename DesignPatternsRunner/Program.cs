using Memento;
using System;
using State;
using Iterator;
using Strategy;
using TemplateMethod;
using Command;
using Command.Fx;
using Command.Editor;
using Command.Composite;
using Observer.Push;
using Mediator;

namespace DesignPatternsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TestMemento();
            // TestState();
            // TestIterator();
            // TestStrategy();
            // TestTemplateMethod();
            // TestCommand();
            // TestUndoableCommand();
            // TestCompositeCommand();
            // TestObserverPush();
            // TestObserverPull();
            TestMediatorPattern();

            // Console.ReadLine();
        }

        static void TestMemento()
        {
            var editor = new Editor();
            var history = new Memento.History();

            editor.Content = "This is content 1";
            history.Push(editor.CreateState());
            
            editor.Content = "This is content 2";
            history.Push(editor.CreateState());

            editor.Content = "This is content 3";
            history.Push(editor.CreateState());

            editor.Content = "This is content 4";
            
            System.Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());

            System.Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            // editor.Restore(history.Pop());
            // editor.Restore(history.Pop());

            System.Console.WriteLine(editor.Content);
        }

        static void TestState()
        {
            var canvas = new Canvas(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            canvas = new Canvas(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }

        static void TestIterator()
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("URL1");
            browserHistory.Push("URL3");
            browserHistory.Push("URL2");

            var iterator = browserHistory.CreateIterator();

            while(iterator.HasNext())
            {
                System.Console.WriteLine(iterator.Current());
                iterator.Next();
            }
            
            browserHistory.Pop();
            browserHistory.Pop();
            browserHistory.Pop();

            iterator = browserHistory.CreateIterator();

            while(iterator.HasNext())
            {
                System.Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }

        static void TestStrategy()
        {
            var imageStorage = new ImageStorage();

            // Strategy 1
            imageStorage.Store("FileName1", new JpegCompressor(), new BlackAndWhiteFilter());
            
            // Strategy 2
            imageStorage.Store("FileName1", new PngCompressor(), new HighContrastFilter());
        }

        static void TestTemplateMethod()
        {
            // This will first execute Audit Trail and then call the Transfer Money operations
            var transferMoney = new TransferMoneyTask();
            transferMoney.Execute();
            
            // This will first execute Audit Trail and then call the Generate Report operations
            var generateReport = new GenerateReportTask();
            generateReport.Execute();
        }

        static void TestCommand()
        {
            var customerService = new CustomerService();
            var command = new AddCustomerCommand(customerService);
            var button = new Command.Fx.Button(command);
            button.Click();
        }

        static void TestUndoableCommand()
        {
            var history = new Command.Editor.History();
            var document = new HtmlDocument();
            document.Content = "Hello World";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            System.Console.WriteLine(document.Content);

            document.Content = "This is Command Pattern";
            boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            System.Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            
            System.Console.WriteLine(document.Content);

            undoCommand.Execute();
            System.Console.WriteLine(document.Content);
        }

        static void TestCompositeCommand()
        {
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());

            composite.Execute();
        }

        private static void TestObserverPush()
        {
            var dataSource = new DataSource();
            dataSource.AddObserver(new Chart());
            dataSource.AddObserver(new SpreadSheet());
            dataSource.AddObserver(new SpreadSheet());
            dataSource.Value = 4;
        }  

        private static void TestObserverPull()
        {
            var dataSource = new Observer.Pull.DataSource();
            dataSource.AddObserver(new Observer.Pull.Chart(dataSource));
            dataSource.AddObserver(new Observer.Pull.SpreadSheet(dataSource));
            dataSource.AddObserver(new Observer.Pull.SpreadSheet(dataSource));
            dataSource.Value = 7;
        }

        private static void TestMediatorPattern()
        {
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();
        }
    }
}

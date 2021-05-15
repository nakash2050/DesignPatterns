using Memento;
using System;
using State;
using Iterator;

namespace DesignPatternsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TestMemento();
            // TestState();
            TestIterator();

            Console.ReadLine();
        }

        static void TestMemento()
        {
            var editor = new Editor();
            var history = new History();

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
    }
}

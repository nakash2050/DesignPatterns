using Memento;
using System;
using State;

namespace DesignPatternsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TestMemento();
            TestState();

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
    }
}

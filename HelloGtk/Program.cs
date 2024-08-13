using System;
using Gtk;

class Program
{
    static void Main()
    {
        Application.Init();
        Window window = new Window("Hello, GTK#");
        window.DeleteEvent += delegate { Application.Quit(); };
        window.SetDefaultSize(250, 200);
        window.ShowAll();
        Application.Run();
    }
}
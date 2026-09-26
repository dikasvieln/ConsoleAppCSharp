using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp
{
    public abstract class MenuItem
    {
        public string Title { get; }
        public bool IsExit { get; protected set; } = false;

        protected MenuItem(string title)
        {
            Title = title;
        }

        public abstract void Execute();

        public virtual void Display()
        {
            Console.WriteLine(Title);
        }
    }

    //public class Menu : MenuItem
    //{
    //    public string Title { get; }
    //    public bool IsExit { get; protected set; } = false;

    //    protected MenuItem(string title)
    //    {
    //        Title = title;
    //    }

    //    //public abstract void Execute();

    //    public virtual void Display()
    //    {
    //        Console.WriteLine(Title);
    //    }
        

    //    private readonly List<MenuItem> _items;
    //    private readonly MenuItem? _parent;

    //    public Menu(string title, MenuItem? parent = null) : base(title)
    //    {
    //        _parent = parent;

    //        // Add back option if this is a submenu
    //        if (_parent != null)
    //        {
    //            _items.Add(new ActionMenuItem("Back", () => { IsExit = true; }));
    //        }
    //    }

    //    public void Add(MenuItem item) => _items.Add(item);
    //}

    public class ActionMenuItem : MenuItem
    {
        private readonly Action _action;
        public ActionMenuItem(string title, Action action) : base(title)
        {
            _action = action;
        }
        public override void Execute()
        {
            _action();
        }
        public override void Display()
        {
            Console.WriteLine($"- {Title}");
        }
    }

    public class ExitMenuItem : MenuItem
    {
        public ExitMenuItem() : base("Exit")
        {
            IsExit = true;
        }
        public override void Execute()
        {
            // No action needed, just exit
        }
        public override void Display()
        {
            Console.WriteLine($"- {Title}");
        }
    }
}

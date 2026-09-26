using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.Games
{
    class MyWindow
    {
        public void Show()
        {
            //VideoMode mode = new VideoMode(400, 400);
            VideoMode desktopMode = VideoMode.DesktopMode;
            RenderWindow window = new RenderWindow(desktopMode, "Try rolling data");
            

            ConvexShape convexShape = new ConvexShape(4);


            window.KeyPressed +=
                (s, e) =>
                {
                    Window window = (Window)s;
                    if (e.Code != null)
                    {
                        Environment.Exit(0);
                    }
                };

            Font font = new Font("C:/Windows/Fonts/arial.ttf");
            Text text = new Text(font, "C# okay bro!!", 20);
            
            // Center text on window
            Vector2u windowSize = window.Size;
            FloatRect textBounds = text.GetLocalBounds();
            text.Position = new Vector2f(
                (windowSize.X - textBounds.Width) / 2f - textBounds.Left,
                (windowSize.Y - textBounds.Height) / 2f - textBounds.Top
            );

            Clock clock = new Clock();
            float delta = 0f;
            float angle = 0f;
            float angleSpeed = 90f;
            
            while (window.IsOpen)
            {
                delta = clock.Restart().AsSeconds();

                convexShape.SetPoint(0, new Vector2f(40, 100));
                convexShape.SetPoint(1, new Vector2f(300, 100));
                convexShape.SetPoint(2, new Vector2f(220, 150));
                convexShape.SetPoint(3, new Vector2f(20, 170));
                angle += angleSpeed * delta;

                window.DispatchEvents();
                window.Clear();
                text.Rotation = angle;
                window.Draw(text);
                window.Display();
            }
        }

        public void About()
        {
            Console.WriteLine("This is a simple SFML window example.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

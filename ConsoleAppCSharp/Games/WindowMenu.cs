using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ConsoleAppCSharp.Games
{
    class WindowMenu
    {
        public int? Show()
        {
            RenderWindow window = new RenderWindow(
                new VideoMode(new Vector2u(800, 600)),
                "Simple Console Apps");

            Font font = new Font("C:/Windows/Fonts/arial.ttf");

            string[] choices =
            {
                "1. MiniGames",
                "2. Simple Project Information System",
                "3. Try to SFML GUI",
                "4. Codingbat C# practice",
                "5. ML Dotnet",
                "6. LeetCode cases",
                "7. Exit Programs"
            };

            Text title = new Text(font, "Welcome to dka Simple Console Apps", 30);
            title.Position = new Vector2f(120, 60);

            Text[] items = new Text[choices.Length];

            for (int i = 0; i < choices.Length; i++)
            {
                items[i] = new Text(font, choices[i], 24);
                items[i].Position = new Vector2f(180, 150 + i * 48);
            }

            Text instructions = new Text(font, "Use Up/Down and Enter. Esc closes this menu.", 16);
            instructions.Position = new Vector2f(150, 520);

            int selectedIndex = 0;
            int? selectedChoice = null;

            window.Closed += (sender, e) => window.Close();

            window.KeyPressed += (sender, e) =>
            {
                if (e.Code == Keyboard.Key.Up)
                {
                    selectedIndex = (selectedIndex - 1 + choices.Length) % choices.Length;
                }
                else if (e.Code == Keyboard.Key.Down)
                {
                    selectedIndex = (selectedIndex + 1) % choices.Length;
                }
                else if (e.Code == Keyboard.Key.Enter)
                {
                    selectedChoice = selectedIndex + 1;
                    window.Close();
                }
                else if (e.Code == Keyboard.Key.Escape)
                {
                    window.Close();
                }
            };

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(new Color(30, 30, 40));

                window.Draw(title);

                for (int i = 0; i < items.Length; i++)
                {
                    items[i].FillColor = i == selectedIndex ? Color.Yellow : Color.White;
                    window.Draw(items[i]);
                }

                window.Draw(instructions);
                window.Display();
            }

            return selectedChoice;
        }
    }
}
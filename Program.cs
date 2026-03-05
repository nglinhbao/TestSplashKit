using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window gameWindow = new Window("Shapes", 800, 600);

        while (!gameWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();

            gameWindow.Clear(Color.White);

            // Draw a red rectangle
            gameWindow.FillRectangle(Color.Red, 100, 100, 200, 150);

            // Draw a blue circle
            gameWindow.FillCircle(Color.Blue, 400, 300, 75);

            // Draw a green line
            gameWindow.DrawLine(Color.Green, 50, 50, 750, 550);

            gameWindow.Refresh(60);
        }
    }
}
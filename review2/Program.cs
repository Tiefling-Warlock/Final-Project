enum WindowState
{
    Quoted,
    Ordered,
    Manufactured,
    Shipped,
    Installed
};

struct Window
{
    public WindowState state;
    public double Width;
    public double Height;
    public string Description;
};

class Demonstrations
{
    public static void Main()
    {
        Window BobsWindow;
        BobsWindow.Description = "Fadded Paint";
        Console.WriteLine(BobsWindow.Description);
        BobsWindow = new Window();
        BobsWindow.Height = 3;
        Console.WriteLine($" Bob's window is {BobsWindow.Height} feet tall.");
        WindowState state;
        state = WindowState.Manufactured;
    }
}
namespace space
{
    public class Program{
        public static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            reader.OnKeyPressed = WriteChar;

            reader.Run();
        }

        public static void WriteChar(object sender, char ch)
        {
            Console.Write(ch);
        }
    }

    public class ConsoleReader
    {
        public EventHandler<char> OnKeyPressed;
        public void Run()
        {
            char ch = (char)Console.Read();
            while (ch != 'c')
            {
                OnKeyPressed(this, ch);
                ch = (char)Console.Read();
            }
        }
    }
}
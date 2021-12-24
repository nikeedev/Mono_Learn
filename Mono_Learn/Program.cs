using System;

namespace Mono_Learn
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using var game = new MouseGame1();
            game.Run();
        }
    }
}

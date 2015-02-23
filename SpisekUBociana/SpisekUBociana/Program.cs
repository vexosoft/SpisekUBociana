using System;

namespace SpisekUBociana
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GameSpisekUBociana game = new GameSpisekUBociana())
            {
                game.Run();
            }
        }
    }
#endif
}


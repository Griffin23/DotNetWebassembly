using Microsoft.JSInterop;

namespace Demo1
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
        }

        [JSInvokable]
        public static int Add(int i, int j)
        {
            return i + j;
        }
    }
}
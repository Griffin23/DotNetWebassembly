using Microsoft.JSInterop;

namespace DotNetWebassembly
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
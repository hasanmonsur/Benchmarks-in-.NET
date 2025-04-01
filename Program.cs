using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var config = DefaultConfig.Instance;
           // var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

            var summary1 = BenchmarkRunner.Run<Md5VsSha256>();


            // Use this to select benchmarks from the console:
            // var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
        }
    }
}
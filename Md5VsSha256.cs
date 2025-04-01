using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    [SimpleJob(RuntimeMoniker.Net80)]
    [MemoryDiagnoser]
    public class Md5VsSha256
    {
        private byte[] data;

        [Params(1000, 10000)]
        public int N;  // Test with different input sizes

        [GlobalSetup]
        public void Setup() => data = new byte[N];

        [Benchmark]
        public byte[] Sha256() => SHA256.HashData(data);

        [Benchmark]
        public byte[] Md5() => MD5.HashData(data);
    }
}

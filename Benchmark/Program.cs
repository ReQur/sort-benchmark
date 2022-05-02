using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace sortbenchmark
{
    public class Sorts
    {
        private static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }
        private void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];
            
            for (i = 0; i < 10; i++)
                count[i] = 0;
            
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
        
        public void RadixSort(int[] arr)
        {
            int n = arr.Length;
            int m = getMax(arr, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        public void ShellSort(int[] array)
        {
            int step = array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                        array[j + step] = array[j];
                    array[j + step] = value;
                }
                step /= 2;
            }
        }

    }
    public class SortsBenchmark
    {
        private const int _N = 1000;
        private readonly int[] _data;

        private Sorts _sorts = new Sorts();
        public SortsBenchmark()
        {
            _data = new int[_N];
            for (int i = 0; i < _N; i++)
            {
                _data[i] = new Random(25).Next(15000);
            }
        }


        [Benchmark]
        public void ShellSort() => _sorts.ShellSort(_data);
        [Benchmark]
        public void Radix() => _sorts.RadixSort(_data);
        [Benchmark]
        public void BuiltInSort() => Array.Sort(_data);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
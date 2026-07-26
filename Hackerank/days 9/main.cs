using System.IO;
using System.Collections.Generic;
using SZ = System;

class Solution {

    static int Factorial(int n) {
        if (n <= 1) {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@SZ.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = SZ.Convert.ToInt32(SZ.Console.ReadLine().Trim());

        int result = Factorial(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

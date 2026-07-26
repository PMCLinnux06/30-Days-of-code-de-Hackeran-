using System;

class Solution {
    static void Main(string[] args) {
        string tInput = Console.ReadLine();
        if (string.IsNullOrEmpty(tInput)) return;
        
        int t = int.Parse(tInput.Trim());

        for (int i = 0; i < t; i++) {
            string palabra = Console.ReadLine();
            if (palabra == null) break;

            string pares = "";
            string impares = "";

            for (int j = 0; j < palabra.Length; j++) {
                if (j % 2 == 0) {
                    pares += palabra[j];
                } else {
                    impares += palabra[j];
                }
            }

            Console.WriteLine($"{pares} {impares}");
        }
    }
}
 using System;
using System.Collections.Generic;

class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++) {
            string[] entry = Console.ReadLine().Split(' ');
            phoneBook[entry[0]] = entry[1];
        }

        string query;
        while ((query = Console.ReadLine()) != null) {
            if (phoneBook.ContainsKey(query)) {
                Console.WriteLine($"{query}={phoneBook[query]}");
            } else {
                Console.WriteLine("Not found");
            }
        }
    }
}

using System;
using System.Linq;

class Person {
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person(string firstName, string lastName, int identification) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }

    public void printPerson() {
        Console.WriteLine("Name: " + lastName + ", " + firstName);
        Console.WriteLine("ID: " + id);
    }
}

class Student : Person {
    private int[] scores;

    public Student(string firstName, string lastName, int identification, int[] scores) 
        : base(firstName, lastName, identification) {
        this.scores = scores;
    }

    public char calculate() {
        int sum = 0;
        foreach (int score in scores) {
            sum += score;
        }
        double avg = (double)sum / scores.Length;

        if (avg >= 90 && avg <= 100) return 'O';
        if (avg >= 80 && avg < 90) return 'E';
        if (avg >= 70 && avg < 80) return 'A';
        if (avg >= 55 && avg < 70) return 'P';
        if (avg >= 40 && avg < 55) return 'D';
        return 'T';
    }
}

class Solution {
    static void Main() {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        Console.ReadLine(); // Lee la cantidad de notas (no siempre necesaria si se usa Split directo)
        int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.calculate());
    }
}
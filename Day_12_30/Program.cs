using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] testScores)
        :   base(firstName, lastName, id)
    {
        this.testScores = testScores;
    }

    public char Calculate()
    {
        char grade;
        double a = this.testScores.Average();
        if (a <= Convert.ToDouble(100) && a >= Convert.ToDouble(90))
        {
            grade = 'O';
        }
        else if (a >= Convert.ToDouble(80) && a < Convert.ToDouble(90))
        {
            grade = 'E';
        }
        else if (a >= Convert.ToDouble(70) && a < Convert.ToDouble(80))
        {
            grade = 'A';
        }
        else if (a >= Convert.ToDouble(55) && a < Convert.ToDouble(70))
        {
            grade = 'P';
        }
        else if (a >= Convert.ToDouble(40) && a < Convert.ToDouble(55))
        {
            grade = 'D';
        }
        else
        {
            grade = 'T';
        }
        return grade;
    }
}

class Solution {
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
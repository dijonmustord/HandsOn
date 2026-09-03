// See https://aka.ms/new-console-template for more information

using System;
Console.WriteLine("no.1");
Console.WriteLine("Please Answer The Following");
Console.WriteLine("What Is Your Name?");
String Name = Console.ReadLine();
Console.WriteLine("What Is Your Course?");
String Course = Console.ReadLine();
Console.WriteLine("What Is Your Year Level?");
String YL = Console.ReadLine();
Console.WriteLine("What Is Your Section?");
String Section = Console.ReadLine();
Console.WriteLine("Name: " + Name);
Console.WriteLine("Course: " + Course);
Console.WriteLine("Year Level: " + YL);
Console.WriteLine("Section: " + Section);

Console.WriteLine("no.2");
Console.WriteLine("Enter Two Numbers");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Addition: " + (num1 + num2));
Console.WriteLine("Subtraction: " + (num1 - num2));
Console.WriteLine("Multiplication: " + (num1 * num2));
Console.WriteLine("Division: " + (num1 / num2));

Console.WriteLine("no.3");
Console.WriteLine("Enter Two Numbers");
double num3 = Convert.ToInt32(Console.ReadLine());
double num4 = Convert.ToInt32(Console.ReadLine());
double area = num3 * num4;
Console.WriteLine("The Area of The Rectrangle Is: " + area);

Console.WriteLine("no.4");
Console.WriteLine("What Are Your 3 Grades? ");
double grade1 = Convert.ToInt32(Console.ReadLine());
double grade2 = Convert.ToInt32(Console.ReadLine());
double grade3 = Convert.ToInt32(Console.ReadLine());
double average = (grade1 + grade2 + grade3)/ 3;
Console.WriteLine("Your Average Is: " + average);

Console.WriteLine("no.5");
Console.WriteLine("Are You A Student?:(True/False) ");

Boolean student = bool.Parse(Console.ReadLine());
Console.WriteLine("Is Student " + student);


Console.WriteLine("no.6");
Console.WriteLine("How Old Are You? ");
int Age = Convert.ToInt32(Console.ReadLine());
bool Adult = Age >= 18;
Console.WriteLine("18 Or Above" + Adult);

Console.WriteLine("no.7");
Console.WriteLine("Whats Your First Name?: ");
String Fn = Console.ReadLine();
Console.WriteLine("Whats Your Last Name?: ");
String Ln = Console.ReadLine();
String FullName = String.Concat(Fn, Ln);
Console.WriteLine(FullName);

Console.WriteLine("no.8");
Console.WriteLine("Whats The Product Name?: ");
String PN = Console.ReadLine();
Console.WriteLine("Whats The Price?: ");
int Quan = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Whats The Quantity?: ");
Double Price = Convert.ToInt32(Console.ReadLine());
Double Total = Quan * Price;
Console.WriteLine("The Total For " + Quan + PN + "Is: " + Total);

Console.WriteLine("no.9");
Console.WriteLine("Whats Your Name?: ");
String EnployeeName = Console.ReadLine();
Console.WriteLine("How Many Hours Worked?: ");
Double HoursWOrked = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Whats Your Hourly Rate?: ");
Double HourlyRate = Convert.ToInt32(Console.ReadLine());
Double Salary = HourlyRate * HoursWOrked;
Console.WriteLine("Employee: " + EnployeeName  + " Salary IS: " + Salary);

Console.WriteLine("no.10");
Console.WriteLine("Please Answer The Following");
Console.WriteLine("What Is Your Name?");
String Name2 = Console.ReadLine();
Console.WriteLine("What Is Your Course?");
String Course2 = Console.ReadLine();
Console.WriteLine("How Old Are You? ");
int Age2 = Convert.ToInt32(Console.ReadLine());
bool Adult2 = Age >= 18;
Console.WriteLine("What Are Your 3 Grades? ");
double grade12 = Convert.ToInt32(Console.ReadLine());
double grade22 = Convert.ToInt32(Console.ReadLine());
double grade32 = Convert.ToInt32(Console.ReadLine());
double average2 = (grade12 + grade22 + grade32) / 3;
Console.WriteLine("Your Average Is: " + average);
Console.WriteLine("What Is Your Year Level?");
String YL2 = Console.ReadLine();
Console.WriteLine("What Is Your Section?");
String Section2 = Console.ReadLine();
Console.WriteLine("Name: " + Name);
Console.WriteLine("Course: " + Course);
Console.WriteLine("18 Or Above" + Adult);
Console.WriteLine("Year Level: " + YL);
Console.WriteLine("Section: " + Section);
Console.WriteLine("18 Or Above" + Adult2);

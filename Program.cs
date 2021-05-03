using System;


namespace ArrayClassesandMethods
{
    class Program
    {
    public static double CGPACalculator(double[] MyScores, int numberofcourses)
{
   
    double[] Grade = new double[numberofcourses];
    double sum = 0, CGPA;

    for (int i = 0; i < numberofcourses; i++)
    {
        Grade[i] = (MyScores[i] / 10);

    }

    for (int i = 0; i < numberofcourses; i++)
    {
        sum += Grade[i];
    }
    CGPA = sum / numberofcourses;
   
    return CGPA;
}

 
   



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your CGPA Calculator");
            Console.WriteLine("Please enter the number of subject offer: ");
            string numberAsString = Console.ReadLine();
            int numberofcourses;
            Int32.TryParse(numberAsString, out numberofcourses);
            double[] MyScores = new double[numberofcourses];


            for (int i = 0; i < numberofcourses; i++)
            {
                Console.WriteLine("Please Enter course score");
                double courseScore = Convert.ToDouble(Console.ReadLine());
                MyScores[i] = courseScore;
            }
            double CGPA=CGPACalculator(MyScores,numberofcourses);
            Console.WriteLine($"The CGPA is: {CGPA} ");
            Console.WriteLine("CGPA Percentage = {0:F2}", CGPA * 9.5);


        }
    }
}



































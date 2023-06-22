namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int answer = 4;// explicit typing
            //string response;// explicit

            //if (answer < 9)
            //{
              //  response = answer + " is less than nine";
            //}
            //else
            //{
              //  response = answer + "greater than or equal to nine";
            //}
            //Console.WriteLine(response);


            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"greater than or ewual to nine";
            Console.WriteLine(response);
        }
    }
}

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exam scores
            int[] scores = { 97, 92, 81, 75, 60, 50 };

            // How many got above 80

            /*var studentsAboveEighty =   from score in scores
                                where score > 80
                                select score; */

            var studentsAboveEighty = scores.Where(s => s > 80);

            Console.WriteLine($"Total {studentsAboveEighty.Count()} student(s) got above 80.\n");

            foreach(var score in studentsAboveEighty)
            {
                 Console.WriteLine(">>> Score: " + score);   
            }
        }
    }
}
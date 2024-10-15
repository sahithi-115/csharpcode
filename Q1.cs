namespace operator_precedence
{
    internal class Q1
        /* int a = 5,b= 10,c=15;
         bool result = a+10>c && b-a <= c || c*a%b == 0;
        5+10>15 && 10-5 <=15 || 15*5%10 == 0;
        15>15 && 5<=15 || 5 == 0;
        f && t || f;
        f;
         */
    {
        static void Main(string[] args)
        {

            int a = 5, b = 10, c = 15;
            bool result = a + 10 > c && b - a <= c || c * a % b == 0;

            Console.WriteLine(result);

        }
    }
}

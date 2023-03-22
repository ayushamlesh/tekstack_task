namespace IntroductionTask
{
    internal class question1
    {
        static void Main(string[] args)
        {
            int num1, num2,choice,ans;
            Console.WriteLine("Enter the  1st number ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number ");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GIVE INPUT : 1=>Addition,2=>Subtraction,3=>Multiplication,4=>Division ");
            choice= Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    question2 obj=new question2();

                    //ans = num1 + num2;
                    //Console.WriteLine("Value after addition is : {0}",ans);
                    break;
                case 2:
                    ans = num1 - num2;
                    Console.WriteLine("Value after Subtraction is : {0}", ans);
                    break;
                case 3:
                    ans = num1 * num2;
                    Console.WriteLine("Value after multiplication is : {0}", ans);
                    break;
               case 4:
                    ans = num1 / num2;
                    Console.WriteLine("Value after Division is : {0}", ans);
                    break;
               default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
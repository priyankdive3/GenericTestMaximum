namespace GenericMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Maximum intger number.2.Maximum Float Value:3.Maximum String:4.Refactor1:5.rectaor2:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                   MaximumInteger i = new MaximumInteger();
                   int intresult= i.MaxNum();
                   Console.WriteLine("Maximum number between 3 int numbers: "+intresult );

                    //Maximum3IntNumbers max = new Maximum3IntNumbers();
                    //int result = max.MaxNum(70, 85, 60);     //direct value
                    //Console.WriteLine("Maximum number of integer is " + result);
                    break;
                case 2:
                    MaximumFloat f = new MaximumFloat();
                    double floatresult = f.MaxFloat();
                    Console.WriteLine("Maximum number between 3 float numbers: " + floatresult);
                break;
                case 3:
                    MaximumString s = new MaximumString();
                    string strlt = s.Maxstring("Ram", "sammy", "Rooooooooooo");
                    Console.WriteLine("Maximum string value is:" + strlt);
                break;
                case 4:
                    Refactor1 refactor1 = new Refactor1();
                    int result1 = refactor1.Max(100, 10, 20);
                    Console.WriteLine("Maximum int value is:" + result1);

                    Refactor1 refactor2 = new Refactor1();
                    float result2 = refactor2.Max(24.5f, 31.6f,5.6f);
                    Console.WriteLine("Maximum float value is:" + result2);

                    Refactor1 refactor3 = new Refactor1();
                    string result3 = refactor3.Max("sai", "mohannnnnnnnnn","priyanka");
                    Console.WriteLine("Maximum string is:" + result3);
                break;
                case 5:
                    Refactor2<int> gr1 = new Refactor2<int>(200,700,100);
                    Console.WriteLine("Maximum Integer value is: " + gr1.Max());

                    Refactor2<float> gr2 = new Refactor2<float>(20.8f,7.00f,10.89f);
                    Console.WriteLine("Maximum float value is: " + gr2.Max());

                    Refactor2<string> gr3 = new Refactor2<string>("Oragnge","Apple","kiwi");
                    Console.WriteLine("Maximum string is: " + gr3.Max());
                    break;



            }
        }
    }
}
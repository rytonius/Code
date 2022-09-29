namespace IllustratedC7
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("The Value: {0,11:C3}", 5000.30289);
            Console.WriteLine("The Value: {0,11:C2}\n", 500000.403);


            IllustratedC7.heyo.howdy();

            void RunHeyo()
            {
                IllustratedC7.heyo.formatStrings(1209.3920f);
            }

            RunHeyo();

            heyo HEYO = new heyo();
            
            HEYO.PV();
            
        }
    }
}

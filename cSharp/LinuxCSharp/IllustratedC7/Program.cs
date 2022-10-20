namespace IllustratedC7
{
    
    class Program
    {
        ReferenceTesting RT;
        private int five = 5;
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
            Program P = new Program();
            P.referencetest();

        }

        void referencetest() 
        {
            int f = five; 
            ReferenceTesting RT = new IllustratedC7.ReferenceTesting();
            Console.WriteLine($"reference test {f}");
            RT.ReferenceStuff(ref f);
            Console.WriteLine($"reference test {f}");

        }
    }
}

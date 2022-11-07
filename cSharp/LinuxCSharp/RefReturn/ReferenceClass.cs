namespace LocalRef
{
    class MyClass
    {
        private int Score = 5;
        public ref int RefToValue()
        {
            return ref Score;
        }

        public void Display()
        {
            Console.WriteLine($"Value inside class object: {Score}");
        }
    }

    class MaxClass {
        static ref int Max(ref int p1, ref int p2) {
            if (p1 > p2)
                return ref p1;
            else
                return ref p2;
        }
    }

}

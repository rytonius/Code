using static System.Console;

LocalRef.MyClass MC = new LocalRef.MyClass();

MC.Display(); // will print 5 as that's the value on creation of class.

ref int v1Outside = ref MC.RefToValue();

v1Outside = 10;  // Change the value out in the calling scope.
MC.Display();    // Check that the value has changed.

// max example with references

static ref int Max(ref int p1, ref int p2) 
    {
        if (p1 > p2)
            return ref p1;
        else
            return ref p2;
    }

int v1 =10, v2 = 20;
WriteLine("\nstart\n V1: {0}, v2: {1} \n", v1, v2);

ref int max = ref Max(ref v1, ref v2);
WriteLine("After assignment");
WriteLine($"max: {max}\n");

max++;
WriteLine("After increment");
WriteLine($"max: {max}, v1: {v1}, v2: {v2}");

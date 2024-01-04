class spg1 {
public void spg() {

// Value Typer

int a = -5;
int b = a;

Console.WriteLine(a);
Console.WriteLine(b);

b= 10;

Console.WriteLine(a);
Console.WriteLine(b);

//Reference typer

int [] c = { -5 };
int [] d = c;

Test(c);

Console.WriteLine(c[0]);
Console.WriteLine(d[0]);

static void Test(int[] x){
    
    x[0] = 100;

}

}

// operator overload

public class Boks
{
    public int Aebler; // Antallet af æbler i boksen.

    public Boks(int antalAebler)
    {
        Aebler = antalAebler;
    }

    // Her definerer vi, hvad der sker, når to bokse lægges sammen.
    public static Boks operator +(Boks boks1, Boks boks2)
    {
        int totalAebler = boks1.Aebler + boks2.Aebler;
        return new Boks(totalAebler);
    }

}

//Method paramaters

//In

public class Inoutref {
    public void DisplayNumber(in int num) {
        Console.WriteLine(num);
        // num = 10; // Dette vil give en kompileringsfejl, da 'num' er read-only.
    }

    //out

     public void GetCoordinates(out int x, out int y) {
        x = 10; // Tildeler værdier inden metoden slutter.
        y = 20;
    }

    //ref
    public void UpdateValue(ref int value) {
        value += 10; // Ændrer værdien af 'value'.
    } 

}

//Named/positional/default

public class NamedPositionDefault{

    public static void Add(int a, int b){

    int sum = a + b;
    Console.WriteLine($"Summen er: {sum}");

}

        public static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"Navn: {name}, Alder: {age}");
        }

        public static void Greet(string name, string greeting = "Hej")
        {
            Console.WriteLine($"{greeting} {name}!");
        }
    }
    
}






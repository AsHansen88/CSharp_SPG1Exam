using System.ComponentModel;
using static spg1;

class Program {

    static void Main(String[] args) {

// Spg 1

        spg1 spg = new spg1();
        spg.spg();
        

        Boks boks1 = new Boks(5); 
        Boks boks2 = new Boks(3); 

        Boks boks3 = boks1 + boks2; 

        Console.WriteLine("Total antal æbler i boks 3: " + boks3.Aebler); 
        
        //in, out, ref
        // in 
        int myNumber = 5;

        //out
        int x,y;

        //ref

        int myValue = 5;

        Inoutref inoutref = new Inoutref();
        inoutref.DisplayNumber(myNumber);
        
        inoutref.GetCoordinates(out x, out y);
        Console.WriteLine($"Coordinates: ({x}, {y})");

        inoutref.UpdateValue(ref myValue);
        Console.WriteLine($"Update value: {myValue}");

                
        //Named/positional/default

        //Positional 
        
        NamedPositionDefault.Add(5, 3);

        // Navngivne argumenter
        NamedPositionDefault.PrintDetails(age: 30, name: "Anders");

            // Standardargumenter
        NamedPositionDefault.Greet("Maria");
        NamedPositionDefault.Greet("Maria", "Godmorgen");

    }

}
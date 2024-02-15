using System;
class Converter{
    private double kilometers, miles, celcius, fahrenheit, usDollars, philippinePeso;
    public double Kilometers{
        get{return kilometers;}
        set{kilometers=value;}
    }
    public double Miles{
        get{return miles;}
        set{miles=value;}
    }
    public double Celcius{
        get{return celcius;}
        set{celcius=value;}
    }
    public double Fahrenheit{
        get{return fahrenheit;}
        set{fahrenheit=value;}
    }
    public double USDollars{
        get{return usDollars;}
        set{usDollars=value;}
    }
    public double PhilippinePeso{
        get{return philippinePeso;}
        set{philippinePeso=value;}
    }
    
    public double ConvertKilometersToMiles(){
        miles = Convert.ToDouble(Console.ReadLine());
        double milesconvert = kilometers * 0.621371;
        return milesconvert;
    }
}

class Program{
    static void Main(string[]args){
        Converter converter = new Converter();
        
        Console.WriteLine("Converter Calculator");
        Console.WriteLine("--------------------\n");
        Console.WriteLine("1. Kilometers to Miles");
        Console.WriteLine("2. Miles to Kilometers");
        Console.WriteLine("3. Celcius to Fahrenheit");
        Console.WriteLine("4. Fahrenheit to Celcius");
        Console.WriteLine("5. US Dollars to Philippine Peso");
        Console.WriteLine("6. Philippine Peso to US Dollars\n");
        Console.WriteLine("Enter your choice: ");
        string choice = Console.ReadLine();
        
        switch(choice){
            case("1"):
            converter.ConvertKilometersToMiles();
            break;
        }
    }
}

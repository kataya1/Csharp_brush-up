using System;
using CsharpOOP;
using CustomeTypes;
using generics;
using shapes;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Csharpbasics
{
    class Program
    {
        // static void Main(string[] args){
            // comment
            /* multi line comment */


            // // consol let your use consol writeline writes in consol
            // Console.Write("what's your name ?");
            // //user inpur
            // string name = Console.ReadLine();
            // Console.WriteLine("hello " + name );

            //data types
            /*  bool canVote = true;
            char grade = 'A';
            string s = "int, long, decimal,float,double";// max value int.MaxValue
            var anotherName ="Tom"; //you can't change var later
            Console.WriteLine("anotherName is {0} and it's typep is {1}", anotherName,anotherName.GetType());*/

            // //castine
            // var pi = 3.14;
            // int intPi = (int)pi;

            // //math functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sing, Sinh, Tan, Tanh
            // Math.Abs(number) Math.(Ceiling, Floor, Max, Min, Pow, Round, Sqrt)
            // Random rand = new Random(); rand.Next(1,11) //to generate a random number between 1 and 10
            // Logical Operators: && || ^ !  // condionals < > == <= >=

            // // IF STATEMENT
            // if ( && )
            // {}
            // else if (){}
            // else {}

            // // terniary operation
            // int age = 15;
            // // canDrive = (condition)? true : false; // if condtion true Candrive = first else second
            // bool canDrive = age >= 16? true : false;

            //     //switch
            //    int age = Convert.ToInt32(Console.ReadLine());
            //     switch(age)
            //     {
            //         case 0:
            //             Console.WriteLine("infant");
            //             break;
            //         case 1:
            //             break;
            //         case 2:
            //             Console.Write("Toddler");
            //             // goto cute;
            //             break;
            //         default:
            //             Console.WriteLine("immortal beeing");
            //             break;
            //     }
            //     // cute:
            //     // Console.WriteLine("todlers are cure");

            // // // // // Looping
            // // // // int i = 0;
            // // // // while(i<10)
            // // // // {
            // // // //     i++;
            // // // //     continue;
            // // // //     break;
            // // // // }
            // // // string guess;
            // // // do
            // // // {
            // // //     Console.WriteLine("guess a number");
            // // //     guess = Console.ReadLine();
            // // // }while(!guess.Equals("15"));
            // //
            // // for(int i = 0; i<10 ; i++)
            // // {
            // //     if(i%2 == 0)
            // //         Console.WriteLine(i);
            // // }
            // string  randstring = "here is a random string mama";
            // foreach(char c in randstring)
            // {
            //     Console.Write("\b" + c + " ");
            // }

            // //strings
            // string[] names = new string[3]{"matt", "joe", "3anter"};
            // string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}",1.56,15.567,.56,1000);
            // Console.Write(fmtStr);
            // console.writeline(String.isNullOrEmpty(fmtstr))

            // //StringBuilders
            // StringBuilder sb = new StringBuilder();
            // sb.Append("first aaaa ");
            // sb.AppendFormat("{0:c} {1:00.00} {2:#.00} {3:0,0}",1.56,15.567,.56,1000);
            // sb.Replace("a","e");
            // Console.WriteLine(sb);

            // // ARRAYS
            // int[] randNumarray;
            // int[] randArray = new int[3];
            // int[] arr = {1,2,3,4,5};
            // //searches for 1 in the array and return the index
            // Console.WriteLine("where is 1"+ Array.IndexOf(arr,1));
            // string[] names = new string[3]{"matt", "joe", "3anter"};
            // string joinedstrings = string.Join(",",names);
            // string[] nameArray = joinedstrings.Split();
            // //two dimensional array
            // int[,] multArray = new int[5,3];
            // int[,] multarray2 = {{2,3},{8,6}}; // 2x2
            // Console.WriteLine(multarray2[1,1]);
            // Console.WriteLine(multarray2[0,1]);
            // Console.WriteLine(multarray2[1,0]);
            // Console.WriteLine(multarray2.GetLength(0));//rows
            // Console.WriteLine(multarray2.GetLength(1));//collomn

            // //LISTS😁 .lists auto resize unlike an array
            // List<int> numlist = new List<int>();
            // numlist.Add(7);
            // int[] arr = {1,2,3,4,5};
            // numlist.AddRange(arr);
            // // numlist.Clear();
            // // copy ana array into a list
            // List<int> n2 = new List<int>(arr);
            // List<int> n3 = new List<int>(new int[]{1,2,3});
            // //insert into a specific index (index,data)
            // numlist.Insert(1,10);
            // //remove element
            // numlist.Remove(5);
            // //remove at a specific index
            // numlist.RemoveAt(3);
            // //get list length
            // int len = numlist.Count;
            // // return the index of an element returns -1 if there'nt any
            // int returN = numlist.IndexOf(4);

            // // exception 🐱‍🚀🐱‍
            // try{
            //     Console.Write("Divide 10 by ");
            //     int num = int.Parse(Console.ReadLine());
            //     Console.WriteLine((10/num));
            // }
            // catch(DivideByZeroException ex)
            // {
            //     Console.WriteLine("Can't divide by zero");
            //     Console.WriteLine(ex.GetType().Name);
            //     Console.WriteLine(ex.Message);
            //     // throw new InvalidOperationException
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine(ex.GetType().Name);
            //     Console.WriteLine(ex.Message);
            // }}




    }
}


namespace CsharpOOP
{
    class Animal
    {
        public  double height{ get; set; } // C# has convinient way of making getters and setters
        public double weight{ get; set; }
        public string sound { get; set; }

        // we're gonna call something static when it doesn't make since for the object to perform those operation but we wanna have it for the class
        // static fields
        static int numOfAnimals = 0;
        public string name;//we could do our own setters and getters
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No name";
            this.name = "soundless";
            numOfAnimals++;
        }
        public Animal(double height, double weight,string name, string sound )
        {
            this.height = height ;
            this.weight = weight ;
            this.sound = sound  ;
            this.name = name;
            numOfAnimals++;
        }
        public static int getNumOfAnimals() => numOfAnimals;

        public string toString()
        {
            return string.Format("{0} is {1} inches tall, weight {2} lbs and says {3}", name, height, weight, sound);
        }
        public int getSum(int num = 1, int num2 = 1) => num + num2;
        // method overloading
        public double getSum(double num, double num2) => num + num2;


    }
    // inheretance
    class Dog : Animal
    {
        public string favFood {get;set;}
        //letting the parent class take care of init
        public Dog():base()
        {
            this.favFood = "he has no fav food";
        }
        public Dog(double height, double weight,string name, string sound, string favFood ) : base(height,weight,name,sound)
        {
            this.favFood = favFood;
        }
        //overiding we type new
        new public string toString()
        {
            return string.Format("new overrider {0}",favFood);
        }
    }

}
namespace shapes
{
    
    abstract class shape
    {
        // you can inherit only one abstract class per class
        // and you define methods in the abstract to be defined
        // you can't instantiate an object out of an abstract class
        public abstract double area(); // so depending on the shape are could be pi*r^2 or x*y
        // you can also make normal methods
        public void sayHi()
        {
            Console.WriteLine("hello motherfucker!!!,we can talk now");
        }
    }
    public interface shapeitem
    {
        double area();
    }
    class Rectangle : shape
    {
        private double length;
        private double width;
        public Rectangle(double len, double wid)
        {
            this.length = len;
            this.width = wid;
        }
        

        public override double area()
        {
            return length * width;
        }
        // operator overloading overloading the plus
        // return tyep Rectangle
        public static Rectangle operator+ (Rectangle rect1 , Rectangle rect2)
        {
            // it doesn't make since 
            double rectLenght = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;
            return new Rectangle(rectLenght,rectWidth);
            
        }
    }
    class Triangle : shape
    {
        private double thebase;
        private double height;
        public Triangle(double thebase, double height)
        {
            this.thebase = thebase;
            this.height = height;
        }

        public override double area()
        {
            return 0.5*(thebase*height);
        }
    }
}
namespace generics //generics
{
    //WITH GENERICS YOU DON'T HAVE TO SPECIFY THE DATA TYPE OF AN ELEMENT IN A CLASS OR IN A METHOD
    class KeyValue<TKey, TValue>{// what an idiotic shit instead of having data inference you want to have this
        public TKey key{get; set;}
        public TValue value {get; set;}
        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void showData()
        {
            Console.WriteLine("key and value are {0}, {1} ", this.key, this.value);
        }

        
         

    }
}
namespace CustomeTypes // or UniqueTypes
{
    // //enumerated types, gonna have sumpolic names and associated values. -i'm getting a python dictionary vibe here-
    // public enum Temperature{ // so tempreture is the name
    //     // and the rest is the values
    //     freeze,
    //     low,
    //     Warm,
    //     Boil
    //     //it's not exactly python dict
    // }
    struct Customers// you might be asking why structs when we have classes, well fuck you and fuck off
    {
        private string name;
        private double balance;
        private int id;

        public void createcust(string n, double b, int i){
            name =n;
            balance = b;
            id = i;
        }
        //  LIKE A FUCKING MINI CLASS, I'M GONNA HAVE PIZZA
        public void showCust(){
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("id " + id);

        }
    }
}

namespace printer
{
    class runner{
        static void Main(string[] args)
        {
            // // Animal spikey; creates a variable of type Animal/*  */
            // // new Animal(); instantiates an instance of a class (object)(unique identity) from class Animal
            // // Animal spikey = new Animal() refares to that object by a variable named spikey
            // Animal DogSpikey = new Animal(15, 10, "spikey","woof woof");
            // Console.WriteLine(DogSpikey.name + " says " + DogSpikey.sound);
            // Console.WriteLine("number of animals created " + Animal.getNumOfAnimals());
            // Console.WriteLine(DogSpikey.toString());
            // Console.WriteLine("{0}  {1}",DogSpikey.getSum(num2: 90, num:6 ) ,DogSpikey.getSum(4,2.2));
            // Dog spot = new Dog();
            // Console.WriteLine(spot.toString());

            // shapes 🐱‍🚀
            // shape rect = new Rectangle(5,5);
            // shape tri = new Triangle(5,5);
            // Console.WriteLine("REct" + rect.area());
            // Console.WriteLine("tri" + tri.area());

            // Rectangle combinedrect = new Rectangle(5,5) + new Rectangle(5,5);
            // // it's wrong dumb teach
            // Console.WriteLine("combrect " + combinedrect.area());

            // //generics 😒
            // KeyValue<string,string> superman = new KeyValue<string, string>("","");
            // superman.key = "Superman";
            // superman.value = "clark kent";

            // KeyValue<int,string> kataya = new KeyValue<int, string>(0,"");
            // kataya.key = 3362;
            // kataya.value = "mohamed mahmoud";

            // superman.showData();
            // kataya.showData();

            // //enums 😘
            // Temperature micrometerTemp = Temperature.low;
            // switch(micrometerTemp)
            // {
            //     case Temperature.low:
            //         Console.Write("temp is low");
            //         break;
            //     default: 
            //         Console.Write("the device broke pal!!");
            //         break;
            // }   

            // structs 💋
            Customers cust1 = new Customers();
            cust1.createcust("Bob",42060,300);
            cust1.showCust();
        }
    }
}
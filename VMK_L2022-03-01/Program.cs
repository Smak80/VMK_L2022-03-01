// See https://aka.ms/new-console-template for more information
using VMK_L2022_03_01;

void ShowC(Class1 cl){
    Console.WriteLine("Counter={0}, A={1}", Class1.ObjCount, cl.A);
}

void ShowS(Struct1 st)
{
    Console.WriteLine("Counter={0}, A={1}", Struct1.ObjCount, st.A);
}

Console.WriteLine("Для класса:");
Console.WriteLine("Counter={0}", Class1.ObjCount);
var c = new Class1();
//Console.WriteLine("A={0}", c.A);
Console.WriteLine("Counter={0}", Class1.ObjCount);
var d = new Class1();
Console.WriteLine("Counter={0}", Class1.ObjCount);
ShowC(c);
Console.WriteLine("Для структуры:");
Console.WriteLine("Counter={0}", Struct1.ObjCount);
var s = new Struct1();
Console.WriteLine("Counter={0}", Struct1.ObjCount);
ShowS(s);

Console.WriteLine("Комплексные числа:");
Console.WriteLine(new Complex(3, 5));
var z1 = new Complex(-1, 4);
var z2 = new Complex(1, -3);
var z3 = z1.Plus(z2);
Console.WriteLine(z3);
var z4 = Complex.Plus(z1, z2);
Console.WriteLine(z4);
var z5 = z1 + z2 + z3;
var a = 3 + 5;
Console.WriteLine(z5);
var z6 = z1 * z2;
Console.WriteLine(z6);
var z7 = z6 * 2;
Console.WriteLine(z7);
var z8 = 2 * z6;
Console.WriteLine(z8);
var z9 = z1 - z2;
Console.WriteLine(z9);
//var z10 = -z1;
abstract class Figura
{
    public int x, y, l, a;
    public string Color;
    public Figura (int x, int y, int l, int a, string c){this.x=x; this.y=y; this.l=l; this.a=a; Color=c;}
    public abstract void Dibuja();
    public abstract int Area();
}

class Rectangulo:Figura
{
    public Rectangulo (int x, int y, int l, int a, string c):base(x, y, l, a, c){}
    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un rectángulo");
    }
    public override int Area()
    {
        return Math.l*a;
    }
}

class Circulo:Figura
{
    public double Diametro {get;set;}
    public Circulo (int x, int y, int l, int a, string c, int d):base(x, y, l, a, c){Diametro=d;}
    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un círculo");
    }
    public override int Area()
    {
        
        return Math.PI(Diametro/2)^2;
    }
}

class Triangulo:Figura
{
    public int b, h;
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
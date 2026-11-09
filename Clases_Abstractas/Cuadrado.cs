public class Cuadrado : Figura
{
    public int L { get; set; }

    public Cuadrado(int l)
    {
        L = l;
    }

    public override double CalcularArea()
    {
        return L * L;
    }

    public override double CalcularPerimetro()
    {
        return 4 * L;
    }
}
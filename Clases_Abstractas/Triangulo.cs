public class Triangulo : Figura
{
    public int L1 { get; set; }
    public int L2 { get; set; }
    public int L3 { get; set; }
    public int Alt { get; set; }

    public Triangulo(int l1, int l2, int l3, int alt)
    {
        L1 = l1;
        L2 = l2;
        L3 = l3;
        Alt = alt;
    }

    public override double CalcularArea()
    {
        return L1 * Alt / 2.0;
    }

    public override double CalcularPerimetro()
    {
        return L1 + L2 + L3;
    }
}
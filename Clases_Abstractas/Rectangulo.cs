public class Rectangulo : Figura
{
    public int Ancho { get; set; }
    public int Alto { get; set; }

    public Rectangulo(int an, int al)
    {
        Ancho = an;
        Alto = al;
    }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Ancho + Alto);
    }
}
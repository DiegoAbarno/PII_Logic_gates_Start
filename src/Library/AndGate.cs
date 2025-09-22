namespace Library;

public class AndGate
{
    private string nombre;
    private List<int> entrada;
    private int salida;

    public string Nombre
    {
        get { return this.nombre; }
        private set { this.nombre = value; }
    }
    
    public List<int> Entrada
    {
        get { return this.entrada; }
        set { this.entrada = value; }
    }

    public int Salida
    {
        get { return this.salida; }
        private set { this.salida = value; }
    }

    public AndGate(string nombre)
    {
        this.Nombre = nombre;
        this.Entrada = new List<int>();
        this.Salida = 0;
    }

    public void Evaluar()
    {
        if (this.entrada.Contains(0))
        {
            this.salida = 0;
        }
        else
        {
            this.salida = 1;
        }
    }

    public void AgregarEntradas(int entrada)
    {
        this.entrada.Add(entrada);
    }
    
}

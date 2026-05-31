namespace CadastroEventosMauiApp.Models;

public class Evento
{
    public string NomeEvento { get; set; } = "";

    public string LocalEvento { get; set; } = "";

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }

    public int NumeroParticipantes { get; set; }

    public double CustoPorParticipante { get; set; }

    public int DuracaoDias
    {
        get
        {
            TimeSpan diferenca = DataFim - DataInicio;
            return diferenca.Days;
        }
    }

    public double CustoTotal
    {
        get
        {
            return NumeroParticipantes * CustoPorParticipante;
        }
    }
}
using CadastroEventosMauiApp.Models;

namespace CadastroEventosMauiApp.Views;

public partial class CadastroEvento : ContentPage
{
    Evento evento = new();

    public CadastroEvento()
    {
        InitializeComponent();

        BindingContext = evento;
    }

    private async void Cadastrar_Clicked(object sender, EventArgs e)
    {
        evento.NomeEvento = txtNome.Text ?? "";
        evento.LocalEvento = txtLocal.Text ?? "";

        // Conversão das datas
        evento.DataInicio = dtInicio.Date.GetValueOrDefault();
        evento.DataFim = dtFim.Date.GetValueOrDefault();

        int.TryParse(txtParticipantes.Text, out int participantes);
        evento.NumeroParticipantes = participantes;

        double.TryParse(txtCusto.Text, out double custo);
        evento.CustoPorParticipante = custo;

        await Navigation.PushAsync(
            new ResumoEvento(evento));
    }
}
using CadastroEventosMauiApp.Models;

namespace CadastroEventosMauiApp.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento(Evento evento)
    {
        InitializeComponent();

        lblNome.Text = evento.NomeEvento;

        lblLocal.Text =
            $"Local: {evento.LocalEvento}";

        lblParticipantes.Text =
            $"Número de Participantes: {evento.NumeroParticipantes}";

        lblInicio.Text =
            $"Data de Início: {evento.DataInicio:dd/MM/yyyy}";

        lblFim.Text =
            $"Data de Término: {evento.DataFim:dd/MM/yyyy}";

        lblDuracao.Text =
            $"Duração do Evento: {evento.DuracaoDias} dia(s)";

        lblCustoParticipante.Text =
            $"Custo por Participante: R$ {evento.CustoPorParticipante:N2}";

        lblTotal.Text =
            $"R$ {evento.CustoTotal:N2}";
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
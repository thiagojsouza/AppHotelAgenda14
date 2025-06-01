using System;
using Microsoft.Maui.Controls;

namespace AppHotelAgenda14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            string nome = entryNome.Text;
            DateTime dataEntrada = pickerDataEntrada.Date;
            string tipoQuarto = pickerTipo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nome))
            {
                await DisplayAlert("Erro", "Por favor, digite o nome do cliente.", "OK");
                return;
            }

            if (string.IsNullOrEmpty(tipoQuarto))
            {
                await DisplayAlert("Erro", "Por favor, selecione o tipo de quarto.", "OK");
                return;
            }

            var cliente = new Cliente
            {
                Nome = nome,
                DataEntrada = dataEntrada,
                TipoQuarto = tipoQuarto
            };

            await Navigation.PushAsync(new Resumo(cliente));
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public string TipoQuarto { get; set; }
    }
}

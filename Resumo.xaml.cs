using System;
using Microsoft.Maui.Controls;

namespace AppHotelAgenda14
{
    public partial class Resumo : ContentPage
    {
        public Resumo(Cliente cliente)
        {
            InitializeComponent();

            labelResumo.Text =
                $"Reserva confirmada para:

" +
                $"Nome: {cliente.Nome}
" +
                $"Data de Entrada: {cliente.DataEntrada:dd/MM/yyyy}
" +
                $"Tipo de Quarto: {cliente.TipoQuarto}

" +
                $"Desenvolvido por: Thiago J. Souza - 2024";
        }
    }
}

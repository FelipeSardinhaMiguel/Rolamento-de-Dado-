using AtividadeRolarDado.Models;
using Microsoft.Maui.Controls.Internals;

namespace AtividadeRolarDado
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void RolarBtn_Clicked(object sender, EventArgs e)
        {

            /*int lados = Convert.ToInt32(NumPicker.SelectedItem);
            int valor;

            Random random = new();
            valor = random.Next(1, lados + 1);*/

            Dado dado = new Dado(67);
            ExibirNumeroLabel.Text = Convert.ToString(dado.LadoSorteado);

        }
    }
}
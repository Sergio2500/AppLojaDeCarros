using App2MobileApp.Models;
using App2MobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo Veiculo { get; set; }


        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();

            //this.Title = veiculo.Nome;

            this.Veiculo = veiculo;

            this.BindingContext = new DetalhesViewModel(veiculo);
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}
using App2MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2MobileApp.Views
{


    // Learn more about making custom code visible in the Xamarin.Forms previewer  
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {

        public ListagemView()
        {
            InitializeComponent();



            //listViewVeiculos.ItemsSource = this.Veiculos;

            //this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //DisplayAlert("TestDrive", string.Format("Você tocou no modelo {0}, cujo preço é {1}", veiculo.Nome, veiculo.PrecoFormatado), "ok");


            Navigation.PushAsync(new DetalhesView(veiculo));

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado",
                (msg) =>
                {
                    Navigation.PushAsync(new DetalhesView(msg));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
        }






    }
}

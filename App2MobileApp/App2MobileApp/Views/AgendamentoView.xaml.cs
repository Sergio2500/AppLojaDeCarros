using App2MobileApp.Models;
using App2MobileApp.ViewModel;
//using static App2MobileApp.Models.Agendamento;
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
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel agendamentoViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            //this.Veiculo = veiculo;
            this.agendamentoViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.agendamentoViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", 
                string.Format(
                    @"
                    Nome: {0} 
                    Fone: {1} 
                    Email: {2}  
                    Data: {3} 
                    Horário: {4}", agendamentoViewModel.agendamento.Veiculo.Nome,
                    agendamentoViewModel.agendamento.Fone, 
                    agendamentoViewModel.agendamento.Email, 
                    agendamentoViewModel.agendamento.DataAgendamento.ToString("dd/MM/yyyy"),
                    agendamentoViewModel.agendamento.HoraAgendamento), "OK");
        }
    }
}
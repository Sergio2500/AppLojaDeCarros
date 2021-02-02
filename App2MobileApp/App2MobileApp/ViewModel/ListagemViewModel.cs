using App2MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2MobileApp.ViewModel
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }
        //public Veiculo VeiculoSelecionado { get; set; }

        private Veiculo veiculoSelecionado;

        public Veiculo VeiculoSelecionado
        {
            get { return veiculoSelecionado; }
            set 
            { 
                veiculoSelecionado = value;
                if(value != null)
                {
                    MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado");
                }
                
            }
        }



        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }



    }
}

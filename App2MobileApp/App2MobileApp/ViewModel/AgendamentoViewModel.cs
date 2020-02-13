using App2MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2MobileApp.ViewModel
{
    public class AgendamentoViewModel
    {
        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.agendamento = new Agendamento();
            this.agendamento.Veiculo = veiculo;
        }

        public Agendamento agendamento { get; set; }

        //Agendamento agendamento = new Agendamento();
        //public ListagemVeiculos listagemVeiculos { get; set; }
        public Veiculo Veiculo
        {
            get { return agendamento.Veiculo; }
            set { agendamento.Veiculo = value; }
        }
        public string Nome
        {
            get { return agendamento.Nome; }
            set { agendamento.Nome = value; }
        }
        public string Fone
        {
            get { return agendamento.Fone; }
            set { agendamento.Fone = value; }
        }
        public string Email
        {
            get { return agendamento.Email; }
            set { agendamento.Email = value; }
        }

        //private DateTime dataAgendamento = DateTime.Today;

        public DateTime DataAgendamento
        {
            get { return agendamento.DataAgendamento; }
            set { agendamento.DataAgendamento = value; }
        }

        public TimeSpan HoraAgendamento
        {
            get { return agendamento.HoraAgendamento; }
            set { agendamento.HoraAgendamento = value; }
        }

    }
}

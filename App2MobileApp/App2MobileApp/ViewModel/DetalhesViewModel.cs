using App2MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2MobileApp.ViewModel
{
    public class DetalhesViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }

        public string TextoFreioAbs
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", Veiculo.Freio_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get { return string.Format("Ar-Condicionado - R${0}", Veiculo.Ar_Condicionado); }
        }

        public string TextoMp3Player
        {
            get { return string.Format("MP3 Player - R${0}", Veiculo.Mp3_Player); }
        }


        public bool TemFreioAbs
        {
            get
            {
                return Veiculo.TemFreioAbs;
            }
            set
            {
                Veiculo.TemFreioAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArCondicionado
        {
            get { return Veiculo.TemArCondicionado; }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemMp3Player
        {
            get { return Veiculo.TemMp3Player; }
            set
            {
                Veiculo.TemMp3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

        public DetalhesViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name="")
        {
            //CallerMemberName garante que o valor da variável seja o mesmo da propriedade que chama o método
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ProximoCommand { get; set; }


    }
}

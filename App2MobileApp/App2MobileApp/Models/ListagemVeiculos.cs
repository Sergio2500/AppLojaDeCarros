﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App2MobileApp.Models
{
    
    public class ListagemVeiculos
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemVeiculos()
        {
            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo { Nome = "Azera V6", Preco = 60000},
                new Veiculo { Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo { Nome = "HB20s", Preco = 40000}
            };
        }   
        
    }
}

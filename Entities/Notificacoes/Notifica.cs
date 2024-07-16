﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
    public class Notifica
    {

        public Notifica()
        {
            Notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }
        [NotMapped]
        public string Mensagem { get; set; }
        [NotMapped]
        public List<Notifica> Notificacoes { get; set; }

        public bool ValidarPropriedadeString(string valor, string nomeProprieade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomeProprieade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomeProprieade
                });

                return false;
            }

            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomeProprieade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomeProprieade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomeProprieade
                });

                return false;
            }

            return true;
        }
    }
}

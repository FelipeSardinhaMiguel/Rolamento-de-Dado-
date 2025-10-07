using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeRolarDado.Models
{
    public class Dado
    {
        private int qteLados;
        private int ladoSorteado;

        //Método construtor
        public Dado(int lados)
        {
            qteLados = lados;
        }

        public int LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public void Rolar()
        {
            //Aventura vai começar
            //Well meet agian, dont know where, dont know when, but I know well meet again, some sunny day.
            LadoSorteado = Random.Shared.Next(1, qteLados + 1);
            


        }
    }
}
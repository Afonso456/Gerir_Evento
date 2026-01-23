using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    internal class Evento
    {
        public static List<Participante> listaParticipantes = new List<Participante>();
        public static List<Evento> listaEventos = new List<Evento>();

        public const int CAPACIDADE_MIN = 15;
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        int capacidadeMax;
        public int CapacidadeMax
        {
            get { return capacidadeMax; }
            set
            {
                if (IsValidCapacidadeMaxl(value))
                    capacidadeMax = value;
                else
                    capacidadeMax = CAPACIDADE_MIN;
            }
        }

        public Evento(string _nome, DateTime _data, int _capacidadeMax)
        {
            Nome = _nome;
            Data = _data;
            CapacidadeMax = _capacidadeMax;
        }

        public static bool IsValidCapacidadeMaxl(int capacidade)
        {
            bool valido = true;

            if (capacidade < 1)
            {
                valido = false;
            }

            return valido;
        }

        public static bool VerificaInscricao()
        {
            bool podeinscrever = true;

            if (listaParticipantes.Count >= Evento.CAPACIDADE_MIN)
                podeinscrever = false;
            else
                podeinscrever = true;
            return podeinscrever;
        }

        static Evento()
        {

        }
    }
}

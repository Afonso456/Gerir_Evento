using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    static class Dados
    {
        public static string appname = "Evento Tecnologia";
        public static string version = "1.0.0";
        public static BindingList<Participante> Participante = new BindingList<Participante>();
        public static BindingList<Evento> Evento = new BindingList<Evento>();

        //Funções para ler e guardar os dados dos eventos e participantes usando arquivos JSON
        private static string ficheiroEventos = "eventos.json";
        private static string ficheiroParticipantes = "participantes.json";

        public static void GuardarEventos(BindingList<Evento> eventos)
        {

            var json = JsonSerializer.Serialize(eventos.ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("eventos.json", json);
        }
        public static BindingList<Evento> LerEventos()
        {
            if (!File.Exists(ficheiroEventos))
                return new BindingList<Evento>();

            string json = File.ReadAllText(ficheiroEventos);
            var lista = JsonSerializer.Deserialize<List<Evento>>(json);

            return new BindingList<Evento>(lista ?? new List<Evento>());
        }

        public static void GuardarParticipantes(BindingList<Participante> participantes)
        {
            var json = JsonSerializer.Serialize(participantes.ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("participantes.json", json);
        }
        public static BindingList<Participante> LerParticipantes()
        {
            if (!File.Exists(ficheiroParticipantes))
                return new BindingList<Participante>();

            string json = File.ReadAllText(ficheiroParticipantes);
            var lista = JsonSerializer.Deserialize<List<Participante>>(json);

            return new BindingList<Participante>(lista ?? new List<Participante>());
        }
    }
}

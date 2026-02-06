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
        public static BindingList<Participante> participante = new BindingList<Participante>();
        public static BindingList<Evento> evento = new BindingList<Evento>();

        private static string ficheiroEventos = "eventos.json";
        private static string ficheiroParticipantes = "participantes.json";

        static Dados()
        {
            /*participantes de exemplo
            participante.Add(new Participante("Ana Silva", 22, "anasilva@gmail.com"));
            participante.Add(new Participante("Marco Paulo", 35, "paulo@gmail.com"));
            participante.Add(new Participante("Antonio Costa", 50, "costaantonio@gmail.com"));

            //evento de exemplo
            evento.Add(new Evento("Festa de Tecnologia", new DateTime(2024, 11, 15), 10));
            evento.Add(new Evento("Evento", new DateTime(2027, 2, 23), 5));*/
        }

        public static BindingList<Evento> LerEventos()
        {
            if (!File.Exists(ficheiroEventos))
                return new BindingList<Evento>();

            string json = File.ReadAllText(ficheiroEventos);
            var lista = JsonSerializer.Deserialize<List<Evento>>(json);

            return new BindingList<Evento>(lista ?? new List<Evento>());
        }

        public static void GuardarEventos(BindingList<Evento> eventos)
        {
            var json = JsonSerializer.Serialize(evento.ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(ficheiroEventos, json);
        }

        public static BindingList<Participante> LerParticipantes()
        {
            if (!File.Exists(ficheiroParticipantes))
                return new BindingList<Participante>();

            string json = File.ReadAllText(ficheiroParticipantes);
            var lista = JsonSerializer.Deserialize<List<Participante>>(json);

            return new BindingList<Participante>(lista ?? new List<Participante>());
        }

        public static void GuardarParticipantes(BindingList<Participante> participantes)
        {
            var json = JsonSerializer.Serialize(participantes.ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(ficheiroParticipantes, json);
        }
    }
}

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

        //função para guardar os dados em ficheiros JSON
        public static void GuardarDados()
        {
            string jsonStringe = JsonSerializer.Serialize(evento);
            string jsonStringp = JsonSerializer.Serialize(participante);

            string fileNamep = "participantes.json";
            File.WriteAllText(fileNamep, jsonStringp);

            string fileName = "eventos.json";
            File.WriteAllText(fileName, jsonStringe);

        }

        //função para carregar os dados de um ficheiro JSON para a datagridview
        public static void CarregarDados()
        {
            
        }
    }
}

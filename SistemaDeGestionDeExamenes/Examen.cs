using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes
{
    public class Examen
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string Fecha { get; set; }
        public string Asignatura { get; set; }

        public List<PreguntaId> PreguntasId { get; set; } = new List<PreguntaId>();

        public void AgregarPreguntaId(string id)
        {
            PreguntasId.Add(new PreguntaId(id));
        }

        public List<PreguntaId> ObtenerPreguntasId()
        {
            return PreguntasId;
        }
    }

    public class PreguntaId
    {
        public string Id { get; set; }

        public PreguntaId(string id)
        {
            Id = id; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteCurso
{
    internal class ReporteCurso
    {
        public readonly List<ReporteCursoEntrada> entradas;
           
        public ReporteCurso()
        {
            entradas = new List<ReporteCursoEntrada>();
        }

        public void AgregarEntrada(ReporteCursoEntrada reporteCursoEntrada)
        {
            entradas.Add(reporteCursoEntrada);
        }

        public void EliminarEntrada(ReporteCursoEntrada reporteCursoEntrada)
        {
            entradas.Add(reporteCursoEntrada);
        }

        public void GuardarArchivo(string directorioRuta, string nombrearchivo)
        {
            if (!Directory.Exists(directorioRuta))
            {
                Directory.CreateDirectory(directorioRuta);
            }
            File.WriteAllText(Path.Combine(directorioRuta, nombrearchivo), ToString());
        }

        //public override string 
    }
}

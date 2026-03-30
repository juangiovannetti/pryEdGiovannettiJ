using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agrego una libreria 
//Permite procesar el archivo
using System.IO;
namespace pryEdGiovannettiJ
{
    internal class clsArchivo
    {
        //Hemos creado un campo
        public String NomArchi = "colores.txt";



        public void Grabar()
        {
            //abri archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("HOLA!!!");
            AD. Close();
        
        }

        public void Grabar( String Dato )
        {
            //abri archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();

        }
    }
   
}

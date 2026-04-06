using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agrego una libreria 
//Permite procesar el archivo
using System.IO;
using System.Windows.Forms;
namespace pryEdGiovannettiJ
{
    internal class clsArchivo
    {
        //Hemos creado un campo
        public String NomArchi = "";



        public void Grabar()
        {
            //abri archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("HOLA!!!");
            AD.Close();

        }

        public void Grabar(String Dato)
        {
            //abri archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();

        }

        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido += AD.ReadLine();
            while (DatoLeido != null)
            {
                //Aca van las lineas de codigo que hagan falta
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();


        }

        public void Recorrer(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido += AD.ReadLine();
            while (DatoLeido != null)
            {
                //Aca van las lineas de codigo que hagan falta
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();

        }

        public void Recorrer(ComboBox cmbDatos)
        {
            cmbDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido += AD.ReadLine();
            while (DatoLeido != null)
            {
                //Aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
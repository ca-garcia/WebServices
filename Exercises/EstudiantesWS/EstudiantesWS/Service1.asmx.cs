using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EstudiantesWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string student)
        {
            return "Hello " + student + ". Bienvenido a nuestro centro.";
        }

        [WebMethod]
        public bool DerechoExamen(string name)
        {
            if (Promedio(name) >= 3)
                return true;
            else
                return false;
        }

        [WebMethod]
        public bool ExisteEstudiante(string name)
        {
            //List<Estudiante> list = getAllStudents();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list.ElementAt(i).getName() == name)
            //        return true;
            
            //}
            //    return false;

            if (getStudent(name) != null)
                return true;
            else
                return false;

        }

        [WebMethod]
        public string FormatoCorrecto(string ci)
        {
            if (ci.Length < 11 || ci.Length > 11)
                return "Longitud del CI incorrecta.";

            try{
             Int64.Parse(ci);
            }             
            catch(Exception e){
                return "El CI no puede contener letras o simbolos.";
            }

            int anno = Int32.Parse(ci.Substring(0, 2));
            int mes = Int32.Parse(ci.Substring(2, 2));
            int dia = Int32.Parse(ci.Substring(4, 2));

            DateTime fecha = new DateTime(anno, mes, dia);

            return fecha.ToString("dd/MM/yy");
        }

        [WebMethod]
        public float Promedio(string name)
        {
            Estudiante est = getStudent(name);
            return est.Average();
        }

        List<Estudiante> getAllStudents()
        {
            List<Estudiante> list = new List<Estudiante>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            { 
                notas notes = new notas();
                notes.es = rand.Next(2, 5);
                notes.mat = rand.Next(2, 5);
                notes.ing = rand.Next(2, 5);
                notes.hist = rand.Next(2, 5);
                notes.geo = rand.Next(2, 5);

                Estudiante stud = new Estudiante("Estudiante " + i, "8712150618"+i, notes);
                list.Add(stud);
            }

            return list;
        }

        Estudiante getStudent(string name)
        {
            List<Estudiante> list = getAllStudents();

            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).getName() == name)
                    return list.ElementAt(i);
            }

            return null;
        
        }

        //DateTime showBirthDate()
        //{ 

        
        //}



    }
}
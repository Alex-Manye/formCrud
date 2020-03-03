using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Presentation.WinSite
{
    class StudentFileXml
    {
        private static void Linq2XmlCrearFicheroXml()
        {
            XElement xml =
              new XElement("Students",
                new XElement("Student",
                  new XElement("StudentId", "0001"),
                  new XElement("Name", "Juan"),
                  new XElement("LastName", "Pérez"),
                  new XElement("Telefono", new XAttribute("Tipo", "Trabajo"), "911111111")),
                new XElement("Contacto",

              );

            XDocument contactosXml = new XDocument(xml);
            contactosXml.Save("Contactos.xml");
        }

    }
}

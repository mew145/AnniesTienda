using System.IO;
using System;
using System.Windows;
using System.Windows.Markup;

namespace Annies_Store.SCS
{
    public class Temas
    {
        public ResourceDictionary CargarTema()
        {
            string tema=Properties.Settings.Default.Tema;
            ResourceDictionary newres;
            if (tema==null)
            {
                tema = "Pink";
                Properties.Settings.Default.Save();
            }
            string ubicacion = "SCS/Themes/"+tema+".xaml";

            if (File.Exists(@"" + tema + ".xaml"))
            {
                newres = new ResourceDictionary
                {
                    Source = new Uri(ubicacion, UriKind.Relative)
                };
            }
            else
            {
                newres = new ResourceDictionary
                {
                    Source = new Uri(ubicacion, UriKind.Relative)
                };

                var settings = new System.Xml.XmlWriterSettings
                {
                    Indent = true
                };
                var writer = System.Xml.XmlWriter.Create(@""+tema+".xaml", settings);
                XamlWriter.Save(newres, writer);
            }

            return newres;
        }
    }
}

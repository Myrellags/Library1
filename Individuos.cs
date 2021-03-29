using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Library1
{
    public class Individuos : IOperations
    {
        private List<Individuo1> _lista;//atributos - na prática dentro da clase utilizar o atributo fora as propriedades

        public List<Individuo1> Items//propriedade
        {
            get { return _lista; }
            set { _lista = value; }
        }

        public Individuos()
        {
            _lista = new List<Individuo1>();//quando um objeto ou propriedade inicializar isnull, criamos
            //um construtor para inicializarmos as propriedades;

        }

        public void FromJson(string json)
        {
            _lista = JsonConvert.DeserializeObject<List<Individuo1>>(json);
        }

        public void FromXML(string xml)
        {
            XmlSerializer x = new XmlSerializer(typeof(Individuo1));//quando eu quero buscar através da definicao de uma classe o mesmo que this.GetType
            StringReader sr = new StringReader(xml);
            XmlTextReader xr = new XmlTextReader(sr);
            Individuos obj = (Individuos)x.Deserialize(xr);
            sr.Close();
            this._lista = obj.Items;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(_lista);
        }

        public string ToXML()
        {
            string result = "";
            try
            {
                //Criando um arquivo XML
                XmlSerializer x = new XmlSerializer(this.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(string.Empty, string.Empty);
                using (StringWriter sw = new StringWriter())
                {
                    x.Serialize(sw, this, ns);
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.LoadXml(sw.ToString());
                    result = xDoc.DocumentElement.OuterXml;
                }
            }
            catch
            {

            }
            return result;
        }
    }
}

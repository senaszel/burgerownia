using Burgerownia.Back.Enum;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Burgerownia.Back.Model
{
    public class Ingredient : Item
    {
        [XmlElement("IsVege")]
        public bool IsVege { get; set; }
        [XmlElement("HasAlergens")]
        public bool HasAlergens => Alergens.Count > 0;
        [XmlIgnore()]
        public List<Alergen> Alergens { get; set; } = new List<Alergen>();


        public Ingredient() { }

        public Ingredient(int id, string name, double price)
            : base(id, name, price) { }


        public override string ToString() => Name;


    }
}
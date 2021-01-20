using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    class Recipe
    {
        public string Path { get; }
        public Recipe(List<Item> list)
        {
            List<Item> items = list;

            Type[] extraTypes = new Type[] { typeof(Burger), typeof(Refreshment) };
            var type = items.GetType();
            XmlSerializer serializer = new XmlSerializer(type, extraTypes);
            string dt = DateTime.Now.ToString().Replace('/', '_').Replace(' ','_').Replace(':','_');
            string folderPath = $@"{Directory.GetCurrentDirectory()}\..\..\..\..\..\Paragony";
            Path += folderPath;
            Path += @$"\Paragon_{dt}.XML";
            TextWriter writer = new StreamWriter(Path);
            serializer.Serialize(writer, items);
            writer.Close();
        }
    }
}

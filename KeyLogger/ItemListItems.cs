using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WacraftColorProgram
{

    public class ItemListItems
    {
        public String SelectedItem { set; get; }
        public List<WarcraftClass> ClassList { set; get; }
        private const string Filename = "ClassData.xml";

        public void Save()
        {
            using (var writer = new System.IO.FileStream(Filename, System.IO.FileMode.Create))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }
        }
        public static ItemListItems Load()
        {
            using (var stream = System.IO.File.OpenRead(Filename))
            {
                var serializer = new XmlSerializer(typeof(ItemListItems));
                return serializer.Deserialize(stream) as ItemListItems;
            }
        }
    }


}

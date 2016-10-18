using System.Xml.Serialization;

namespace WacraftColorProgram
{

    public class MouseLocation
    {
        public int XCoordinateSingle { set; get; }
        public int YCcoordinateSingle { set; get; }
        public int XcoordinateAoe { set; get; }
        public int YcoordinateAoe { set; get; }
        public int XcoordinateThird { set; get; }
        public int YcoordinateThird { set; get; }

        private const string Filename = "mouselocation.xml";

        public void Save()
        {
            using (var writer = new System.IO.StreamWriter(Filename))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }
        }
        public static MouseLocation Load()
        {
            using (var stream = System.IO.File.OpenRead(Filename))
            {
                var serializer = new XmlSerializer(typeof(MouseLocation));
                return serializer.Deserialize(stream) as MouseLocation;
            }
        }
    }
}

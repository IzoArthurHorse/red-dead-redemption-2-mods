using System.Collections.Generic;

namespace MapEditing.MapPersistence
{
    public class SerializableMap
    {
        public string MapName { get; set; }
        public string AuthorName { get; set; }
        public string MapDescription { get; set; }
        public IEnumerable<SerializableMapObject> MapObjects { get; set; }
    }
}

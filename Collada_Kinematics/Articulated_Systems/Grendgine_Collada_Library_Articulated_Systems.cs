using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="library_articulated_systems", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Library_Articulated_Systems
	{
		[XmlAttribute("id")]
		public string ID;

		[XmlAttribute("name")]
		public string Name;

		[XmlElement(ElementName = "articulated_system")]
		public Grendgine_Collada_Articulated_System[] Articulated_System;

		[XmlElement(ElementName = "asset")]
		public Grendgine_Collada_Asset Asset;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra; 
	}
}
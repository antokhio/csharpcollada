using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="frame_origin", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public class Grendgine_Collada_Frame_Origin
	{
		[XmlAttribute("link")]
		public string Link;

		[XmlElement(ElementName = "translate")]
		public Grendgine_Collada_Translate[] Translate;

		[XmlElement(ElementName = "rotate")]
		public Grendgine_Collada_Rotate[] Rotate;
	}
}
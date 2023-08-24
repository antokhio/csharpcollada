using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="texture", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Texture
	{
		[XmlAttribute("texture")]
		public string Texture;

		[XmlAttribute("texcoord")]
		public string TexCoord;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra;
	}
}
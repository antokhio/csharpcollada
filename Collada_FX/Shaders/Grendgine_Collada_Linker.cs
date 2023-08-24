using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="linker", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Linker
	{
		[XmlAttribute("platform")]
		public string Platform;

		[XmlAttribute("target")]
		public string Target;

		[XmlAttribute("options")]
		public string Options;

		[XmlElement(ElementName = "binary")]
		public Grendgine_Collada_Binary[] Binary;
	}
}
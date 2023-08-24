using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="annotate", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Annotate
	{
		[XmlAttribute("name")]
		public string Name;

		/// <summary>
		/// Need to determine the type and value of the Object(s)
		/// </summary>
		[XmlAnyElement]
		public XmlElement[] Data;
	}
}
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="texenv", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_TexEnv
	{
		[XmlAttribute("operator")]
		public Grendgine_Collada_TexEnv_Operator Operator;

		[XmlAttribute("sampler")]
		public string Sampler;

		[XmlElement(ElementName = "constant")]
		public Grendgine_Collada_Constant_Attribute Constant;
	}
}
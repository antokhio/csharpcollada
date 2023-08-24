using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="argument", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Argument_Alpha
	{
		[XmlAttribute("source")]
		public Grendgine_Collada_Argument_Source Source;

		[XmlAttribute("operand")]
		[System.ComponentModel.DefaultValueAttribute(Grendgine_Collada_Argument_Alpha_Operand.SRC_ALPHA)]
		public Grendgine_Collada_Argument_Alpha_Operand Operand;

		[XmlAttribute("sampler")]
		public string Sampler;
	}
}
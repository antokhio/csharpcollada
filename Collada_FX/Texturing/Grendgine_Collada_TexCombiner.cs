using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="texcombiner", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_TexCombiner
	{
		[XmlElement(ElementName = "constant")]
		public Grendgine_Collada_Constant_Attribute Constant;

		[XmlElement(ElementName = "RGB")]
		public Grendgine_Collada_RGB RGB;

		[XmlElement(ElementName = "alpha")]
		public Grendgine_Collada_Alpha Alpha;
	}
}
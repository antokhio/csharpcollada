using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="binary", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Binary
	{
		[XmlElement(ElementName = "ref")]
		public string Ref;
		
		[XmlElement(ElementName = "hex")]
		public Grendgine_Collada_Hex Hex;		
	}
}


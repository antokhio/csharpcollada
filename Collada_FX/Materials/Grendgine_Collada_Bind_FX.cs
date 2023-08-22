using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="bind", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Bind_FX
	{
		[XmlAttribute("semantic")]
		public string Semantic;
		
		[XmlAttribute("target")]
		public string Target;		
	}
}


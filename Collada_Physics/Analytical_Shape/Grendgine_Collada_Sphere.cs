using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="sphere", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Sphere
	{

		[XmlElement(ElementName = "radius")]
		public float Radius;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra;
	}
}
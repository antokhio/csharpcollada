using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="mass_frame", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Mass_Frame
	{

		[XmlElement(ElementName = "rotate")]
		public Grendgine_Collada_Rotate[] Rotate;
		

		[XmlElement(ElementName = "translate")]
		public Grendgine_Collada_Translate[] Translate;		
	}
}


using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="profile_BRIDGE", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Profile_BRIDGE : Grendgine_Collada_Profile
	{
		[XmlAttribute("platform")]
		public string Platform;
		
		[XmlAttribute("url")]
		public string URL;	
	}
}


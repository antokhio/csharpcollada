using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="library_kinematics_scene", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Library_Kinematics_Scene
	{
		[XmlAttribute("id")]
		public string ID;

		[XmlAttribute("name")]
		public string Name;

		[XmlElement(ElementName = "kinematics_scene")]
		public Grendgine_Collada_Kinematics_Scene[] Kinematics_Scene;

		[XmlElement(ElementName = "asset")]
		public Grendgine_Collada_Asset Asset;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra; 
	}
}
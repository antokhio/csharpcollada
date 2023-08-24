using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="kinematics_scene", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Kinematics_Scene
	{
		[XmlAttribute("id")]
		public string ID;

		[XmlAttribute("name")]
		public string Name;

		[XmlElement(ElementName = "instance_kinematics_model")]
		public Grendgine_Collada_Instance_Kinematics_Model[] Instance_Kinematics_Model;

		[XmlElement(ElementName = "instance_articulated_system")]
		public Grendgine_Collada_Instance_Articulated_System[] Instance_Articulated_System;

		[XmlElement(ElementName = "asset")]
		public Grendgine_Collada_Asset Asset;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra; 
	}
}
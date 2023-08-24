using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="library_joints", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Library_Joints
	{
		[XmlAttribute("id")]
		public string ID;

		[XmlAttribute("name")]
		public string Name;

		[XmlElement(ElementName = "joint")]
		public Grendgine_Collada_Joint[] Joint;

		[XmlElement(ElementName = "asset")]
		public Grendgine_Collada_Asset Asset;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra; 
	}
}
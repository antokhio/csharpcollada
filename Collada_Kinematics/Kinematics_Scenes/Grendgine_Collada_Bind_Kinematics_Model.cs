using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="bind_kinematics_model", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Bind_Kinematics_Model
	{
		[XmlAttribute("node")]
		public string Node;

		[XmlElement(ElementName = "param")]
		public Grendgine_Collada_Param Param;

		[XmlElement(ElementName = "SIDREF")]
		public string SIDREF;
	}
}
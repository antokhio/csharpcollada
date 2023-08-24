using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="revolute", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Revolute
	{
		[XmlAttribute("sid")]
		public string sID;

		[XmlElement(ElementName = "axis")]
		public Grendgine_Collada_SID_Float_Array_String Axis;

		[XmlElement(ElementName = "limits")]
		public Grendgine_Collada_Kinematics_Limits Limits;
	}
}
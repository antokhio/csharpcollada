using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Constraint_Spring_Type
	{
		[XmlElement(ElementName = "stiffness")]
		public Grendgine_Collada_SID_Float Stiffness;

		[XmlElement(ElementName = "damping")]
		public Grendgine_Collada_SID_Float Damping;

		[XmlElement(ElementName = "target_value")]
		public Grendgine_Collada_SID_Float Target_Value;
	}
}
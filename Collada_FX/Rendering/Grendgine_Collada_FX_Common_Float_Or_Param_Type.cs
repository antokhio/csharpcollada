using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="fx_common_float_or_param_type", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_FX_Common_Float_Or_Param_Type
	{
		[XmlElement(ElementName = "float")]
		public Grendgine_Collada_SID_Float Float;

		[XmlElement(ElementName = "param")]
		public Grendgine_Collada_Param Param;
	}
}
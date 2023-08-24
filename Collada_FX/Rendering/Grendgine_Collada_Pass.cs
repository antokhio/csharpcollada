using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="pass", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Pass
	{
		[XmlAttribute("sid")]
		public string sID;

		[XmlElement(ElementName = "annotate")]
		public Grendgine_Collada_Annotate[] Annotate;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra;

		[XmlElement(ElementName = "states")]
		public Grendgine_Collada_States States;

		[XmlElement(ElementName = "evaluate")]
		public Grendgine_Collada_Effect_Technique_Evaluate Evaluate;
	}
}
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="ref_attachment", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Ref_Attachment
	{
		[XmlAttribute("rigid_body")]
		public string Rigid_Body;

		[XmlElement(ElementName = "translate")]
		public Grendgine_Collada_Translate[] Translate;

		[XmlElement(ElementName = "rotate")]
		public Grendgine_Collada_Rotate[] Rotate;

		[XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra;
	}
}
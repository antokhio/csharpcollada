using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="depth_clear", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Depth_Clear
	{
		[XmlAttribute("index")]
		[System.ComponentModel.DefaultValueAttribute(typeof(int), "0")]
		public int Index;

		[XmlTextAttribute()]
		public float Value;
	}
}
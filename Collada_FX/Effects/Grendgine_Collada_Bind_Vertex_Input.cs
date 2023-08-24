using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="bind_vertex_input", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Bind_Vertex_Input
	{
		[XmlAttribute("semantic")]
		public string Semantic;

		[XmlAttribute("imput_semantic")]
		public string Imput_Semantic;

		[XmlAttribute("input_set")]
		public int Input_Set;
	}
}
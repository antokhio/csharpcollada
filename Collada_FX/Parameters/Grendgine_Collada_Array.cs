using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="array", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Array
	{
		[XmlAttribute("length")]
		public int Length;
		[XmlAttribute("resizable")]
		public bool Resizable;

		/// <summary>
		/// Need to determine the type and value of the Object(s)
		/// </summary>
		[XmlAnyElement]
		public XmlElement[] Data;
	}
}
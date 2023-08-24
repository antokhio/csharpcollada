using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="modifier", Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Modifier
	{
		[XmlTextAttribute()]
		[System.ComponentModel.DefaultValueAttribute(Grendgine_Collada_Modifier_Value.CONST)]
		public Grendgine_Collada_Modifier_Value Value;
	}
}
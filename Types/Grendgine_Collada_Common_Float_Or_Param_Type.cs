using System.Xml.Serialization;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class Grendgine_Collada_Common_Float_Or_Param_Type : Grendgine_Collada_Common_Param_Type
	{
		[XmlTextAttribute()]
		public string Value_As_String;
	}
}
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{

	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema", IsNullable=true)]
	public partial class Grendgine_Collada_Constraint_Limit_Detail
	{
		
		[XmlElement(ElementName = "min")]
		public Grendgine_Collada_SID_Float_Array_String Min;	
		
		
		[XmlElement(ElementName = "max")]
		public Grendgine_Collada_SID_Float_Array_String Max;			
	}
}


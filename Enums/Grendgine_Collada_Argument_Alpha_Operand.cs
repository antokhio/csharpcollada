using System;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema" )]
	public enum Grendgine_Collada_Argument_Alpha_Operand
	{
		SRC_ALPHA,
		ONE_MINUS_SRC_ALPHA
	}
}
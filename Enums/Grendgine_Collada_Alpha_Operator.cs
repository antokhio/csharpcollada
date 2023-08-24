namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema" )]
	public enum Grendgine_Collada_Alpha_Operator
	{
		REPLACE,
		MODULATE,
		ADD,
		ADD_SIGNED,
		INTERPOLATE,
		SUBTRACT
	}
}
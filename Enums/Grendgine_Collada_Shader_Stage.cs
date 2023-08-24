namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema" )]
	public enum Grendgine_Collada_Shader_Stage
	{
		TESSELATION, 
		VERTEX, 
		GEOMETRY, 
		FRAGMENT
	}
}
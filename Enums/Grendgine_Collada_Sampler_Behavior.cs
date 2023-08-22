using System;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema" )]
	public enum Grendgine_Collada_Sampler_Behavior
	{

		UNDEFINED,
		CONSTANT,
		GRADIENT, 
		CYCLE,
		OSCILLATE, 
		CYCLE_RELATIVE
	}
}


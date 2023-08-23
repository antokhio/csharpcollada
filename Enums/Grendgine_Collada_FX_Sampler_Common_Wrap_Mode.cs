using System;
namespace grendgine_collada
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.collada.org/2008/03/COLLADASchema" )]
	public enum Grendgine_Collada_FX_Sampler_Common_Wrap_Mode
	{
		WRAP,
		MIRROR,
		CLAMP,
		BORDER,
		MIRROR_ONCE,

		REPEAT,
		CLAMP_TO_EDGE,
		MIRRORED_REPEAT
	}
}
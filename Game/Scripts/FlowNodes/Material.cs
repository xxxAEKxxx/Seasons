using CryEngine;
using CryEngine.Flowgraph;

namespace CryGameCode
{
	[FlowNode(Name = "Material", Category = "MaterialGraph")]
	public class MaterialNode : FlowNode
	{
        [Port(Name = "Material", StringPortType = StringPortType.Material)]
		public void MaterialName(string name) { }

		[Port(Description = "Gets the material")]
		public void Get()
		{
			var material = Material.Find(GetPortValue<string>(MaterialName));
			if(material == null)
				return;

            var subMatId = GetPortValue<int>(Submaterial);
			if(subMatId != -1)
			{
                material = material.GetSubmaterial(GetPortValue<int>(Submaterial));
				if(material == null)
					return;
			}

			AlphaTestOutput.Activate(material.AlphaTest);
			OpacityOutput.Activate(material.Opacity);
			GlowOutput.Activate(material.Glow);
			ShininessOutput.Activate(material.Shininess);

			DiffuseColorOutput.Activate(material.DiffuseColor);
			EmissiveColorOutput.Activate(material.EmissiveColor);
			SpecularColorOutput.Activate(material.SpecularColor);
		}

		[Port(Description = "Sets the entity's material")]
		public void Set()
		{
            var material = Material.Find(GetPortValue<string>(MaterialName));

			if(material == null)
				return;

            var subMatId = GetPortValue<int>(Submaterial);

			if(subMatId != -1)
			{
				material = material.GetSubmaterial(subMatId);

				if(material == null)
					return;
			}

			if(IsPortActive<Color>(DiffuseColor))
                material.DiffuseColor = GetPortValue<Color>(DiffuseColor);

            if (IsPortActive<Color>(EmissiveColor))
                material.EmissiveColor = GetPortValue<Color>(EmissiveColor);

            if (IsPortActive<Color>(SpecularColor))
                material.SpecularColor = GetPortValue<Color>(SpecularColor);

            if (IsPortActive<float>(AlphaTest))
                material.AlphaTest = GetPortValue<float>(AlphaTest);

            if (IsPortActive<float>(Opacity))
                material.Opacity = GetPortValue<float>(Opacity);

            if (IsPortActive<float>(Glow))
                material.Glow = GetPortValue<float>(Glow);

            if (IsPortActive<float>(Shininess))
                material.Shininess = GetPortValue<float>(Shininess);
		}

		[Port(Description = "If not -1, attempts to get a submaterial at the specified slot")]
		public void Submaterial(int value = -1) { }

		[Port]
		public void AlphaTest(float value) { }

		[Port(Name = "AlphaTest")]
		public OutputPort<float> AlphaTestOutput { get; set; }

		[Port]
		public void Opacity(float value) { }

		[Port(Name = "Opacity")]
		public OutputPort<float> OpacityOutput { get; set; }

		[Port]
		public void Glow(float value) { }

		[Port(Name = "Glow")]
		public OutputPort<float> GlowOutput { get; set; }

		[Port]
		public void Shininess(float value) { }

		[Port(Name = "Shininess")]
		public OutputPort<float> ShininessOutput { get; set; }

        [Port]
		public void DiffuseColor(Color value) { }

		[Port(Name = "DiffuseColor")]
		public OutputPort<Vec3> DiffuseColorOutput { get; set; }

        [Port]
		public void EmissiveColor(Color value) { }

		[Port(Name = "EmissiveColor")]
		public OutputPort<Vec3> EmissiveColorOutput { get; set; }

        [Port]
		public void SpecularColor(Color value) { }

		[Port(Name = "SpecularColor")]
		public OutputPort<Vec3> SpecularColorOutput { get; set; }
	}
}
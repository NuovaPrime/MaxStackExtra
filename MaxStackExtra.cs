using Terraria.ModLoader;

namespace MaxStackExtra
{
	class MaxStackExtra : Mod
	{
		public MaxStackExtra()
		{
			Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
	}
}

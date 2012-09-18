using CryEngine;

namespace CryGameCode.Actors
{
	class Player : NativeActor
	{
		public void Init()
		{
			View.Active.FieldOfView = Math.DegreesToRadians(60);
		}
	}
}

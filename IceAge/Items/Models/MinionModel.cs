using System.Collections.Generic;

using Terraria.ID;

namespace IceAge.Models
{
	public class MinionModel
	{
		public int ItemID { get; set; }
		public int BuffID { get; set; }
		public List<int> ProjectileIDs { get; set; }

		public MinionModel(int itemID, int buffID, List<int> projectileIDs)
		{
			this.ItemID = itemID;
			this.BuffID = buffID;
			this.ProjectileIDs = projectileIDs;
		}
	}
}
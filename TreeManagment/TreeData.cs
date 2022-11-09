namespace TreeManagment
{
	public class TreeData : ITreeData
	{
		public int Tank { get; protected set; }
		public int LossFactor { get; protected set; }
		public int MaxLoss { get; protected set; }

		public TreeData(int tank, int lossFactor, int maxLoss = 0)
		{
			Tank = tank;
			LossFactor = lossFactor;
			MaxLoss = maxLoss;
		}

		public ITreeData Perform(IList<ITreeData> treeData)
		{
			int tank = Tank;
			int maxLoss = 0;
			for (int i = 0; i < treeData.Count; i++)
			{
				TreeData data = (TreeData)treeData[i];
				tank += data.Tank;
				maxLoss = Math.Max(maxLoss, data.MaxLoss);
			}
			return new TreeData(tank, LossFactor, Math.Max(tank * LossFactor, maxLoss));
		}
	}
}
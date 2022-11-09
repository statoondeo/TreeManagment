namespace TreeManagment
{
	public interface ITreeData
	{
		ITreeData Perform(IList<ITreeData> treeData);
	}
}
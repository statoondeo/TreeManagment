namespace TreeManagment
{
	public class Tree<T> where T : ITreeData
	{
		protected IDictionary<int, Composite<T>> Composites;

		public Tree() => Composites = new Dictionary<int, Composite<T>>();

		public Composite<T> AddComposite(int id, T data)
		{
			Composite<T> composite = new(id, data);
			Composites.Add(id, composite);
			return (composite);
		}
		public Composite<T> GetComposite(int compositeId) => Composites[compositeId];
		public T DeepFirstSearch(int startingCompositeId) => Composites[startingCompositeId].DeepFirstSearch();
	}
}
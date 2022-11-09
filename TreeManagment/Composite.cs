namespace TreeManagment
{
	public class Composite<T> where T : ITreeData
	{
		public int Id { get; protected set; }
		public T Data { get; protected set; }
		public IList<Composite<T>> Composites { get; protected set; }

		public Composite(int id, T data)
		{
			Id = id;
			Data = data;
			Composites = new List<Composite<T>>();
		}
		public Composite(int id) : this(id, default(T)) { }

		public T SetData(T data)
		{
			Data = data;
			return (Data);
		}
		public Composite<T> AddComposite(Composite<T> composite)
		{
			Composites.Add(composite);
			return (composite);
		}
		public T DeepFirstSearch()
		{
			IList<ITreeData> dataList = new List<ITreeData>();
			for (int i = 0; i < Composites.Count; i++) dataList.Add(Composites[i].DeepFirstSearch());
			return (T)Data.Perform(dataList);
		}
	}
}
using TreeManagment;

List<string> inputs = new List<string>();
string line = "4\r\n0 0 1 1 2 3\r\n1 5 3 2 4 1\r\n2 6 \r\n3 10\r\n4 12";
inputs.AddRange(line.Split("\r\n"));
Tree<TreeData> tree = new();
for (int i = (inputs.Count - 1); i > 0; i--)
{
	string[] currentLine = inputs[i].Trim().Split(" ");
	switch(currentLine.Length)
	{
		case 2:
			tree.AddComposite(int.Parse(currentLine[0]), new TreeData(int.Parse(currentLine[1]), 0, 0));
			break;
		case 6:
			Composite<TreeData> rootComposite = tree.AddComposite(int.Parse(currentLine[0]), new TreeData(int.Parse(currentLine[1]), 0, 0));
			Composite<TreeData> composite = rootComposite.AddComposite(tree.GetComposite(int.Parse(currentLine[2])));
			composite.SetData(new TreeData(composite.Data.Tank, int.Parse(currentLine[3])));
			composite = rootComposite.AddComposite(tree.GetComposite(int.Parse(currentLine[4])));
			composite.SetData(new TreeData(composite.Data.Tank, int.Parse(currentLine[5])));
			break;
	}
}
Console.WriteLine(tree.DeepFirstSearch(0).MaxLoss);
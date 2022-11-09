using TreeManagment;

List<string> inputs = new List<string>();
string line = "16\r\n0 0 1 104 2 246\r\n1 9366 5 134 6 1590\r\n2 1788 3 418 4 738\r\n3 9023 7 1560 8 2617\r\n5 7529 9 721 10 202\r\n10 7345 11 3450 12 279\r\n12 2740 13 1295 14 416\r\n14 1969 15 993 16 917\r\n4 8832\r\n6 4107\r\n7 4197\r\n8 2499\r\n9 9059\r\n11 1897\r\n13 5050\r\n15 6570\r\n16 7126";
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
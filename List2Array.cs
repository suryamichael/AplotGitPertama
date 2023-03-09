 int[] NumberArray = {15, 10, 17, 2, 4};

List<int> BasicNumber = new List<int>();

BasicNumber.AddRange(NumberArray); 

int[] Number = BasicNumber.ToArray();
foreach (int x in Number) 
Console.WriteLine(x);
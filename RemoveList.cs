/*
 int[] NumberArray = {1, 2, 3, 4};

List<int> BasicNumber = new List<int>();

BasicNumber.AddRange(NumberArray);  
*/

//Remove with specific element
/* 
BasicNumber.Remove(2);
Console.WriteLine(BasicNumber[1]); //remove element 2 in the list, so will be replace by element 3 
*/

//Remove with specific locations
/* 
BasicNumber.RemoveAt(1);
Console.WriteLine(BasicNumber[2]); //The element in list with the position is 1 is removed 
*/

//Remove all after the position
/* 
BasicNumber.RemoveRange(2, 1); //(Position, element will removed)
Console.WriteLine(BasicNumber[2]); //Dont have element at this position 
*/

//Format the list
/* BasicNumber.Clear(); */
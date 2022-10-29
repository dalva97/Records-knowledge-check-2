
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Running>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new Running ();

    Console.WriteLine("Enter the value for ");
    myClass.Distance = decimal.Parse(Console.ReadLine());
    myClass.Heartrate = int.Parse(Console.ReadLine());

    recordList.Add(myClass);
}
foreach (var element in recordList)
{
    Console.WriteLine(element.Distance);
  Console.WriteLine(element.Heartrate);
}
Console.ReadLine();
// Print out the list of records using Console.WriteLine()

public class Running : Exercise
{
    public decimal Distance { get; set; }
}
public class Exercise
{
    public int Heartrate { get; set; }
}

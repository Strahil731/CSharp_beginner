int numberAllPage = int.Parse(Console.ReadLine());
int pageForOneHour = int.Parse(Console.ReadLine());
int dayNumber = int.Parse(Console.ReadLine());

int needHour = numberAllPage / pageForOneHour;
int needHourPerDay = needHour / dayNumber;

Console.WriteLine(needHourPerDay);
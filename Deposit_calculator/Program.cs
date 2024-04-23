double depositSum = double.Parse(Console.ReadLine());
int month = int.Parse(Console.ReadLine());
double yearPercent = double.Parse(Console.ReadLine());

double accredInterest = depositSum * (yearPercent / 100);
double accredInterestPerMonth = accredInterest / 12;
double resultSum = depositSum + month * accredInterestPerMonth;

Console.WriteLine(resultSum);
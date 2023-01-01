//1) напишите программу которая выводит случайное исло из отрезка [30,99]и показывает наибольшую цифру этого числа
/*int func(int num)
{
    int randnumber1=num/10;
    int randnumber2=num%10;
    if(randnumber2==randnumber1)
    {
        return -1;
        //Console.WriteLine($"Они равны{randnumber1})");
    }
    else
    {
    if(randnumber1>randnumber2)
    {
    return randnumber1;
        //Console.WriteLine($"наибольшая цифра этого числа{randnumber2}");
    }
    else
    return randnumber2;
    //Console.WriteLine($"наибольшая цифра этого числа{randnumber1}");
    }
}
int randnumber=new Random().Next(29,100);
Console.WriteLine(randnumber);
Console.WriteLine(func(randnumber));
*/
// 2) написать программу которая на вход будет принимать два числа и выявлять является ли второе число кратынм первому
/*
bool func(int num1, int num2)
{
if(num2 % num1 ==0) return true;
else return false;
}
Console.WriteLine("введите пожалуйсто первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пожалуйсто второе число");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(num1,num2));
*/
/*
int CutNumber(int number)
{
  int sot=number/100;
  int ed=number%10;
  int reuslt=sot*10+ed;
return reuslt;
}
int randnumber=new Random().Next(100,1000);
int newNumber=CutNumber(randnumber);
Console.WriteLine($"New version of a number {randnumber} is {newNumber}");
*/
// 3)написать программу которая на вход будет принимать два числа и выявлять является ли одно число квадратом другого
bool func(int num1, int num2)
{
if(num2==num1*num1||num1==num2*num2) return true;
else return false;
}
Console.WriteLine("введите пожалуйсто первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пожалуйсто второе число");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(num1,num2));
/*
bool isEven(int num)
{
   if(num%2==0)
return true;
else 
return false;
}
*/
/*int a=5;
if(a>0 && a%2==0)
{

}
*/

using System;
					
public class Program
{
	public static void Main()
	{	int input=0, sum=0, num=0, p=0 , k=0;
	 	Console.WriteLine("Narcissistic number verification:");
		Console.Write("insert a number:");
		input = int.Parse(Console.ReadLine());
	 	num = input;	
	 	p = (int)Math.Ceiling(Math.Log10(num));
	 	
	 while( num != 0)
		{ 
			k = num % 10;
			//Console.WriteLine("K= "+k); 
			sum = sum + (int)(Math.Pow(k,p));
			//Console.WriteLine("Sum= "+sum); 
			num = num/10;
			//Console.WriteLine("num= " +num);
		}
	 if(sum == input){
	 Console.WriteLine("True, {0} is a narcissistic number.", input);	
	 }else{
	 Console.WriteLine("false, {0} is not a narcissistic number.", input);	
	 }	 	 
	}
}

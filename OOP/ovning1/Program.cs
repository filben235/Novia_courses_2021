using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning1
{
    class Program
	{
		//----------------1.1----------------------

		//static void Main()
		//{
		//	double brutto, netto, skatt;

		//	Console.WriteLine("brutto? ");
		//	brutto = double.Parse(Console.ReadLine());

		//	if (brutto < 500) skatt = 0;
		//	else if (brutto <= 3000) skatt = brutto * 0.3;
		//	else skatt = 3000 * 0.3 + (brutto - 3000) * 0.5;
		//	netto = brutto - skatt;

		//	Console.WriteLine("Skatt= " + skatt);
		//	Console.WriteLine("Netto= " + netto);
		//}

		//-------------------------------------------



		//----------------1.2-------------------------

		//static double GetSkatt(double brutto)
		//{
		//	double skatt;
		//	if (brutto < 500) skatt = 0;
		//	else if (brutto <= 3000) skatt = brutto * 0.3;
		//	else skatt = 3000 * 0.3 + (brutto - 3000) * 0.5;
		//	return skatt;
		//}
		//static void Main()
		//{
		//	double brutto, netto, skatt;
		//	double sumBrutto = 0, sumNetto = 0;
		//	Console.WriteLine("brutto? ");
		//	brutto = double.Parse(Console.ReadLine());
		//	while (brutto > 0)
		//	{
		//		skatt = GetSkatt(brutto);
		//		netto = brutto - skatt;
		//		sumBrutto += brutto;
		//		sumNetto += netto;
		//		Console.WriteLine("Skatt: " + skatt);
		//		Console.WriteLine("Netto: " + netto);
		//		Console.WriteLine("brutto? ");
		//		brutto = double.Parse(Console.ReadLine());
		//	}
		//	Console.WriteLine(
		//		"Medelskatteprocent: "
		//		+ ((1 - sumNetto / sumBrutto) * 100).ToString("N2")
		//		+ "%"
		//	);
		//}

		//-------------------------------------------



		//------------------1.3----------------------

		//static double GetSkatt(double brutto)
		//{
		//	double skatt;
		//	if (brutto < 500) skatt = 0;
		//	else if (brutto <= 3000) skatt = brutto * 0.3;
		//	else skatt = 3000 * 0.3 + (brutto - 3000) * 0.5;
		//	return skatt;
		//}

		//static double getMedian(double[] taxes, int counter)
		//{
		//	bubblesort(taxes, counter);
		//	int middle = counter / 2;
		//	if (counter % 2 == 1) return taxes[middle] * 100;
		//	else return ((taxes[middle] + taxes[middle + 1]) / 2) * 100;
		//}

		//static void bubblesort(double[] args, int c)
		//{
		//	bool switched;
		//	do
		//	{
		//		switched = false;
		//		for (int i = 0; i < c - 1; i++)
		//		{
		//			if (args[i] > args[i + 1])
		//			{
		//				double temp = args[i];
		//				args[i] = args[i + 1];
		//				args[i + 1] = temp;
		//				switched = true;
		//			}

		//		}
		//	} while (switched == true);
		//}

		//static void Main()
		//{
		//	double brutto, netto, skatt;
		//	double sumBrutto = 0, sumTaxes = 0;
		//	double[] taxes = new double[20];
		//	int counter = 0;
		//	Console.WriteLine("brutto? ");
		//	brutto = double.Parse(Console.ReadLine());
		//	while (brutto > 0)
		//	{
		//		skatt = GetSkatt(brutto);
		//		netto = brutto - skatt;
		//		sumBrutto += brutto;
		//		sumTaxes += skatt;
		//		taxes[counter++] = 1 - (netto / brutto);
		//		Console.WriteLine("Skatt: " + skatt);
		//		Console.WriteLine("Netto: " + netto);
		//		Console.WriteLine("brutto? ");
		//		brutto = double.Parse(Console.ReadLine());
		//	}
		//	Console.WriteLine(
		//		"Medelskatteprocent: "
		//		+ (( sumTaxes / sumBrutto) * 100).ToString("N2")
		//		+ "%"
		//	);
		//	double medianTax = getMedian(taxes, counter);
		//	Console.WriteLine(
		//		"Medianskatt: "
		//		+ medianTax.ToString()
		//		+ "%"
		//	);
		//}
	}
}

/*
 * Created by SharpDevelop.
 * User: Kroll_Lars
 * Date: 26.11.2018
 * Time: 10:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sortieren
{
	class Program
	{
		static double[] ErstelleZufallsArray()
		{
			Console.WriteLine("Wieviele Stellen soll das Array habe?");
			int eigeneLaenge = Convert.ToInt32(NummerEingabe());
			double[] randomArray = new double[eigeneLaenge];
			Random rnd = new Random();
			
			for (int i = 0; i < randomArray.Length; i++)
			{
				randomArray[i] = rnd.Next(1, 100);						//TODO: eigenes Min und Max bestimmen, außerdem Kommastellen
			}
			return randomArray;
			
			
		}
		public static double NummerEingabe()
		{
			
			double eingabe = Convert.ToDouble(Console.ReadLine());		//TODO: Ueberpruefen ob Eingabe korrekt ist
			return eingabe;
		}

		static double[] BubbleSort(double[] zahlenArray)					//Solange Stelle(i) im Array mit Stelle(i+1)
		{															// vergleichen bis KEIN Tausch mehr stattfindet
			bool fertig = false;								
			while (fertig == false) {
				fertig = true;
				for (int i = 0; i < zahlenArray.Length - 1; i++) {
					if (zahlenArray[i] > zahlenArray[i + 1]) {
						double temp = zahlenArray[i];
						zahlenArray[i] = zahlenArray[i + 1];
						zahlenArray[i + 1] = temp;
						fertig = false;
					}
				}
			}
			return zahlenArray;
		}
		static double[] ErstelleEigenesArray()
		{
			Console.WriteLine("Wieviele Stellen soll das Array habe?");
			int eigeneLaenge = Convert.ToInt32(NummerEingabe());
			double[] eigenesArray = new double[eigeneLaenge];
			
			for (int i = 0; i < eigenesArray.Length; i++) {
				Console.WriteLine("Bitte {0}. Zahl eingeben", i + 1);	//Zahleneingabe
				eigenesArray[i] = NummerEingabe();
			}
			return eigenesArray;
		}

		static double[] GebeArrayAus(double[] array)
		{
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
			return array;
		}
		
		public static void quicksort(double[] liste)
		{
			quicksortHelp(0, liste.Length - 1, liste);
		}
		
		public static void quicksortHelp(int anfang, int ende, double[] liste){
			if (anfang < ende) 
			{
				int spaltung = Sortierung(anfang, ende, liste);
				
				quicksortHelp(anfang, spaltung - 1, liste);
				quicksortHelp(spaltung + 1, ende, liste);
			}
			
		}
		public static int Sortierung(int anfang, int ende, double[] liste){
			
			double vergleichsW = liste[anfang];
			int links = anfang + 1;
			int rechts = ende;
			bool fertig = false;
			while (fertig == false) 
			{
				while (links <= rechts && liste[links] <= vergleichsW) 
				{
					links++;
				}
				while (rechts >= links && liste[rechts] >= vergleichsW) 
				{
					rechts--;
				}
				if (rechts < links) 
				{
					fertig = true;
				}
				else
				{
					double temp = liste[links];
					liste[links] = liste[rechts];
					liste[rechts] = temp;
				}
			}
			double temptwo = liste[anfang];
			liste[anfang] = liste[rechts];
			liste[rechts] = temptwo;
			
			return rechts;
		}
		
		public static void Main(string[] args)
		{
			string eingabe;
			
			Console.WriteLine("Moechtest du eine Zahlenfolge eingeben oder ein Zufaelliges erstellen?\n" +
			                  "fuer Zufall gebe >zufall< ein und fuer selber >selber<");
			eingabe = Console.ReadLine();
			
			
			if (eingabe == "zufall") 											//zufaelliges Array erstellen
			{
				double[] zufallsArr = ErstelleZufallsArray();
				GebeArrayAus(zufallsArr);
				Console.WriteLine("Moechtest du sortieren?\n" +					//TODO: Methode fuer gleichen Code
			                  "fuer sortieren gebe >ja< ein");
				eingabe = Console.ReadLine();
				if (eingabe == "ja") 
				{
					Console.WriteLine("Bubble oder Quick?");
					eingabe = Console.ReadLine();
					if (eingabe == "Bubble"){
						GebeArrayAus(BubbleSort(zufallsArr));
					}
					if (eingabe == "Quick"){
						quicksort(zufallsArr);
						GebeArrayAus(zufallsArr);
					}
					
				}
			}
			if (eingabe == "selber") 											//eigenes Array erstellen
			{
				double[] eigenesArray = ErstelleEigenesArray();
				BubbleSort(eigenesArray);
				Console.WriteLine("Moechtest du sortieren?\n" +					//TODO: Methode fuer gleichen Code
			                  "fuer sortieren gebe >ja< ein");
				eingabe = Console.ReadLine();
				if (eingabe == "ja") 
				{
					GebeArrayAus(BubbleSort(eigenesArray));
				}
			}
			
			Console.Write("Ich schliesse mich jetzt . . . ");
			Console.ReadKey(true);
		}
	}
}
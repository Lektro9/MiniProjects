/*
 * Created by SharpDevelop.
 * User: TestWin10
 * Date: 13.09.2018
 * Time: 10:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * Dinklebergers
 */
using System;
using System.Collections.Generic; // um mehr Methoden abrufen zu können und vorallem "List" benutzen zu können


namespace MenueZweiterAnlauf
{
	class Program
	{
		public static List<string> einkaufsWagen = new List<string>();
		public static string[,] menue = new string[,]{{"[1]", "Milchkaffee", "2,20"}, {"[2]", "Käsekuchen", "2,30"},
													  {"[3]", "Kakao\t", "2,00"}, {"[4]", "Blaubeermuffin", "1,30"},
													  {"[5]", "Mineralwasser", "1,80"}, {"[6]", "Brownie\t", "1,00"},
													  {"[7]", "Espresso", "2,00"}, {"[8]", "Apfelkuchen", "2,40"},
													  {"[9]", "Latte Macchiato", "2,50"}, {"[10]", "Kirschtorte", "3,00"},
													  {"[11]", "Mittagstisch", "4,50"}, {"[12]", "habnet", "999"},};
		public static float[] price = new float[]{1,50 , 2,32};
		public static float gesamt;
		public static bool stillShopping;
		
		public static void Main(string[] args)
		{
			gesamt = 0;
			stillShopping = true;
			Console.WriteLine ("Brauchen sie das Menue, dann tippen Sie bitte 'Menue' ein?");
			switch(Console.ReadLine())
			{
				case "Menue":
					Console.WriteLine ("Hier die Liste aller Produkte des Cafe-Blaus: ");
					for (int s=0; s < 11; s++)
					{
						Console.WriteLine(menue[s, 0] + "\t" + menue[s, 1] + "\t\t\t" + menue[s, 2] + " Euro");
					}
					Console.WriteLine ("Was darf es denn sein? Wenn Sie fertig sind dann tippen Sie bitte 'Rechnung' ein.");
					// ein for loop bis der Benutzer sagt dass er nichts anderes mehr braucht
					
					while(stillShopping)
					{
					switch(Console.ReadLine())
						{
						case "1": //nimm den gesamtwert und addiere das produkt
						gesamt += Single.Parse(menue[0,2]);
						MenueAusgabe();
						EinkaufsWagenAusgabe(0);
						break;
						case "2":
						MenueAusgabe();
						gesamt += Single.Parse(menue[1,2]);
						EinkaufsWagenAusgabe(1);
						break;
						case "3":
						MenueAusgabe();
						gesamt += Single.Parse(menue[2,2]);
						EinkaufsWagenAusgabe(2);
						break;
						case "4":
						MenueAusgabe();
						gesamt += Single.Parse(menue[3,2]);
						EinkaufsWagenAusgabe(3);
						break;
						case "5":
						MenueAusgabe();
						gesamt += Single.Parse(menue[4,2]);
						EinkaufsWagenAusgabe(4);
						break;
						case "6":
						MenueAusgabe();
						gesamt += Single.Parse(menue[5,2]);
						EinkaufsWagenAusgabe(5);
						break;
						case "7":
						MenueAusgabe();
						gesamt += Single.Parse(menue[6,2]);
						EinkaufsWagenAusgabe(6);
						break;
						case "8":
						MenueAusgabe();
						gesamt += Single.Parse(menue[7,2]);
						EinkaufsWagenAusgabe(7);
						break;
						case "9":
						MenueAusgabe();
						gesamt += Single.Parse(menue[8,2]);
						EinkaufsWagenAusgabe(8);
						break;
						case "10":
						MenueAusgabe();
						gesamt += Single.Parse(menue[9,2]);
						EinkaufsWagenAusgabe(9);
						break;
						case "11":
						MenueAusgabe();
						gesamt += Single.Parse(menue[10,2]);
						EinkaufsWagenAusgabe(10);
						break;
						
						case "Rechnung":
						stillShopping = false;
						break;
						}
					}
					break;
					
				default:
					break;
			}
			

			
			Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\nDanke für die Auswahl!");
			Console.WriteLine("\nIhre endgültige Bestellung lautet: ");
						foreach(string gk in einkaufsWagen)
						{
							Console.WriteLine("\t\t\t\t\t" + gk);
						}
			Console.WriteLine("\n\nDas macht dann: " + gesamt.ToString("n2") + " Euro");
			Console.WriteLine("\n\n\n\nBeehren Sie uns bald wieder!\n\n\n\n\n\n\n\n");
			Console.ReadKey(true);
		}
		public static void MenueAusgabe()
		{
					Console.WriteLine ("\nHier die Liste aller Produkte des Cafe-Blaus: ");
					for (int s=0; s < 11; s++) // solange s
					{
						Console.WriteLine(menue[s, 0] + "\t" + menue[s, 1] + "\t\t\t" + menue[s, 2] + " Euro");
					}
					Console.WriteLine ("Darf es noch etwas sein? 'Rechnung' eintippen wenn Sie ihre Bestellung beenden wollen.\n");
		}
		
		public static void EinkaufsWagenAusgabe(int bP)
		{
						einkaufsWagen.Add (menue[bP,1]);  // hier wird der Name des Produktes zur einer Liste hinzugefügt und ausgegeben.
						Console.WriteLine("\nIhre Bestellungen bis jetzt lauten: ");
						foreach(string gk in einkaufsWagen)
						{
							Console.WriteLine("\t\t\t\t\t" + gk);
						}
						Console.WriteLine("Aktueller Preis: \t" + gesamt.ToString("n2") + " Euro");
						Console.WriteLine("Wenn Sie ihre Bestellung beenden wollen, tippen Sie bitte 'Rechnung' ein\n");//hier kommt bald eine Ersparung rein
		}
		
	}
}
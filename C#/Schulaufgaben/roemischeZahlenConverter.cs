/*
 * Created by SharpDevelop.
 * User: TestWin10
 * Date: 14.09.2018
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace DieRoemerDOTjpeg
{
	class Program
	{
		public static List<char> history = new List<char>();
		public static List<int> subRegel = new List<int>();
		public static List<char> addRegel = new List<char>();
		public static int zwischenSpeicher;
		public static int subtrahierSpeicher;
		public static bool errorSchalter = false;
		public static bool ausSchalter = false;
		public static string eingabe;
		public static string ausgabe;
		
		public static int Einzel(char roemischeZahl) //wandle jede einzelne Zahl um
		{
			int unsereZahl = 0;
			switch (roemischeZahl)
			{
				case 'I':
					unsereZahl = 1;
					break;
					
				case 'V':
					unsereZahl = 5;
					break;
					
				case 'X':
					unsereZahl = 10;
					break;
					
				case 'L':
					unsereZahl = 50;
					break;
				
				case 'C':
					unsereZahl = 100;
					break;
					
				case 'D':
					unsereZahl = 500;
					break;
					
				case 'M':
					unsereZahl = 1000;
					break;
					
				case '0':
					unsereZahl = 0;
					break;
				
				default:
					unsereZahl = 4004;
					errorSchalter = true;
					break;
					
				
			}
			return unsereZahl;
		}
		

		public static void Main(string[] args)
		{
			while (ausSchalter == false)
			{
			Console.WriteLine("Gebe hier deine Zahl ein um sie umzuwandeln!");
			
			eingabe = Console.ReadLine();
			GueltigkeitsUeberpruefung();
			
			Console.WriteLine("Drücke Esc zum Verlassen, oder eine beliebige Taste zum weiterrechnen\n\n");
			ConsoleKeyInfo key = Console.ReadKey();
			if (key.KeyChar == (char)27) {
				ausSchalter = true;
			}
			}
			Console.Write("Console wird nun verlassen . . .");
			Console.ReadKey(true);
			
		}
		
		public static int Umwandler() //Hauptmethode die das Umwandeln macht
		{
			zwischenSpeicher = 0;
			subtrahierSpeicher = 0;
			errorSchalter = false;
			AlleListenLeeren();
			ListenErstellerDerEingabe(eingabe);
			for (int position = 0; position < eingabe.Length; position++) //loop solange wie die Anzahl der vorhandenen Zeichen
			{
				if (eingabe.Length == 1) // Wenn nur ein Zeichen benutzt wird
				{
					zwischenSpeicher = Einzel(history[position]);
					return zwischenSpeicher;
				}
				
				if (eingabe.Length >= 2 && position+1 < eingabe.Length) // für 2 oder mehr Zeichen (outofrange auffänger)
				{
					ZweiGleicheDannGroesserCase(position);
					WennMehrAlsDreiGleicheCase(position);
					LCase(position);
					ICase(position);
					XCase(position);
					VCase(position);
					DCase(position);
					SubtraktionsRegelUndAusListeEntfernen(position);
				}
			}
					SummeDerSubtraktionsliste();
					SummeAllerUebrigen();
			return zwischenSpeicher + subtrahierSpeicher;
		}

		public static void GueltigkeitsUeberpruefung()
		{
			ausgabe = Umwandler().ToString();
			if (errorSchalter == true) {	// überprüfe auf ungültige Eingaben
				ausgabe = "ungültige Eingabe";
			}
			Console.WriteLine("\n{0}\n", ausgabe);
		}

		static void ListenErstellerDerEingabe(string roemischeZahl)
		{
			
			for (int laenge = 0; laenge < roemischeZahl.Length; laenge++) { // erstelle zwei Listen mit allen eingegebenen Zeichen (pass auf die Laenge des arrays auf!)
				history.Add(roemischeZahl[laenge]);
				addRegel.Add(roemischeZahl[laenge]); //zweite Liste um später zu filtern, aber eigentlich auch nur mit history machbar
			}
		}

		public static void AlleListenLeeren()
		{
			history.Clear();
			addRegel.Clear();
			subRegel.Clear();
		}

		static void ZweiGleicheDannGroesserCase(int position)
		{
			if (position + 2 < eingabe.Length && Einzel(history[position]) <= Einzel(history[position + 1]) && // zwei Zahlen und dann größere CASE
			    Einzel(history[position + 1]) < Einzel(history[position + 2])) {
				errorSchalter = true;
			}
		}

		static void WennMehrAlsDreiGleicheCase(int position)
		{
			if (position + 3 < eingabe.Length && Einzel(history[position]) == Einzel(history[position + 1]) && // mehr als 3 gleiche zahlen hintereiander
			    Einzel(history[position + 1]) == Einzel(history[position + 2]) && Einzel(history[position + 2]) == Einzel(history[position + 3])) {
				errorSchalter = true;
			}
		}

		static void ICase(int position)
		{
			if (history[position] == 'I') {
				switch (history[position + 1]) {
					case 'L':
					case 'C':
					case 'D':
					case 'M':
						errorSchalter = true;
						break;
				}
			}
		}

		static void XCase(int position)
		{
			if (history[position] == 'X') {
				switch (history[position + 1]) {
					case 'D':
					case 'M':
						errorSchalter = true;
						break;
				}
			}
		}

		static void VCase(int position)
		{
			if (history[position] == 'V') {
				switch (history[position + 1]) {
					case 'X':
					case 'C':
					case 'M':
					case 'V':
					case 'L':
					case 'D':
						errorSchalter = true;
						break;
				}
			}
		}

		static void LCase(int position)
		{
			if (history[position] == 'L') {
				switch (history[position + 1]) {
					case 'C':
					case 'L':
					case 'D':
					case 'M':
						errorSchalter = true;
						break;
				}
			}
		}

		static void DCase(int position)
		{
			if (history[position] == 'D') {
				switch (history[position + 1]) {
					case 'D':
					case 'M':
						errorSchalter = true;
						break;
				}
			}
		}

		static void SubtraktionsRegelUndAusListeEntfernen(int position)
		{
			if (Einzel(history[position]) < Einzel(history[position + 1])) {//subtrahiere wenn Zahl kleiner ist als nächste
				subRegel.Add(Einzel(history[position + 1]) - Einzel(history[position]));
				addRegel[position + 1] = '0';
				addRegel[position] = '0';
			}
		}

		static void SummeDerSubtraktionsliste()
		{
			foreach (int Zahl in subRegel) {
				subtrahierSpeicher += Zahl;
			}
		}

		static void SummeAllerUebrigen()
		{
			foreach (char roemisch in addRegel) {
				zwischenSpeicher += Einzel(roemisch);
			}
		}
	}
}
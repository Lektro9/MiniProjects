/*
 * Created by SharpDevelop.
 * User: Kroll_Lars
 * Date: 19.02.2019
 * Time: 08:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace oopfirst
{
	class Bruch
	{
		protected int zaehler;
		protected int nenner;
		
		public void SetBruch(int zaehler, int nenner)
		{
			this.zaehler = zaehler;
			this.nenner = nenner;
		}
		
		public int GetZaehler()
		{
			return this.zaehler;
		}
		
		public int GetNenner()
		{
			return this.nenner;
		}
		
		public string ToString()
		{
			return Convert.ToString(zaehler) + "/" + Convert.ToString(nenner);
		}

		public Bruch Multiply(Bruch other)
		{
			Bruch b3 = new Bruch();
			this.zaehler = this.zaehler * other.GetZaehler();
			this.nenner = this.nenner * other.GetNenner();
			
			b3.SetBruch(zaehler, nenner);
			
			return b3;
		}
		
		public void Kuerze() 
		{
			int ggTZaehler = this.zaehler;
			int ggTNenner = this.nenner;
			int ggT;
			
			if (ggTZaehler == 0) 					//ggT bestimmen
			{
				ggT = ggTNenner;
			}
			else
			{
				while (ggTNenner != 0) 
				{
					if (ggTZaehler > ggTNenner) 
					{
						ggTZaehler = ggTZaehler - ggTNenner;
					}
					else
					{
						ggTNenner = ggTNenner - ggTZaehler;
					}
				}
				ggT = ggTZaehler;
			}
			
			this.zaehler = this.zaehler/ggT;
			this.nenner = this.nenner/ggT;
		}
		
		public static Bruch operator *(Bruch b1, Bruch b2)
		{
			Bruch b3 = new Bruch();
			
			b3.SetBruch(b1.GetZaehler() * b2.GetZaehler(), b1.GetNenner() * b2.GetNenner());
			
			return b3;
		}
		
		public static Bruch operator /(Bruch b1, Bruch b2)
		{
			Bruch b3 = new Bruch();
			
			b3.SetBruch(b1.GetZaehler() * b2.GetNenner(), b1.GetNenner() * b2.GetZaehler());
			
			//b3 = b1.Multiply(b2);
			return b3;
		}
		
		public static Bruch operator +(Bruch b1, Bruch b2)
		{
			Bruch b3 = new Bruch();
			Bruch b4 = new Bruch();
			Bruch b5 = new Bruch();
			
			b3.SetBruch(b1.GetNenner()*b2.GetZaehler(), b1.GetNenner()*b2.GetNenner());
			b4.SetBruch(b2.GetNenner()*b1.GetZaehler(), b2.GetNenner()*b1.GetNenner());
			
			b5.SetBruch(b3.GetZaehler() + b4.GetZaehler(), b3.GetNenner());
			
			//b3 = b1.Multiply(b2);
			return b5;
		}
		
		public static Bruch operator -(Bruch b1, Bruch b2)
		{
			Bruch b3 = new Bruch();
			Bruch b4 = new Bruch();
			Bruch b5 = new Bruch();
			
			b3.SetBruch(b1.GetNenner()*b2.GetZaehler(), b1.GetNenner()*b2.GetNenner());
			b4.SetBruch(b2.GetNenner()*b1.GetZaehler(), b2.GetNenner()*b1.GetNenner());			//Achtung, Reihenfolge ist wichtig!
			
			b5.SetBruch(b4.GetZaehler() - b3.GetZaehler(), b3.GetNenner());
			
			//b3 = b1.Multiply(b2);
			return b5;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Regex regEx = new Regex(@"((\d+)(?:/)(\d+)) (\*|\/|\+|\-) ((\d+)(?:/)(\d+))", RegexOptions.Multiline);
			string input = Console.ReadLine();
			Match testMatch = regEx.Match(input);
			GroupCollection data = testMatch.Groups;
			//Console.WriteLine(data[4]);
			Bruch b1 = new Bruch();
			Bruch b2 = new Bruch();
			Bruch b3 = new Bruch();
			List<string> matches = new List<string>();
			
			
			if (testMatch.Success)
			{
				foreach(string groupName in regEx.GetGroupNames())
					{
        			matches.Add(testMatch.Groups[groupName].Value);  
					}
			}

			
			
			b1.SetBruch(Convert.ToInt32(matches[2]), Convert.ToInt32(matches[3]));
			string Rzeichen = matches[4].ToString();
			b2.SetBruch(Convert.ToInt32(matches[6]), Convert.ToInt32(matches[7]));
			
			switch (Rzeichen) 
			{
				case "*":
					b3 = b1 * b2;
					break;
					
				case "/":
					b3 = b1 / b2;
					break;
					
				case "+":
					b3 = b1 + b2;
					break;
					
				case "-":
					b3 = b1 - b2;
					break;
			}
			
			b3.Kuerze();
			Console.WriteLine(b3.ToString());
			
			
			//b1.SetBruch(Convert.ToInt32(data[1]), Convert.ToInt32(data[3]));
			//Console.WriteLine(b1.ToString());
			
//			b2.SetBruch(10, 5);
//			
//			Bruch b3 = new Bruch();
//			b3 = b1+b2;
//			Console.WriteLine(b3.ToString());
//			b3 = b1-b2;
//			Console.WriteLine(b3.ToString());
			//b3.Kuerze();
			
			//Console.WriteLine(b3.ToString()); 
			

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}
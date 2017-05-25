/*
 * Created by SharpDevelop.
 * User: flori
 * Date: 19.05.2017
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUK_Abfrage
{
	class Program
	{
		public static void Main(string[] args)
		{
			int eingabeVersuche, verbleibeneVersuche, eingabePin, Korrektheit;
			long eingabePuk;
			eingabePin=37146082;
			eingabePuk=3714608237146082;
			verbleibeneVersuche=5;
			eingabeVersuche=0;
			Korrektheit=0;
			
			//Puk-Eingabe
					
			
			Console.WriteLine("Bitte PIN eingeben");
					
					do{
						Console.WriteLine("" +verbleibeneVersuche+ " Versuche");
						eingabePin=Convert.ToInt32(Console.ReadLine());
					
						
						if (eingabePin==37146082) {
							Korrektheit=1;
							eingabeVersuche=5;
						}
						
						if (eingabePin!=37146082) {
							Korrektheit=0;
							verbleibeneVersuche--;
							eingabeVersuche++;
						}
						
						} while (eingabeVersuche<5);
			
					
			

			if (Korrektheit==1) {
				Console.WriteLine("Ihr System wird entschlüsselt, bitte haben Sie eine Sekunde Geduld.");
			}

			if (Korrektheit==0) {
				verbleibeneVersuche=10;
				eingabeVersuche=0;
			
				Console.WriteLine("Bitte PUK eingeben");


					do{
						Console.WriteLine("" +verbleibeneVersuche+ " Versuche");
						eingabePuk=Convert.ToInt64(Console.ReadLine());
						
						if (eingabePuk!=3714608237146082) {
						verbleibeneVersuche--;
						eingabeVersuche++;
						Korrektheit=0;
						}
						
						if (eingabePuk==3714608237146082) {
						Korrektheit=2;
						eingabeVersuche=10;
						}
	
						
				} while (eingabeVersuche<10); }
	

			
				if (Korrektheit==2) {	
				Console.WriteLine("Ihr System wird entschlüsselt, bitte haben Sie eine Sekunde Geduld");
				}
				
				if (Korrektheit==0) {
				Console.WriteLine("Ihr System wurde gesperrt, bitte wenden Sie sich an den Administartor der Anlage.");
				}
			
						
				Console.ReadLine();
			}
		}
	}
/**
	Created by [Lekx] Hugo Saul Sanchez Montes de Oca.
	link_mx@live.com
**/

using System;

namespace RandColorGen
{
	class RandomColors
	{
	
		//function colorGenerator
		//params: int quanity of the desired colors to be returned in the array
		public Array colorGenerator (int quantity)
		{

			string[] colors = new string[quantity];
			string[] dictionary = {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
			Random random = new Random();
			string generatedColor = "#";

			for (int counter = 0; counter < quantity; counter++)
			{

				for (int counter2 = 1; counter2 <= 6; counter2++)
				{
					generatedColor += dictionary[random.Next(0, 15)];
				}

				colors[counter] = generatedColor;
				generatedColor = "#";

			}

			return colors;
		}


		public static void Main (string[] args)
		{

			RandomColors colors = new RandomColors();
			Array myColors = colors.colorGenerator(10);
			int i = 1;

			foreach(string color in myColors)
				Console.WriteLine ("color "+(i++)+": "+color);

		}
	
	}
}

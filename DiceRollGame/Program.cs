using DiceRollGame.Game;
using System.Threading.Channels;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);



Console.ReadKey();

//Season firstSeason = Season.Spring;
//Season lastSeason = Season.Winter;
//int firstSeasonAsNumber = (int)firstSeason;
//int lastSeasonAsNumber = (int)lastSeason;
//Console.WriteLine(firstSeason);
//Console.WriteLine("As a number: " + firstSeasonAsNumber);
//Console.WriteLine(lastSeason);
//Console.WriteLine("As a number: " + lastSeasonAsNumber);


//public enum HttpCode
//{
//	Ok = 200,
//	NotFound = 404,
//	InternalServerError = 500
//}

//public enum Season
//{
//	Spring,
//	Summer,
//	Autumn,
//	Winter

//}

//public enum DayOfWeek
//{
//	Monday,
//	Tuesday,
//	Wednesday,
//	Friday,
//	Saturday,
//	Sunday
//}

//public enum ItemCategory
//{
//	Food,
//	Clothing,
//	Electronics
//}



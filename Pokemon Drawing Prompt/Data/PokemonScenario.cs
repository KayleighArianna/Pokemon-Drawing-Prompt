using Pokemon_Drawing_Prompt.Data.Interfaces;
using System;

namespace Pokemon_Drawing_Prompt.Data
{
    public class PokemonScenario : IPokemonScenario
    {
        public string GetPokemonScenario(string firstPokemon, string secondPokemon)
        {
            Random rnd = new Random();
            var scenario = rnd.Next(0, 64);
            switch (scenario)
            {
                case 0:
                    return $"{firstPokemon} baking a cake";
                    break;
                case 1:
                    return $"{firstPokemon} plays a prank on {secondPokemon}";
                    break;
                case 2:
                    return $"{firstPokemon} riding a {secondPokemon} into battle";
                    break;
                case 3:
                    return $"{firstPokemon} sneaking up on {secondPokemon}";
                    break;
                case 4:
                    return $"{firstPokemon} being best pals with {secondPokemon}";
                    break;
                case 5:
                    return $"{firstPokemon} is afraid of {secondPokemon}";
                    break;
                case 6:
                    return $"{firstPokemon} merged with {secondPokemon}";
                    break;
                case 7:
                    return $"{firstPokemon} sneaking up on {secondPokemon}";
                    break;
                case 8:
                    return $"{firstPokemon} going surfing";
                    break;
                case 9:
                    return $"{firstPokemon} going skateboarding";
                    break;
                case 10:
                    return $"{firstPokemon} climbing a mountain";
                    break;
                case 11:
                    return $"{firstPokemon} going shopping";
                    break;
                case 12:
                    return $"{firstPokemon} in full chibi style";
                    break;
                case 13:
                    return $"{firstPokemon}, as seen in your nightmares";
                    break;
                case 14:
                    return $"{firstPokemon} wowing fans at a pokemon contest";
                    break;
                case 15:
                    return $"{firstPokemon} getting mad!";
                    break;
                case 16:
                    return $"{firstPokemon} is very happy";
                    break;
                case 17:
                    return $"{firstPokemon} is a naughty boy";
                    break;
                case 18:
                    return $"{firstPokemon} following their dreams";
                    break;
                case 19:
                    return $"{firstPokemon} posing with their favourite celebrity";
                    break;
                case 20:
                    return $"{firstPokemon} playing with {secondPokemon}";
                    break;
                case 21:
                    return $"{firstPokemon} has had enough of {secondPokemon}'s shit";
                    break;
                case 22:
                    return $"{firstPokemon} and {secondPokemon} on holiday";
                    break;
                case 23:
                    return $"{firstPokemon} and {secondPokemon} holding hands";
                    break;
                case 24:
                    return $"{firstPokemon} will never forgive {secondPokemon}";
                    break;
                case 25:
                    return $"{firstPokemon} is doing their best impression of {secondPokemon}";
                    break;
                case 26:
                    return $"{firstPokemon} in a wrestling match against {secondPokemon}";
                    break;
                case 27:
                    return $"{firstPokemon} has misplaced {secondPokemon}";
                    break;
                case 28:
                    return $"{firstPokemon} hiding behind a {secondPokemon}";
                    break;
                case 29:
                    return $"{firstPokemon} dressed as a {secondPokemon} for halloween";
                    break;
                case 30:
                    return $"{firstPokemon} mocking {secondPokemon}";
                    break;
                case 31:
                    return $"{firstPokemon} having a tea or picnic";
                    break;
                case 32:
                    return $"{firstPokemon} doing a handstand";
                    break;
                case 33:
                    return $"{firstPokemon} breakdancing";
                    break;
                case 34:
                    return $"{firstPokemon} playing the sims";
                    break;
                case 35:
                    return $"{firstPokemon} playing cards with {secondPokemon}";
                    break;
                case 36:
                    return $"{firstPokemon} throwing a tantrum";
                    break;
                case 37:
                    return $"{firstPokemon} has dropped their icecream";
                    break;
                case 38:
                    return $"{firstPokemon} having dinner with {secondPokemon}";
                    break;
                case 39:
                    return $"{firstPokemon} changing a lightbulb";
                    break;
                case 40:
                    return $"{firstPokemon} giving {secondPokemon} a wedgie";
                    break;
                case 41:
                    return $"{firstPokemon} wearing people clothes";
                    break;
                case 42:
                    return $"{firstPokemon}'s morning routine";
                    break;
                case 43:
                    return $"{firstPokemon} is basically a puppy";
                    break;
                case 44:
                    return $"{firstPokemon} painting a picture of  {secondPokemon}";
                    break;
                case 45:
                    return $"{firstPokemon} walking {secondPokemon}";
                    break;
                case 46:
                    return $"{firstPokemon} having a haircut";
                    break;
                case 47:
                    return $"{firstPokemon} standing on the shoulders of {secondPokemon}";
                    break;
                case 48:
                    return $"{firstPokemon} chasing {secondPokemon}";
                    break;
                case 49:
                    return $"{firstPokemon} learning to drive";
                    break;
                case 50:
                    return $"{firstPokemon} getting married to {secondPokemon}";
                    break;
                case 51:
                    return $"{firstPokemon} in a rap battle against {secondPokemon}";
                    break;
                case 52:
                    return $"{firstPokemon} is so scared!";
                    break;
                case 53:
                    return $"{firstPokemon}'s biggest fear";
                    break;
                case 54:
                    return $"{firstPokemon} climbing a building, King Kong style";
                    break;
                case 55:
                    return $"{firstPokemon} and their little baby {secondPokemon}";
                    break;
                case 56:
                    return $"A {firstPokemon} puppet";
                    break;
                case 57:
                    return $"A mega cute {firstPokemon} plushie";
                    break;
                case 58:
                    return $"{firstPokemon} competing in the olympics";
                    break;
                case 59:
                    return $"{firstPokemon} having a nice bath";
                    break;
                case 60:
                    return $"A band with {firstPokemon} on vocals and {secondPokemon} on the drums";
                    break;
                case 61:
                    return $"{firstPokemon} describing their favourite pokemon";
                    break;
                case 62:
                    return $"{firstPokemon} is very chilly";
                    break;
                case 63:
                    return $"You've just told {firstPokemon} that it can't have some of your malasada";
                    break;
                case 64:
                    return $"{firstPokemon} is the champion";
                    break;
                case 65:
                    return $"{firstPokemon}'s embarrasing school photo";
                    break;
                case 66:
                    return $"{firstPokemon} and {secondPokemon} are up to something...";
                    break;
                case 67:
                    return $"{firstPokemon} and {secondPokemon} having a dance-off";
                    break;
                case 68:
                    return $"{firstPokemon} having the best day ever!";
                    break;
                default:
                    return $"{firstPokemon} battling {secondPokemon}";
                    break;
            }
        }
    }
}

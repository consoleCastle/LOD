using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Tools
{
    static class TauntGenerator
    {
        static string[] relations = {
            "mother",
            "father",
            "grandmother",
            "grandfather",
            "first crush"
        };
        static string[] insultingAnimalsAndObjects = {
            "hamster",
            "microwave oven",
            "rusty acordian",
            "hard boiled egg",
            "fat but charming toad"
        };
        static string[] smells = {
            "elderberries",
            "garbage",
            "gym shorts",
            "fine cheese",
            "Michael Bay's Transformers"
        };
        static string[] insultingPlurals = {
            "smelly dogs",
            "dumb people",
            "idiots",
            "insurance salespeople",
            "weirdos"
        };
        static string[] sadFollowUpPhrases = {
            "nobody likes you",
            "you will never find happiness",
            "children make fun of you",
            "I am actually sorry for you",
            "babies cry when they see you"
        };
        static string[] insultingAdjectives = {
            "ugly",
            "dumb",
            "smelly",
            "actually, factually a potted plant",
            "a loser"
        };
        static Random random = new Random();
        static public string Taunt()
        {
            string relation = relations[random.Next(0, relations.Length)];
            string insultingAnimalAndObject = insultingAnimalsAndObjects[random.Next(0, insultingAnimalsAndObjects.Length)];
            string smell = smells[random.Next(0, smells.Length)];
            string insultingPlural = insultingPlurals[random.Next(0, insultingPlurals.Length)];
            string sadFollowUpPhrase = sadFollowUpPhrases[random.Next(0, sadFollowUpPhrases.Length)];
            string insultingAdjective = insultingAdjectives[random.Next(0, insultingAdjectives.Length)];
            int sentenceNum = random.Next(0, 5);
            switch (sentenceNum)
            {
                case (0):
                    return $"Your {relation} was a {insultingAnimalAndObject}!";
                case (1):
                    return $"{insultingPlural.ToUpper()} GO AWAY";

                case (2):
                    return $"Your {relation} smelled of {smell}!";

                case (3):
                    return $"You are a {insultingAnimalAndObject} and you hang out with {insultingPlural}!";

                case (4):
                    return $"You're {insultingAdjective} and {sadFollowUpPhrase}";

                default:
                    return "This shouldn't happen!";
            }
        }

    }
}

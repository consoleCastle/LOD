using System.Collections.Generic;
using LOD.Utils;


namespace LOD.Classes
{
    class GameRooms
    {

        public Room mountain_top = new Room(
            "mountain_top",
            RoomDescriptions.MountainTop,
            MapRoomMatrices.mountainTopCoor,
            new List<string>
            {
                "Go to the Temple",
                "Go to the Forest",
                "Go to the Desert",
                "Go to the Icy Tundra"
            }
        );
        public Room temple_door = new Room(
            "temple_door",
            RoomDescriptions.TempleDoor,
            MapRoomMatrices.templeCoor,
            new List<string>
            {
                "Go back outside",
                "Read the wall"
            }
        );
        public Room forest_entrance = new Room(
            "forest_entrance",
            RoomDescriptions.ForestEntrance,
            MapRoomMatrices.forestCoor,
            new List<string>
            {
                "Go to the Village",
                "Go back to the Mountain"
            }
        );
        public Room desert = new Room(
            "desert",
            RoomDescriptions.Desert,
            MapRoomMatrices.desertCoor,
            new List<string>
            {
                "Go back to the Mountain",
                "Go to the wall"
            }
        );
        public Room read_the_wall = new Room(
            "read_the_wall",
            RoomDescriptions.ReadTheWall,
            MapRoomMatrices.doorCoor,
            new List<string>
            {
                "Go back"
            }
        );
        public Room open_door = new Room(
            "open_door",
            RoomDescriptions.OpenDoor,
            MapRoomMatrices.dummyCoor
        );
        public Room forest_village = new Room(
            "forest_village",
            RoomDescriptions.ForestVillage,
            MapRoomMatrices.forestVillageCoor,
            new List<string>
            {
                "Go back to the Forest Entrance",
                "Go into the Dark Woods",
                "Go into the Dojo"
            }
        );
        public Room dark_woods = new Room(
            "dark_woods",
            RoomDescriptions.DarkWoods,
            MapRoomMatrices.darkWoodsCoor,
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room dojo = new Room(
            "dojo",
            RoomDescriptions.Dojo,
            MapRoomMatrices.dojoCoor,
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room open_mind = new Room(
            "open_mind",
            RoomDescriptions.OpenMind,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room village_wall = new Room(
            "village_wall",
            RoomDescriptions.VillageWall,
            MapRoomMatrices.desertWallCoor,
            new List<string>
            {
                "Go back to the desert",
                "Try to reason with the man"
            }
        );
        public Room taunt = new Room(
            "taunt",
            RoomDescriptions.Taunt,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Gather yourself and try again"
            }
        );
        public Room desert_village = new Room(
            "desert_village",
            RoomDescriptions.DesertVillage,
            MapRoomMatrices.desertVillageCoor,
            new List<string>
            {
                "Play the rock game",
                "Go back to the desert wall"
            }
        );
        public Room rock_game = new Room(
            "rock_game",
            RoomDescriptions.RockGame,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {

            }
        );
        public Room rock_game_lose = new Room(
            "rock_game_lose",
            RoomDescriptions.RockGameLose,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room rock_game_win = new Room(
            "rock_game_win",
            RoomDescriptions.RockGameWin,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room rock_game_win_again = new Room(
            "rock_game_win_again",
            RoomDescriptions.RockGameWinAgain,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room icy_tundra = new Room(
            "icy_tundra",
            RoomDescriptions.IcyTundra,
            MapRoomMatrices.tundraCoor,
            new List<string>
            {
                "Go back up the Mountain",
                "Go into the Dark Castle",
                "Go into the Ravine"
            }
        );
        public Room ravine = new Room(
            "ravine",
            RoomDescriptions.Ravine,
            MapRoomMatrices.ravineCoor,
            new List<string>
            {
                "Go back down the stairs and leave the Ravine",
                "Enter the Tunnel"
            }
        );
        public Room shelobs_lair = new Room(
            "shelobs_lair",
            RoomDescriptions.ShelobsLair,
            MapRoomMatrices.tunnelCoor,
            new List<string>
            {
                "Leave the Tunnel",
                "Read the Scribbling on Wall"
            }
        );
        public Room read_scribbles = new Room(
            "read_scribbles",
            RoomDescriptions.ReadScribbles,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Leave the Tunnel"
            }
        );
        public Room castle_entrance = new Room(
            "castle_entrance",
            RoomDescriptions.CastleEntrance,
            MapRoomMatrices.castleCoor,
            new List<string>
            {
                "Go back to the icy tundra entrance",
                "Go blindly forward into the castle"
            }
        );
        public Room skeleton_room = new Room(
            "skeleton_room",
            RoomDescriptions.SkeletonRoom,
            MapRoomMatrices.foyerCoor,
            new List<string>
            {
                "Go back to the castle entrance",
                "Tell a Skeleton Joke"
            }
        );
        public Room skeleton_joke = new Room(
            "skeleton_joke",
            RoomDescriptions.SkeletonJoke,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "What was the skeleton's favorite musical instrument? The trom-bone.",
                "What do you call a funny bone? A humerus.",
                "What do bone-y people use to get into their homes? Skeleton Keys!"
            }
        );
        public Room joke_fail = new Room(
            "joke_fail",
            RoomDescriptions.JokeFail,
            MapRoomMatrices.dummyCoor
        );
        public Room joke_no_reaction = new Room(
            "joke_no_reaction",
            RoomDescriptions.JokeNoReaction,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Leave the Castle",
                "Try Again"
            }
        );
        public Room joke_success = new Room(
            "joke_success",
            RoomDescriptions.JokeSuccess,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Leave the Castle",
                "Enter the Throne Room"
            }
        );
        public Room throne_room = new Room(
            "throne_room",
            RoomDescriptions.ThroneRoom,
            MapRoomMatrices.throneRoomCoor,
            new List<string>
            {
                "Go back to the skeleton room"
            }
        );
        public Room three_stones_collected = new Room(
            "three_stones_collected",
            RoomDescriptions.ThreeStonesCollected,
            MapRoomMatrices.dummyCoor,
            new List<string>
            {
                "Go back to the skeleton room"
            }
        );
        public GameRooms()
        {
            mountain_top.Choices.Add("1", temple_door);
            mountain_top.Choices.Add("2", forest_entrance);
            mountain_top.Choices.Add("3", desert);
            mountain_top.Choices.Add("4", icy_tundra);

            temple_door.Choices.Add("1", mountain_top);
            temple_door.Choices.Add("2", read_the_wall);

            read_the_wall.Choices.Add("1", temple_door);

            forest_entrance.Choices.Add("1", forest_village);
            forest_entrance.Choices.Add("2", mountain_top);

            forest_village.Choices.Add("1", forest_entrance);
            forest_village.Choices.Add("2", dark_woods);
            forest_village.Choices.Add("3", dojo);

            dojo.Choices.Add("1", forest_village);

            open_mind.Choices.Add("1", forest_village);

            dark_woods.Choices.Add("1", forest_village);

            desert.Choices.Add("1", mountain_top);
            desert.Choices.Add("2", village_wall);

            desert_village.Choices.Add("1", rock_game);
            desert_village.Choices.Add("2", village_wall);

            rock_game_lose.Choices.Add("1", desert_village);

            rock_game_win.Choices.Add("1", desert_village);

            rock_game_win_again.Choices.Add("1", desert_village);

            village_wall.Choices.Add("1", desert);
            village_wall.Choices.Add("2", taunt);

            taunt.Choices.Add("1", village_wall);

            icy_tundra.Choices.Add("1", mountain_top);
            icy_tundra.Choices.Add("2", castle_entrance);
            icy_tundra.Choices.Add("3", ravine);

            ravine.Choices.Add("1", icy_tundra);
            ravine.Choices.Add("2", shelobs_lair);

            shelobs_lair.Choices.Add("1", icy_tundra);
            shelobs_lair.Choices.Add("2", read_scribbles);

            read_scribbles.Choices.Add("1", icy_tundra);

            castle_entrance.Choices.Add("1", icy_tundra);
            castle_entrance.Choices.Add("2", skeleton_room);

            skeleton_room.Choices.Add("1", castle_entrance);
            skeleton_room.Choices.Add("2", skeleton_joke);

            skeleton_joke.Choices.Add("1", joke_fail);
            skeleton_joke.Choices.Add("2", joke_no_reaction);
            skeleton_joke.Choices.Add("3", joke_success);

            joke_no_reaction.Choices.Add("1", icy_tundra);
            joke_no_reaction.Choices.Add("2", skeleton_joke);

            joke_success.Choices.Add("1", icy_tundra);
            joke_success.Choices.Add("2", throne_room);

            throne_room.Choices.Add("1", skeleton_room);

            three_stones_collected.Choices.Add("1", skeleton_room);
        }
    }
}

using System.Collections.Generic;
using LOD.Utils;


namespace LOD.Classes
{
    class GameRooms
    {
        public Room mountain_top = new Room(
            "mountain_top",
            RoomDescriptions.MountainTop,
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
            new List<string>
            {
                "Go back outside",
                "Read the wall"
            }
        );
        public Room forest_entrance = new Room(
            "forest_entrance",
            RoomDescriptions.ForestEntrance,
            new List<string>
            {
                "Go to the Village",
                "Go back to the Mountain"
            }
        );
        public Room desert = new Room(
            "desert",
            RoomDescriptions.Desert,
            new List<string>
            {
                "Go back to the Mountain",
                "Go to the wall"
            }
        );
        public Room read_the_wall = new Room(
            "read_the_wall",
            RoomDescriptions.ReadTheWall,
            new List<string>
            {
                "Go back"
            }
        );
        public Room open_door = new Room(
            "open_door",
            RoomDescriptions.OpenDoor
        );
        public Room forest_village = new Room(
            "forest_village",
            RoomDescriptions.ForestVillage,
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
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room dojo = new Room(
            "dojo",
            RoomDescriptions.Dojo,
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room open_mind = new Room(
            "open_mind",
            RoomDescriptions.OpenMind,
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room village_wall = new Room(
            "village_wall",
            RoomDescriptions.VillageWall,
            new List<string>
            {
                "Go back to the desert",
                "Try to reason with the man"
            }
        );
        public Room taunt = new Room(
            "taunt",
            RoomDescriptions.Taunt,
            new List<string>
            {
                "Gather yourself and try again"
            }
        );
        public Room desert_village = new Room(
            "desert_village",
            RoomDescriptions.DesertVillage,
            new List<string>
            {
                "Play the rock game",
                "Go back to the desert"
            }
        );
        public Room rock_game = new Room(
            "rock_game",
            RoomDescriptions.RockGame,
            new List<string>
            {

            }
        );
        public Room rock_game_lose = new Room(
            "rock_game_lose",
            RoomDescriptions.RockGameLose,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room rock_game_win = new Room(
            "rock_game_win",
            RoomDescriptions.RockGameWin,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room rock_game_win_again = new Room(
            "rock_game_win_again",
            RoomDescriptions.RockGameWinAgain,
            new List<string>
            {
                "Go back to the desert village"
            }
        );
        public Room icy_tundra = new Room(
            "icy_tundra",
            RoomDescriptions.IcyTundra,
            new List<string>
            {
                "Go back up the Mountain",
                "Go into the Dark Castle"
            }
        );
        public Room castle_entrance = new Room(
            "castle_entrance",
            RoomDescriptions.CastleEntrance,
            new List<string>
            {
                "Go back to the icy tundra entrance",
                "Go blindly forward into the castle"
            }
        );
        public Room skeleton_room = new Room(
            "skeleton_room",
            RoomDescriptions.SkeletonRoom,
            new List<string>
            {
                "Go back to the castle entrance",
                "Go into the throne room",
                "Go into the spider room"
            }
        );
        public Room spider_room = new Room(
            "spider_room",
            RoomDescriptions.SpiderRoom,
            new List<string>
            {
                "Go back to the skeleton room"
            }
        );
        public Room throne_room = new Room(
            "throne_room",
            RoomDescriptions.ThroneRoom,
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

            castle_entrance.Choices.Add("1", icy_tundra);
            castle_entrance.Choices.Add("2", skeleton_room);

            skeleton_room.Choices.Add("1", castle_entrance);
            skeleton_room.Choices.Add("2", throne_room);
            skeleton_room.Choices.Add("3", spider_room);

            spider_room.Choices.Add("1", skeleton_room);

            throne_room.Choices.Add("1", skeleton_room);
        }
    }
}

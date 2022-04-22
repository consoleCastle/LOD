using System;
using System.Collections.Generic;
using System.Text;
using LOD.Utils;
using LOD.Classes;

namespace LOD.Tools
{
    class MapBuilder
    {
        private MapRoomMatrices roomMatrices;
        private Counter roomCounts;
        private GameData gameData;
        private GameRooms gamerooms;

        public void PrintMap()
        {
            PrintRow(GetRowOne(), 0);
            PrintRow(GetRowTwo(), 8);
            PrintRow(GetRowThree(), 16);
            PrintRow(GetRowFour(), 24);
            PrintRow(GetRowFive(), 32);
        }

        public string RoomLabelHelper(string roomLabel, int count)
        {
            roomCounts = new Counter();
            string label;

            if (count > 0)
            {
                label = roomLabel;
            }
            else
            {
                label = "???";
            }
            return label;
        }

        public int[] SetLabelHelper(int rowIndex, int colIndex, int innerIndex, string label, string[,] matrix)
        {
            int[] newIndexes = { 0, 1 };
            int length = label.Length;
            int wordIndex = 0;
            int wordEnd = colIndex + length;
            int endSequence = colIndex + 10;

            while (colIndex <= endSequence)
            {
                if (colIndex < wordEnd)
                {
                    char character = label[wordIndex];
                    matrix[rowIndex, colIndex] = character.ToString();
                    wordIndex++;
                }
                else
                {
                    matrix[rowIndex, colIndex] = " ";
                }
                colIndex++;
                innerIndex++;
            }
            matrix[rowIndex, colIndex] = " ";
            newIndexes[0] = colIndex;
            newIndexes[1] = innerIndex;
            return newIndexes;
        }

        public void turnRoomHighlighterOn(bool turnOn)
        {
            if (turnOn)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else { Console.ForegroundColor = ConsoleColor.White;}
        }

        public void PrintRow(string[,] matrix, int startRowIndex)
        {
            gameData = new GameData();

            int[] currentRoomCoor = GameData.CurrentRoom.Coordinate;
            int highlightRowIndex = currentRoomCoor[0];
            int highlightColIndex = currentRoomCoor[1];
            int highlightCounter = highlightColIndex;
            int endHighlightIndex = highlightColIndex + 15;
            bool highlighterOn = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var value = matrix[i, j];
                    if (highlightRowIndex == startRowIndex)
                    {
                        if (highlightColIndex == j)
                        {
                            turnRoomHighlighterOn(true);
                            highlighterOn = true;
                            Console.Write("{0}", value);
                        } 
                        else if ((j > highlightColIndex) && (highlighterOn))
                        {
                            if (highlightCounter >= endHighlightIndex)
                            {
                                turnRoomHighlighterOn(false);
                                highlighterOn = false;
                            }
                            Console.Write("{0}", value);
                            highlightCounter++;
                        }
                        else
                        {
                            Console.Write("{0}", value);
                        }
                    }
                    else
                    {
                        Console.Write("{0}", value);
                    }
                }
                highlightCounter = highlightColIndex;
                Console.WriteLine();
            }
        }

        public string[,] GetRowOne()
        {
            roomMatrices = new MapRoomMatrices();
            gamerooms = new GameRooms();

            string[,] emptyRoom = roomMatrices.emptyRoomMatrix;
            string[,] southEntrRoom = roomMatrices.southEntranceMatrix;

            string[,] rowMatrix = new string[8, 95];

            for (int i = 0; i < rowMatrix.GetLength(0); i++)
            {
                int currentInnerIndex = 0;
                int currentMasterIndex = 0;
                int currentEndIndex = 18;
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Tunnel- Shelob's Lair
                while (currentMasterIndex < currentEndIndex)
                {
                    if (southEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Tunnel", Counter.shelobs_lair);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0] - 1;
                        currentInnerIndex =newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = southEntrRoom[i, currentInnerIndex];
                        currentInnerIndex++;
                    }
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Temple Door
                while (currentMasterIndex < currentEndIndex)
                {
                    if (southEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Door", Counter.read_the_wall);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = southEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
            }
            return rowMatrix;
        }
        public string[,] GetRowTwo()
        {
            roomMatrices = new MapRoomMatrices();
            gamerooms = new GameRooms();
            string[,] emptyRoom = roomMatrices.emptyRoomMatrix;
            string[,] southEntrRoom = roomMatrices.southEntranceMatrix;

            string[,] rowMatrix = new string[8, 95];

            for (int i = 0; i < rowMatrix.GetLength(0); i++)
            {
                int currentInnerIndex = 0;
                int currentMasterIndex = 0;
                int currentEndIndex = 18;
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Ravine
                while (currentMasterIndex < currentEndIndex)
                {
                    if (southEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Ravine", Counter.ravine);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = southEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Temple - NO hidden feature
                while (currentMasterIndex < currentEndIndex)
                {
                    if (southEntrRoom[i, currentInnerIndex] == "*")
                    {
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, "Temple", rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = southEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Dark Woods
                while (currentMasterIndex < currentEndIndex)
                {
                    if (southEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("DarkWoods", Counter.dark_woods);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = southEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
            }
            return rowMatrix;
        }
        public string[,] GetRowThree()
        {
            roomMatrices = new MapRoomMatrices();
            gamerooms = new GameRooms();
            string[,] centerRoom = roomMatrices.centerMatrix;
            string[,] eastEntrRoom = roomMatrices.eastEntranceMatrix;
            string[,] eastEdgeRoom = roomMatrices.eastEdgeMatrix;
            string[,] westEntrRoom = roomMatrices.westEntranceMatrix;
            string[,] westEdgeRoom = roomMatrices.westEdgeMatrix;

            string[,] rowMatrix = new string[8, 95];

            for (int i = 0; i < rowMatrix.GetLength(0); i++)
            {
                int currentInnerIndex = 0;
                int currentMasterIndex = 0;
                int currentEndIndex = 18;
                // Castle
                while (currentMasterIndex < currentEndIndex)
                {
                    if (eastEdgeRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Castle", Counter.castle_entrance);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = eastEdgeRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Tundra - NO hidden feature
                while (currentMasterIndex < currentEndIndex)
                {
                    if (eastEntrRoom[i, currentInnerIndex] == "*")
                    {
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, "Tundra", rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = eastEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // MountainTop - NO hidden feature
                while (currentMasterIndex < currentEndIndex)
                {
                    if (centerRoom[i, currentInnerIndex] == "*")
                    {
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, "MountainTop", rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = centerRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Forest - NO hidden feature
                while (currentMasterIndex < currentEndIndex)
                {
                    if (westEntrRoom[i, currentInnerIndex] == "*")
                    {
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, "Forest", rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = westEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Village
                while (currentMasterIndex < currentEndIndex)
                {
                    if (westEdgeRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Village", Counter.forest_village);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = westEdgeRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
            }
            return rowMatrix;
        }
        public string[,] GetRowFour()
        {
            roomMatrices = new MapRoomMatrices();
            gamerooms = new GameRooms();
            string[,] emptyRoom = roomMatrices.emptyRoomMatrix;
            string[,] northEntrRoom = roomMatrices.northEntranceMatrix;

            string[,] rowMatrix = new string[8, 95];

            for (int i = 0; i < rowMatrix.GetLength(0); i++)
            {
                int currentInnerIndex = 0;
                int currentMasterIndex = 0;
                int currentEndIndex = 18;
                // Foyer
                while (currentMasterIndex < currentEndIndex)
                {
                    if (northEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Foyer", Counter.skeleton_room);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = northEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Desert - NO hidden feature
                while (currentMasterIndex < currentEndIndex)
                {
                    if (northEntrRoom[i, currentInnerIndex] == "*")
                    {
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, "Desert", rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = northEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Dojo
                while (currentMasterIndex < currentEndIndex)
                {
                    if (northEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Dojo", Counter.dojo);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = northEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
            }
            return rowMatrix;
        }
        public string[,] GetRowFive()
        {
            roomMatrices = new MapRoomMatrices();
            gamerooms = new GameRooms();
            string[,] emptyRoom = roomMatrices.emptyRoomMatrix;
            string[,] northEntrRoom = roomMatrices.northEntranceMatrix;
            string[,] northEdgeRoom = roomMatrices.northEdgeMatrix;
            string[,] westEdge2Room = roomMatrices.westEdge2Matrix;

            string[,] rowMatrix = new string[8, 95];

            for (int i = 0; i < rowMatrix.GetLength(0); i++)
            {
                int currentInnerIndex = 0;
                int currentMasterIndex = 0;
                int currentEndIndex = 18;
                // ThroneRoom
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = northEntrRoom[i, currentInnerIndex];
                    if (northEntrRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("ThroneRoom", Counter.throne_room);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = northEntrRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Wall
                while (currentMasterIndex < currentEndIndex)
                {
                    if (northEdgeRoom[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Wall", Counter.desert_wall);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = northEdgeRoom[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                // Village
                while (currentMasterIndex < currentEndIndex)
                {
                    if (westEdge2Room[i, currentInnerIndex] == "*")
                    {
                        string label = RoomLabelHelper("Village", Counter.desert_village);
                        int[] newIndex = SetLabelHelper(i, currentMasterIndex, currentInnerIndex, label, rowMatrix);
                        currentMasterIndex = newIndex[0];
                        currentInnerIndex = newIndex[1];
                    }
                    else
                    {
                        rowMatrix[i, currentMasterIndex] = westEdge2Room[i, currentInnerIndex];
                    }
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
                currentInnerIndex = 0;
                currentEndIndex = ((currentMasterIndex) + 19);
                while (currentMasterIndex < currentEndIndex)
                {
                    rowMatrix[i, currentMasterIndex] = emptyRoom[i, currentInnerIndex];
                    currentInnerIndex++;
                    currentMasterIndex++;
                }
            }
            return rowMatrix;
        }

    }
}
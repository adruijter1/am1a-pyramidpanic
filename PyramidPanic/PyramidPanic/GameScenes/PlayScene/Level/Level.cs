// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;

namespace PyramidPanic
{
    public class Level
    {
        // Fields
        private PyramidPanic game;
        private int levelIndex;
        private Stream stream;
        private List<String> lines;
        private Block[,] blocks;

        // Properties
        public PyramidPanic Game
        {
            get { return this.game; }
        }
        public int LevelIndex
        {
            get { return this.levelIndex; }
        }

        // Constructor
        public Level(PyramidPanic game, int levelIndex)
        {
            this.game = game;
            this.levelIndex = levelIndex;

            //Laad het textbestand met behulp van een stream object
            this.stream = TitleContainer.OpenStream(@"Content\Level\0.txt");
            this.LoadAssets();
        }


        // Update



        // Draw
        public void Draw(GameTime gameTime)
        {
            // Het blocks-array wordt getekend
            for (int row = 0; row < this.blocks.GetLength(1); row++)
            {
                for (int column = 0; column < this.blocks.GetLength(0); column++)
                {
                    this.blocks[column, row].Draw(gameTime);
                }
            }
        }

        private void LoadAssets()
        {
            // Deze list van strings slaat elke regel van 0.txt op
            this.lines = new List<string>();
            
            // Het readerobject kan lezen wat er in het tekstbestand staat.
            StreamReader reader = new StreamReader(this.stream);

            // Lees de eerste regel uit het tekstbestand in
            string line = reader.ReadLine();

            // Bepaal hoeveel tekens een regel lang is (blijkt 20 te zijn)
            int lineWidth = line.Length;

            // De while lus leest alle regels uit het tekstbestand en zet deze 
            // in de list<String> this.lines
            while (line != null)
            {
                // Stop de uitgelezen regel in de List<String> this.lines
                this.lines.Add(line);
                // Lees de volgende regel uit het tekstbestand met reader.Readline()
                line = reader.ReadLine();
            }

            // Bepaal uit hoeveel regels het tekstbestand bestaat (blijken 15 regels te zijn)
            int amountOfLines = this.lines.Count;
            
            // Vernietig het reader object. Niet meer nodig. Het bestand is uitgelezen
            reader.Close();
            // Vernietig het stream object. Niet meer nodig. Het bestand is uitgelezen.
            this.stream.Close(); 

            // Dit tweedimensionale array bevat block-objecten
            this.blocks = new Block[lineWidth, amountOfLines];

            //We gaan het blocks-array doorlopen met een dubbele for-lus
            for (int row = 0; row < amountOfLines; row++)
            {
                for (int column = 0; column < lineWidth; column++)
                {
                    //We lezen iedere letter uit de lines-list uit in een char variabele
                    char blockElement = this.lines[row][column];
                    this.blocks[column, row] = this.LoadBlock(blockElement, column * 32, row * 32);
                }
            }
        }

        public Block LoadBlock(char blockElement, int x, int y)
        {
            switch (blockElement)
            {
                case 'x':
                    return new Block(this.game, @"Block\Block", new Vector2(x, y)); 
                case '.':
                    return new Block(this.game, @"Block\Transparant", new Vector2(x, y));
                default:
                    return new Block(this.game, @"Block\Transparant", new Vector2(x, y));
            }
        }
    }
}

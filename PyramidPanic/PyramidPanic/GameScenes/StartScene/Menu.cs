// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class Menu
    {
        //Fields
        //Maak een variabele (reference) van het type Image
        private Image start, load, help, scores, quit;

        //Deze variabelen zorgen voor de juiste afstand tussen de knopen
        private int top = 20, bottom = 430, space = 120;

        //Maak een variabele (reference) van het type PyramidPaniic
        private PyramidPanic game;


        //Constructor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        public void Initialize()
        {
            this.LoadContent();
        }

        public void LoadContent()
        {
            this.start = new Image(this.game, @"StartScene\Button_start", new Vector2(this.top, this.bottom));
            this.load = new Image(this.game, @"StartScene\Button_load", new Vector2(this.top + 1 * this.space, this.bottom));
            this.help = new Image(this.game, @"StartScene\Button_help", new Vector2(this.top + 2 * this.space, this.bottom));
            this.scores = new Image(this.game, @"StartScene\Button_scores", new Vector2(this.top + 3 * this.space, this.bottom));
            this.quit = new Image(this.game, @"StartScene\Button_quit", new Vector2(this.top + 4 * this.space, this.bottom));
        }


        //Update
        public void Update(GameTime gameTime)
        {

        }


        //Draw
        public void Draw(GameTime gameTime)
        {
            this.start.Draw(gameTime);
            this.load.Draw(gameTime);
            this.help.Draw(gameTime);
            this.scores.Draw(gameTime);
            this.quit.Draw(gameTime);
        }
    }
}

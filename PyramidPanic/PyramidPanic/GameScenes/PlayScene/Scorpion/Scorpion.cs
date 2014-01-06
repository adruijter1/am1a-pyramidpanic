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
    public class Scorpion : AnimatedSprite
    {
        //Fields
        private PyramidPanic game;
        private Texture2D texture;
        
        //Properties
        public PyramidPanic Game
        {
            get { return this.game; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
        }


        //Constructor
        public Scorpion(PyramidPanic game) : base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion\Scorpion");
        }



        //Update
        public void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);                   
        }
    }
}

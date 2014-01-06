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
    public class Beetle : AnimatedSprite
    {
        //Fields
        private PyramidPanic game;
        private Texture2D texture;
        private int speed = -2;
        
        //Constructor
        public Beetle(PyramidPanic game) : base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Beetle\Beetle");
            this.destinationRectangle.X = 0;
            this.destinationRectangle.Y = 400;
        }

        //Update
        public new void Update(GameTime gameTime)
        {
            if (this.destinationRectangle.Y > (480 - 32) ||
                this.destinationRectangle.Y < 0)
            {
                if (this.speed > 0)
                {
                    this.effect = SpriteEffects.None;
                }
                else
                {
                    this.effect = SpriteEffects.FlipVertically;
                }
                this.speed = this.speed * -1;
            }
            this.destinationRectangle.Y += this.speed;
            base.Update(gameTime);
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);                   
        }
    }
}

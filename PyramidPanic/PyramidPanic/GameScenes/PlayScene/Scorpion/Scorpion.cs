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
    public class Scorpion
    {
        //Fields
        private PyramidPanic game;
        private Texture2D texture;
        private Rectangle destinationRectangle, sourceRectangle;
        private float timer = 0f;


        //Properties


        //Constructor
        public Scorpion(PyramidPanic game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion\Scorpion");
            this.sourceRectangle = new Rectangle(64, 0, 32, 32);
            this.destinationRectangle = new Rectangle(100, 200, this.texture.Width/4, this.texture.Height);
        }



        //Update
        public void Update(GameTime gameTime)
        {
            if (this.timer > 5 / 60f)
            {
                if (this.sourceRectangle.X < 96)
                {
                    this.sourceRectangle.X += 32;
                }
                else
                {
                    this.sourceRectangle.X = 0;
                }
                this.timer = 0f;
            }
            
            this.timer += 1 / 60f;
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.SpriteBatch.Draw(this.texture,
                                       this.destinationRectangle,
                                       this.sourceRectangle,
                                       Color.White,
                                       0f,
                                       Vector2.Zero,
                                       SpriteEffects.None,
                                       0f);                                        
        }
    }
}

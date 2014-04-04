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
    public class LevelDoorOpen : ILevel
    {
         // Fields
        private Level level;
        private Image overlay, message;
        private float timer = 0f;

        // Properties

        // Constructor
        public LevelDoorOpen(Level level)
        {
            this.level = level;
            this.overlay = new Image(level.Game, @"Overlay\overlay", Vector2.Zero, '.');
            this.message = new Image(level.Game, @"Overlay\message", new Vector2(170f, 140f), '.');
            this.overlay.Color = new Color(0f, 0f, 0f, 0.6f);
        }

        // Update
        public void Update(GameTime gameTime)
        {
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (this.timer > 1.5f)
            {  
                this.level.State = this.level.Play;
                this.timer = 0f;
            }
        }
        
        // Draw
        public void Draw(GameTime gameTime)
        {
            this.overlay.Draw(gameTime);
            this.message.Draw(gameTime);
        }
    }
}

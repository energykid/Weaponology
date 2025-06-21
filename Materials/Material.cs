using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace Weaponology.Materials
{
    public abstract class Material
    {
        public string Name = "";
        public int ItemType;
        public Types.MaterialClass Class;
        public string GradientFile = "";
        public Material(string name, int item, Types.MaterialClass type) {
            Name = Name;
            ItemType = item;
            Class = type;
        }
        public void SetShader()
        {
            WayLib.Graphics.Gradients.SetCurrentGradient(GradientFile, 0);
            Main.spriteBatch.End();
            Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, null, null, WayLib.WayLib.GradientShader, Main.GameViewMatrix.ZoomMatrix);
        }
        public void ResetShader()
        {
            Main.spriteBatch.End(); 
            Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, null, null, null, Main.GameViewMatrix.ZoomMatrix);
        }
    }

    public class Types
    {
        public enum MaterialClass
        {
            Metal,
            Gem,
            Wood,
            Magic
        }

        public enum WeaponClass
        {
            Blade,
            Polearm,
            Tool,
            Curved
        }
    }
}

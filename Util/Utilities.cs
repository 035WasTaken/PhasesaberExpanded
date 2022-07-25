using Microsoft.Xna.Framework;

namespace PhasesaberExpanded.Util
{
    public class Utilities
    {
        public static (float r, float g, float b) GetRGBTuple(int r, int g, int b) {
            float red = (r / 1000) * 4;
            float green = (g / 1000) * 4;
            float blue = (b / 1000) * 4;

            return (red, green, blue);
        }

        public static Vector3 GetRGBVector(int r, int g, int b) {
            float red = (r / 1000) * 4;
            float green = (g / 1000) * 4;
            float blue = (b / 1000) * 4;

            return new Vector3(red, green, blue);
        }
    }
}
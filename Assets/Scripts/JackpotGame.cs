using UnityEngine;


    public class JackpotGame
    {
        // public const float waitTime = 0.05f;
        

        public static Color GetColor(int colorChoice)
        {
            switch (colorChoice)
            {
                case 1: return new Color(0.372549f,0.6447293f,0.9254902f,1);
                case 2: return new Color(0.9245283f,0.3706835f,0.3706835f,1);
                case 3: return Color.green;
                case 4: return Color.yellow;
                case 5: return Color.cyan;
                case 6: return Color.grey;
                case 7: return Color.magenta;
                case 8: return new Color(0.6f,0.3f,0.0902f,1);
                case 9: return Color.black;
                case 10: return Color.red;
            }

            return Color.black;
        }
    }

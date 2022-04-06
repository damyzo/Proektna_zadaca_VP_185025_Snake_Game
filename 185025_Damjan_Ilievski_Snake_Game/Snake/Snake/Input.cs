using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class Input
    {
        //Lista od kopchinja
        public static Hashtable keyTable = new Hashtable();

        //Proverka dali e pritisnato kopche
        public static bool keyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detektiranje na pritisnato kopche
        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}

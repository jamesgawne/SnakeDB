using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Allows us to use the Keys class from Windows.Forms


namespace SnakeDB
{
    class Input
    {
        //Creates a new instance of the Hashtable Class.
        private static readonly Hashtable keyTable = new Hashtable();
        
        public static bool KeyPress(Keys key)
        {
            //this fuction will return a key back to the class
            //at this point don't worry about the red sqigglies under 
            //the keyTable name.
            if (keyTable[key] == null)
            {
                //if the hashtable is empty the we return false.
                return false;
            }
            return (bool)keyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            //this functin will change thew state of the keys
            //this function takes two augumnets (key & state)
            keyTable[key] = state;
        }
    }
}

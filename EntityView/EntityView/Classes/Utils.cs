using System;

namespace EntityView.Classes
{
    public static class Utils
    {
        public static string GetStateString(bool success, bool isNew)
        {
            if (success)
            {
                if (isNew)
                    return ("Successfully created on " + DateTime.Now.ToString());
                else
                    return ("Successfully updated on " + DateTime.Now.ToString());
            }
            else
            {
                if (isNew)
                    return ("Create failed");
                else
                    return ("Update failed");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Globals
    {
        public static int GlobalUserId { get; private set; }

        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}

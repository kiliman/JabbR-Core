﻿using System;
using System.Collections.Generic;

namespace JabbR_Core.Models
{
    public partial class ChatUserIdentities
    {
        public int Key { get; set; }
        public int UserKey { get; set; }
        public string Email { get; set; }
        public string Identity { get; set; }
        public string ProviderName { get; set; }

        public virtual ChatUsers UserKeyNavigation { get; set; }
    }
}

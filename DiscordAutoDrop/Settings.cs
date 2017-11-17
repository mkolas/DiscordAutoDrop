﻿using System;
using System.Collections.Generic;
using DiscordAutoDrop.ViewModels;

namespace DiscordAutoDrop
{
   [Serializable]
   public sealed class Settings
   {
      public List<DiscordDropViewModel> DiscordDrops { get; set; }
      public string UserToken { get; set; }

      public ulong TargetChannelId { get; set; } = 153577153320058881;
   }
}

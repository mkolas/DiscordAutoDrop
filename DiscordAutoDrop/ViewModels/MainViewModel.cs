﻿using System.Collections.ObjectModel;
using DiscordAutoDrop.MVVM;

namespace DiscordAutoDrop.ViewModels
{
   internal sealed class MainViewModel : ViewModelBase
   {
      public HotkeyManager Manager { get; } = new HotkeyManager();

      public ObservableCollection<DiscordDropViewModel> DiscordDrops { get; } = new ObservableCollection<DiscordDropViewModel>();

      public RelayCommand AddDropCommand { get; set; }
      public RelayCommand<DiscordDropViewModel> RemoveDropCommand { get; set; }
   }
}

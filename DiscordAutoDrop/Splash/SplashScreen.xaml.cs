﻿using System.Collections.Generic;
using System.Collections.Immutable;

namespace DiscordAutoDrop.Splash
{
   public enum LoadingTask
   {
      Initializing,
      LaunchingInspect,
      InitializingUIAutomation,
      FindingDiscord,
      FindingDiscordMessageBox
   }

   public partial class SplashScreen
   {
      private readonly ImmutableDictionary<LoadingTask, string> _stepToTaskDictionary = new Dictionary<LoadingTask, string>
      {
         [LoadingTask.Initializing] = "Initializing...",
         [LoadingTask.LaunchingInspect] = "Injecting UI Automation DLLs...",
         [LoadingTask.InitializingUIAutomation] = "Initializing UI Automation Search Trees...",
         [LoadingTask.FindingDiscord] = "Finding Discord window...",
         [LoadingTask.FindingDiscordMessageBox] = "Finding Discord message box..."
      }.ToImmutableDictionary();

      public SplashScreen()
      {
         InitializeComponent();

         DisplayTask( LoadingTask.Initializing );
      }

      public void DisplayTask( LoadingTask task )
      {
         SplashLabel.Text = _stepToTaskDictionary[task];
      }
   }
}
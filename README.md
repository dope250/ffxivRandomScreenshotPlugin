# Random Screenshot

 FFXIV Plugin for Dalamud.

Makes Screenshots at a random interval with or without UI. Looking pretty awesome in battle scenes where you don't have time to do anything else.
Be careful when setting the interval to short, it can get messy on your harddrive.

## Features

* Screenshot
  * Random Interval
  * With UI
  * or without

## To Use
### Hotkey

1. Open up die keyboard binding in ffxiv and set the "Hide UI" bind to "ALT+Y". This will be used by the plugin.

### Activating in-game

1. Launch the game and use `/xlsettings` in chat or `xlsettings` in the Dalamud Console to open up the Dalamud settings.
    * In here, go to `Experimental`, and add the full path to the `SamplePlugin.dll` to the list of Dev Plugin Locations.
2. Next, use `/xlplugins` (chat) or `xlplugins` (console) to open up the Plugin Installer.
    * In here, go to `Dev Tools > Installed Dev Plugins`, and the `SamplePlugin` should be visible. Enable it.
3. You should now be able to use `/pmycommand` (chat) or `pmycommand` (console)!

Note that you only need to add it to the Dev Plugin Locations once (Step 1); it is preserved afterwards. You can disable, enable, or load your plugin on startup through the Plugin Installer.

### Reconfiguring for your own uses

Basically, just replace all references to `SamplePlugin` in all of the files and filenames with your desired name. You'll figure it out 😁

Dalamud will load the JSON file (by default, `Data/SamplePlugin.json`) next to your DLL and use it for metadata, including the description for your plugin in the Plugin Installer. Make sure to update this with information relevant to _your_ plugin!
Originally written by  @vXSovereignXv, it was adopted by @sarbian for a while.

@sarbiangave permission for me to adopt it, his thread is here:  https://forum.kerbalspaceprogram.com/index.php?/topic/55485-12x-kerbal-crew-manifest-v0640-dec-30th-2016/

This plugin will allow you to add or remove crew from parts while on the launch pad or transfer crew between parts in the same vessel. You can also edit/add custom crew members in your available crew roster provided that they are not part of an active flight (or dead).

Pics

Crew Manifest Window

  Reveal hidden contents
  https://i.imgur.com/Mcr4ToQ.png
 

Crew Roster Window

  Reveal hidden contents
  https://i.imgur.com/eAlTBY3.png


Create A Kerbal Window

  Reveal hidden contents
  https://i.imgur.com/fvJFJ58.png
 

Instructions:

In the flight scene:

Click on the Manifest Icon to show the Manifest Window.
Crew Manifest:

To Add or Remove Crew you must be landed at the Runway or Launchpad. Select the part from the top list (the part will be highlighted in yellow). The bottom list will show the crew of that part and actions that can be performed (Add or Remove).
You can also open the Crew Roster window to add specific Kerbals to the selected part. Click the "Add" button next to their name.
Crew Transfer:

To Transfer Crew, click the Transfer Crew button at the bottom of the Manifest Window.
A new window will popup. You can select a part on the left and move crew from that part to the select part on the right (or Vice Versa).
The left selected part will be highlighted in green while the right selection will be highlighedt in red.
Clicking the "Out" button will send the Kerbal to the other selected Part.
Use the "Update Portraits" button to refresh the crew portraits if they did not load correctly during transfer.
Crew Roster:

To open the Crew Roster, click the button on the Crew Manifest window
To Edit a Kerbal, click the edit button next to their name. Kerbal names in Red are assigned to a Vessel and cannot be modified.
Name, Courage, Stupidity, and the badass flag can all be modified.
Click the "Apply" button to submit changes. Cancel will revert your changes.
To Create a Kerbal click the "Create Kerbal" button at the bottom of the window. This will generate a semi-random Kerbal that can be further modified.(Uses the games code. It's not entirely random.)
Click the "Apply" button to add the new Kerbal to the Manifest.
Availability

License: MIT
Source code: https://github.com/linuxgurugamer/CrewManifest
Download:  https://spacedock.info/mod/3097/CrewManifest
Available via CKAN

Changes

Fixed flashing screen when opening crew manifest right after launching
New Dependencies
ClickThroughBlocker
ToolbarController
SpaceTuxLibrary
Replaced toolbar code with the ToolbarController
Added ClickThroughBlocker support
Updated the GUI.DragWindow to allow dragging from the entire window, not just the top

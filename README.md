# Terminal Tools

A Lethal Company mod to make the ship's terminal a bit more useful. Allows manipulating the ship's doors, lights, and teleporters, allows you to launch or land the ship, and provides status information about crewmember health and the current time.

## Equipment Commands

### Teleport
- **Description**: Teleport the specified member of the crew.
- **Usage**: `Teleport [Player Name]`
- **Details**: Teleports a specified player to a set location. If no player is specified, it attempts to teleport the player currently targeted in the map screen.

### InverseTeleport
- **Description**: Start the inverse teleporter.
- **Usage**: `Inverse`
- **Details**: Initiates the inverse teleportation process. Checks if the teleporter is available and interactable before initiating.

### ResetInverse
- **Description**: Resets the inverse teleporter cooldown.
- **Usage**: `ResetInverse`, `Reset`
- **Details**: Resets the cooldown for the inverse teleporter, allowing it to be used again immediately.

### Scramble
- **Description**: Reset then activate inverse teleporter.
- **Usage**: `Scramble`
- **Details**: Performs a reset of the inverse teleporter's cooldown and then immediately initiates inverse teleportation.

## Ship Commands

### Lights
- **Description**: Toggle the lights on or off.
- **Usage**: `Lights`
- **Details**: Turn the lights on or off. Useful for when one of your crewmates is a joker with a remote.

### Door
- **Description**: Toggle the door's open or close state.
- **Usage**: `Door`, `Doors`
- **Details**: Determines the current state of the ship's door and opens or closes it.

### Close
- **Description**: Close the door.
- **Usage**: `Close`
- **Details**: Closes the ship's door and provides current door power.

### Open
- **Description**: Open the door.
- **Usage**: `Open`
- **Details**: Opens the ship's door and provides current door power.

### Launch
- **Description**: Launches the ship.
- **Usage**: `Launch`, `GTFO`
- **Details**: Launches the ship.

### Land
- **Description**: Land the ship.
- **Usage**: `Land`
- **Details**: Lands the ship.

## Info Commands

### Time
- **Description**: Tells the current time.
- **Usage**: `Time`
- **Details**: Provides the current time.

### Status
- **Description**: Get the status of crew members.
- **Usage**: `Status [Player name]`
- **Details**: Displays the status (health / cause of death) of the designated crew member. If none is specified, lists the status of all crew members.

### Clear
- **Description**: Clears the console.
- **Usage**: `Clear`
- **Details**: Clears all text from the console, providing a clean slate for new commands and responses.

## Entity Commands

### ListMines
- **Description**: Lists all landmines.
- **Usage**: `ListMines`
- **Details**: Scans for landmines and returns their object codes.

### ListTurrets
- **Description**: Lists all turrets.
- **Usage**: `ListTurrets`
- **Details**: Scans for turrets and returns their object codes.

### ListDoors
- **Description**: Lists all doors.
- **Usage**: `ListDoors`
- **Details**: Scans for doors and returns their object codes.

### Detonate
- **Description**: Detonates designated landmine(s).
- **Usage**: `Detonate [All / Mine Id]`
- **Details**: Detonate a mine by its code, or detonate all mines with "all".

### Berserk
- **Description**: Makes designated turret(s) go berserk.
- **Usage**: `Berserk [All / Turret Id]`
- **Details**: Make the selected turret fire uncontrollably, or use "all" for absolute mayhem.

## Other Commands

There are a few commands that aren't listed here. They're mostly used for debugging and testing, but I don't want to encourage their use. If you happen to find out what they are from the source code, though, I can't stop you from using them.

Happy hunting ;)

## Changes

Refer to the [Changelog](https://github.com/Nasawa/LethalAPI.Terminal/blob/development/CHANGELOG.md).

## Attribution

This document and the associated commands are based on the work found in the original repository. For more detailed information, contributions, or to view the source code, please visit:

[LethalAPI.Terminal](https://github.com/LethalCompany/LethalAPI.Terminal)

## Acknowledgements

The development of this README was assisted by AI tools provided by OpenAI. Their guidance and information helped in compiling the summaries and structuring this document.

## Disclaimer

Please note that the code and commands provided in this repository are currently in **beta**. While every effort is made to ensure reliability and functionality, the code is still under development and may contain bugs or issues. **No guarantees are made regarding its functionality or success**. Users are advised to use this code at their own risk and to report any issues they encounter to help improve the project.


# Pin Throw Game

## Overview
**Pin Throw** is a fun and challenging arcade-style game where players must strategically throw pins onto a rotating circle without letting them collide. The game features multiple difficulty levels, sound effects, and visual feedback to enhance the gaming experience. It’s a test of timing, precision, and strategy!

---

## Features
- **Three Difficulty Levels**:
  - **Easy**: Fewer pins and slower rotation speed.
  - **Medium**: More pins and moderate rotation speed.
  - **Hard**: Even more pins, faster rotation, and one throw adds two pins to the circle.
- **Dynamic Gameplay**: Pins rotate around a central circle, and players must time their throws carefully to avoid collisions.
- **Win/Lose Conditions**:
  - **Win**: Successfully place all pins without collisions.
  - **Lose**: Pins collide, ending the game.
- **Sound Effects**: Audio feedback for pin throws, wins, and losses.
- **Visual Feedback**: The screen changes color to indicate wins (green) or losses (red).
- **Replayability**: Players can restart the game or exit after a win or loss.

---

## How to Play
1. **Start the Game**:
   - Choose a difficulty level when launching the game.
   - The game begins with a rotating circle and a set number of pins to throw.

2. **Throw Pins**:
   - Click the "Throw Pin" button (or press the **Spacebar**) to launch a pin onto the rotating circle.
   - Each pin will stick to the circle at its current rotation angle.

3. **Avoid Collisions**:
   - If two pins come too close to each other (within a certain angle), they will collide, and the game will end.

4. **Win the Game**:
   - Successfully place all pins onto the circle without any collisions to win.

5. **Restart or Exit**:
   - After a win or loss, you can restart the game or exit.

---

## Controls
- **Throw Pin**: Click the "Throw Pin" button or press the **Spacebar**.
- **Restart Game**: Click the "Restart" button after a win or loss.
- **Exit Game**: Click the "Exit" button to close the game.

---

## Technical Details
- **Programming Language**: C#
- **Framework**: .NET Windows Forms
- **Graphics**: Custom drawing using `Graphics` and `Bitmap` classes.
- **Sound**: Sound effects for pin throws, wins, and losses using `SoundPlayer`.

---

## Requirements
- **.NET Framework**: Installed on the system.

---

## Installation
1. Download the game files.
2. Ensure the `.wav` sound files (`click.wav`, `win.wav`, `fail.wav`) are in the same directory as the executable.
3. Run the executable file to start the game.

---

## Credits
- Developed as a fun project to practice C# and game development.
- Sound effects sourced from free sound libraries (replace with actual credits if applicable).

---

Enjoy playing **Pin Throw**! Test your skills and see how many pins you can place without a collision! 🎮

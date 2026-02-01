# Rig for Red - Main Menu

## Overview
This is the main menu screen for "Rig for Red", a 2D submarine sonar-themed strategy game with ear training mechanics.

## Files Created

### Scenes
- `Assets/Scenes/MainMenu.unity` - The main menu scene with sonar display aesthetic

### Scripts
- `Assets/Scripts/MainMenuController.cs` - Handles button functionality (Start, Instructions, Exit)
- `Assets/Scripts/SonarEffect.cs` - Creates pulsing sonar effect animation on UI elements

## Design Features

### Visual Theme
- **Green sonar display background** - Dark green color (#0D4D26) mimicking submarine sonar screens
- **Camera background** - Medium green (#008033) for sonar panel effect
- **Pixel Perfect Canvas** - Enabled for crisp 2D pixel art rendering
- **Resolution** - 1920x1080 reference resolution with scaling

### UI Elements
1. **Title: "RIG FOR RED"**
   - Red color (#FF0000)
   - Large bold font (80pt)
   - Positioned at top of screen
   - Has sonar pulse effect (fades in/out)

2. **Three Buttons:**
   - **START** - Loads game level
   - **INSTRUCTIONS** - Shows game instructions
   - **EXIT** - Quits the application
   
   Button styling:
   - Green submarine sonar theme
   - Hover effects (brighten on mouseover)
   - Bright green text on darker green background
   - Pixel-perfect alignment

### Effects
- **Sonar Pulse Animation**: Title text pulses like a sonar ping (0.7-1.0 alpha)
- **Button Hover States**: Buttons light up when hovered over
- **Smooth Color Transitions**: 0.1s fade duration

## Setup Instructions

### 1. Add MainMenu Scene to Build Settings
1. Open Unity Editor
2. Go to `File > Build Settings`
3. Click `Add Open Scenes` or drag `MainMenu.unity` into the scene list
4. Make sure MainMenu is at index 0 (first scene)

### 2. Create Additional Scenes
You need to create two more scenes for the buttons to work:
- `GameLevel.unity` - Your actual game scene
- `Instructions.unity` - Instructions screen

Then update the scene names in `MainMenuController.cs` if you use different names.

### 3. Update Build Settings
Add all three scenes to the build settings in this order:
1. MainMenu
2. Instructions (or your actual scene name)
3. GameLevel (or your actual scene name)

## Customization

### To Change Colors
Edit the color values in `MainMenu.unity`:
- **Background**: GameObject "Background" > Image component
- **Title**: GameObject "Title" > Text component
- **Buttons**: Button GameObjects > Image components

### To Add Pixel Font
1. Import your pixel font into the project
2. Select the Title and Button Text objects
3. Replace the Font property with your pixel font
4. Adjust font size as needed for pixel-perfect rendering

### To Add Sonar Graphics
You can enhance the visual design by:
1. Creating circular sonar scan sprites
2. Adding grid overlay sprites
3. Adding animated sonar ping effects
4. Creating custom button sprites with pixel art borders

### To Adjust Sonar Pulse Effect
In `SonarEffect.cs`, you can modify:
- `pulseSpeed` - How fast the pulse cycles
- `minAlpha` - Minimum transparency
- `maxAlpha` - Maximum transparency

## Testing
1. Open `MainMenu.unity` in Unity
2. Press Play
3. Test all three buttons:
   - START should attempt to load GameLevel scene
   - INSTRUCTIONS should attempt to load Instructions scene
   - EXIT should stop play mode (or quit in build)

## Next Steps
1. Create your game level scene
2. Create an instructions scene with game controls and mechanics
3. Add custom pixel art fonts for more authentic retro feel
4. Add sonar scan animation sprites
5. Add sound effects (sonar ping, button clicks)
6. Consider adding background music with submarine/naval theme

## Notes
- The scene uses Unity's built-in Arial font. Import a pixel font for better pixel art aesthetic.
- Currently using solid colors for buttons. Consider creating sprite-based buttons with pixel art borders.
- The Exit button uses `#if UNITY_EDITOR` to stop play mode in editor, and `Application.Quit()` for builds.

# HW4
## Devlog

In this assignment, in this project, the control layer is mainly composed of classes such as PlayerController, PipeSpawner, and PipeMover. For instance, in the Update() method of PlayerController, it detects whether the player presses the space bar, and in the Flap() method, it controls the bird's jumping. These scripts are responsible for handling player input and game rules, but they do not directly manipulate the UI. PipeSpawner is responsible for generating pipes, and PipeMover is responsible for making the pipes move to the left. They only handle the game logic and do not concern themselves with how the screen is displayed. 
The view layer is mainly handled by the UI code in the GameManager. In the GameManager, I used TMP_Text named scoreText to display the score, and updated the text on the screen in the UpdateScoreUI() method (for example, "Score: " + Score). This way, the display of the score is centrally managed rather than scattered across multiple scripts.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
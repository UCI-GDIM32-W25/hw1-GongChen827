[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.
1& 2. Objects
    UI
        Seeds planted UI
            Counting the number of seeds planted
        Seeds remaining UI
            Shows how many seeds are remaining
    Player
        Movement
            Move up, down, left and right
            Plant the seeds when pressing the spacebar
    Seeds
        Will be planted by the player object when pressing the spacebar

3. players can click “space” to plant seeds where the cat is, and players can use WASD to move the cat to anyplace on the screen if they want. Players can combine these two functions to plant seeds wherever they want. After players plant seeds, the UI will show the Seeds remaining and the Seeds Plated.


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
In my initial plan from the week 1 activity that my partner and I planned together, we broke down the project's needed objects into three main parts: the UI, the Player, and the Seeds. The UI would include two parts: one to track the seeds planted and another to show the remaining seeds. The Player was to be able to move by using the WASD keys and plant seeds by pressing the spacebar, which the Seeds would be instantiated at the Player's position as the spacebar was pressed. After reviewing the lecture slides, I created a player sprite and put it in the prefab, which is ready to use. Then, I started following the plan.

I coded The PlantCountUI script to handle the UI updates, where the UpdateSeeds() method updated the "Seeds Planted" and "Seeds Remaining" counts. For the Player, the Player script implemented movement using Input.GetAxis and the planting mechanic used the PlantSeed() method, which checked if seeds were available before instantiating the plantPrefab. Those coding parts are really easy for me because I learned how to do them when I took the GDIM 31 class. For the inspector window, I assigned the Player GameObject to the Player Transform and the Plant prefab to the Plant prefab. In the end, I checked my plan first to see if I did all of the parts needed for the game and made sure all features were the same as the it.io link and the requirements on Canvas.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

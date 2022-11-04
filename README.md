# Project Mid-term Reflection

--Halloween/Horror VR Game Demo--

[Overview]

The setting of my project was based in a winter forest. The goal of the demo was to collect a sword after finding all magic items, placing them into crest sockets which then opens the door in a hut where the sword itself is collected, but you got to watch out, a scary skeleton is chasing after you!

[Technical contributions]

I put high emphasis on graphical aspect of my demo. I utilized the terrain feature of unity. Downloaded assets that could be used by terrain tool. I experimented with real time lighting, post processing effects like vignette, bloom and ACES Tone mapping curve which give it more of a filmic look. I have also enabled ambient occlusion. I edited a night sky HDRI(High Dynamic Range Image) in photoshop in order to remove the original moon on the image as the moon was too bright for the scene. After importing the HDRI to Unity I created a material for it so that it can be used as a night Skybox in my scene. All of these graphical contributions were implemented due to the fact that my aim for the project was to create a dark spooky horror scene.

A working enemy skeleton that chases the player using "Navigation UI" was also achieved. The skeleton will avoid 3D objects and will try to find the shortest path towards you, it will also avoid moving up steep slopes over 55.5°. For this to work correctly me the developer had to bake a new NavMesh after applying changes to 3D game objects within the scene.

Enemy will avoid areas that are not highlighted in turquoise and will find shortest path to the game object it is chasing:

![image](https://user-images.githubusercontent.com/90252845/200051788-4faf8580-b659-4df1-ad96-c8c6e3daf48b.png)

A NavMeshAgent component was used to create the AI of the skeleton game object, it also makes Unity understand that this new AI should be using the NavMesh that was baked by the developer:

![image](https://user-images.githubusercontent.com/90252845/200052297-796b8c1f-59fb-4dde-8207-51818eb63c58.png)

This code takes information of the player position and gives it to the NavMeshAgent component

![image](https://user-images.githubusercontent.com/90252845/200059303-c17b8d05-0b3f-4961-bff9-af9e22fb1ce3.png)


[Limitations of implementation]

One of the limitations of my demo was that the original aim was to have all 3 magical items open the door but just one made it possible. I simply did not focus enough time on implementing it. This could have been achieved by using an array of size three (since there are 3 crest sockets for the magic items) inside a script. Each time an item is placed inside a socket the array would increment until all magic items are in place, only then the door would open.

[Technical achievements]

As demonstrated on my demo, I did in fact achieve the door to react if a socket is occupied, but there was one problem, instead of the door to rotate relative to the location of its hinges it was floated towards the sky. This was expected as the reason for this was that I have used the velocity method within the script instead of using rotation to open the door. The reaction was accomplished on the socket game object within the XR Socket Interactor component using interaction events. The script within Select Entered event is activated when an interactable object is placed within the socket:

![image](https://user-images.githubusercontent.com/90252845/200042262-73ef6de3-c428-4bb2-a712-af2a286359d0.png)

MoveDoor method should be using eulerAngles to set the new position of 3D Vector points, this will rotate the door by the amount defined on y-axis.

Original code:

![image](https://user-images.githubusercontent.com/90252845/200059187-c062cb19-ea37-4cd7-b143-aad1cef37fd4.png)

Correct code:

![image](https://user-images.githubusercontent.com/90252845/200058945-05f9144c-7153-4c5a-b8ab-25b30ae202f6.png)

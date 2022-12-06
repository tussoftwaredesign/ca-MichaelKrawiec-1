# Project Final Reflection

***--Halloween/Horror VR Game Demo--***
<br/>
<br/>
**[Overview]**

For my final end of first semester VR Application Development project I continued to work on my mid-term project in order to improve the game mechanics, implement fresh knowledge learned throughout the second part of this semester and achieve features/goals that were planned but did not make it into the first project submission.
<br/>
<br/>
<br/>
**[New Additions]**
<br/>
<br/>
**Ragdoll**

After the player aquires its sword, the player can now attack the skelaton. After the skelaton gets hit by the sword its ragdoll state is enabled and visually the skelaton falls to the ground.

![Ragdoll](https://user-images.githubusercontent.com/90252845/205978485-ba54ce67-89a8-4f14-91ec-4d56fae22eb0.gif)

This is achieved by disabling his pre-ragdoll components like the animator, nav mesh agent which is responible for following the player, sound component, its original rigidbody and the box-collider on collision with an object that has a certain tag. After this the ragdoll state gets activated. This means that each body part having its own collider and rigidbody get enabled which gives a unique ragdoll fall depening on the forces hitting the skelaton.

![image](https://user-images.githubusercontent.com/90252845/205996509-c5e03be6-d7f6-4e0e-acd6-80ceca1d86e2.png)

Each skelaton part from the model rig which contains colliders and rigidbodies gets assigned to an array at the start of the game, once a collision is detected they get enabled.

![image](https://user-images.githubusercontent.com/90252845/205999588-d2fd353f-31e1-4a6e-af5c-47c5d99633ce.png)
*Fragment of full code*
<br/>
<br/>
<br/>
**Main menu lobby**

I have added a main menu free from stress where you can prepare yourself before starting the game:)
The UI allows the player to open the setting menu and toggle between snap turning or continuous rotation.

![image](https://user-images.githubusercontent.com/90252845/205979463-3065483f-d50c-4576-b022-3badd9d20555.png)
<br/>
<br/>
<br/>

**[Improvements]**
<br/>
<br/>
**Array Check**

In this version of the game, it is required for the player to provide all three magic items into the sockets. This is done by checking if all empty game objects that are attached to its independent sockets are enabled and if all three of them are the door animator gets disabled and rotation method is activated.

![image](https://user-images.githubusercontent.com/90252845/205995285-480e6f7f-5666-4222-8e5d-2004c0abeb6f.png)

![image](https://user-images.githubusercontent.com/90252845/206006568-58c157fc-4623-4755-8419-112a0bbf63dc.png)

**Correct Door Opening**

On my first demo that was presented, the door magically flew towards the sky. This has been fixed by using the correct rotation method.

*Animator On*

![image](https://user-images.githubusercontent.com/90252845/205994840-4e9aff49-a256-487a-937f-73b342d4136c.png)

*Animator Off, Rotation Activated*

![image](https://user-images.githubusercontent.com/90252845/205994942-8d118747-7578-42af-81fa-0fe562c3852e.png)
<br/>
<br/>
<br/>

**[Final Thoughts]**

Overall I'm happy how the project turned out to be considering only small amout of time put into developing it. Many more features can still be added like player/ enemy health, improved combat system, Static screen space GUI's representing health and time and much more.


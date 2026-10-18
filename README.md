<h1>Unity-Based RobotSphere Navigation in an Unstructured Environment</h1>


<h2>Description</h2>
This work demonstrates the development of mobile robot navigation in constrained and unstructured spaces using the Unity 3D virtual environment. It also demonstrates two navigation techniques a RobotSphere can use: walking and rolling. This project was achieved by performing the following.
<ul>
<li>Import abandoned factory assets from asset stores. Create an abandoned factory building structure with its surrounding environment. Include factory warehouse materials in an unorganized pattern.</li>
<li>Import the RobotSphere asset from the asset store. Set up its materials/texture and animation. Develop a C# script that will control its navigation.</li>
<li>Develop a First Person Character (FPC) controller that can be used to proceed from outside the building to enter the building through the door. Develop and set up a door and its trigger that will enable the door to open when the FPC controller approaches the door.</li>
</ul>
Video demonstration: https://youtu.be/bhkwCiT28XM?si=RXpO0ydp-UvOHPcW

<h2>Project Development and Procedure</h2>

<h4>Building Structure and Factory Materials</h4>
Having launched Unity Hub, a blank project was created, and a 3D cube game object was collected and positioned to a size fit for a base. The cube game object was duplicated to create a 160 X 140 base. Then a rectangular wall was erected on the base platform.
An abandoned factory warehouse was downloaded into My Assets from asset stores, imported, and added to the project tab. From there, materials were collected and placed on the base floors and the rectangular walls to clearly depict abandonment. Roof bases and roof tops were collected from the imported abandoned building material models and placed on the rectangular structure to form a complete building. To add a door to create an entry point into the building, a 3D model was collected from the materials in the imported project folder, and the material texture was used to create the outlook of the door, and the toggle tool handle was placed as a pivot to enable it to rotate at one end. Furthermore, the imported models that form the items inside the warehouse were collected with their different texture materials applied using the mesh renderer, and they were placed in an unstructured way to depict a constrained pathway for the mobile robot. 

<h2></h2>
<figure>
<img src="https://i.postimg.cc/wjhXPrNX/Screenshot-2026-01-22-190132.png" height="30%" width="50%" alt="Disk Sanitization Steps"/>
<figcaption style="margin-top: 8px;">Abandoned Factory Warehouse Outward View</figcaption>
</figure>
<h2></h2>
<figure>
<img src="https://i.postimg.cc/x1Kh0YhM/Screenshot-2026-01-22-190518.png" height="30%" width="50%" alt="Disk Sanitization Steps"/>
<figcaption style="margin-top: 8px;">Unorganised Arrangement within the Factory Warehouse</figcaption>
</figure>
<h2></h2>

<h4>First Person Character Controller</h4>
Having installed the FPS controller from the package manager, then it is collected from the asset folder on the project tab and dragged into the scene. When positioned, it can be tested when the scene is played using the WASD keys, mouse to move, space bar to jump, and the Shift key to sprint. During motion, as it approaches the door leading into the warehouse, a trigger developed in a C# script is activated for the door to open while the FPS goes in through the door.
<h2></h2>
<h4>Cinemachine</h4>
Here, Cinemachine virtual cameras were automatically applied to follow and track the RobotSphere using smooth camera movement with manual scripting. When searched and installed by the package manager, the Cinemachine virtual camera was added to the scene from game object and was automatically added as the Cinemachine brain of the main camera. Having created the RobotSphere, it was selected as the target object for the camera to follow. This was done by selecting the virtual camera in the hierarchy, then in the inspector, the target is specified to “follow” and “look at”. The camera is adjusted for a proper screen position and damping. This was tested to ensure it reflected the desired outcome.
<h2></h2>
<h4>RobotSphere</h4>
When the RobotSphere was imported from the Asset Store into the project, it was set up by dragging the prefabs from the package into the warehouse in the scene. It was placed on the walkable floor with navigable areas. NavMeshAgent component was applied to the robot to enable it to avoid obstacles and move smoothly within the environment. An AI controller script for navigation was created to define the target agent, which is the robot, and the destination. Also, parameters such as agent type, speed, stopping distance, and turning rate were configured to match the robot’s physical behaviour. The robot controller script was developed using C# to enable the robot to switch between walking and rolling when folded, using the WASD keys for movement in any of the four directions and the Ctrl key for folding and unfolding.
<h2></h2>
<figure>
<img src="https://i.postimg.cc/cL991HT0/Screenshot-2026-01-22-190254.png" height="30%" width="50%" alt="Disk Sanitization Steps"/>
<figcaption style="margin-top: 8px;">RobotSphere in Animated Mode</figcaption>
</figure>
<h2></h2>

<h2>Conclusion</h2>
This project development shows the application of RobotSphere in a constrained space within an abandoned factory warehouse, thereby displaying its ability to navigate on both even and uneven terrain at the same time. The project also achieved the ability to walk and roll under controlled conditions. It could perform these tasks within the complexities of the environment. However, there are still areas for improvement, which are the ability for robots to function with sensors and navigate autonomously. These were not achieved due to limited time constraints, and as such, there is a strong desire to implement the improvements in the future.

<!--
 ```diff
- text in red
+ text in green
! text in orange
# text in gray
@@ text in purple (and bold)@@
```
--!>

<h1>Unity-Based RobotSphere Navigation in an Unstructured Environment</h1>


<h2>Description</h2>
This work demonstrates the development of mobile robot navigation in constrained and unstructured spaces using the Unity 3D virtual environment. It also demonstrates two navigation techniques a RobotSphere can use: walking and rolling. This project was achieved by performing the following.
<ul>
<li>Import abandoned factory assets from asset stores. Create an abandoned factory building structure with its surrounding environment. Include factory warehouse materials in an unorganized pattern.</li>
<li>Import the RobotSphere asset from the asset store. Set up its materials/texture and animation. Develop a C# script that will control its navigation.</li>
<li>Develop a First Person Character (FPC) controller that can be used to proceed from outside the building to enter the building through the door. Develop and set up a door and its trigger that will enable the door to open when the FPC controller approaches the door.</li>
</ul>

<h3>PROJECT DEVELOPMENT AND PROCEDURE</h3>

<h4>Building Structure and Factory Materials</h4>
Having launched Unity Hub, a blank project was created, and a 3D cube game object was collected and positioned to a size fit for a base. The cube game object was duplicated to create a 160 X 140 base. Then a rectangular wall was erected on the base platform.
An abandoned factory warehouse was downloaded into My Assets from asset stores, imported, and added to the project tab. From there, materials were collected and placed on the base floors and the rectangular walls to clearly depict abandonment. Roof bases and roof tops were collected from the imported abandoned building material models and placed on the rectangular structure to form a complete building. To add a door to create an entry point into the building, a 3D model was collected from the materials in the imported project folder, and the material texture was used to create the outlook of the door, and the toggle tool handle was placed as a pivot to enable it to rotate at one end. Furthermore, the imported models that form the items inside the warehouse were collected with their different texture materials applied using the mesh renderer, and they were placed in an unstructured way to depict a constrained pathway for the mobile robot. 




<!--
 ```diff
- text in red
+ text in green
! text in orange
# text in gray
@@ text in purple (and bold)@@
```
--!>

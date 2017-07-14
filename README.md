# sphericalParallax
Collab with Perry to experiment with using parallax on nested photospheres.

7/14/2017

Hey Perry,

When I imported the shared files into a new Unity project, they appear in the assets folder just fine, but I can't figure out how to use the .blend file. According to the Unity docs, I should be able to just drag and drop the blend file into the scene, but it isn't allowing me to. Clicking and dragging the .blend from Assets to Scene gives me a 🚫cursor. 

I then installed Blender and tried to directly export the FBX into my Unity project's assets folder. This created a prefab that's usable, but it's the 3D meshes of the objects rather than being an inside-out sphere.

But I came up with a work-around. I created 3 new spheres, applied the supplied textures to their materials, added a script to each that ~~flips their normals~~ flips the mesh's triangles inside-out, added a MouseLook script to the camera, and then wrote the parallax motion script.

The good news is that your idea for the sphere-based parallax seems to work pretty well! When you first play the project, the parallax effect might seem very subtle, so I added in an "exaggerator" value that you can use to change how pronounced the parallax effect is. By default it's set at 0.5, but can be bumped up for a more exaggerated effect.

Another method for changing how pronounced the effect is would be to increase the scale of each sphere. The parallax script uses the radius of each sphere as a strength modifier.

- Chris

PS: This Unity project does not yet have a git ignore filled out.

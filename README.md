# Gears-Recruitment-Test


Turn main gear by pushing down left mouse button around white handle. Gears will turn to meet mouse position.

Every gear has Gear script attached to it. In this script we configure how many tooth gear has, and optional - what gears are affected by that gear movement (child gears).
With that, in Unity editor, we can easly create chain of gears that connects all of them. Gears chain starts at main power gear that can be powered/rotated.
This is done by attaching PoweredGear script to that main power gear. PoweredGear script inherits Gear script, so we add only one of them on the gear object.
In powered gear we can also configurate default speed of gears.

In this example, on Power Gear object there is a handle with a script that turns main gear by hand using mouse movement.


# Instructions
	* Implement a gear with a handle that can be rotated around its pivot. 
	* Another connected gear next to it should turn with the hand powered gear.

# Optional
  - If you had more time what further improvements would you add to your solution
      - Child gear loop check: Avoid configurations of gears in chain that would cause a loop and unity error

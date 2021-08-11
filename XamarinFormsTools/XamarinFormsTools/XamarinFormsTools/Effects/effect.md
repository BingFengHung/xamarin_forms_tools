# The process of creating an Effect
The process for creating an effect in each platform-specific project is as follows:

1. Create a subclass of the `PlatformEffect` class.
2. Override the `OnAttached` method and write logic to customize the control.
3. Override the `Detached` method and write logic to clean up the control customization, if requried.
4. Add a `resolutionGroupName` attribute to the effect class.
	- This attribute sets a company wide namespace for effects, preventing collision with other effets with the same name.
	- Note that this attribute can only be applied once per project.
5. Add an `ExportEffect` attribute to the effect class.
	- This attribute registers the effect with a unique ID that's used by Xamarin.Forms.
	- Along with the group name, to locate the effect prior to applying it to a control.
	- The attribute takes two parameters – the type name of the effect, and a unique string that will be used to locate the effect prior to applying it to a control.


Each platform-specific PlatformEffect class exposes the following properties:
- Container – references the platform-specific control being used to implement the layout.
- Control – references the platform-specific control being used to implement the Xamarin.Forms control.
- Element – references the Xamarin.Forms control that's being rendered.

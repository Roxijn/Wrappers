# GLFW

This is a wrapper around [GLFW](https://www.glfw.org/). Everything is wrapped in as pure a manner as possible to the original Glfw, while still allowing consumers to avoid handling marshalling themselves. Therefore code written using the library should look resonably similar to native code.

## Usage

Using this wrapper requires GLFW binaries to be downloaded from their website, or built, and then the location of the dynamic library Specified in [Lib.cs](./Lib.cs). Once the assembly is referenced, GLFW can be added to the scope with a static using directive.

Since this library perfoms only minor changes to the API, regarding typing, it is possible to refer directly to educational material and documentation for GLFW directly, while taking C# into account.

## Example

Below is an example demonstrating how this library might be used in practice to create an empty window:

```C#
//use the wrapper
using static Glfw.Lib;

//initialisation
if (glfwInit() == GLFW_FALSE) return;

//set our window hints
glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);
glfwWindowHint(GLFW_RESIZABLE, GLFW_FALSE);

//create a window
var window = glfwCreateWindow(800, 600, "Vulkan", GLFWmonitor.Zero, GLFWwindow.Zero);

//loop until we close the window
while(glfwWindowShouldClose(window) == GLFW_FALSE) glfwPollEvents();

//clean up
glfwDestroyWindow(window);
glfwTerminate();
```

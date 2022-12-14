This is a managed wrapper around the [GLFW](https://www.glfw.org/) library for .Net.

## Usage

Using this wrapper requires GLFW binaries to be downloaded from their website, or built, and then included alongside the assembly. Once the assembly is referenced, GLFW can be added to the scope with a static using directive.

Since this library perfoms only minor changes to the API, regarding typing, it is possible to refer directly to educational material and documentation for GLFW directly, while taking C# into account.

## Example

Below is an example demonstrating how this library might be used in practice to create an empty window:

```C#
//use the wrapper
using static Glfw;

//initialisation
if (glfwInit() == GLFW_FALSE) return;

//set our window hints
glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);
glfwWindowHint(GLFW_RESIZABLE, GLFW_FALSE);

//create a window
var window = glfwCreateWindow(800, 600, "Empty", GLFWmonitor.Zero, GLFWwindow.Zero);

//loop until we close the window
while(glfwWindowShouldClose(window) == GLFW_FALSE) glfwPollEvents();

//clean up
glfwDestroyWindow(window);
glfwTerminate();
```

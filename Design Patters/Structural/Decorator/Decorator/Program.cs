
using Decorator;

AbstractRenderer renderer = new Renderer();
renderer.RenderInformation("Hello Kitty");

renderer = new ColorDecorator(renderer, ConsoleColor.Red);
renderer = new UpperCaseDecorator(renderer);

renderer.RenderInformation("Hello Kitty");
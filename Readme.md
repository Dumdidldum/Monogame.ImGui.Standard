﻿# Monogame.ImGui.Standard

This is a Monogame wrapper for the ImGui.NET Library (https://github.com/mellinoe/ImGui.NET). Monogame.ImGui lets you build graphical interfaces for your Monogame games using a simple immediate-mode style.

Disclaimer: This code wasn't written by me, I just cleaned up the repository and rebuilt the nuget package for NET standard.
The original Repository: https://github.com/dovker/Monogame.ImGui


# Usage

To use Monogame.ImGui, download this library using NuGet inside your Monogame project.
In your Game1, Initialize ImGuiRenderer like so:

```
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.ImGui.Standard;
using ImGuiNET;


namespace YourGame
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private ImGUIRenderer _imGUIRenderer;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
    }
    
    protected override void Initialize()
    {
        base.Initialize();

        _imGUIRenderer = new ImGUIRenderer(this).Initialize().RebuildFontAtlas();
    }
...
```

And then in the Draw event, you need to add `GuiRenderer.BeginLayout(gameTime);` and `GuiRenderer.EndLayout();`
Like so:

```
...
protected override void Draw(GameTime gameTime)
{
    graphics.GraphicsDevice.Clear(Color.Coral);

    spriteBatch.Begin();
    //Your regular Game draw calls
    spriteBatch.End();

    
    GuiRenderer.BeginLayout(gameTime);
    ImGui.LabelText("Hello World", "");

    //Insert Your ImGui code

    GuiRenderer.EndLayout();

    base.Draw(gameTime);
}
...
```

# See Also

https://github.com/ocornut/imgui
> Dear ImGui is a bloat-free graphical user interface library for C++. It outputs optimized vertex buffers that you can render anytime in your 3D-pipeline enabled application. It is fast, portable, renderer agnostic and self-contained (no external dependencies).

> Dear ImGui is designed to enable fast iterations and to empower programmers to create content creation tools and visualization / debug tools (as opposed to UI for the average end-user). It favors simplicity and productivity toward this goal, and lacks certain features normally found in more high-level libraries.

> Dear ImGui is particularly suited to integration in games engine (for tooling), real-time 3D applications, fullscreen applications, embedded applications, or any applications on consoles platforms where operating system features are non-standard.

https://github.com/mellinoe/ImGui.NET
> This is a .NET wrapper for the immediate mode GUI library, Dear ImGui. ImGui.NET lets you build graphical interfaces using a simple immediate-mode style. ImGui.NET is a .NET Standard library, and can be used on all major .NET runtimes and operating systems.


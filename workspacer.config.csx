#r "C:\Program Files\workspacer\workspacer.Shared.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.Bar\workspacer.Bar.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.ActionMenu\workspacer.ActionMenu.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.FocusIndicator\workspacer.FocusIndicator.dll"

using System.Data;
using System.Diagnostics.Contracts;
using System.ComponentModel.Design.Serialization;
using System.Threading;
using System;
using System.IO;
using workspacer;
using workspacer.Bar;
using workspacer.ActionMenu;
using workspacer.FocusIndicator;


// var bar = context.AddBar(new BarPluginConfig()
// {
//     BarTitle = "workspacer.Bar",
//     BarHeight = 50,
//     FontSize = 16,
//     DefaultWidgetForeground = Color.White,
//     DefaultWidgetBackground = Color.Black,
//     Background = Color.Black,
//     LeftWidgets = () => new IBarWidget[] { new WorkspaceWidget(), new TextWidget(": "), new TitleWidget() },
//     RightWidgets = () => new IBarWidget[] { new TimeWidget(), new ActiveLayoutWidget() },
// });



Action<IConfigContext> doConfig = (context) =>
{
context.AddBar(new BarPluginConfig(){
    BarTitle = "workspacer.Bar",
    BarHeight = 20,
    FontSize = 11,
    FontName = "Victor Mono Semibold",
    // These should be used in separate function for 'title'
    //IsShortTitle = True,
    //blinktimer = False,
    DefaultWidgetForeground = Color.Purple,
    DefaultWidgetBackground = Color.Silver,
    Background = Color.White,

    // var bar = context.AddBar(new BarPluginConfig()
// {
//     BarTitle = "workspacer.Bar",
//     BarHeight = 50,
//     FontSize = 16,
//     DefaultWidgetForeground = Color.White,
//     DefaultWidgetBackground = Color.Black,
//     Background = Color.Black,
//     LeftWidgets = () => new IBarWidget[] { new WorkspaceWidget(), new TextWidget(": "), new TitleWidget() },
//     RightWidgets = () => new IBarWidget[] { new TimeWidget(), new ActiveLayoutWidget() },
// });

// Things to look for later
    // WorkspaceHasFocusColor = Color.Fuchsia,
    // WorkspaceEmptyColor = Color.Fuchsia,
    //WorkspaceIndicatingBackColor = Color.Fuchsia,
    //TitleWidget.IsShortTitle
});

var actionMenu = context.AddActionMenu();

context.WorkspaceContainer.CreateWorkspaces("Browser", "Coding", "Virtual",  "Social", "Notes", "Files", "Media", "Various"); 
context.WindowRouter.AddRoute((window) => window.Title.Contains("Discord") ? context.WorkspaceContainer["Social"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Visual Studio") ? context.WorkspaceContainer["Coding"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("To Do") ? context.WorkspaceContainer["Notes"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("VirtualBox") ? context.WorkspaceContainer["Virtual"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("OneNote") ? context.WorkspaceContainer["Notes"] : null);

// # custom filter
context.WindowRouter.AddFilter((window) => !window.Title.Contains("Screen Snipping"));

context.WindowRouter.AddFilter((window) => !window.Title.Contains("PowerLauncher"));
context.WindowRouter.AddFilter((window) => !window.Title.Contains("Power"));

var mod = KeyModifiers.Win;
//context.Modifiers = KeyModifiers.Win;
//context.Keybinds.Subscribe(mod, Keys.Y, () => Console.WriteLine(modifiersPressed(mod));

// mod.K
context.Keybinds.Subscribe(mod, Keys.B, () => System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"));
context.Keybinds.Subscribe(mod, Keys.Enter, () => System.Diagnostics.Process.Start(@"C:\Users\Danie\AppData\Local\Microsoft\WindowsApps\wt.exe"));



// context.Keybinds.Subscribe(mod, Keys.B, () => System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"));
// To Do

// Build some custom launchers for Browser, VSCode
// Shrink dpi of bar
// Add Gaps
// Figure out these ridic keybinds. (Although alt is kinda comfy... :O)

//Keybinds
//var mod = KeyModifiers.LWin;
//KeyModifiers mod = KeyModifiers.Win;
//context.WindowRouter = new MyWindowRouter();

};
return doConfig;

//context.Keybinds.Subscribe(mod, Keys.Y, () => Console.WriteLine("Y was pressed"));
//context.Keybinds.Unsubscribe(Keys.Alt); 
// KeybindManager.Keybinds {mod; Win};
//var mod = KeyModifiers.Win;
// //  context.Unsubscribe(KeyModifiers, Alt);      
// # default implementation in the standard configuration
// # custom filter, will ensure all windows with "my fun application" in the title are ignored
// router.AddFilter((window) => !window.Title.Contains("my fun application"));
// # custom route, will ensure that "Google Chrome" will be placed into the "web" workspace
// router.AddRoute((window) => window.Title.Contains("Google Chrome") ? container["web"] : null));
// # you can optionally provide an implementation of IWindowRouter
// context.WindowRouter = new MyWindowRouter(...);
//   // new KeybindManager(this);
// #### One thing we learned is that the 
// context.####Keybinds###.Unsubscribe(KeyModifiers(LAlt));
//!    context.Keybinds.Subscribe(mod, Keys.Y, () => Console.WriteLine("Y was pressed"))
// context.Keybinds.Unsubscribe(LAlt);
//var mod = context.KeyModifiers.LWin;
//context.Keybinds.Subscribe(LWin);
//context.KeyModifiers.Win()
//context.Keybinds.Unsubscribe(mod, Keys.Y);




// SUpported Colors

        // public static readonly Color White =     new Color(0xFF, 0xFF, 0xFF);
        // public static readonly Color Silver =    new Color(0xC0, 0xC0, 0xC0);
        // public static readonly Color Gray =      new Color(0x80, 0x80, 0x80);
        // public static readonly Color Black =     new Color(0x00, 0x00, 0x00);
        // public static readonly Color Red =       new Color(0xFF, 0x00, 0x00);
        // public static readonly Color Maroon =    new Color(0x80, 0x00, 0x00);
        // public static readonly Color Yellow =    new Color(0xFF, 0xFF, 0x00);
        // public static readonly Color Olive =     new Color(0x80, 0x80, 0x00);
        // public static readonly Color Lime =      new Color(0x00, 0xFF, 0x00);
        // public static readonly Color Green =     new Color(0x00, 0x80, 0x00);
        // public static readonly Color Aqua =      new Color(0x00, 0xFF, 0xFF);
        // public static readonly Color Teal =      new Color(0x00, 0x80, 0x80);
        // public static readonly Color Blue =      new Color(0x00, 0x00, 0xFF);
        // public static readonly Color Navy =      new Color(0x00, 0x00, 0x80);
        // public static readonly Color Fuchsia =   new Color(0xFF, 0x00, 0xFF);
        // public static readonly Color Purple =    new Color(0x80, 0x00, 0x80);




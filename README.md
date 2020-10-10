# <img src="https://wisej.com/wp-content/uploads/2018/09/Wisej-Black.png" height="42" align="top"/> Wisej Syncfusion Essential JS1 Integration

Essential JS is a comprehensive collection of over 80 enterprise-grade HTML5 JavaScript components for building modern web applications. It includes all the UI controls that are typically required for building line-of-business (LOB) applications including charts, grids, Gantt, scheduler, diagram and much more.


## Concept
For the premium Syncfusion, DevExtreme, and Telerik KendoUI integration packages we have used an approach different from the other integrations we publish on the open Wisej repositories. In this case we wanted to use all the features that are available to javascript, angular, react, blazor developers instead of trying to build a limited .NET object hierarchy.

When you look at the code, you will find a common base class **ejBase** for all the widgets classes. Overloaded constructors that indicate which ej1 class to use, and a number of initialization options that may be different for some widgets.

The ejBase class uses a custom **wisej.web.ext.Syncfusion** implementation that takes care of the creation and registration of events, methods, and templates. It also provides some simple methods to override in each derived class.

Each specific class has it's own nested .js file that may add specific functionality to filter event data to make it serializable for the server, make sure the wrapped widget fits the container, and whatever else may be needed to make the integration as smooth as possible.

All the premium extensions are open projects, meaning that we will keep adding, fixing, changing, and expanding them according to the requirements of our Technology Partners and needs we find on our projects using these extensions.

## License
To use this extension you need to acquire at least a **JavaScript Bundle** license from Syncfusion: https://www.syncfusion.com/sales/products. Contact us at sales@wisej.com if you'd like us to get you a nice discount from Syncfusion.

## Demo
Live demo of the Wisej.Web.Ext.Syncfusion.Test.sln project:
http://demo.wisej.com/syncfusion

## Work in progress
The library and test are in progress - we are adding every available widget to the test app and will keep refining the intergration for the foreseable future.

## How to use
All the integrated widgets have 3 types of members: options, methods, and events. The options (you'll find them under "members" in the documentation) are represented by a single javascript map. Methods are javascript functions. Events in the Syncfusion widgets are callback methods defined in the options map.

### Options
When using the ej classes in your .NET Wisej application, you have access to the entire set of options using a single property, Options. It is a dynamic .NET object and you can use it directly or assign it.

When you set the Options using the designer, you can simply copy and paste (and edit) any JSON string.

When you set (or change) the Options by code, you can

- Assign the fields directly using the built-in dynamic objects,
- Assign an object that has the properties you want to use,
- Assign an anonymous class.

Assigning the fields directly will automatically update the widget on the client when the property that changes is on the first level. In case your code changes properties deeper than the first level in the hierarchy, you need to call widget1.Update().

~~~
this.ejCircularGauge1.Options.backgroundColor = "white"; // this is updated automatically on the client.

this.ejCircularGauge1.Options.scales[0].pointers[0].value = 75;
this.ejCircularGauge1.Update();
~~~

The function BuildScales() in the code sample below returns a .NET array of instance of .NET classes with the members that match the fields expected by the ejCircularGauge widget.

~~~
this.ejCircularGauge1.Options.scales = this.BuildScales();
~~~

Anonymous classes (example below) allow for a syntax very similar to javascript. However, once you assign an anonymous class instance, you cannot change the value of it's properties. To change a value you have to reassign the anonymous object.

~~~
this.ejCircularGauge1.Options.scales = new [] {
  new {
    showRanges = true,
    pointers =  new [] {
      new {
        value = 10,
        length = 195
      }
    }
  }
};
~~~

You will find the complete set of options at the Syncfusion docs site linked below. Each ej class in the source code also include a direct link to the docs API and Concept pages.

### Methods
All the methods exposed by the javascript ej1 widget are available to your .NET extension class as C# or VB.NET methods using the new *Widget* object. All methods are also available as async methods with the "Async" suffix.

Note: When using VB.NET you need to use *Option Strict Off* to allow the .NET dynamic compiler to handle the calls into the *Widget* object.

~~~
// C#
this.ejSpreadsheet1.Widget.setReadOnly("B3");

' VB.NET
Me.EjSpreadsheet1.Widget.setReadOnly("B3")
~~~

However, some methods may return values that are not immediately usable in .NET, or you need to use several methods together in a single javascript function in a way that wouldn't make sense from the server. When you need to add a method to your ej widget instance, or your derived class, use the **WidgetFunctions** property in the designer (can be used at runtime as well) to register a new javascript function.

~~~
this.ejRichTextEditor1.WidgetFunctions = new []{

  new WidgetFunction()  {
    Name = "addMenuOption",
    Source = @"
      this.widget.insertMenuOption({
        newItem: arguments[0],
        targetItem: "Insert/Edit Hyperlink",
        insertType: "insertAfter",
        menuType: {text: true},
        spriteCssClass: "e-rte-toolbar-icon " + arguments[1]
      });
   
    ";
  }

};

this.ejRichTextEditor1.Call("addMenuOption", "Make Lowercase", "e-lowercase_01");

// In alternative (C#):
this.ejRichTextEditor1.Widget.insertMenuOption(new {
  newItem = "Make Lowercase",
  newItem = arguments[0],
  targetItem = "Insert/Edit Hyperlink",
  insertType = "insertAfter",
  menuType = new {Text = true},
  spriteCssClass = "e-rte-toolbar-icon e-lowercase_01"
});


~~~

The code above adds a javascript function "addMenuOption" to the Wisej Syncfusion widget and then calls it to add a context menu option to the ejRTE widget.

**Be careful** not to override existing methods. The extension will simply not register your new method and log an error in the JavaScript console.

### Events
The events registered by the ej class (see constructor for each component in the source code) are also available as .NET events exposed by the *Widget* object:

~~~
// C#
this.ejChart1.Widget.chartClick += new WidgetEventHandler(ejChart1_WidgetEvent);

' VB.NET
Me.EjChart1.Widget.chartClick = New WidgetEventHandler(AddressOf Me.EjChart1_CellClick)
~~~

**Note:** Unfortunately in VB.NET you cannot use *AddHandler* or *Handles* to handle dynamic events. You can attach only a single handle using the syntax above, or attach to the existing *WidgetEvent* event and check the *e.Type* property.

Events fired by the Syncfusion widgets are callbacks, not events. The .NET classes representing each widget already registers a set of events and routes them to the .NET widget's WidgetEvent event. However, if your app needs to handle an event in javascript, you can use the **WidgetEvents** collection to register your event callback.

~~~
this.ejRichTextEditor1.WidgetEvents = new []{
  new WidgetEvent() {
    Name = "contextMenuClick",
    Source = @"
      this.makeLowerCase(); // this is not an actual method in the ejRTE widget.
    "
  }
};
~~~

The event **args** object sent by the widget is available as **e** and the code can refer to the ej widget simply using **this**. Note that in the event code **this** refers to the ej widget, while in function code **this** refers to the Wisej widget and **this.widget** refers to the wrapped ej widget.

## Support
To log issues related to this extension, please use the Issues section of this repository. To log issues related to the usage of this extension in your projects, please use the Issues section in your Technology Partner repository.

You may also fork this project and modify it to fit your needs and if you want to share a change or fix, please create a pull request.

## Documentation

Syncfusion Documentation:

https://help.syncfusion.com/js/

Syncfusion API:

https://help.syncfusion.com/api/js/

Syncfusion Demos:

https://js.syncfusion.com/demos/web/

## Redistribution

We have bundled the entire set of JS1 widgets, themes, and assets in the Wisej.Web.Ext.Syncfusion assembly as embedded resources. You need to deploy only 1 assembly and your client devices don't need an open internet connection.

## Update

The Syncfusion assets are located in /JavaScript using the same directory structure used in the installation zip you receive from Syncfusion when you purchase the license. To update the version of the JS1 library, simply copy the files over and recompile the project.



---
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.

# <img src="https://wisej.com/wp-content/uploads/2018/09/Wisej-Black.png" height="42" align="top"/> Wisej Syncfusion Integration

Essential JS is a comprehensive collection of over 80 enterprise-grade HTML5 JavaScript components for building modern web applications. It includes all the UI controls that are typically required for building line-of-business (LOB) applications including charts, grids, Gantt, scheduler, diagram and much more.


## Concept
For the premium Syncfusion, DevExtreme, and Telerik KendoUI integration packages we have used an approach different from the other integrations we publish on the open Wisej repositories. In this case we wanted to use all the features that are available to javascript, angular, react, blazor developers instead of trying to build a limited .NET object hierarchy.

When you look at the code, you will find a common base class **ejBase** for all the widgets classes. Overloaded constructors that indicate which ej1 class to use, and a number of initialization options that may be different for some widgets.

The ejBase class uses a custom **wisej.web.ext.Syncfusion** implementation that takes care of the creation and registration of events, methods, and templates. It also provides some simple methods to override in each derived class.

Each specific clas


## License
To use this extension you need to acquire at least a **JavaScript Bundle** license forom Syncfusion: https://www.syncfusion.com/sales/products. Contact us at sales@wisej.com if you'd like us to get you a nice discount from Syncfusion.


## How to use
All the integrated widgets have 3 types of members: options, methods, and events. The options (you'll find them under "members" in the documentation) are represented by a single javascript map. Methods are javascript functions. Events in the Syncfusion widgets are callback methods defined in the options map.

### Options

When using the ej classes in your .NET Wisej application, you have access to the entire set of options using a single property Options. It is a dynamic .NET object and you can use it directly or assign it.

When you set the Options using the designer, you can simply copy and paste (and edit) any JSON string.

When you set (or change) the Options by code, you can

- Assign the fields directly using the built-in dynamic objects,
- Assign an object that has the properties you want to use,
- Assign an anonymous class.

Assigning the fields directly will automatically upate the widget on the client when the property that changes is a the first level. In case your code changes properies deeper in the hierarchy, you need to call widget1.Update().

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

All the methods exposed by the javascript ej1 widget are available to your .NET extension class using the existing Call and Eval methods. You can also use the CallAsync and EvalAsync to retrieve the return value in-line, or use the callback methods to receive the return value asynchronously.

However, some methods may return values that are not immediately usable in .NET, or you need to use several methods together in a single javascript function in a way that wouldn't make sense from the server. When you need to add a method to your ej widget instance, or your derived class, use the **WidgetFunctions** property in the designer (can be used at runtime as well) to register a new javascript function that you can use with a simple widget.Call().

~~~
this.ejRichTextEditor1.WidgetFunctions = new []{

  new WidgetFunction()  {
    Name = "addMenuOption",
    Source = @"
      this.widget.inserMenuOption({
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
~~~

The code above add a javascript function "addMenuOption" to the Wisej Syncfusion widget and then called it to add a context menu option to the ejRTE widget. The javascript code can refer to the Wisej widget as **this** and to the inner Syncfusion object as **this.widget**. All the arguments are available in the **arguments[]** array.

### Events

Events fired by the Syncfusion widgets are callbacks, not events. The .NET classes representing each widget already register a set of events and route them to the .NET widget's WidgetEvent event. However, if your app needs to handle an event in javascript, you can use the **WidgetEvents** collection to register your event callback.

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

The event **args** object sent by the widget is available as **e** and the code can refer to the ej widget simplty using **this**. Note that in the event code **this** refers to the ej widget, while in function code **this** refers to the Wisej widget and **this.widget** refers to the wrapped ej widget.

## Documentation

Synfusion Documentation:

https://help.syncfusion.com/js/

Synfusion API:

https://help.syncfusion.com/api/js/

Syncfusion Demos:

https://js.syncfusion.com/demos/web/

## Redistribution

We have bundled the entire set of JS1 widgets, themes, and assets in the Wisej.Web.Ext.Syncfusion assembly as embedded resources. You need to deploy only 1 assembly and your client devices don't need an open internet connection.

## Update

The Syncfusion assets are located in /JavaScript/ejSyncfusion using the same directory structure used in the installation zip you receive from Syncfusion when you purchase the license. To update the version of the JS1 library, simply copy the files over and recompile the project.



---
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.

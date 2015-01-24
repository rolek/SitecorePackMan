# Sitecore PackMan

![](images/packman-logo.png)

The target audience of this module are Sitecore developers who want to keep track of Item and Template changes while working on new features. It enables you to automatically track those changes and add additional Items manually to the process. At the end of your work, you can generate a Item Package which contains all those changes without having to go into the Package Designer and remember which Items you touched. **All of this without leaving the Content Editor!**

On Youtube, you can see the module in action: https://www.youtube.com/v/abc

This module was created during the Sitecore Hackathon 2015 by Kevin Brechbühl ([@aquasonic](https://twitter.com/aquasonic)), Tobias Studer ([@studert](https://twitter.com/studert)) and Pascal Mathys ([@rootix](https://twitter.com/rootix))

## Installation Instructions

## Usage

### Start Tracking
To start the tracking of the item changes, enable the Developer stripe in the Content Editor and click `Start Tracking`.

![](images/ribbon-inactive.png)

Every change on Items (which are allowed trough the configuration) will be tracked from now on. The tracking process ignores the Item languages and versions. If an Item changes, the whole item gets added to the Item package afterwards.

### Add Item(s) manually

If you want to add an Item or a whole tree manually to the Item package (In case you don't make any changes on them), you can select the appropriate Item in the Content Editor and choose `Add Item` or its child entry `Add Item with subitems`.

![](images/ribbon-active.png)

### Remove Item(s)

If you have added an Item by accident or want to discard an automatically added Item, select it in Content Editor and click on `Remove Item`. In case the Item was choosen to include the children, the whole child tree gets removed from the Item package tracking. You can't remove the child items from such a Item. In this case, you have to select the relevant Items one by one.

### Generate Package

If you have finished your work (and have at least one Item change), you can click on `Generate Package` to generate a package with all tracked Items in this Session. You have to choose a package name which will be part of the final package archive. If you have added many Items to the Session, it can take some time to generate the Item package for you.

After the package is generated, it is stored in the `($data)/packages` folder of your Sitecore solution and gets additionally downloaded by your Browser for you.

![](images/generate-package.png)

The package metadata will contain the following information:

- **Package Name**: Your entered package name
- **Author**: The Sitecore user which created the package
- **Version**: The UTC Time while generating the package

The name of the generated ZIP-file will look like <date>-<package name>.zip to have them sorted in case multiple developers generate packages.

### Show Tracked Items

As soon as there is at least one changed Item, the `Tracked Items` button will show you all tracked items in this Session.

#### Gutter Icons
Beside of the list of tracked Items, you can enable a so called Gutter to show directly in the content tree which Items are tracked. For doing this, you have to right click into the most left bar and choose `PackMan Tracking State` to enable them.

![](images/gutter-icons.png)

The two different Icons show you whether the children of the Item are included.

### Stop Tracking

If you have finished your tracking session, you can stop the tracking by clicking on `Stop Tracking`. You will be warned that all stored tracking information will be deleted if you do this. If you haven't generated the resulting Item package yet, do this first if you need the changes.

# Disclaimer

This module was built during a 24 hour hack session. We cannot guarantee that the output of the module is always 100% correct, so please check the results before rolling the packages out to production. It worked very well in our tests :)

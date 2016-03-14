# Xamarin.CropView
This is an Objective-C binding project of TOCropViewController for Xamarin.iOS or Xamarin.Forms projects.

Objective-C Source: https://github.com/TimOliver/TOCropViewController


## Overview

This binding project was created for TOCropViewController from CocoaControls.

### Instructions

1. Add a binding project to your Xamarin Forms solution.
2. Copy the files from Xamarin.CropView into your binding project
3. Reference your binding project from your iOS project
4. Create a dependency service to show the CropView controller


### *** Add this to your link file ***
LinkerFlags = "-ObjC"

Ex: [assembly: LinkWith ("...", LinkerFlags = "-ObjC")]

This will allow the CropView to work on physical devices

Source: http://stackoverflow.com/questions/30663144/xamarin-lost-custom-objc-categories-unrecognized-selector-sent-to-instance-on
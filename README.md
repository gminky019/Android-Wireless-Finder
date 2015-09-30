# Android-Wireless-Finder
Finds Wireless devices around you and displays the information

Overview:

Bluetooth Wireless Scanner and mapper is made for an android device. It utilizes bluetooth, wifi, and location functionality on the device. The program is used to scan for all available device around a person's location within a few meters. It can discover multiple devices, Bluetooth Low Energy, Bluetooth, and WIFI connected devices. It then queries each device for information, and ultimately saves that unto phone memory. 

Technology:

It is developed for an andriod system. We used Xamarin (which is a plugin for android development for c# and visual studio). A library that allowed the use of the WIFI search and Bluetooth Low Energy search was the Monkey Robotics component included within the component store of Xamarin. 

Usage:

When a user initiates a search, the device will find all bluetooth and BLE enabled devices around it. It then displays the basic information on screen in a list.

Project Goal:

A user can use this application to essentially map all bluetooth,wifi, and ble devices around their location. The user can then attempt to connect to these devices and mark them as vulnerable or not. Essentially creating a vulnerability map around you area.

Whats Implemented:

Bluetooth and BLE search, along with the framework for WIFI search. Saves all information in objects to be used in later implementation. 

Future Implementation:

Finish implementation for WIFI search. Add a feature to connect to vulnerable devices. Lastly, map out locations on map.


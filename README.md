# UnityEventListener
This helper class is meant to serve as a base class for every MonoBehaviour class that needs to register a method to one or more events.
The purpose of this class is to serve as a "Garbage Collector" for your dynamic event registrations.
If you use the RegisterToEvent method implemented here, you will not need to take care of unregistering from events.
The UnityEventListener will keep reference of all events and actions. Upon disabling of the game object, it will unregister every action from its corresponding event.

Example:

<img style="display: block;-webkit-user-select: none;margin: auto;cursor: zoom-in;background-color: hsl(0, 0%, 90%);transition: background-color 300ms;" src="https://i.imgur.com/CLqvMNR.png" width="531" height="577">

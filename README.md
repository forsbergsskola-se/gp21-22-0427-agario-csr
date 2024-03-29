# AgarioGame -My own version of Agar.io

https://user-images.githubusercontent.com/90723803/193925190-5f7e8922-fd41-4150-809d-4ca91876dc96.mov


https://user-images.githubusercontent.com/90723803/197017675-62e29bd0-976e-48ea-a898-2e3ddb48a2a7.mov


https://user-images.githubusercontent.com/90723803/193916367-7cc72a28-1914-49bb-bf5f-26cf0417c9cd.mov




# Part 1 - Time Server


![Agario-2](https://user-images.githubusercontent.com/90723803/188310098-ca95858d-7f94-467d-a1d5-4ee4f2016d85.JPG)

![Agario-3](https://user-images.githubusercontent.com/90723803/188310018-844620ff-07b5-4196-bb64-acd114e7b0c9.jpg)

# Part 2 - Time Client

![Time server](https://user-images.githubusercontent.com/90723803/196994964-bbd378e5-7782-456c-abea-bfda5eb97f3c.JPG)

# Part 3 and 4 - Open word Client & Server

![Time server2](https://user-images.githubusercontent.com/90723803/197017080-6cbf8081-56be-4809-adb9-e53c3634bc82.JPG)




# Goal of this Assignment
The goal of this assignment is to introduce you to Game-Server-Development using `C#` and the `TCP` and `UDP` Protocols.\
In total, our steps will include:
- Creating a small Time-Server using TCP Technology
- Building a Unity Client to connect to that server and receive the time
- Building a small Word-Game-Server using UDP Technology
- Building a Unity Client to connect to that server and play the game
- Building a Game similar to Agar.io
  - A game server that handles multiple player states
  - A unity client that 
    - can display those players' states
    - and forward any input to the server

# Grading
|Grade  |  Requirement |
|-------|:-------------|
|Summa Cum laude (A*)| Clean Code|
|Magna Cum Laude (A)| Agar.io playable in Multiplayer.\*\*|
|Cum Laude (B)| Agar.io playable with Server. Other players may behave glitchy.\*\*|
|Passed (C)| 6 Points of Agar.io done. (or Bonus for Clean Code\*)|
|Barely Passed (D)| UDP OpenWord-MMO Server and Client implemented. |
|Insufficient (E)| TCP Time Server and Client implemented. |
|Failed (F)| |
-------------------------------
Each of these grades expects the previous requirements as well as its own requirements to be fulfilled.\
\* Bonus for Clean Code requires ALL previous requirements to be fulfilled as well as the Code to be tidy and cleaned up.\
\*\* For these grades, it's more important to show that the network communication is happening. Gameplay goes second.

# Prerequisites / Requirements
- Make sure, that .NET Core 6 SDK is installed from https://www.microsoft.com/net/download
- I recommend to use Jetbrains Rider as an IDE.\
- Install Unity Hub & Unity.

For Testing you can either...
- Run multiple Clients on one Computer
- Use multiple computers on the same Local Area Network (LAN)
  - You can also use VPNs or Software like Hamachi to fake a Remote-LAN
- Or configure Port Forwarding in your Router for a certain Port or Port Range (Security Risk)
  - Make the router forward e.g. Port 4444 to your Computer's Local IP (usually 192.168.0.xxx)
  - Run the Server on Port 4444
  - Connect from the outside using your router's Public IP - [What Is my IP?](https://www.whatismyip.com) and the Port
- Or find a way of hosting your .NET Application somewhere in the Azure Cloud or so.
  - Unfortunately, I did not get to prepare this for this year :(

Assignments
- [1 - Time Server](./assignments/part1-timeserver.md)
- [2 - Time Client](./assignments/part2-timeclient.md)
- [3 - Open Word Server](./assignments/part3-openwordserver.md)
- [4 - Open word Client](./assignments/part4-openwordclient.md)
- [5 - Agar.io](./assignments/part5-agario.md)

# Remarks
- In the first four exercises, we are not using any advanced classes for working with `Streams`
  - it is slightly tedious, but it will teach you about how `byte[]` can be used as buffers
- Refer to the Slides `030 - Internet` for details on TCP / UDP.
- Be wary of following Tutorials or downloading Sample Code. Chances are that it's extremely over-engineered and that I'll notice tha the code is not yours.
- Especially exercises 1-4 do not require any complex code.
- For Exercise 5, it's also best to start very small and slowly scale it up when required.

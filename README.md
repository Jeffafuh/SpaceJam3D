# SpaceJam 3D
A RowdyHacks 2023 project using Unity 3D and the Microsoft Azure Kinect DX. Jeff, Phuc, and Rafael.
Developed on Unity 2021.3.12f1. View the Devpost submission [here](https://devpost.com/software/spacejam-3d)

## Inspiration
We had access to a Microsoft Azure Kinect DK over the weekend, so we _had_ to use it! In terms of _what_ we were actually going to do with it, we figured it would be a fun idea of have a "reverse" hole-in-the-wall game, where you had to try and dodge objects as opposed to slipping through an opening in the wall.

## What it does
SpaceJam 3D (not to be affiliated with Space Jam the movie) is a 3D Unity game that takes in RGD-D-IR input from a Microsoft Azure Kinect DK, then feeds it through a Pose-Estimation Neural Network (ONNX) to generate a 3D mesh that is rendered in real time in Unity. Once the game is started, asteroids will start flying at the player and it's their job to dodge them! Each hit takes away from your finite health pool; how long can you survive?

## How we built it
Using the Microsoft Azure SDK,  we used the provided classes and function wrappers to help us receive data from the Kinect and feed it into the Pose-Estimation network. Once the neural network provides the inferred pose in real-time, we then map it onto a pre-rigged model in our scene. From there, we would spawn asteroids that would move towards the player. The player's job is to dodge these asteroids, otherwise they would take damage to their health and eventually die.

## Challenges we ran into
Although we wanted to use this Kinect to make a game, none of us had any real experience designing a game in Unity before. Although we had experience in similar languages in our studies, it was still a process learning how Unity games are structured and what functions we had available to us. Additionally, pushing to GitHub was quite the hassle to deal with. Especially due to the large and complex nature of our project, we very quickly hit our Git LFS bandwidth limit. As a result, we had to pull some very round-about techniques to properly commit everything to our GitHub.

## Accomplishments that we're proud of
We're immensely proud of our ability to get the Microsoft Azure Kinect DK working and properly feeding the RGB-D-IR data into the Pose-Estimation neural network. Also properly mapping the joint/mesh data from the neural network into a Unity mesh in real time was a tough, but satisfying challenge.

## What we learned
The biggest thing we've learned was our new knowledge regarding how to build/design games in Unity. Although we are all gamers, none of us have had any real knowledge into the amount of hard work and ingenuity that goes into designing and creating games. After completing this project, it has inspired all of us to at least try to learn more about the space of game design in our free time.

## What's next for SpaceJam 3D
Although SpaceJam3D won't be published in any research papers, the technologies and pipelines that we used are critical in the field of 3D pose estimation. The ability to take in visual data, feed it through a neural network, and then render it in real time in a game-like setting is a largely unexplored area of immersive, real-time telehealth experiences. The ability to design rehabilitative games without the need of external sensors or HUDs may not be designed based off of SpaceJam 3D, but it certainly a very small step in the right direction.

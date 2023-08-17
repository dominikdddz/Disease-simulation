## Table of contents
* [General info](#general-info)
* [Features](#features)
* [Technologies](#technologies)
* [Simulation Turn](#simulation-turn)
* [Ilustration and graph](#Ilustration-and-graph)

## General info
Simple program to prepare a disease simulation, where setting number of population, their conditions and after complete simulation save data from this which use for example to create graph

## Features
* creates simulation for n-person
* each person is a separate entity with its own health condition, age, direction and speed of movement
* during the encounter, individuals can become infected if their health resistance is too low
* resistance decreases with age
* each person can move at different speeds in one of 9 directions
* too low immunity during infection causes death

## Technologies
Project is created with:
* C# Language
* Windows Form

## Simulation Turn
```
MoveAllPerson();                    // Move all person in this turn
for (int i = 0; i < N; i++)         // loop to iterate for each person
{
    IsMeetSomeone(Persons[i]);                  // check is meet someone
    ChangeAgePerTurn(Persons[i]);               // get older
    CheckDurationConditionPerTurn(Persons[i]);  // check condition and resistance 
    IsDead(i);                                  // check is resistance is too low or age too high
}
ClearMeeting();       // clear all meetings
saveTurnToData();     // save simulation data for this turn
turnCount++;
```


## Ilustration and graph
Program during simulation create
![Simulation UI](/UI.png?raw=true "Simulation UI")

An example of a disease simulation
![Simulation GIF](/simulation.gif?raw=true "Simulation GIF")

An example of plot data generate from csv file after end simulation
![Simulation Plot](/plot.png?raw=true "Simulation Plot")

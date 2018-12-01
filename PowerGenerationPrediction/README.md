# Power prediction generation

Project's goal is to simplify modeling of solar panels and wind farms in order to make reliable power generation predictions. 

## Project's history

This project started as a simple application for predicting power generated by wind farm. First version of app used two ways 
of modeling power plants. First one was mathematical model, used to calculate an electrical output power of a wind turbine in 
given atmospheric conditions. Secound model was more advanced one - feed forward neural network was used. Unfortunatly neural 
network in first version was created using MATLAB and Neural Network Toolbox. 
To make project more elastic and possible to use without MATLAB license, it was necessary to resign from previous solution and 
move toward open source based alternatives. This decision created also opportunity to rewrite some crutial parts of code to 
better meet best coding practices and design patterns.

## Current status

Application is still in its infancy, yet slowly and continously growing. Works on connecting to weather forecasts 
api are still in progress. Next 
issues will focus on different ways to model all kinds of wind and solar based energy sources, sucha as solar panels and wind 
farms.  

## Tech used

Currently only C# and .Net Core are used, but in the future there needs to be a database allowing to store neural network 
configurations and data. Future technologies aren't still definietly decided. 


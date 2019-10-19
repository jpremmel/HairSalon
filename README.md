# _Eau Claire's Salon Management App_

#### _A web page where the fictional salon owner Claire can keep track of her salon's stylists & clients, 18 Oct 2019_

#### By _**Jacqueline Remmel**_

## Description

_This application allows a salon owner to interact with a database to keep track of her stylists and their clients._

## Setup/Installation Requirements

* _Clone this repository_
* _Log into MySQL via the terminal and create the database by running the following commands:_
  * _> CREATE DATABASE jacqueline_remmel;_
  * _> USE jacqueline_remmel;_
  * _> CREATE TABLE stylists (StylistId serial PRIMARY KEY, Name VARCHAR(255), Description VARCHAR(255), HireDate VARCHAR(255), HourlyWage INT);
  * _> CREATE TABLE clients (ClientId serial PRIMARY KEY, StylistId INT, Name VARCHAR(255), Description VARCHAR(255), PhoneNumber VARCHAR(255));_
* _Navigate to the "HairSalon" main directory_
* _Navigate to the "HairSalon" project sub-directory_
* _Run the command "dotnet restore"_
* _Run the command "dotnet watch run"_
* _Go to the URL "http://localhost:5000" in a browser_

## Technologies Used

_C#, ASP.NET Core MVC, MySQL, Entity, LINQ, CSS, Bootstrap, HTML_

### License

*Open-source*

Copyright (c) 2019 **_Jacqueline Remmel_**
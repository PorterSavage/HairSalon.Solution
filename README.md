# Hair Salon Webpage
## By Porter Savage

## Description
This is A Webpage that allows the user to see a list of current available stylists, if there are none then the user can add a stylist to the list, also the user can add clients for that specific stylist in a stylist/client one to many relationship.

## Specifications
* Can add new Stylists
* Able to view all the stylists that have been added
* Can add new Clients to an already added stylist
* User will be able to select a stylist and see the clients that are attached to that stylist

## Setup Instructions
* Download and Install .NET Core version 1.1.4 SDK, .NET core Runtime version 1.1.2, and MAMP.

* Clone repository by executing the following command in your command line "$git clone https://github.com/PorterSavage/HairSalon.Solution.git""
* Execute command to open the repository in your preferred text editor
* Open MAMP and MAKE SURE your Apache port is set to 8888 and MySql port is set to 8889. Then click "Start Servers"
* YOU MUST CREATE THE DATABASE FIRST TO BE ABLE TO USE THE WEBPAGE!
* In the command line Execute the command "MySql -uroot -proot -P8889
* Once you are in the MySql shell Execute the following commands to create the database:
* > "CREATE DATABASE hair_salon;"
* > "USE hair_salon;"
* > "CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));"
* > "CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255)), stylist_id INT;"
* > "CREATE DATABASE hair_salon_test;"
* > "USE hair_salon_test;"
* > "CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));"
* > "CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255)), stylist_id INT;"
* In order to use the webpage you need to navigate to the "HairSalon" directory within the "HairSalon.Solution" directory
* Once you've navigated to the "HairSalon" directory, execute these commands in order in the command line, "dotnet restore", "dotnet build", "dotnet run"
* Navigate to "http://localhost:5000" to see the webpage

### Bugs
* No known bugs

### Languages and Libraries Used
* C#
* .NET
* MAMP
* PhpMyAdmin

### Contact
* For support contact theportersavage@gmail.com

Copyright (c) 2019 Porter Savage
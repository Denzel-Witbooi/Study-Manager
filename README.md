Web published link: [Study Manager Website](https://studymanagementprj.azurewebsites.net/) <br/>
admin name : denzelwitbooi password: Password1<br/>
Youtube link: https://youtu.be/FdzMHWEDK7I
Slides are available in the pdf version in the documents folder. 

-------------------------------------------
Videos refered to making this project <br/>
[Video1](https://www.youtube.com/watch?v=Pi46L7UYP8I)<br/>
[Video2](https://www.youtube.com/watch?v=B0_gM-wBlmE&t=756s)<br/>
Helpful websites: <br/>
[Website1](https://www.codeproject.com/Articles/1207962/Simple-CRUD-Operation-with-Razor-Pages)<br/>
[Website2](https://dotnetthoughts.net/integrating-google-charts-in-aspnet-core/)<br/>
---------------------------------------------

HOW TO USE THIS PROJECT <br/>
FIRST OPTION: 
--------------------
Click on this link [Study Manager Website](https://studymanagementprj.azurewebsites.net/) to access the web version hosted on azure
---------
-----------------------------------------------------
The web app already has the users and their modules added.
------------------------------------------------------
nav bar will have home, module, view, graph links visible after login.<br/> 
Module link --> enter specific details for Module then click save. <br/>
View --> shows a report for all modules of the *specific user* <br/>
Graph --> shows a graph for the amount of weeks per module. <br/>


SECOND OPTION: 
-----------------------
- Clone the project from git repo (the green button). <br/>
- Click on it and copy the link. <br/>
- Open visual studio and select clone repository. <br/>
- Paste the link and click ok. <br/>
- Go to Sql Server management and run the *StudentInfoAsp.sql script*  <br/>
- On the *Create and use Statements*<br/>
- Which will create the database. <br/>
- Right Click on the database<br/>
- Select properties<br/>
- Find the connection string and copy it. 
- Go back the cloned repo in visual studio navigate the *appsettings.json* file <br/>
  _ And change the **StudentConnectionString** to yours<br/>
  _ "StudentConnectionString": "[PLACE YOUR CONNECTION STRING HERE]"
- Delete the current migration folder 
---------------------------------
- Then Go to tools on the nav bar then --> Nuget Package Manager --> Package Manager Console
- In the console enter *add-migration AddStudentToDatabase* the doesn't really matter as long as it makes sense to you. 
- After it's completed add *update-database* in the console. 
- **In sql Script drop the Module table and run the create table Module statement**
- Reason for dropping the table is to change the datetime2 --> datetime. 
- **In sql script run the the insert statements to add to the *Module* table.** 
- Run the application and register a new user with username JohnDoe. 
- Reason being you can't add inserts for the **AspNet tables** as they were created automatically throught the **IdentityDbContext**
- Which also comes with secure password hashing.
----------------------------------
Run the application in any browser but preferably on Chrome,firefox and edge as its been tested in these browsers
----------------------------------------
- You'll be greet by a home page with and image welcome title. 
- Click on the register button to register as a new user 
- Login if you already registered. 
- nav bar will have home, module, view, graph links visible after login. 
- Module link --> enter specific details for Module then click save. 
- View --> shows a report for all modules of the *specific user* 
- Graph --> shows a graph for the amount of weeks per module. 
- Logout button when pressed show a page asking if you really want to logout.
-------------------------------------------


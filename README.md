# TimeManagementApp

Title: POE Part2 ST10083954

Version: 2.0.0

Table of Contents: 
 A - How I Implented Feedback.
 B - Pre-Requisites
 C - Description.
 D - How to intall the project.
 E - How to use the project.
 F - Credits.
 G - Challenges.
 H - What I would like to Add.
 I - UML.
 J - Change Log.

A) How I Implented Feedback: 

1) "Students, modules, reg, study session, stored. Dates not stored?" - I add more tables into my database (Reminder, Semester, ModuleSemester, StudySession) which will store the dates the user enters.
2) "Separate the reg from the semester please." - Once the user register it will then take them to the option to add a semester.
3) "Add pre-requisites" - Added to the Readme.md
4) "Your readme file needs some minor details pre-requisites, etc. See this: https://www.freecodecamp.org/news/how-to-write-a-good-readme-file/" - This site was used to add more to my Readme file.

B) Pre-Requisites

1) Visual Studio 2022
2) .Net Core 6
3) TMADll

C) Description: 

The project is used to help students manage their times and recommend how many hours they should spend studying a module per week.	
This application was created in Visual Studio using C# and ASP.NET MVC.
A library called TMADll is added into the project. This library was created by me.

D) How to intall the project:

1) First you will have to download this project.
2) Afterwards you will have to open this project in Visual Studios 2022 as it uses .Net 6.
3) If a warining shows up on the due to the library class please go to step 4, if not the project is correctly installed.
4) First you will have to download this project and the ModulesCal library 
5) Right click on the project and select the following options
![Add](https://user-images.githubusercontent.com/63053721/188342725-a2ad5026-ac42-4939-9f03-8bf672557251.JPG)
6) Go onto 'Browse' and go to the Dll folder located in the project'
7) Make sure the check box is checked 
8) The project is now installed and will work properly

E) How to use the project:

1) Click the run button in Visual Studio.

2) You will be shown the LoginWindow. Please enter the requested data and then click the 'Enter' button to continue with the application or click the 'Exit' button to close the application.

![Login](https://user-images.githubusercontent.com/63053721/198496062-18f196c5-acbd-4c2d-bfe5-c16050b6cb10.JPG)

3) If you don't have an account click the signUp button. This will take you to a form to register an account.

![SignUp](https://user-images.githubusercontent.com/63053721/198496035-7df81ed1-8bd1-424e-b13e-da0d9fa57608.JPG)

4) Errors will be displayed to the user and the error can be viewed by hovering over the highlighted text box.

![Error](https://user-images.githubusercontent.com/63053721/198496497-289c4691-cd1d-49b7-b9a1-42575a13b3f7.JPG)

5) You will be shown the main form of the applicaiton. Click on one of the 3 options on the navigation bar to continue.

6) The Dashboard has a data grid that will fill up as the user enters their modules into the Caption form. 

![DashboardNull](https://user-images.githubusercontent.com/63053721/198496133-952b23b4-05fb-48a8-9910-5c2599bea078.JPG)

![DashboardFull](https://user-images.githubusercontent.com/63053721/198496139-42b4832a-c7c6-4c5b-9a55-e25070e718c7.JPG)

7) The Capture button has a form that must be filled out so that your modules can be displayed onto the data gird in the Dashboard page.

![Capture](https://user-images.githubusercontent.com/63053721/198496187-c43d0121-bc93-4f15-ba08-3285eb6b26d5.JPG)

8) The Study button has a form that must be filled out to calculate your remaining hours of study for the week.

![Studied](https://user-images.githubusercontent.com/63053721/198496229-d7a875db-2c40-4102-893b-f16cf034501e.JPG)

9) To exit the application please select the Exit option at the bottom left.

F) Credits:

I would like to thank my tutors and Shayne for input on the application and for help with the code and logic.

G) Challenges:

1) When I would create a study session it would add a new row into a different table and take that primary key. I solved this by adding a viewModel.

H) What I would like to add:

1) Would like to add a search bar feature
2) Add animations
3) Add an API
4) Add more style to the combo box and data grid

I) UMl: 

![UML Part 2 drawio (1)](https://user-images.githubusercontent.com/63053721/199377761-d86e9da9-1dbc-4cb2-be01-d537440f31a0.png)



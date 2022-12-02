# TimeManagementApp

Title: POE ST10083954

Version: 3.0.0

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

2) This will take you to the login screen. If you have an account you can login but if not you can click on REGISTER which is on the top navigation bar.

![login](https://user-images.githubusercontent.com/63053721/205197767-32b15ad6-8896-4892-9ad5-b0741eeee616.JPG)

![Reg](https://user-images.githubusercontent.com/63053721/205197774-8f255326-37c6-486a-9ca1-265211d6cf88.JPG)

3) Once you login you will be taken to the semester create page which is required in order for you to add modules. Add your semesters details.

![Sem](https://user-images.githubusercontent.com/63053721/205197827-127b15b6-f148-4776-9156-e277afea6a91.JPG)

4) Once you add your semester you can add your modules and it will be displayed to the user on the dashboard.

![Module](https://user-images.githubusercontent.com/63053721/205197943-eb8322cd-20ad-4636-b7b6-5e5ba17c6e0c.JPG)

5) You can input your study details. This will effect the remaining hours of your module on the dashboard.

![Study](https://user-images.githubusercontent.com/63053721/205197865-21bb61bd-6016-4493-a0b9-ede4fd4bf979.JPG)

6) You can create a reminder to be displayed on the dashboard as a specific day of the week will be selected for each module, reminding you on that day to study for it.

![Remind](https://user-images.githubusercontent.com/63053721/205197903-8cca48d2-3380-469d-8456-9890ed6ae831.JPG)

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

![Part 3 drawio](https://user-images.githubusercontent.com/63053721/205197984-cf8dfd4e-ddd4-4fa9-ae56-9940f5df97bc.png)

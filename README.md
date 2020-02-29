# STUDENTS ERP

An ERP to manage the information from the school students. The school staff can add the information of new students, access this information, Edit the information and delete the student inforation once he is graduated.
 
## Getting Started
This ERP is in C# code. I reccomend Visual Studio to check the code.

## Implementation

In this implementation, I tried to apply Single Responsibility in the classes and methods. 
In a first moment, after I analysed the project, I segregate the problem in tasks and classes.

I planned the project with a 3 layer architechture:
1) FileManager.Common.Layer
2) FileManager.DataAccess.Data
3) FileManager.Presentation.WinSite

The data that the school staff will manage will be: 
- StudentId
- StudentName
- StudentLastName
- Date of birth

The staff can record the student information in: txt, json or xml files (Combobox).

Classes:

-- frmStudent:

-- StudentDao:

-- StudentFile:

-- StudentFileXml:

-- StudentFileJson:

-- StudentFileTxt:


## Product Backlog
- Refactorize the code: Use 10x10x10 rule
- Add more information to student file (Grades, Country, Previous studies...)
- Apply the SOLID principle

## Technology Stack

`C# | .NET FRAMEWORK | MSTest`







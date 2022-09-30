# Crystal report DEMO
crystal report demo to download the employee informtion using crystal reports.

##### Envirnonment Setup
- Install Microsoft Visual Studio 2019 Version 16.11
- Install SQL Server Management Studio (SSMS) 18 and above
- Download and Install [SAP Crystal Reports for Visual Studio (SP32) installation package for Microsoft Visual Studio IDE (VS 2019 and below)]
  Recommended to download from the link given [Crystal Reports for Visual Studio (SP32)](https://www.sap.com/cmp/td/sap-crystal-reports-visual-studio-trial.html).

#### Download and Install the database scripts from the folder [db_scripts]

#### Cloning a repository to your local machines
 
Follow these steps to get your development environment set up:
1. Clone the repository
2. At the root directory, restore required packages by running:
```csharp
dotnet restore
```
3. Next, build the solution by running:
```csharp
dotnet build
```
4. Ensure your connection strings in ```web.config``` point to a local SQL Server instance.

5. Next, within the AspnetRun.Web directory, launch the back end by running:
```csharp
dotnet run
```
5. Launch http://localhost:5400/ in your browser to view the Web UI.

If you have **Visual Studio** after cloning Open solution with your IDE, AspnetRun.Web should be the start-up project. Directly run this project on Visual Studio with **F5 or Ctrl+F5**. You will see index page of project, you can navigate product and category pages and you can perform crud operations on your browser.
 

This is a Blazor Web Application, with Server Side Rendering enabled. <br> <br>
Built with Microsoft Visual Studio Professional 2022 (64-bit) - Version 17.12.3<br><br>
DB - Sql Server Local DB, Entity Framework Core enabled, CRUD operation razors are created by scaffolding the EF model<br><br>
Implemented MS Entity Framework to create ppiCandidateTestAppContext class to auto generate the schema. But may need to Double Click on connected services, Select ... and Add Migration for the ppiCandidateTestAppContext
to create the database initially. Then double click connected service and update Database. Then after the migration is done upon running the application, default entries will be added. <br><br>
In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database: <br><br>
PM> Update-Database <br><br>
Alternatively, you can apply pending migrations from a command prompt at your project directory:<br><br>
dotnet ef database update<br>

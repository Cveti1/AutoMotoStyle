# AutoMotoStyle


"AutoMotoStyle" is an ASP.NET Core MVC App - а Web application for renting of different vehicles and some additional services which are offered. 
The project is divided into three parts: 
- AutoMotoStyle - contains two areas - Admin and Identity, Controllers and Views of the project.
- AutoMotoStyle.Core - where is the logic of the project  - Interfaces, Services and Models.
- AutoMotoStyle.Infrastructure  - which contains the entity models.
- AutoMotoStyle.Unit Tests includes the unit tests for testing the services of the project.

The application has the follow logic:  an administrator, some dealers and guest users.
The Users can look at all vehicles and services with their details, search and rent a desired car. If they want can become Dealer. Dealers have more privilegies to add, edit and delete only their added cars. The Administrator has all privileges of Users and Dealers and can see all registrations in the application.

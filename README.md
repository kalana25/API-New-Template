# API-New-Template

This project Template use EntityFrameworkCore. (Data Access Technology)

Delete Migration Folder (Inside DAL Layer) exist once you have the repository in your local machine.
Change the connection string in the startup class (API Layer).
Include all the models required to your project.
Do the migration to DAL Layer.

Information About Project Sturcture and Architecture.

1) Controllers layers only consume UseCase Layer.
2) DTO mapping should be carried out only inside the UseCase layer.
3) All the business logic should be developed inside the UseCase layer.
4) Unit of work is available inside the UseCase layer.
5) Therefore invoke the complete method after all inside your custom usecases.


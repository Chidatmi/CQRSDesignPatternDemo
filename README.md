# CQRSDesignPatternDemo
CQRS stands for Command and Query Responsibility Segregation
This demo application follows CQRS Design Pattern (a pattern that separates read and update operations for a data store)
This demo application is showing StudentApp which includes folders of Controller, Data, Features, Models, Services and Views.
** Controller - Request by the client comes to this through the View.
** Data - Context class which includes Database table and connection.
** Models- Models class of student which shows the fields/Properties of Student Table.
** Services- Inclueds Interface of student class and other class is doing the operation which is equested by the client.
** Features -- This includes Commands and Queries folders which does the database operations.

CQRS is used for maximize its performance, scalability, and security.

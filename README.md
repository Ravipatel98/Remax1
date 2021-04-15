# Remax1
F1 : The Admin (with full access) manages Employees (admin et agents), Houses, Clients (Buyers and Sellers). 
F2 : The Agent manages ONLY his own Clients (Buyers and Sellers) and House 
F3 : Any User can search for a one particular or all the Houses (by reference number) and for a particular or all Agents (by employee number).

- GUI Layer :
Window C# Application with MDI (multiple documents interface) based on the user functionality requirements.

- BUSINESS Layer :
Library of classes for the entities: Company, Employees (User, Admin or Agent), Clients (Buyer or Seller) and Houses.

- DATASOURCE Layer :
Class that encapsulates the database (access) and provides public interfaces for feeding data to the business layer and writing data back to the database.
Microsoft Access database that will contains all the needed data for Remax (Sales bonus).


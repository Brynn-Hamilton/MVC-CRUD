create database potluck;
use potluck;

CREATE TABLE teammember (
    Id INT NOT NULL auto_increment,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    EmailAddress VARCHAR(50),
    AttendanceDate VARCHAR(50),
    GuestName VARCHAR(50),
    PRIMARY KEY (Id)
    
);

CREATE TABLE dish (
    Id INT NOT NULL AUTO_INCREMENT,
    TMName VARCHAR(50),
    PhoneNumber VARCHAR(50),
    DishName VARCHAR(50),
    DishDescription VARCHAR(100),
    Category VARCHAR(25),
    PRIMARY KEY (Id)
);

insert into teammember (FirstName, LastName, EmailAddress, AttendanceDate, GuestName) values ('Brynn', 'Hamilton', 'brynnh@abc.com', '10/31/2022', 'Zach');

insert into dish (TMName, PhoneNumber, DishName, DishDescription, Category) values ('Zachary', '4073823322', 'Tteokbokki', 'Rice cakes in a spicy gochujang sauce', 'Appetizer');

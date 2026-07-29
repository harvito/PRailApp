-- Create Customer table
CREATE TABLE Customer
(
    CustomerId INT IDENTITY PRIMARY KEY,
    CustomerName NVARCHAR (128) NOT NULL
);

-- Create Passenger table
CREATE TABLE Passenger
(
    PassengerId INT IDENTITY PRIMARY KEY,
    PassengerName NVARCHAR (128) NOT NULL,
    DateOfBirth DATE NOT NULL
);

-- Create Trip table
CREATE TABLE Trip
(
    PassengerName NVARCHAR (128) NOT NULL,
    DepartureTime DATETIME2 NOT NULL,
    DeparturePlace NVARCHAR (128) NOT NULL,
    ArrivalTime DATETIME2 NOT NULL,
    ArrivalPlace NVARCHAR (128) NOT NULL,
    TrainRouteNumber INT NOT NULL,
    PassengerId INT FOREIGN KEY REFERENCES Passenger (PassengerId),
    CustomerId INT FOREIGN KEY REFERENCES Customer (CustomerId)
);
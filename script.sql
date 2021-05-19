CREATE TABLE Positions
(
  PositionID INT NOT NULL,
  PositionTitle INT NOT NULL,
  Salary INT NOT NULL,
  Duties INT NOT NULL,
  Demands INT NOT NULL,
  PRIMARY KEY (PositionID)
);

CREATE TABLE Publisher
(
  PubID INT NOT NULL,
  PublicistTitle INT NOT NULL,
  City INT NOT NULL,
  Address INT NOT NULL,
  PRIMARY KEY (PubID)
);

CREATE TABLE Genres
(
  GenID INT NOT NULL,
  GenTitle INT NOT NULL,
  Description INT NOT NULL,
  PRIMARY KEY (GenID)
);

CREATE TABLE Books
(
  BookID INT NOT NULL,
  BookTitle INT NOT NULL,
  Author INT NOT NULL,
  PubYear INT NOT NULL,
  GenID INT NOT NULL,
  PubID INT NOT NULL,
  PRIMARY KEY (BookID),
  FOREIGN KEY (GenID) REFERENCES Genres(GenID),
  FOREIGN KEY (PubID) REFERENCES Publisher(PubID)
);

CREATE TABLE Reader
(
  ReadID INT NOT NULL,
  Name INT NOT NULL,
  BirthDate INT NOT NULL,
  Gender INT NOT NULL,
  Address INT NOT NULL,
  Phone INT NOT NULL,
  PassportData INT NOT NULL,
  PRIMARY KEY (ReadID)
);

CREATE TABLE Employee
(
  EmpID INT NOT NULL,
  Name INT NOT NULL,
  BirthDate INT NOT NULL,
  Gender INT NOT NULL,
  Address INT NOT NULL,
  Phone INT NOT NULL,
  passportData INT NOT NULL,
  PositionID INT NOT NULL,
  PRIMARY KEY (EmpID),
  FOREIGN KEY (PositionID) REFERENCES Positions(PositionID)
);

CREATE TABLE IssuedBooks
(
  IssueDate INT NOT NULL,
  ReturnDate INT NOT NULL,
  ReturnMark INT NOT NULL,
  EmpID INT NOT NULL,
  ReadID INT NOT NULL,
  BookID INT NOT NULL,
  FOREIGN KEY (EmpID) REFERENCES Employee(EmpID),
  FOREIGN KEY (ReadID) REFERENCES Reader(ReadID),
  FOREIGN KEY (BookID) REFERENCES Books(BookID)
);
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (1, 'Johann',
                                                                   'Wolfgang', '1756-01-27');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (2, 'Jane',
                                                                   'Austen', '1775-12-16');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (3, 'Agatha',
                                                                   'Christie', '1890-09-15');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (4, 'George',
                                                                   'Orwell', '1903-06-25');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (5, 'Isaac',
                                                                   'Asimov', '1920-01-02');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (6, 'George',
                                                                   'Orwell', '1903-06-25');
INSERT INTO PERSONS (Id, FirstName, LastName, DateOfBirth) VALUES (7, 'Isaac',
                                                                   'Asimov', '1920-01-02');

-- Beispielhafte Kundendaten 
INSERT INTO CUSTOMERS (Id, MembershipDate)
VALUES (1,  '2020-05-01');
INSERT INTO CUSTOMERS (Id, MembershipDate)
VALUES (2,  '2021-08-15');
INSERT INTO CUSTOMERS (Id, MembershipDate)
VALUES (3, '2019-11-10');
INSERT INTO CUSTOMERS (Id, MembershipDate)
VALUES (4,  '2022-01-18');
INSERT INTO CUSTOMERS (Id, MembershipDate)
VALUES (5,  '2023-03-25');
-- Beispielhafte Bibliothekarendaten 
INSERT INTO LIBRARIANS (Id, EmployeeId) VALUES
    (1,  'LIB001');
INSERT INTO LIBRARIANS (Id, EmployeeId) VALUES
    (2,  'LIB002');
INSERT INTO LIBRARIANS (Id, EmployeeId) VALUES
    (3,  'LIB003');
INSERT INTO LIBRARIANS (Id, EmployeeId) VALUES
    (4,  'LIB004');
INSERT INTO LIBRARIANS (Id, EmployeeId) VALUES
    (5,  'LIB005');


-- BookDetails für das Buch "Das Kapital"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (1, 10, 2, 8);
-- BookDetails für das Buch "1984"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (2, 15, 5, 10);
-- BookDetails für das Buch "Einführung in die Programmierung"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (3, 20, 7, 13);
-- BookDetails für die Biografie "Die Biografie von Albert Einstein"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (4, 12, 4, 8);
-- BookDetails für das Buch "Der Marsianer"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (5, 10, 3, 7);
-- BookDetails für das Buch "Harry Potter und der Stein der Weisen"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (6, 25, 10, 15);
-- BookDetails für das Buch "Der Hund von Baskerville"
INSERT INTO BOOKDETAILS (BookId, TotalCopies, BorrowedCopies, AvailableCopies)
VALUES (7, 8, 2, 6);


INSERT INTO AUTHORS (Id, Biography)
VALUES (1,  'Philosopher, economist, and political theorist.');
INSERT INTO AUTHORS (Id, Biography)
VALUES (2,  'British novelist, essayist, and critic.');
INSERT INTO AUTHORS (Id, Biography)
VALUES (3,  'Experienced programmer and author of programming 
textbooks.');
INSERT INTO AUTHORS (Id, Biography)
VALUES (4,  'Biographer and historian.');
INSERT INTO AUTHORS (Id, Biography)
VALUES (5,  'Science fiction author known for his work "The 
Martian".');
INSERT INTO AUTHORS (Id, Biography)
VALUES (6,  'British author known for the Harry Potter 
series.');
INSERT INTO AUTHORS (Id, Biography)
VALUES (7,  'Author of detective novels, creator of 
Sherlock Holmes.');




INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (1, 'Das Kapital', 'Karl Marx', '1867-09-14', '978-3-16-148410-
0',  'NonFiction', 1, 1);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (2, '1984', 'George Orwell', '1949-06-08', '978-0-452-28423-4',
                                                              'Novel', 2, 2);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (3, 'Einführung in die Programmierung', 'John Doe', '2020-01-01',
                                                              '978-3-16-148410-1',  'Textbook', 3, 3);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (4, 'Die Biografie von Albert Einstein', 'Walter Isaacson',
                                                              '2007-10-02', '978-1-59420-193-0',  'Biography', 4, 4);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (5, 'Der Marsianer', 'Andy Weir', '2011-02-11', '978-3-446-23559-
6',  'ScienceFiction', 5, 5);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (6, 'Harry Potter und der Stein der Weisen', 'J.K. Rowling',
                                                              '1997-06-26', '978-3-7459-9406-7',  'Fantasy', 6, 6);
INSERT INTO BOOKS (Id, Title, Author, PublishedDate, ISBN,
                   ItemType, BookDetailsId, AuthorId) VALUES (7, 'Der Hund von Baskerville', 'Arthur Conan Doyle', '1902-04-01', '978-3-16-148410-8',  'Mystery', 7, 7);


-- Beispielhafte Ausleihe-Daten in die BookLoan-Tabelle
-- Kunde leiht ein Buch aus
INSERT INTO BOOKLOANS (CustomerId, BookId, LoanDate, DueDate, LibrarianId)
VALUES (1, 1, '2024-01-10', '2024-02-10', 2);
-- Ein weiteres Beispiel mit Rückgabedaten
INSERT INTO BOOKLOANS (CustomerId, BookId, LoanDate, DueDate, LibrarianId,
                       ReturnDate, ReturnLibrarianId)
VALUES (2, 3, '2024-02-01', '2024-02-28', 1, '2024-02-20', 3);
-- Noch eine Ausleihe ohne Rückgabedatum
INSERT INTO BOOKLOANS (CustomerId, BookId, LoanDate, DueDate, LibrarianId)
VALUES (3, 2, '2024-02-15', '2024-03-15', 2);
-- Rückgabe eines anderen Buches
INSERT INTO BOOKLOANS (CustomerId, BookId, LoanDate, DueDate, LibrarianId,
                       ReturnDate, ReturnLibrarianId)
VALUES (1, 4, '2024-03-05', '2024-04-05', 3, '2024-03-25', 1);



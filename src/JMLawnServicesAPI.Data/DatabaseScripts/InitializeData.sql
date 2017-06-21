--sql scripts below will load the database with initial data
--for the moment, we will proceed using dummy data for the Estimate table

-- Estimates table initialize
INSERT INTO 'Estimates' ( 'ID', 'FirstName', 'LastName', 'StreetAddress', 'City', 'ZipCode', 'PhoneNumber', 'Email', 'RequestsMow', 'RequestsBlow', 'RequestsEdge', 'Estimate', 'AreaInSquareFeet')
VALUES(1, "John", "Monarchik", "5318 Saffron Drive", "Dunwoody", 30338, 6787617274, "monarchikj@marist.com", 1, 1, 1, 40, 10000);

INSERT INTO 'Estimates' ('ID', 'FirstName', 'LastName', 'StreetAddress', 'City', 'ZipCode', 'PhoneNumber', 'Email', 'RequestsMow', 'RequestsBlow', 'RequestsEdge', 'Estimate', 'AreaInSquareFeet')
VALUES( 2, "MATRIX", "Resources", "1000 Abernathy Road NE", "Atlanta", 30328, 7706772400, "support@matrixres.com", 1, 0, 1, 30, 10000);

INSERT INTO 'Estimates' ('ID', 'FirstName', 'LastName', 'StreetAddress', 'City', 'ZipCode', 'PhoneNumber', 'Email', 'RequestsMow', 'RequestsBlow', 'RequestsEdge', 'Estimate', 'AreaInSquareFeet')
VALUES(3, "Ed", "Monarchik", "3060 Peachtree Road NW", "Atlanta", 30305, 6789043223, "emonarchik@mesacp.com", 0, 0, 1, 25, 10000);


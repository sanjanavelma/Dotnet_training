CREATE TABLE Contacts (
    name VARCHAR(50),
    phoneno VARCHAR(15),
    email VARCHAR(50),
    fatherphone VARCHAR(15),
    motherphone VARCHAR(15),
    landline VARCHAR(15)
);

INSERT INTO Contacts VALUES
('Sanjana', '9876543210', NULL, NULL, NULL, NULL),
('Ashi Gupta', NULL, 'ashi@gmail.com', NULL, NULL, NULL),
('Raima', NULL, NULL, '9123456780', NULL, NULL),
('Shahid', NULL, NULL, NULL, '9988776655', NULL),
('Sabeer', NULL, NULL, NULL, NULL, '0442345678'),
('Mustafeez', NULL, NULL, NULL, NULL, NULL),
('Sathvika', '9988123456', NULL, NULL, NULL, NULL),
('Srividhya', NULL, 'srividhya@gmail.com', NULL, NULL, NULL),
('Achi pori', NULL, NULL, '9000012345', NULL, NULL),
('Achi pori', NULL, NULL, NULL, '9111122222', NULL);

SELECT 
    name,
    COALESCE(phoneno, email, fatherphone, motherphone, landline) AS primary_contact
FROM Contacts;

SELECT 
    name,
    COALESCE(phoneno, email, fatherphone, motherphone, landline) AS primary_contact,

    CASE 
        WHEN phoneno IS NOT NULL THEN 'Phone Number'
        WHEN email IS NOT NULL THEN 'Email'
        WHEN fatherphone IS NOT NULL THEN 'Father Phone'
        WHEN motherphone IS NOT NULL THEN 'Mother Phone'
        WHEN landline IS NOT NULL THEN 'Landline'
        ELSE 'No Contact'
    END AS contact_source

FROM Contacts;

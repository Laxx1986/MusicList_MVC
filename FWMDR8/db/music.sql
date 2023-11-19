CREATE TABLE Music (
 ID integer NOT NULL PRIMARY KEY AUTOINCREMENT,
 Title text NOT NULL,
 Performer text NOT NULL,
 Release_date integer,
 Music_length integer NOT NULL,
 Priority integer NOT NULL,
 UNIQUE(Title, Performer)
);

CREATE TABLE isfilm (
	id INT NOT NULL PRIMARY KEY IDENTITY,
	film VARCHAR (100) NOT NULL,
	genre VARCHAR (100) NOT NULL,
	tahun VARCHAR (50) NOT NULL,
	sutradara VARCHAR (100) NOT NULL,
	createed_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO isfilm (film, genre, tahun, sutradara)
VALUES
('The Dark Night', 'Aksi', '2008', 'Christopher Nolan'),
('The Shawshank Redemption', 'Drama', '1994', 'Frank Darabont'),
('The Matrix', 'Sci-Fi / Aksi', '1999', 'Lana Wachowski & Lily Wachowski');
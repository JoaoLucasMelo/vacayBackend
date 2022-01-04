CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';


CREATE TABLE IF NOT EXISTS cruises(
  id INT NOT NULL AUTO_INCREMENT primary key,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  destination TEXT NOT NULL,
  tours INT NOT NULL,
  startDate DATETIME NOT NULL,
  price DOUBLE NOT NULL
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS tours(
  id INT NOT NULL AUTO_INCREMENT primary key,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  city TEXT NOT NULL,
  duration INT NOT NULL,
  price DOUBLE NOT NULL,
  cruiseId INT NOT NULL,
  resortId INT NOT NULL,
  FOREIGN KEY (cruiseId) REFERENCES cruises(id) ON DELETE CASCADE,
  FOREIGN KEY (resortId) REFERENCES resorts(id) ON DELETE CASCADE
) default charset utf8 COMMENT '';


CREATE TABLE IF NOT EXISTS resorts(
  id INT NOT NULL AUTO_INCREMENT primary key,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name TEXT NOT NULL,
  price DOUBLE NOT NULL,
  cruiseIncluded TINYINT NOT NULL
) default charset utf8 COMMENT '';

INSERT INTO cruises
(destination, price, tours, startDate)
VALUES
("Hawaii", 800, 2, "2022-12-03");

INSERT INTO resorts
(name, price, cruiseIncluded)
VALUES
("Big Ol' Resort", 1400, true);


INSERT INTO tours
(city, duration, price, cruiseId, resortId)
VALUES
("Hawaii", 8, 300, 1, 1);
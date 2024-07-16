CREATE TABLE Rca (
    rca_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    insured_vehicle VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE Casco (
    casco_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    insured_vehicle VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE Pad (
    pad_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    insured_property VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE OptionalHousing (
    optionalhousing_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    insured_property VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE Life (
    life_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    beneficiary VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE Health (
    health_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    age VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

CREATE TABLE Travel (
    travel_id INT PRIMARY KEY,
    insured_person VARCHAR(255),
    destination VARCHAR(255),
    startt_date DATE,
    end_date DATE, 
    premium DECIMAL(10,2),
);

select * from admin;





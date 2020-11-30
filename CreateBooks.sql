DROP TABLE konyvek;

CREATE TABLE konyvek(
	kolcsonzes_id int not null,
    olvasojegy_code char(8) not null,
	kolcsonzo_nev varchar2(100) not null,
	cim varchar(100) not null,
	iro_id int not null,
	mufaj varchar2(100) not null,
	kolcsonzes_date date not null,
	
	constraint pk_kolcsonzes_id primary key(kolcsonzes_id),
	constraint fk_irok foreign key(iro_id) references irok(id)
	
);

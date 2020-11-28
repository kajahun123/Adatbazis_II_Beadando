DROP TABLE konyvek;

CREATE TABLE konyvek(
    olvasojegy_code char(8) not null,
	first_name varchar(100) not null,
    last_name varchar(100) not null,
	cim varchar(100) not null,
	iro_id int not null,
	mufaj varchar2(100) not null,
	kiadas date not null,
	
	constraint pk_konyvek primary key(olvasojegy_code),
	constraint fk_irok foreign key(iro_id) references irok(id)
	
);

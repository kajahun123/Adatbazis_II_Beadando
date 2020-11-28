CREATE OR REPLACE PROCEDURE spInsert_konyvek(
	p_olvasojegy 		   in konyvek.olvasojegy_code%type,
	p_first_name 	        in konyvek.first_name%type,
	p_last_name		        in konyvek.last_name%type,
	p_cim		            in konyvek.cim%type,
	p_iro	                in iro.nev%type,
	p_mufaj		            in konyvek.mufaj%type,
	p_kiadas		        in konyvek.kiadas%type,
	
	p_out_rowcnt out int
)

AUTHID DEFINER
AS
	v_check_olvasojegy int;
BEGIN
	p_out_rowcnt := 0;
	
	IF v_check_rendszam = 1 THEN
		INSERT INTO konyvek
			(olvasojegy_code, first_name, last_name, cim, iro_id, mufaj, kiadas)
		VALUES 
        (p_olvasojegy, p_first_name, p_last_name, p_cim, p_iro, p_mufaj, p_kiadas);
		
        p_out_rowcnt := SQL%rowcount;
		COMMIT;
	END IF;
END spInsert_konyvek;
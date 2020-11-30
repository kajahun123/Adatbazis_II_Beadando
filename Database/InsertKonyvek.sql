CREATE OR REPLACE PROCEDURE spInsert_konyvek(
	p_olvasojegy 		   	in konyvek.olvasojegy_code%type,
	p_kolcsozno_nev	        in konyvek.kolcsonzo_nev%type,
	p_cim		            in konyvek.cim%type,
	p_iro	                in iro.nev%type,
	p_mufaj		            in konyvek.mufaj%type,
	p_kolcsonzes_date       in konyvek.kolcsonzes_date%type,
	
	p_out_rowcnt out int
)

AUTHID DEFINER
AS
	v_check_olvasojegy int;
	v_kolcsonzes_id int;
BEGIN
	p_out_rowcnt := 0;
	
	IF v_check_olvasojegy = 1 THEN
	
		SELECT MAX(kolcsonzes_id) INTO v_kolcsonzes_id FROM konyvek;
		
		IF v_kolcsonzes_id IS NULL THEN
			v_kolcsonzes_id := 0;
		END IF;
		v_id := v_id + 1;
		
		INSERT INTO konyvek
			(olvasojegy_code, kolcsonzo_nev, cim, iro_id, mufaj, kolcsonzes_date, kolcsonzes_id)
		VALUES 
        (p_olvasojegy, p_kolcsozno_nev, p_cim, p_iro, p_mufaj, p_kolcsonzes_date, v_kolcsonzes_id);
		
        p_out_rowcnt := SQL%rowcount;
		COMMIT;
	END IF;
END spInsert_konyvek;
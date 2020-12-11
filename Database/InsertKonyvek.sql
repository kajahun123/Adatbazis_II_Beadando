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
	v_iro_id int;
BEGIN
	p_out_rowcnt := 0;
	
	v_iro_id := sf_GetIrokId(p_iro);
    if v_iro_id is null then
        sp_InsertIrok(p_iro);
        v_iro_id := sf_getIrokId(p_iro);
    end if;
    v_check_olvasojegy := sf_check_olvasojegy(p_olvasojegy);
	
	IF v_check_olvasojegy = 1 THEN
		
		INSERT INTO konyvek
			(olvasojegy_code, kolcsonzo_nev, cim, iro_id, mufaj, kolcsonzes_date)
		VALUES 
        (p_olvasojegy, p_kolcsozno_nev, p_cim, p_iro_id, p_mufaj, p_kolcsonzes_date);
		
        p_out_rowcnt := SQL%rowcount;
		COMMIT;
	END IF;
END spInsert_konyvek;
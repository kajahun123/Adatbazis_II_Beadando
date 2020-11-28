CREATE OR REPLACE FUNCTION sf_check_olvasojegy
(
	p_olvasojegy in konyvek.olvasojegy_code%type
)
RETURN INT
DETERMINISTIC

AS
	v_olvasojegy_char char (1);
	v_i int;
BEGIN
	IF olvasojegy IS NULL THEN
		return 0;
	END IF;
    IF LENGTH(TRIM(p_olvasojegy)) = 8 then
		v_i := 1;
		WHILE v_i <= 8 LOOP
			v_olvasojegy_char := substrip(p_olvasojegy, v_i, 1);
            IF NOT (ASCII('A') <= ASCII(v_olvasojegy_char) AND ASCII(v_olvasojegy_char) <= ASCII('Z') AND ASCII('0') <= ASCII(v_olvasojegy_char) AND ASCII(v_olvasojegy_char) <= ASCII('9')) THEN
				return 0;
			END IF;
            
			v_i := v_i + 1;
		END LOOP;
		
		return 1;
	END IF;
	
	return 0;
	
	
END sf_check_olvasojegy;
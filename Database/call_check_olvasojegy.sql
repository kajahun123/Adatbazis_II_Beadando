SET SERVEROUTPUT ON;
DECLARE
	v_call_olvasojegy int;
	v_olvasojegy konyvek.olvasojegy_code%TYPE := '82DS3A23';
BEGIN
	v_call_olvasojegy :=sf_check_olvasojegy(v_olvasojegy);
	
	IF v_call_olvasojegy = 1 THEN
		DBMS_OUTPUT.PUT_LINE('Az al�bbi olvas�jegy helyes: '||v_olvasojegy);
	ELSE
		DBMS_OUTPUT.PUT_LINE('Az al�bbi olvas�jegy helytelen: '||v_olvasojegy);
	END IF;

END;

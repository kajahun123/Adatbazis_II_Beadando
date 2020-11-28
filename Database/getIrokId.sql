CREATE OR REPLACE FUNCTION sf_GetIrokId
(
	p_nev in irok.nev%TYPE
)
RETURN int
DETERMINISTIC

AS
	temp int;
	temp_cnt int;
BEGIN
	SELECT COUNT(*) INTO temp_cnt FROM irok WHERE nev = p_nev;
	
	IF temp_cnt = 0 THEN
		return null;
	ELSE
		SELECT id INTO temp FROM irok WHERE nev = p_nev;
	END IF;
	
	return temp;
	
END sf_GetIrokId;
CREATE OR REPLACE PROCEDURE sp_InsertIrok(
	p_nev 		in irok.nev%type
)

AUTHID DEFINER
AS
	v_id int;
BEGIN
	SELECT MAX(id) INTO v_id FROM irok;
	
	IF v_id IS NULL THEN
		v_id := 0;
	END IF;
    
	v_id := v_id + 1;
	
	insert into irok
		(id, nev) values (v_id, p_nev);
end sp_InsertIrok;
DELIMITER @@
CREATE TRIGGER simplemembershiptest.responsable_familiaTrigger AFTER INSERT ON simplemembershiptest.userprofile
    FOR EACH ROW 
BEGIN

insert into ent_familiar.usuario
(CoTipoUsuario,NoEmail,FlEstado) values (2,NEW.Email,0);
    
INSERT INTO ent_familiar.responsable_familia
(CoResponsable,
NoNombres,
NoApePaterno,
NoApeMaterno,
FlSexo,
CoTipoDocumento,
NuDocumento,
NoDireccion,
NuCelular,
FlEstado,
CoUsuario)
VALUES
(NEW.UserId,
NEW.NoNombres,
NEW.NoApePaterno,
NEW.NoApeMaterno,
NEW.FlSexo,
NEW.CoTipoDocumento,
NEW.NuDocumento,
NEW.NoDireccion,
NEW.NuCelular,
1,
LAST_INSERT_ID());
END;
@@
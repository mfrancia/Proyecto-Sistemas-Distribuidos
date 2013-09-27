SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

DROP SCHEMA IF EXISTS `ent_familiar` ;
CREATE SCHEMA IF NOT EXISTS `ent_familiar` DEFAULT CHARACTER SET latin1 ;
USE `ent_familiar` ;

-- -----------------------------------------------------
-- Table `ent_familiar`.`master_catalogo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`master_catalogo` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`master_catalogo` (
  `CoCtl` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoDescripcion` VARCHAR(60) NOT NULL ,
  PRIMARY KEY (`CoCtl`) )
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = latin1;

-- -----------------------------------------------------
-- Table `ent_familiar`.`catalogo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`catalogo` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`catalogo` (
  `CoCtl` INT(10) UNSIGNED NOT NULL ,
  `CoSubCtl` INT(10) NOT NULL ,
  `NoDescripcion` VARCHAR(60) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoCtl`, `CoSubCtl`) ,
  INDEX `fk_catalogo_master_catalogo1` (`CoCtl` ASC) ,
  CONSTRAINT `fk_catalogo_master_catalogo1`
    FOREIGN KEY (`CoCtl` )
    REFERENCES `ent_familiar`.`master_catalogo` (`CoCtl` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- -----------------------------------------------------
-- Table `ent_familiar`.`club`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`club` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`club` (
  `CoClub` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoClub` VARCHAR(60) NULL DEFAULT NULL ,
  `NoDireccion` VARCHAR(200) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoClub`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`servicio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`servicio` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`servicio` (
  `CoServicio` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoServicio` VARCHAR(60) NULL DEFAULT NULL ,
  `TxtDescripcion` VARCHAR(200) NULL DEFAULT NULL ,
  `SsPrecio` DECIMAL(10,2) NULL DEFAULT NULL ,
  `FlEstado` INT(2) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoServicio`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;

-- -----------------------------------------------------
-- Table `ent_familiar`.`juego`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`juego` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`juego` (
  `CoJuego` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoJuego` VARCHAR(60) NULL DEFAULT NULL ,
  `TxtDescripcion` VARCHAR(200) NULL DEFAULT NULL ,
  `TxtImagen` VARCHAR(300) NULL DEFAULT NULL ,
  `SsPrecio` DECIMAL(10,2) NULL DEFAULT NULL ,
  `FlEstado` INT(2) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoJuego`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;

-- -----------------------------------------------------
-- Table `ent_familiar`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`usuario` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`usuario` (
  `CoUsuario` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `CoTipoUsuario` INT(2) NULL DEFAULT NULL ,
  `NoEmail` VARCHAR(160) NULL DEFAULT NULL ,
  `FlEstado` INT(2) NULL DEFAULT NULL ,
  `NoContrasena` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoUsuario`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`responsable_familia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`responsable_familia` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`responsable_familia` (
  `CoResponsable` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoNombres` VARCHAR(60) NULL DEFAULT NULL ,
  `NoApePaterno` VARCHAR(60) NULL DEFAULT NULL ,
  `NoApeMaterno` VARCHAR(60) NULL DEFAULT NULL ,
  `FlSexo` INT(2) NULL DEFAULT NULL ,
  `CoTipoDocumento` INT(2) NULL DEFAULT NULL ,
  `NuDocumento` VARCHAR(20) NULL DEFAULT NULL ,
  `NoDireccion` VARCHAR(200) NULL DEFAULT NULL ,
  `NuCelular` VARCHAR(15) NULL DEFAULT NULL ,
  `FlEstado` INT(2) NULL DEFAULT NULL ,
  `CoUsuario` INT(10) UNSIGNED NOT NULL ,
  PRIMARY KEY (`CoResponsable`) ,
  INDEX `fk_responsable_familia_usuario1` (`CoUsuario` ASC) ,
  CONSTRAINT `fk_responsable_familia_usuario1`
    FOREIGN KEY (`CoUsuario` )
    REFERENCES `ent_familiar`.`usuario` (`CoUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`oferta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`oferta` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`oferta` (
  `CoOferta` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoOferta` VARCHAR(100) NULL DEFAULT NULL ,
  `FeInicio` DATE NULL DEFAULT NULL ,
  `FeCaducidad` DATE NULL DEFAULT NULL ,
  `TxtDescripcion` VARCHAR(200) NULL DEFAULT NULL ,
  `CoUbicacion` INT(2) NULL DEFAULT NULL ,
  `FlEstado` INT(2) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoOferta`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`solicitud_dia_campo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`solicitud_dia_campo` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`solicitud_dia_campo` (
  `CoDiaCampo` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `CoResponsable` INT(10) UNSIGNED NOT NULL ,
  `FeDiaCampo` DATE NULL DEFAULT NULL ,
  `NuTotalPersonas` INT(10) NULL DEFAULT NULL ,
  `SsImporteTotal` DECIMAL(10,2) NULL DEFAULT NULL ,
  `FlAprobado` INT(2) NULL DEFAULT NULL ,
  `FeAprobado` DATE NULL DEFAULT NULL ,
  `CoUsuarioAdmin` INT(10) UNSIGNED NULL DEFAULT NULL ,
  `CoClub` INT(10) UNSIGNED NOT NULL ,
  `CoOferta` INT(10) UNSIGNED NULL ,
  PRIMARY KEY (`CoDiaCampo`, `CoResponsable`) ,
  INDEX `fk_solicitud_dia_campo_usuarios` (`CoUsuarioAdmin` ASC) ,
  INDEX `fk_solicitud_dia_campo_club1` (`CoClub` ASC) ,
  INDEX `fk_solicitud_dia_campo_responsable_familia1` (`CoResponsable` ASC) ,
  INDEX `fk_solicitud_dia_campo_oferta1` (`CoOferta` ASC) ,
  CONSTRAINT `fk_solicitud_dia_campo_usuario`
    FOREIGN KEY (`CoUsuarioAdmin` )
    REFERENCES `ent_familiar`.`usuario` (`CoUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_solicitud_dia_campo_club1`
    FOREIGN KEY (`CoClub` )
    REFERENCES `ent_familiar`.`club` (`CoClub` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_solicitud_dia_campo_responsable_familia1`
    FOREIGN KEY (`CoResponsable` )
    REFERENCES `ent_familiar`.`responsable_familia` (`CoResponsable` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_solicitud_dia_campo_oferta1`
    FOREIGN KEY (`CoOferta` )
    REFERENCES `ent_familiar`.`oferta` (`CoOferta` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`detalle_dia_campo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`detalle_dia_campo` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`detalle_dia_campo` (
  `CoDiaCampo` INT(10) UNSIGNED NOT NULL ,
  `CoResponsable` INT(10) UNSIGNED NOT NULL ,
  `NuSecuencia` INT(10) NOT NULL ,
  `NuPersonas` INT(10) NULL DEFAULT NULL ,
  `SsPrecioPersona` DECIMAL(10,2) NULL DEFAULT NULL ,
  `SsImporte` DECIMAL(10,2) NULL DEFAULT NULL ,
  `TxtComentario` VARCHAR(200) NULL DEFAULT NULL ,
  `CoServicio` INT(10) UNSIGNED NULL ,
  `CoJuego` INT(10) UNSIGNED NULL ,
  PRIMARY KEY (`CoDiaCampo`, `CoResponsable`, `NuSecuencia`) ,
  INDEX `fk_detalle_dia_campo_servicio1` (`CoServicio` ASC) ,
  INDEX `fk_detalle_dia_campo_juego1` (`CoJuego` ASC) ,
  CONSTRAINT `fk_detalle_dia_campo_servicio1`
    FOREIGN KEY (`CoServicio` )
    REFERENCES `ent_familiar`.`servicio` (`CoServicio` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_dia_campo_juego1`
    FOREIGN KEY (`CoJuego` )
    REFERENCES `ent_familiar`.`juego` (`CoJuego` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_dia_campo_solicitud_dia_campo1`
    FOREIGN KEY (`CoDiaCampo` , `CoResponsable` )
    REFERENCES `ent_familiar`.`solicitud_dia_campo` (`CoDiaCampo` , `CoResponsable` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`detalleoferta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`detalleoferta` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`detalleoferta` (
  `CoOferta` INT(10) UNSIGNED NOT NULL ,
  `NuSecuencia` INT(10) NOT NULL ,
  `FeConsulta` DATE NULL DEFAULT NULL ,
  `TxtConsulta` VARCHAR(500) NULL DEFAULT NULL ,
  `TxtRespuesta` VARCHAR(500) NULL DEFAULT NULL ,
  `CoResponsable` INT(10) UNSIGNED NOT NULL ,
  `CoUsuarioAdmin` INT(10) UNSIGNED NOT NULL ,
  PRIMARY KEY (`CoOferta`, `NuSecuencia`) ,
  INDEX `fk_detalleoferta_oferta1` (`CoOferta` ASC) ,
  INDEX `fk_detalleoferta_responsable_familia1` (`CoResponsable` ASC) ,
  INDEX `fk_detalleoferta_usuarios1` (`CoUsuarioAdmin` ASC) ,
  CONSTRAINT `fk_detalleoferta_oferta1`
    FOREIGN KEY (`CoOferta` )
    REFERENCES `ent_familiar`.`oferta` (`CoOferta` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalleoferta_responsable_familia1`
    FOREIGN KEY (`CoResponsable` )
    REFERENCES `ent_familiar`.`responsable_familia` (`CoResponsable` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalleoferta_usuario1`
    FOREIGN KEY (`CoUsuarioAdmin` )
    REFERENCES `ent_familiar`.`usuario` (`CoUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`material` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`material` (
  `CoMaterial` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `NoMaterial` VARCHAR(60) NULL DEFAULT NULL ,
  PRIMARY KEY (`CoMaterial`) )
ENGINE = InnoDB
AUTO_INCREMENT = 0
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `ent_familiar`.`juego_material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ent_familiar`.`juego_material` ;

CREATE  TABLE IF NOT EXISTS `ent_familiar`.`juego_material` (
  `CoMaterial` INT(10) UNSIGNED NOT NULL ,
  `CoJuego` INT(10) UNSIGNED NOT NULL ,
  PRIMARY KEY (`CoMaterial`, `CoJuego`) ,
  INDEX `fk_juego_material_material1` (`CoMaterial` ASC) ,
  INDEX `fk_juego_material_juego1` (`CoJuego` ASC) ,
  CONSTRAINT `fk_juego_material_material1`
    FOREIGN KEY (`CoMaterial` )
    REFERENCES `ent_familiar`.`material` (`CoMaterial` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_juego_material_juego1`
    FOREIGN KEY (`CoJuego` )
    REFERENCES `ent_familiar`.`juego` (`CoJuego` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO MASTER_CATALOGO (CoCtl ,NoDescripcion) VALUES (1,'ESTADO REGISTRO');
INSERT INTO MASTER_CATALOGO (CoCtl, NoDescripcion) VALUES (2,'TIPO USUARIO');
INSERT INTO MASTER_CATALOGO (CoCtl, NoDescripcion) VALUES (3,'SEXO');
INSERT INTO MASTER_CATALOGO (CoCtl, NoDescripcion) VALUES (4,'TIPO DE DOCUMENTO');
INSERT INTO MASTER_CATALOGO (CoCtl, NoDescripcion) VALUES (5,'UBICACION BANNER');
INSERT INTO MASTER_CATALOGO (CoCtl, NoDescripcion) VALUES (6,'APROBAR SOLICITUD DE CAMPO');

INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (1,0,'Activo');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (1,1,'Eliminado');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (2,1,'Administrador');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (2,2,'Responsable de Familia');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (3,1,'Masculino');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (3,2,'Femenino');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (4,1,'DNI');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (4,2,'Libreta Militar');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (4,3,'Pasaporte');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (4,4,'Carnet de Salud');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (5,1,'Superior');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (5,2,'Lateral');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (6,1,'Aprobado');
INSERT INTO CATALOGO (CoCtl, CoSubCtl, NoDescripcion) VALUES (6,2,'Eliminado');

INSERT INTO USUARIO (CoUsuario, CoTipoUsuario, NoEmail, FlEstado, NoContrasena) VALUES (1, 1, 'admin@hotmail.com', 0, '123456');
INSERT INTO USUARIO (CoUsuario, CoTipoUsuario, NoEmail, FlEstado, NoContrasena) VALUES (2, 2, 'cazador_dexk28@hotmail.com', 0, 'ramos');
INSERT INTO USUARIO (CoUsuario, CoTipoUsuario, NoEmail, FlEstado, NoContrasena) VALUES (3, 2, 'gcardenas@hotmail.com', 0, 'g123');
INSERT INTO USUARIO (CoUsuario, CoTipoUsuario, NoEmail, FlEstado, NoContrasena) VALUES (4, 2, 'lpolo@hotmail.com', 0, 'l123');
INSERT INTO USUARIO (CoUsuario, CoTipoUsuario, NoEmail, FlEstado, NoContrasena) VALUES (5, 2, 'aguerra@hotmail.com', 0, 'a123');

INSERT INTO CLUB (CoClub, NoClub, NoDireccion) VALUES (1,'Los Angeles', 'Chaclacayo - Carretera Central S/N');
INSERT INTO CLUB (CoClub, NoClub, NoDireccion) VALUES (2,'La Cabañita', 'Chosica - Carretera Central S/N');
INSERT INTO CLUB (CoClub, NoClub, NoDireccion) VALUES (3,'El Dorado', 'Cienguilla - Carretera Central S/N');

INSERT INTO JUEGO (CoJuego, NoJuego, TxtDescripcion, TxtImagen, SsPrecio, FlEstado) 
           VALUES (1, 'Huevo y Cuchara', 'Clásico Juego de Huevo y Cucharara', null, 10, null);
INSERT INTO JUEGO (CoJuego, NoJuego, TxtDescripcion, TxtImagen, SsPrecio, FlEstado) 
           VALUES (2, 'Saltos en Costal', 'Clásico Juego de Saltar envuelto en un costal', null, 15, null);
INSERT INTO JUEGO (CoJuego, NoJuego, TxtDescripcion, TxtImagen, SsPrecio, FlEstado) 
           VALUES (3, 'Tumbalatas', 'Clásico Juego que consiste en tumbar latas vacias', null, 5, null);
INSERT INTO JUEGO (CoJuego, NoJuego, TxtDescripcion, TxtImagen, SsPrecio, FlEstado) 
           VALUES (4, 'Lucha en la cuerda', 'Clásico Juego de vencer al otro equipo de jalar de una cuerda', null, 8, null);
INSERT INTO JUEGO (CoJuego, NoJuego, TxtDescripcion, TxtImagen, SsPrecio, FlEstado) 
           VALUES (5, 'La carretilla', 'Clásico Juego correr con tu amigo en una carretilla', null, 12, null);                         
                         

INSERT INTO SERVICIO (CoServicio, NoServicio, TxtDescripcion, SsPrecio, FlEstado) 
           VALUES (1, 'Movilidad', 'Transporta a la Familia al Club respectivo de destino', 40, null);
INSERT INTO SERVICIO (CoServicio, NoServicio, TxtDescripcion, SsPrecio, FlEstado) 
           VALUES (2, 'Almuerzo', 'Corresponde al Almuerzo durante el dia de campo', 20, null);                                    
INSERT INTO SERVICIO (CoServicio, NoServicio, TxtDescripcion, SsPrecio, FlEstado) 
           VALUES (3, 'Piscina', 'Corresponde al uso de la piscina', 5, null);
           
           
INSERT INTO RESPONSABLE_FAMILIA (CoResponsable, NoNombres, NoApePaterno, NoApeMaterno, FlSexo, CoTipoDocumento,
                                 NuDocumento, NoDireccion, NuCelular, FlEstado, CoUsuario) 
                         VALUES (1, 'FELIPE ANTHONINO', 'RAMOS', 'ARIAS', 1, 1, '44312396', 'Los Alamos N 178',
                                 '980590156', 0, 2);

INSERT INTO RESPONSABLE_FAMILIA (CoResponsable, NoNombres, NoApePaterno, NoApeMaterno, FlSexo, CoTipoDocumento,
                                 NuDocumento, NoDireccion, NuCelular, FlEstado, CoUsuario) 
                         VALUES (2, 'GIULIANA', 'CARDENAS', 'ARCE', 2, 1, '45123687', 'Los Canarios N 125',
                                 '951263478', 0, 3);
                                 
INSERT INTO RESPONSABLE_FAMILIA (CoResponsable, NoNombres, NoApePaterno, NoApeMaterno, FlSexo, CoTipoDocumento,
                                 NuDocumento, NoDireccion, NuCelular, FlEstado, CoUsuario) 
                         VALUES (3, 'LUIS', 'POLO', 'MARTINEZ', 1, 1, '42159681', 'Las Flores N 245',
                                 '923568417', 0, 4);

INSERT INTO RESPONSABLE_FAMILIA (CoResponsable, NoNombres, NoApePaterno, NoApeMaterno, FlSexo, CoTipoDocumento,
                                 NuDocumento, NoDireccion, NuCelular, FlEstado, CoUsuario) 
                         VALUES (4, 'ALAN', 'GUERRA', 'QUISPE', 1, 1, '43152879', 'Los Sauces N 987',
                                 '998562481', 0, 5);

INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (1, 1, '2013-12-15', 10, 150, 1, null);

INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (2, 2, '2013-12-07', 5, 380, 1, null);
                         
INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (3, 2, '2013-12-05', 7, 175, 1, null);
                         
INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (4, 1, '2013-12-06', 12, 145, 1, null);
                         
INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (5, 3, '2013-11-07', 5, 160, 3, null);
                         
INSERT INTO SOLICITUD_DIA_CAMPO (CoDiaCampo, CoResponsable, FeDiaCampo, NuTotalPersonas, SsImporteTotal, CoClub, CoOferta) 
                         VALUES (6, 4, '2013-11-07', 5, 325, 3, null);

                         
INSERT INTO DETALLE_DIA_CAMPO (CoDiaCampo, CoResponsable, NuSecuencia, NuPersonas, SsPrecioPersona, SsImporte, TxtComentario, CoServicio, CoJuego) 
                         VALUES (1, 1, 1, 10, 15, 150, null, null, 2);

INSERT INTO DETALLE_DIA_CAMPO (CoDiaCampo, CoResponsable, NuSecuencia, NuPersonas, SsPrecioPersona, SsImporte, TxtComentario, CoServicio, CoJuego) 
                         VALUES (2, 2, 1, 5, 40, 200, null, 1, null);

INSERT INTO DETALLE_DIA_CAMPO (CoDiaCampo, CoResponsable, NuSecuencia, NuPersonas, SsPrecioPersona, SsImporte, TxtComentario, CoServicio, CoJuego) 
                         VALUES (2, 2, 2, 5, 20, 100, null, 2, null);
                         
INSERT INTO DETALLE_DIA_CAMPO (CoDiaCampo, CoResponsable, NuSecuencia, NuPersonas, SsPrecioPersona, SsImporte, TxtComentario, CoServicio, CoJuego) 
                         VALUES (2, 2, 3, 4, 8, 32, null, null, 4);
                         
INSERT INTO DETALLE_DIA_CAMPO (CoDiaCampo, CoResponsable, NuSecuencia, NuPersonas, SsPrecioPersona, SsImporte, TxtComentario, CoServicio, CoJuego) 
                         VALUES (2, 2, 4, 4, 12, 48, null, null, 5);
                        
-- -----------------------------------------------------
-- Creando Procedimientos
-- -----------------------------------------------------
                         
drop procedure IF EXISTS `SET_TIPO_USUARIO`;

-- Consultar Tipos de Usuarios
DELIMITER //
CREATE DEFINER=`root`@`localhost`PROCEDURE SET_TIPO_USUARIO ()
BEGIN 
    select CoSubCtl as Codigo, trim(NoDescripcion) as Desnivel from catalogo
    where CoCtl = 2
    order by 2 asc;
END //
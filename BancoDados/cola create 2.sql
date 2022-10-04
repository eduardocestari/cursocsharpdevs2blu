-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sistemacadastro_professor
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sistemacadastro_professor
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sistemacadastro_professor` DEFAULT CHARACTER SET utf8 ;
USE `sistemacadastro_professor` ;

-- -----------------------------------------------------
-- Table `sistemacadastro_professor`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro_professor`.`pessoa` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `cgccpf` VARCHAR(25) NOT NULL,
  `tipopessoa` ENUM('PF', 'PJ') NOT NULL COMMENT '1 - PF; 2 - PJ (ENUM)',
  `flstatus` ENUM('E', 'A', 'I') NOT NULL DEFAULT 'A' COMMENT 'E - EXCLUÍDO; A - ATIVO; I - INATIVO',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro_professor`.`endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro_professor`.`endereco` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_pessoa` INT NOT NULL,
  `CEP` VARCHAR(15) NULL,
  `rua` VARCHAR(45) NOT NULL,
  `numero` INT NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `uf` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_endereco_pessoa_idx` (`id_pessoa` ASC) VISIBLE,
  CONSTRAINT `fk_endereco_pessoa`
    FOREIGN KEY (`id_pessoa`)
    REFERENCES `sistemacadastro_professor`.`pessoa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro_professor`.`convenio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro_professor`.`convenio` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `flstatus` ENUM('I', 'A') NOT NULL DEFAULT 'A' COMMENT 'I - Inativo; A - Ativo',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro_professor`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro_professor`.`paciente` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_pessoa` INT NOT NULL,
  `id_convenio` INT NOT NULL,
  `numero_prontuario` INT NOT NULL,
  `paciente_risco` VARCHAR(5) NULL,
  `flstatus` ENUM('E', 'A') NOT NULL DEFAULT 'A' COMMENT 'E - Excluído; - A - Ativo',
  `flobito` TINYINT NOT NULL DEFAULT 0 COMMENT '0 - Não; 1 - Sim',
  PRIMARY KEY (`id`),
  INDEX `index_nrprontuario` (`numero_prontuario` ASC) VISIBLE,
  INDEX `fk_paciente_pessoa1_idx` (`id_pessoa` ASC) VISIBLE,
  INDEX `fk_paciente_convenio1_idx` (`id_convenio` ASC) VISIBLE,
  CONSTRAINT `fk_paciente_pessoa1`
    FOREIGN KEY (`id_pessoa`)
    REFERENCES `sistemacadastro_professor`.`pessoa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_paciente_convenio1`
    FOREIGN KEY (`id_convenio`)
    REFERENCES `sistemacadastro_professor`.`convenio` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Data for table `sistemacadastro_professor`.`pessoa`
-- -----------------------------------------------------
START TRANSACTION;
USE `sistemacadastro_professor`;
INSERT INTO `sistemacadastro_professor`.`pessoa` (`id`, `nome`, `cgccpf`, `tipopessoa`, `flstatus`) VALUES (1, 'Eduardo Augusto Cestari', '065.854.729-18', 'PF', 'A');
INSERT INTO `sistemacadastro_professor`.`pessoa` (`id`, `nome`, `cgccpf`, `tipopessoa`, `flstatus`) VALUES (2, 'Priscila da Silva', '066.654.854-19', 'PF', 'A');

COMMIT;


-- -----------------------------------------------------
-- Data for table `sistemacadastro_professor`.`convenio`
-- -----------------------------------------------------
START TRANSACTION;
USE `sistemacadastro_professor`;
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (1, 'Unimed Blumenau', 'A');
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (2, 'Pladisa', 'A');
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (3, 'Clinipam', 'A');
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (4, 'Bradesco', 'A');
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (5, 'Boa Vida', 'A');
INSERT INTO `sistemacadastro_professor`.`convenio` (`id`, `nome`, `flstatus`) VALUES (6, 'Amil', 'A');

COMMIT;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

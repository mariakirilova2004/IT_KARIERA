-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema online_shop
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema online_shop
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `online_shop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `university` ;

-- -----------------------------------------------------
-- Table `mydb`.`subjects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`subjects` (
  `subjects_id` INT(11) NOT NULL,
  `subject_name` VARCHAR(50) NULL,
  PRIMARY KEY (`subjects_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`majors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`majors` (
  `major_id` INT(11) NOT NULL,
  `name` VARCHAR(50) NULL,
  PRIMARY KEY (`major_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`students` (
  `student_id` INT(11) NOT NULL,
  `student_number` VARCHAR(12) NULL,
  `student_name` VARCHAR(50) NULL,
  `major_id` INT(11) NOT NULL,
  PRIMARY KEY (`student_id`),
  INDEX `fk_students_majors1_idx` (`major_id` ASC) VISIBLE,
  CONSTRAINT `fk_students_majors1`
    FOREIGN KEY (`major_id`)
    REFERENCES `mydb`.`majors` (`major_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`agenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`agenda` (
  `subjects_id` INT(11) NOT NULL,
  `student_id` INT(11) NOT NULL,
  PRIMARY KEY (`subjects_id`, `student_id`),
  INDEX `fk_agenda_subjects_idx` (`subjects_id` ASC) VISIBLE,
  INDEX `fk_agenda_students1_idx` (`student_id` ASC) VISIBLE,
  CONSTRAINT `fk_agenda_subjects`
    FOREIGN KEY (`subjects_id`)
    REFERENCES `university`.`subjects` (`subjects_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_agenda_students1`
    FOREIGN KEY (`student_id`)
    REFERENCES `university`.`students` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`payments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`payments` (
  `payment_id` INT(11) NOT NULL,
  `payment_date` DATE NULL,
  `payment_amount` DECIMAL(8,2) NULL,
  `student_id` INT(11) NOT NULL,
  PRIMARY KEY (`payment_id`),
  INDEX `fk_payments_students1_idx` (`student_id` ASC) VISIBLE,
  CONSTRAINT `fk_payments_students1`
    FOREIGN KEY (`student_id`)
    REFERENCES `university`.`students` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `online_shop` ;

-- -----------------------------------------------------
-- Table `online_shop`.`cities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`cities` (
  `city_id` INT NOT NULL,
  `name` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`city_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `online_shop`.`customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`customers` (
  `customer_id` INT NOT NULL,
  `name` VARCHAR(50) NULL DEFAULT NULL,
  `birthday` DATE NULL DEFAULT NULL,
  `city_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`customer_id`),
  INDEX `fk_customers_cities` (`city_id` ASC) VISIBLE,
  CONSTRAINT `fk_customers_cities`
    FOREIGN KEY (`city_id`)
    REFERENCES `online_shop`.`cities` (`city_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `online_shop`.`item_types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`item_types` (
  `item_type_id` INT NOT NULL,
  `name` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`item_type_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `online_shop`.`items`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`items` (
  `item_id` INT NOT NULL,
  `name` VARCHAR(50) NULL DEFAULT NULL,
  `item_type_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`item_id`),
  INDEX `fk_items_item_types` (`item_type_id` ASC) VISIBLE,
  CONSTRAINT `fk_items_item_types`
    FOREIGN KEY (`item_type_id`)
    REFERENCES `online_shop`.`item_types` (`item_type_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `online_shop`.`order_items`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`order_items` (
  `order_id` INT NOT NULL,
  `item_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  INDEX `fk_order_items_items` (`item_id` ASC) VISIBLE,
  CONSTRAINT `fk_order_items_items`
    FOREIGN KEY (`item_id`)
    REFERENCES `online_shop`.`items` (`item_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `online_shop`.`orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `online_shop`.`orders` (
  `order_id` INT NOT NULL,
  `customer_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  INDEX `fk_orders_customers` (`customer_id` ASC) VISIBLE,
  CONSTRAINT `fk_order_items_orders`
    FOREIGN KEY (`order_id`)
    REFERENCES `online_shop`.`order_items` (`order_id`),
  CONSTRAINT `fk_orders_customers`
    FOREIGN KEY (`customer_id`)
    REFERENCES `online_shop`.`customers` (`customer_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

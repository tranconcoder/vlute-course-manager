use `vlute_course_manager`;

DELIMITER $$

DROP PROCEDURE IF EXISTS searchCourse$$
CREATE PROCEDURE 
  searchCourse( q VARCHAR(60), s INT )
BEGIN  
	SELECT `course`.*, `user`.`fullname` AS teacher_fullname, `subject`.`subject_name`, `subject`.`theory_credit_count`, `subject`.`practice_credit_count`, `major`.`major_title`, (
		SELECT COUNT(*)
        FROM `vlute_course_manager`.`course_enroll`
		WHERE 
			`course`.`course_id` = `course_enroll`.`course_id`
            AND `course_enroll`.`enroll_session_id` = s
    ) AS current_member_count
    FROM `vlute_course_manager`.`course`
    INNER JOIN `course_session`
		ON `course_session`.`course_id` = `course`.`course_id`
        AND `course_session`.`enroll_session_id` = s
    INNER JOIN `user`
		ON `user`.user_id = `course`.teacher_id
	INNER JOIN `subject`
		ON `subject`.`subject_id` = `course`.`subject_id`
	INNER JOIN  `major`
		ON `subject`.`major_id` = `major`.`major_id`
    WHERE CONCAT(`course_name`, `course_code`, `user`.`fullname`, `subject`.`subject_name`, `major_title`) LIKE CONCAT("%", q ,"%");		
END$$

DROP PROCEDURE IF EXISTS selectUserProfile$$
CREATE PROCEDURE
	selectUserProfile(user_id INT)
BEGIN
	SELECT * FROM `user` WHERE `user`.`user_id` = user_id;
END$$

DROP PROCEDURE IF EXISTS changePassword$$
CREATE PROCEDURE
	changePassword(`user_id` INT)
BEGIN
	
END$$

DELIMITER ;
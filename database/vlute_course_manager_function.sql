USE `vlute_course_manager`;

DELIMITER $$

DROP PROCEDURE IF EXISTS searchCourse$$
CREATE PROCEDURE 
  searchCourse( q VARCHAR(60), s INT )
BEGIN 
	SELECT 
		`subject`.`subject_name`,
        `subject`.`subject_code`,
        `subject`.`theory_credit_count`,
        `subject`.`practice_credit_count`,
        `subject`.`major_id`,
        `user`.`fullname` AS `teacher_fullname`,
		`course`.*,
        (
			SELECT COUNT(*)
            FROM `course_enroll`
            WHERE `course_enroll`.`course_id` = `course`.`course_id`
        ) AS `member_count`
	FROM `vlute_course_manager`.`course`
    INNER JOIN `vlute_course_manager`.`subject`
		ON `course`.`subject_id` = `subject`.`subject_id`
	INNER JOIN `vlute_course_manager`.`user`
		ON `course`.`teacher_id` = `user`.`user_id`
	WHERE
		`course`.`enroll_session_id` = s
		AND CONCAT(`subject`.`subject_name`, `subject`.`subject_code`, `course`.`course_name`, `user`.`fullname`) LIKE CONCAT("%", q, "%")
    ;
END$$

DROP PROCEDURE IF EXISTS selectUserProfile$$
CREATE PROCEDURE
	selectUserProfile(user_id INT)
BEGIN
	SELECT * FROM `user` WHERE `user`.`user_id` = user_id;
END$$

DROP PROCEDURE IF EXISTS selectCourseEnrolled$$
CREATE PROCEDURE
	selectCourseEnrolled(student_id VARCHAR(8), session_id INT)
BEGIN
	SELECT 
		`subject`.`subject_name`,
        `subject`.`subject_code`,
        `subject`.`theory_credit_count`,
        `subject`.`practice_credit_count`,
        `subject`.`major_id`,
        `user`.`fullname` AS `teacher_fullname`,
		`course`.*,
        (
			SELECT COUNT(*)
            FROM `course_enroll`
            WHERE `course_enroll`.`course_id` = `course`.`course_id`
        ) AS `member_count`
	FROM `vlute_course_manager`.`course`
    INNER JOIN `vlute_course_manager`.`subject`
		ON `course`.`subject_id` = `subject`.`subject_id`
	INNER JOIN `vlute_course_manager`.`user`
		ON `course`.`teacher_id` = `user`.`user_id`
	INNER JOIN `vlute_course_manager`.`course_enroll`
		ON `course`.`course_id` = `course_enroll`.`course_id`
	WHERE
		`course`.`enroll_session_id` = session_id
		AND `course_enroll`.`student_id` = student_id
    ;	
END$$

DROP PROCEDURE IF EXISTS selectTeacherInMajor$$
CREATE PROCEDURE
	selectTeacherInMajor(major_id INT)
BEGIN
	SELECT `user`.* FROM `user`
    INNER JOIN `major` ON `major`.`major_id` = `user`.`major_id`
    WHERE `major`.`major_id` = major_id
		AND `role` = 'teacher'
    ;
END$$

DROP PROCEDURE IF EXISTS selectCourseInfoById$$
CREATE PROCEDURE
	selectCourseInfoById(course_id INT)
BEGIN
	SELECT 
		`subject`.`subject_name`,
        `subject`.`subject_code`,
        `subject`.`theory_credit_count`,
        `subject`.`practice_credit_count`,
        `subject`.`major_id`,
        `user`.`fullname` AS `teacher_fullname`,
		`course`.*,
        (
			SELECT COUNT(*)
            FROM `course_enroll`
            WHERE `course_enroll`.`course_id` = `course`.`course_id`
        ) AS `member_count`
	FROM `vlute_course_manager`.`course`
    INNER JOIN `vlute_course_manager`.`subject`
		ON `course`.`subject_id` = `subject`.`subject_id`
	INNER JOIN `vlute_course_manager`.`user`
		ON `course`.`teacher_id` = `user`.`user_id`
	INNER JOIN `vlute_course_manager`.`course_enroll`
		ON `course`.`course_id` = `course_enroll`.`course_id`
	WHERE `course`.`course_id` = course_id
    ;
END$$

DELIMITER ;

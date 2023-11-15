SET SQL_SAFE_UPDATES = 0;

USE `vlute_course_manager`;

-- Thêm ràng buộc toàn vẹn
ALTER TABLE `vlute_course_manager`.`user`
	ADD CONSTRAINT check_user_accountType CHECK(`role` IN ("student", "teacher", "admin")),
	ADD CONSTRAINT check_user_accountType_studentId CHECK(`role` = "student" AND LENGTH(`student_id`) = 8 OR `role` = "teacher");
    
ALTER TABLE `vlute_course_manager`.`enroll_session`
	ADD CONSTRAINT check_enrollSession_startAt_endAt CHECK(`start_at` < `end_at`);

-- Major
INSERT INTO `vlute_course_manager`.`major`(major_title) VALUES ("Công nghệ thông tin");

INSERT INTO `vlute_course_manager`.`authenticate`(username, password) VALUES
	("conkgytt", "$2a$11$PtC5OUnz9XegCzRmi7toWee5GJNTNf4srQyvXeMgWdFXRec1azMNW");

INSERT INTO `vlute_course_manager`.`authenticate`(username, password) VALUES 
	("teacheraccount", "passforteacheraccount");
INSERT INTO `vlute_course_manager`.`user`(user_id, student_id, role, fullname, major_id) VALUES 
	(1, "22004015", "student", "Trần Văn Còn", 1),
	(2, NULL, "teacher", "Ngọc Nga", 1);

-- Nhập danh sách môn học
INSERT INTO `vlute_course_manager`.`subject` (major_id, subject_name, theory_credit_count, practice_credit_count) VALUES
	(1, "Cấu trúc dữ liệu và giải thuật", 2, 1),
    (1, "Hệ điều hành", 2, 1),
    (1, "Lập trình hướng đối tượng", 2, 1),
    (1, "Phân tích và thiết kế thuật toán", 2, 0);
    
-- Nhập danh sách khóa học
INSERT INTO `vlute_course_manager`.`course`(subject_id, teacher_id, course_name, course_number, course_code, practice, max_member_count) VALUES 
	(1, 2, "Khóa học CTDL&GT", 1, "A", 1, 1),
    (3, 2, "Object Oriented Programming", 1, "B", 0, 10),
    (4, 2, "Thuật toán", 2, "C", 0, 30);

-- Nhập phiên đăng ký
INSERT INTO `vlute_course_manager`.`enroll_session`(title, start_at, end_at) VALUES
	("Học kỳ 1 - Năm học 2022-2023", now(), now() + INTERVAL 100 DAY),
    ("Học kỳ phụ - Năm học 2022-2023", now(), now() + INTERVAL 100 DAY),
    ("Học kỳ 2 - Năm học 2022-2023", now(), now() + INTERVAL 100 DAY),
    ("Học kỳ hè - Năm học 2022-2023", now(), now() + INTERVAL 100 DAY);
    
-- Học phần được phép đăng ký cho đợt
INSERT INTO `vlute_course_manager`.`course_session`(course_id, enroll_session_id) VALUES
	(1, 1),
    (1, 2),
    (2, 1),
    (3, 1);

-- Đăng ký học phần
INSERT INTO `vlute_course_manager`.`course_enroll`(course_id, enroll_session_id, student_id, enroll_at) VALUES
	(1, 2, 1, now()),
    (1, 2, 2, now());

SELECT * FROM `vlute_course_manager`.`course`;
SELECT * FROM `vlute_course_manager`.`course_enroll`;
SELECT * FROM `vlute_course_manager`.`enroll_session`;
SELECT * FROM `vlute_course_manager`.`user`;
select * from authenticate;

USE `vlute_course_manager`;
call searchCourse("giai", 1);

call selectUserProfile(1);
SET SQL_SAFE_UPDATES = 0;
USE `vlute_course_manager`;

-- Thêm ràng buộc toàn vẹn
ALTER TABLE `vlute_course_manager`.`user`
	ADD CONSTRAINT check_user_accountType CHECK(`role` IN ("student", "teacher", "admin")),
	ADD CONSTRAINT check_user_accountType_studentId CHECK(`role` = "student" AND LENGTH(`student_id`) = 8 OR `role` = "teacher");
    
ALTER TABLE `vlute_course_manager`.`enroll_session`
	ADD CONSTRAINT check_enrollSession_dateRange CHECK(`date_range` > 0);

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
INSERT INTO `vlute_course_manager`.`subject` (major_id, subject_name, subject_code, theory_credit_count, practice_credit_count) VALUES
	(1, 'Triết học Mác-Lênin', 'CT2101', 3, 0),
	(1, 'Kinh tế chính trị Mác-Lênin', 'CT2102', 2, 0),
	(1, 'Chủ nghĩa xã hội khoa học', 'CT2103', 2, 0),
	(1, 'Lịch sử Đảng Cộng sản Việt Nam', 'CT2104', 2, 0),
	(1, 'Tư tưởng Hồ Chí Minh', 'CT1102', 2, 0),
	(1, 'Pháp luật đại cương', 'UL1104', 2, 0),
	(1, 'Khởi nghiệp', 'EC1600', 1, 0),
	(1, 'Quản lý hành chính nhà nước và quản lý ngành giáo dục – đào tạo', 'UL1106', 2, 0),
	(1, 'Nguyên lý kế toán', 'EC1217', 2, 0),
	(1, 'Toán cao cấp A1', 'CB1106', 3, 0),
	(1, 'Toán cao cấp A2', 'CB1107', 3, 0),
	(1, 'Xác suất thống kê', 'CB1109', 3, 0),
	(1, 'Vật lý đại cương A1', 'CB1111', 3, 0),
	(1, 'Tin học', 'TH1114', 2, 1),
	(1, 'Anh văn 1', 'NN1101', 3, 0),
	(1, 'Anh văn 2', 'NN1102', 3, 0),
	(1, 'Anh văn 3', 'NN1103', 4, 0),
	(1, 'Giáo dục thể chất 1', 'TC1101', 0, 1),
	(1, 'Giáo dục thể chất 2', 'TC1102', 0, 1),
	(1, 'Giáo dục thể chất 3', 'TC1103', 0, 1),
	(1, 'Đường lối quốc phòng và an ninh của ĐCSVN', 'QP2101', 3, 0),
	(1, 'Công tác quốc phòng – An ninh', 'QP2102', 2, 0),
	(1, 'Quân sự chung', 'QP2103', 0, 1),
	(1, 'Kỹ thuật chiến đấu bộ binh và chiến thuật', 'QP2104', 0, 2),
	(1, 'Tin học cơ sở', 'TH1201', 2, 0),
	(1, 'Toán rời rạc', 'TH1203', 2, 0),
	(1, 'Lập trình căn bản', 'TH1219', 2, 2),
	(1, 'Cấu trúc máy tính', 'TH1205', 2, 1),
	(1, 'Cấu trúc dữ liệu và giải thuật', 'TH1206', 2, 1),
	(1, 'Cơ sở dữ liệu', 'TH1207', 2, 1),
	(1, 'Hệ điều hành', 'TH1208', 2, 1),
	(1, 'Lập trình hướng đối tượng', 'TH1209', 2, 1),
	(1, 'Biên tập và soạn thảo văn bản', 'TH1227', 1, 1),
	(1, 'Kỹ thuật số - CNTT', 'DT1283', 1, 1),
	(1, 'Phân tích và thiết kế thuật toán', 'TH1212', 2, 0),
	(1, 'Phần mềm mã nguồn mở', 'TH1216', 1, 1),
	(1, 'Mạng máy tính', 'TH1214', 2, 1),
	(1, 'An toàn và vệ sinh lao động trong lĩnh vực CNTT', 'TH1217', 1, 0),
	(1, 'Đồ án công nghệ thông tin 1', 'TH1507', 0, 1),
	(1, 'Lắp ráp và cài đặt máy tính', 'TH1521', 0, 2),
	(1, 'Tin học ứng dụng', 'TH1522', 0, 2),
	(1, 'Anh văn chuyên ngành', 'TH1354', 2, 0),
	(1, 'Trí tuệ nhân tạo', 'TH1333', 2, 1),
	(1, 'Internet vạn vật', 'TH1359', 2, 1),
	(1, 'Xử lý ảnh', 'TH1335', 2, 1),
	(1, 'Phân tích thiết kế hệ thống thông tin', 'TH1305', 2, 1),
	(1, 'Phân tích thiết kế hướng đối tượng', 'TH1324', 2, 1),
	(1, 'Lập trình Web', 'TH1336', 2, 2),
	(1, 'Lập trình Java', 'TH1309', 2, 1),
	(1, 'Lập trình dotNET', 'TH1337', 2, 2),
	(1, 'Lập trình ứng dụng cho thiết bị di động', 'TH1338', 2, 2),
	(1, 'Sensor và ứng dụng', 'TH1376', 1, 2),
	(1, 'Phát triển ứng dụng IoT', 'TH1369', 1, 2),
	(1, 'Đồ án công nghệ thông tin 2', 'TH1512', 0, 2),
	(1, 'Bảo mật ứng dụng Web', 'TH1358', 2, 1),
	(1, 'Hệ quản trị cơ sở dữ liệu', 'TH1307', 2, 1),
	(1, 'Quản trị mạng máy tính', 'TH1339', 1, 2),
	(1, 'An toàn và an ninh thông tin', 'TH1341', 2, 1),
	(1, 'Lập trình mạng', 'TH1314', 2, 1),
	(1, 'Công nghệ mạng không dây', 'TH1342', 1, 1),
	(1, 'Thiết kế mạng máy tính', 'TH1316', 2, 1),
	(1, 'Triển khai hệ thống mạng văn phòng', 'TH1370', 1, 2),
	(1, 'Hệ thống thông tin quang', 'TH1526', 0, 2),
	(1, 'Hệ thống nhúng', 'TH1355', 1, 2),
	(1, 'Mạng trong IoT', 'TH1356', 2, 1),
	(1, 'Phát triển ứng dụng IoT nâng cao', 'TH1357', 1, 2),
	(1, 'Bảo mật trong IoT', 'TH1377', 2, 1),
	(1, 'Phân tích dữ liệu lớn trong IoT', 'TH1360', 2, 1),
	(1, 'Ứng dụng máy học trong IoT', 'TH1361', 1, 1),
	(1, 'Điện toán đám mây', 'TH1353', 2, 0),
	(1, 'An toàn cơ sở dữ liệu', 'TH1363', 2, 1),
	(1, 'An toàn mạng máy tính', 'TH1364', 2, 1),
	(1, 'Tấn công mạng', 'TH1365', 2, 1),
	(1, 'Kỹ thuật phân tích mã độc', 'TH1366', 2, 1),
	(1, 'Quản lý rủi ro và an toàn thông tin trong doanh nghiệp ', 'TH1367', 2, 0),
	(1, 'An toàn điện toán đám mây', 'TH1368', 2, 1),
	(1, 'Hệ thống phân tán', 'TH1340', 2, 1),
	(1, 'Ứng dụng điện toán đám mây trong IoT', 'TH1362', 1, 1),
	(1, 'Phát triển ứng dụng điện toán đám mây', 'TH1378', 2, 2),
	(1, 'Công nghệ ảo hóa', 'TH1379', 1, 2),
	(1, 'Hệ điều hành nguồn mở', 'TH1387', 1, 1),
	(1, 'Thực tập tốt nghiệp', 'TH1601', 0, 2),
	(1, 'Khóa luận tốt nghiệp', 'TH1602', 0, 10),
	(1, 'Thương mại điện tử', 'TH1606', 2, 1),
	(1, 'Cơ sở dữ liệu phân tán', 'TH1607', 2, 1),
	(1, 'Chuyên đề về công nghệ thông tin', 'TH1608', 2, 2);
    
-- Nhập phiên đăng ký
INSERT INTO `vlute_course_manager`.`enroll_session`(title, start_at, date_range) VALUES
	("Học kỳ 1 - Năm học 2022-2023", now(), 1),
    ("Học kỳ phụ - Năm học 2022-2023", now(), 2),
    ("Học kỳ 2 - Năm học 2022-2023", now(), 3),
    ("Học kỳ hè - Năm học 2022-2023", now(), 4);
    
-- Nhập danh sách khóa học
INSERT INTO `vlute_course_manager`.`course`(subject_id, teacher_id, enroll_session_id, course_name, max_member_count, `description`) VALUES 
	(1, 2, 1, "Khóa học CTDL&GT", 1, ""),
    (3, 2, 1, "Object Oriented Programming", 10, ""),
    (4, 2, 2, "Thuật toán", 30, "");


    
-- Học phần được phép đăng ký cho đợt
INSERT INTO `vlute_course_manager`.`course_session`(course_id, enroll_session_id) VALUES
	(1, 1),
    (1, 2),
    (2, 1),
    (3, 1);

-- Đăng ký học phần
INSERT INTO `vlute_course_manager`.`course_enroll`(course_id, student_id, enroll_at) VALUES
	(1, 1, now()),
    (1, 2, now());

SELECT * FROM `vlute_course_manager`.`course`;
SELECT * FROM `vlute_course_manager`.`course_enroll`;
SELECT * FROM `vlute_course_manager`.`enroll_session`;
SELECT * FROM `vlute_course_manager`.`user`;
select * from `vlute_course_manager`.`authenticate`;
select * from `vlute_course_manager`.`subject`;
select * from `vlute_course_manager`.`major`;

USE `vlute_course_manager`;
call searchCourse("", 1);

call selectUserProfile(1);

call selectNewCourseId();
# QLDSV | QUẢN LÝ ĐIỂM SINH VIÊN

Đồ án kết thúc môn Cơ sở dữ liệu phân tán lớp D16CQCP01  (được 7đ :v)

# Demo
<a href="https://www.youtube.com/watch?v=RUsqJeA89vo&t=757s">Xem video tại đây!!!</a>
## Thành viên
| Họ & Tên  | MSSV| Lớp|
| ------------- | ------------- |----------|
| Võ Duy Khánh   | N16DCCN076  |D16CQCP01|
| ------------- | ------------- |----------|
| Nguyễn Thanh Phong    | N16DCCN116  |D16CQCP01|
-----------------------------------------------
### Giảng viên hướng dẫn
>>**Lưu Nguyễn Kỳ Thư**
-----------------------------------------------
### Prerequisites
 - .Net Framework version 4.5
 -  Devexpress version 19.2
-----------------------------------------------
### Chi tiết
 - 1 site chủ, 3 site phân mãnh
-----------------------------------------------
### Yêu cầu 
 Giả sử  trường có 2 khoa chính : công nghệ thông tin (CNTT),  và viễn thông (VT)z	
-	Phân tán cơ sở dữ liệu QLDSV ra làm 3 mảnh với điều kiện sau: 
o	QLDSV được đặt trên server1: chứa thông tin của các sinh viên thuộc khoa công nghệ thông tin
o	QLDSV được đặt trên server2:  chứa thông tin của các sinh viên thuộc khoa viễn thông.
o	QLDSV được đặt trên server3:  chứa thông tin đóng học phí của các sinh viên của trường

Viết chương trình thực hiện các công việc sau trên từng khoa:
a. Nhập liệu: gồm các công việc sau
- Nhập danh mục lớp: Form có các chức năng sau Thêm, Xóa, Hiệu chỉnh, Ghi, Phục hồi. Trên từng khoa ta chỉ thấy được danh sách lớp thuộc khoa đó.
- Nhập danh sách sinh viên: dưới dạng SubForm 
Form có các chức năng sau Thêm, Xóa, Hiệu chỉnh, Ghi, Phục hồi, Chuyển lớp. Trên từng lớp ta chỉ thấy được danh sách sinh viên thuộc lớp đó.
- Nhập môn học : trên form Nhập môn học có các nút lệnh : Thêm, Xóa, Hiệu chỉnh, Phục hồi, Ghi, Thoát.
- Nhập điểm:  Điểm thuộc khoa nào thì khoa đó nhập hoặc PGV nhập
Sau khi nhập xong các thông tin cần thiết (lớp, môn học, lần thi) , user click nút ‘Bắt đầu’ thì sẽ xuất hiện thêm 1 bảng có các cột:
MASV 	Họ &	Tên		Điểm
Trong đó, 2 cột mã sinh viên , họ tên là đã có sẵn giá trị, ta chỉ việc nhập điểm trên bảng. Sau khi nhập điểm thi xong, click nút lệnh ‘Ghi điểm’ thì mới ghi hết điểm về CSDL. 
-	Đóng học phí: login thuộc nhóm PkeToan mới được quyền vào module này.
User nhập vào mã SV, chương trình tự động load lên họ tên, mã lớp và 1 bảng chứa toàn bộ thông tin đóng học phí của sinh viên:
Niên khóa	Học kỳ	Học phí	Số tiền đã đóng
			
User nhập vào thông tin, sau đó click nút Ghi để ghi dữ liệu vào CƠ SỞ DỮ LIỆU

2. Phân quyền: CƠ SỞ DỮ LIỆU có 3 loại nhóm: PGV, Khoa, PKeToan
-  Nếu login thuộc nhóm PGV thì login đó có thể đăng nhập vào bất kỳ khoa nào để cập nhật bằng cách chọn tên khoa,  và tìm dữ liệu trên phân mảnh tương ứng. Login này được tạo tài khoản cho nhóm PGV,Khoa và PKeToan
. 
-  Nếu login thuộc nhóm Khoa thì ta chỉ cho phép xem dữ liệu trên khoa đó   và tìm dữ liệu trên phân mảnh tương ứng để in.  Nhóm Khoa chỉ được quyền cập nhật điểm. Nhóm Khoa chỉ được tạo tài khoản cho nhóm Khoa  .
- Nếu login thuộc nhóm PKeToan thì chỉ được quyền cập nhật dữ liệu đóng học phí của sinh viên, chỉ được tạo tài khoản mới thuộc cùng nhóm.
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn tương ứng. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh. 
..............................
<h2><a href="https://github.com/PhongMax/qldsv/blob/master/DATABASE/De1-QLDSV-SQLSERVER_PhanTan-KHOA2016.doc">...Xem full yêu cầu tại đây!!!</a></h2>









































Nội dung: Thi trắc nghiệm các môn học theo các trình độ khác nhau.
Yêu cầu: Giả sử  trường có 2 cơ sở chính : cơ sở 1  (CS1), cơ sở 2  (CS2) 
Phân tán cơ sở dữ liệu THITN ra làm 3 mảnh với điều kiện sau: 
-	THITN được đặt trên server1: chứa thông tin của các lớp, đăng ký thi trắc nghiệm của các lớp thuộc cơ sở 1.
-	THITN được đặt trên server2: chứa thông tin của các lớp, đăng ký thi trắc nghiệm của các lớp thuộc cơ sở 2.
-	THITN được đặt trên server3: chứa thông tin  các lớp, sinh viên   của cả 2 cơ sở 1 và 2. Server này dùng để tra cứu thông tin của lớp, sinh viên của cả 2 cơ sở. 

Viết chương trình thực hiện các công việc sau trên từng cơ sở:
-----------------------------------------------
#### 1.	Đăng nhập:
 - Cơ sở		  :
 - Login     :
 - Password	:

 - Trước khi sinh viên/ giáo viên sử dụng chương trình thì phải đăng ký trước.  Đối với sinh viên thì masv xem như là login name
-----------------------------------------------
#### 2. Nhập môn học: 
 - Tạo form cho phép user nhập vào các môn học sẽ thi trắc nghiệm. Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh, Phục hồi , Ghi.
#### 3. Nhập Khoa, lớp
#### 4. Nhập sinh viên: 
 - Tạo form cho phép user nhập vào các lớp và sinh viên của lớp (trình bày dưới dạng subform) . Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh, Phục hồi, Ghi.
#### 5. Nhập giáo viên: 
 - Tạo form cho phép user nhập vào thông tin của giáo viên (trình bày dưới dạng subform) . Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh, Phục hồi , Ghi.
#### 6. Nhập đề: 
 - Form này cho phép user là giáo viên nhập vào bộ đề thi trắc nghiệm. Các câu hỏi sẽ được ghi vào table Bo_de.
#### 7. Chuẩn bị thi: 
 - Nhân viên nhập vào tên lớp, chọn môn học sẽ thi, chọn trình độ, lần thi, số câu thi, ngày thi, thời gian thi. Kết quả đăng ký sẽ được ghi vào table GiaoVien_DangKy. Khi đăng ký thi cho 1 lớp thì chương trình  phải kiểm tra các ràng buộc .
#### 8. Thi : 
 - Chương trình tự động in ra mã lớp, tên lớp, họ tên  của sinh viên dựa vào loginname (mã sinh viên) của sinh viên khi đăng nhập. Sinh viên chọn môn học, ngày thi, lần thi thì chương trình sẽ tự động lọc ra số câu thi, thời gian thi, trình độ mà giáo viên đã đăng ký. Sau khi click nút Bắt đầu thi thì chương trình sẽ lọc ra số câu thi ngẫu nhiên dựa vào các thông số đó, và sau đó tiến hành cho sinh viên thi
Lưu ý:	
- Các câu ngẫu nhiên không được trùng nhau, và lấy theo trình độ A, B hay C. Tuy nhiên, nếu ta chọn cho lớp thi các câu với trình độ cao (tối thiểu phải đạt 70% số câu thi) thì vẫn được lấy các câu cho các hệ với trình độ thấp hơn 1 bậc (không quá 30% số câu thi).
- Các câu hỏi thi sẽ ưu tiên lấy ở cơ sở mà lớp đó học. Nếu thiếu thì mới lấy thêm ở cơ sở còn lại.
- Điểm lớn nhất là 10
- Số điểm các câu là như nhau
- Cho phép user chọn lại các câu đã thi của lần thi trước
- Khi hết thời gian qui định thì chương trình tự động kết thúc việc thi
-	Thông báo điểm ngay cho sinh viên thi và ghi kết quả vào table Bangdiem.
#### 9. Xem kết quả:  
 - Mục này cho phép user in ra lại các câu đã thi dựa vào các thông tin : tên lớp, môn học, trình độ , (login của user đã nhập).
Màn hình kết xuất có dạng:
-----------------------------
|Lớp	: xxxxxxxxxxxxxxxxxxxxxxx|
| ------------- |
|Họ tên	: xxxxxxxxxxxxxxxxxxxxxx|
|Môn thi	: xxxxxxxxxxxxxx|
>>
|Ngày thi 	: 	dd/mm/yyyy		|	Lần thi: 99     |     STT	Câu số(trong bộ đề)|	Nội dung	|Các chọn lựa	|Đáp án	|Đã chọn|
|-----------------------------|-----------------|----------------------------|------------|-------------|-------|-------|
| 06/01/2020                  |    1            |             2              |     ABC    | A.Something |   B   |   C   |
-----------------------------------------------

					
#### 10. Bảng điểm môn học: 
 - Giao viên chọn tên lớp, tên môn học, lần thi ; chương trình sẽ in ra bảng điểm thi hết môn của lớp đã chọn .  Mẫu in : thực hiện giống như của trường. (MASV HO  TEN DIEM  DIEMCHU)
#### 11. Xem danh sách đăng ký thi trắc nghiệm 
 - Xem danh sách đăng ký thi trắc nghiệm của 2 cơ sở từ ngày @tungay đến ngày @denngay. Báo cáo sẽ nhóm danh sách đăng ký theo từng cơ sở,  và in theo thứ tự tăng dần của ngày đăng ký
Báo cáo có dạng:

-----------------------------
|DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM CƠ SỞ 1|
| ------------- |
|TỪ NGÀY dd/mm/yyyy  ĐẾN NGÀY dd/mm/yyyy|

|STT	| TÊN LỚP	| TÊN MÔN HỌC	| GIẢNG VIÊN ĐĂNG KÝ	| SỐ CÂU THI	| NGÀY THI	| ĐÃ THI (X) |	GHI CHÚ|
|-----|---------|-------------|---------------------|-------------|-----------|------------|---------|
|1		|	 				
|2		|					
|3		|
>>
#### Tổng cộng số lượt đăng ký : xxxx
------------------

#### 10. Phân quyền : 
- Chương trình có 4 nhóm : Truong , Coso , Giangvien, Sinhvien
-  Nếu login thuộc nhóm Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu bằng cách chọn tên cơ sở:
 + Chỉ có thể xem dữ liệu của phân mảnh tương ứng.
 	 + Xem được các báo cáo.
	 + Tạo login thuộc nhóm Truong
-  Nếu login thuộc nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc trên cơ sở  đó , không được log vào cơ sở  khác,   được tạo tài khoản mới cho nhóm Coso, Giangvien .
- Nếu login thuộc nhóm Giangvien thì chỉ được quyền cập nhật đề thi, và chỉ được quyền hiệu chỉnh câu hỏi thi do mình soạn , được thi thử nhưng không ghi điểm
- Nhóm Sinhvien chỉ được thi .  
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn tương ứng. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh.
Ghi chú: Sinh viên tự kiểm tra các ràng buộc có thể có khi viết chương trình.

-----------------------------------------------

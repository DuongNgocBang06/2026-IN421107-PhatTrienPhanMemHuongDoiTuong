Lỗi 1:Vi phạm nguyên tắc trách nhiệm duy nhất
- Vị trí:
+ CreateClub: dòng 35 - 64
+ AddMemberToClub: dòng 67 - 84
+ CreateEvent: dòng 88 - 99
+ PrintClubReport: dòng 103 - 13
- Hậu quả: ClubManager phải gánh vác quá nhiều nhiệm vụ cùng lúc như quản lí dữ liệu, validate dữ liệu, gửi thông báo, ghi file log, xuất báo cáo

Lỗi 2: Vi phạm nguyên lí đóng/mở 
- Vị trí:
+ Dùng cấu trúc if-else để kiểm tra @@gmail.com và @yahoo.com: dòng 52 - 64
+ AddMemberToClub in console thủ công: dòng 82 - 83
+ CreateEvent vòng lặp gửi email thông báo sự kiện: dòng 96- 97
- Hậu quả: Khi hệ thống muốn mở rộng thêm thông báo mới lập trình viên bắt buộc phải sửa trực thiếp code bên trong các method thay vì mở rộng thông qua kế thừa

Lỗi 3:Vi phạm nguyên lý đảo ngược phụ thuộc:
- Vị trí: Các thao tác ghi file trực tiếp 
+ CreateClub: dòng 48
+ AddMemberToClub: dòng 79
+ CreateEvent: dòng 94 
+ PrintClubReport: dòng 111   
- Hậu quả: Class cấp cao phụ thuộc trực tiếp vào chi tiết tầng hạ tầng thấp (lớp File cụ thể của hệ thống tệp) thay vì phụ thuộc qua một abstraction/interface

Lỗi 4: Interface Segregation Principle / Tách biệt hành vi:
- Vị trí: 
+ Khai báo tổng thể của lớp ClubManager: dòng 28 - 117
- Hậu quả: Giao diện hoặc lớp xử lý bị gộp chung quá nhiều chức năng khiến các thành phần client phụ thuộc vào những thứ chúng không dùng tới.
## Phân loại theo Sinh viên
### US01: Đăng ký tham gia Câu lạc bộ
* Tiêu chí 1: sinh viên -> đăng ký tham gia vào một câu lạc bộ -> tôi có thể tham gia các hoạt động và sự kiện do CLB tổ chức.
* Tiêu chí 2: sinh viên đã đăng nhập và đang xem chi tiết một câu lạc bộ -> sinh viên bấm nút "Đăng ký tham gia" -> hệ thống ghi nhận trạng thái thành viên và hiển thị thông báo thành công.
### US02: Đăng ký tham gia Sự kiện
* Tiêu chí 1: sinh viên -> đăng ký tham dự một sự kiện của CLB -> tôi có vé tham gia và điểm danh khi đến nơi.
Tiêu chí 2: sự kiện còn chỗ trống chưa vượt quá capacity -> sinh viên chọn đăng ký sự kiện -> hệ thống tạo một phiếu đăng ký với trạng thái Pending.
### US03: Check-in sự kiện
* Tiêu chí 1: sinh viên -> thực hiện check-in khi đến tham gia sự kiện -> hệ thống ghi nhận thời gian tham dự thực tế của tôi.
* Tiêu chí 2: sinh viên đã có phiếu đăng ký được xác nhận (Confirmed) -> sinh viên quét mã hoặc điểm danh tại sự kiện -> hệ thống tạo bản ghi CheckIn thành công.
---
## Phân loại theo Ban Chủ nhiệm CLB 
### US04: Tạo sự kiện mới
* Tiêu chí 1: ban chủ nhiệm CLB -> tạo một sự kiện mới với tên, thời gian và sức chứa -> thành viên có thể biết và đăng ký tham gia.
* Tiêu chí 2: ban CLB cung cấp đầy đủ thông tin hợp lệ tên, ngày giờ, sức chứa > 0 -> họ gửi yêu cầu tạo sự kiện -> sự kiện mới được lưu vào hệ thống và gắn với CLB đó.
---
## Phân loại theo Admin
### US05: Phê duyệt thành viên
* Tiêu chí 1: admin -> xem danh sách và phê duyệt đơn đăng ký tham gia CLB của sinh viên -> đảm bảo chỉ những sinh viên hợp lệ mới trở thành thành viên chính thức.
* Tiêu chí 2: có đơn đăng ký đang ở trạng thái chờ duyệt -> admin bấm "Phê duyệt" -> tài khoản sinh viên được kích hoạt trong CLB.
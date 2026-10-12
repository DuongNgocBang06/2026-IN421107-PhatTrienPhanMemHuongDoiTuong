using eduHub.Ch01.Domain;
using System;
using System.Collections.Generic;

namespace EduHub.Ch01;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Tạo CLB "Tech Club" với mô tả phù hợp
        var techClub = Club.Create("Tech Club", "Câu lạc bộ Công nghệ thông tin Đại học Đồng Tháp");
        Console.WriteLine($"Bước 1: Đã tạo CLB: {techClub.Name} | Mô tả: {techClub.Description}");
        PrintSeparator();

        // 2. Thêm 3 thành viên vào CLB 
        var m1 = Member.Create("Dương Ngọc Băng", "bang@dthu.edu.vn", "mssv:2357876432");
        var m2 = Member.Create("Trần Thị Trâm", "tram@dthu.edu.vn", "mssv:9876546790");
        var m3 = Member.Create("Trần Phương Anh", "anh@dthu.edu.vn", "mssv:9864568964");

        techClub.AddMember(m1);
        techClub.AddMember(m2);
        techClub.AddMember(m3);

        Console.WriteLine($"Bước 2: Đã thêm {techClub.MemberCount()} thành viên vào CLB:");
        foreach (var member in techClub.Members)
        {
            Console.WriteLine($" - {member.Name} ({member.StudentCode}) - {member.Email}");
        }
        PrintSeparator();

        // 3. Tạo 1 sự kiện cho CLB 
        var aiEvent = Event.Create(techClub.Id, "Workshop AI & .NET 10", DateTime.UtcNow.AddDays(3), 50, true);
        Console.WriteLine($"Bước 3: Tạo sự kiện thành công: '{aiEvent.Title}' | Sức chứa: {aiEvent.Capacity}");
        PrintSeparator();

        // 4. 2 thành viên đăng ký tham dự sự kiện 
        var reg1 = Registration.Create(m1.Id, aiEvent.Id);
        var reg2 = Registration.Create(m2.Id, aiEvent.Id);

        Console.WriteLine($"Bước 4: Thành viên {m1.Name} và {m2.Name} đã đăng ký sự kiện.");
        Console.WriteLine($" - Trạng thái ban đầu: Reg1 = {reg1.Status}, Reg2 = {reg2.Status}");

        reg1.Confirm();
        reg2.Confirm();
        Console.WriteLine($" - Sau khi gọi Confirm(): Reg1 = {reg1.Status}, Reg2 = {reg2.Status}");
        PrintSeparator();

        // 5. 1 thành viên thực hiện check-in -> tạo CheckIn record
        var checkInRecord = CheckIn.Create(reg1.Id, "Tham gia trực tiếp tại hội trường H1");
        Console.WriteLine($"Bước 5: Thành viên {m1.Name} thực hiện check-in thành công!");
        Console.WriteLine($" Chi tiết: {checkInRecord.Summary()}");
        PrintSeparator();

        // 6. In báo cáo tham dự
        Console.WriteLine("Bước 6: BÁO CÁO THAM DỰ SỰ KIỆN");
        Console.WriteLine($" - Tên sự kiện: {aiEvent.Title}");
        Console.WriteLine($" - Tổng số đăng ký được xác nhận: 2");
        Console.WriteLine($" - Tổng số check-in thực tế: 1");
        Console.WriteLine($" - Danh sách thành viên đã check-in:");
        Console.WriteLine($"   + {m1.Name} ({m1.StudentCode})");
        PrintSeparator();

        //  Thử nghiệm vi phạm luật nghiệp vụ
        Console.WriteLine("Bước 7: Thử nghiệm vi phạm quy tắc nghiệp vụ:");
        try
        {
            var regCancelled = Registration.Create(m3.Id, aiEvent.Id);
            regCancelled.Cancel();
            Console.WriteLine($" - Đã hủy phiếu đăng ký của {m3.Name}. Trạng thái hiện tại: {regCancelled.Status}");
            Console.WriteLine(" - Thử gọi phương thức Confirm() trên phiếu đã hủy...");

            regCancelled.Confirm(); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($" -> Bắt lỗi thành công: {ex.Message}");
        }
    }
    private static void PrintSeparator()
    {
        Console.WriteLine("----------------------------------------");
    }
}
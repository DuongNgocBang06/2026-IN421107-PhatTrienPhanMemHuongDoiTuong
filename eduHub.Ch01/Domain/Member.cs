namespace eduHub.Ch01.Domain;

/// <summary>
/// Đại diện cho một sinh viên / thành viên trong hệ thống EduHub.
/// </summary>
public class Member
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string StudentCode { get; private set; } = string.Empty;
    public DateTime JoinedAt { get; private set; }

    private Member(Guid id, string name, string email, string studentCode, DateTime joinedAt)
    {
        Id = id;
        Name = name;
        Email = email;
        StudentCode = studentCode;
        JoinedAt = joinedAt;
    }

    /// <summary>
    /// Factory method tạo mới một Member sau khi kiểm tra tính hợp lệ của dữ liệu.
    /// </summary>
    public static Member Create(string name, string email, string studentCode)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên thành viên không được để trống.", nameof(name));
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException("Email không hợp lệ hoặc thiếu ký tự '@'.", nameof(email));
        if (string.IsNullOrWhiteSpace(studentCode))
            throw new ArgumentException("Mã sinh viên không được để trống.", nameof(studentCode));

        return new Member(Guid.NewGuid(), name.Trim(), email.Trim(), studentCode.Trim(), DateTime.UtcNow);
    }

    /// <summary>
    /// Kiểm tra xem thành viên đã tham gia trên 1 ngày hay chưa (ví dụ minh họa behavior).
    /// </summary>
    public bool IsActive()
    {
        return (DateTime.UtcNow - JoinedAt).TotalDays >= 0;
    }
}
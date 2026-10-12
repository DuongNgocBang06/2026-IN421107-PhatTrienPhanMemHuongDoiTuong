namespace eduHub.Ch01.Domain;
/// <summary>
/// Ghi nhận thông tin điểm danh của thành viên tại sự kiện.
/// </summary>

public class CheckIn
{
    public Guid Id { get; private set; }
    public Guid RegistrationId { get; private set; }
    public DateTime CheckedInAt { get; private set; }
    public string Note { get; private set; } = string.Empty;

    private CheckIn(Guid id, Guid registrationId, DateTime checkedInAt, string note)
    {
        Id = id;
        RegistrationId = registrationId;
        CheckedInAt = checkedInAt;
        Note = note;
    }

    public static CheckIn Create(Guid registrationId, string note = "Đúng giờ")
    {
        if (registrationId == Guid.Empty)
            throw new ArgumentException("RegistrationId không hợp lệ.", nameof(registrationId));

        return new CheckIn(Guid.NewGuid(), registrationId, DateTime.UtcNow, note ?? string.Empty);
    }

    /// <summary>
    /// Trả về chuỗi mô tả tóm tắt thông tin điểm danh.
    /// </summary>
    public string Summary()
    {
        return $"CheckIn ID: {Id} | Registration: {RegistrationId} | Time: {CheckedInAt:yyyy-MM-dd HH:mm:ss} | Note: {Note}";
    }
}
namespace eduHub.Ch01.Domain;
/// <summary>
/// Ghi nhận thông tin điểm danh của thành viên tại sự kiện.
/// </summary>
public static class RegistrationStatus
{
    public const string Pending = "Pending";
    public const string Confirmed = "Confirmed";
    public const string Cancelled = "Cancelled";
}

public class Registration
{
    public Guid Id { get; private set; }
    public Guid MemberId { get; private set; }
    public Guid EventId { get; private set; }
    public DateTime RegisteredAt { get; private set; }
    public string Status { get; private set; }

    private Registration(Guid id, Guid memberId, Guid eventId, DateTime registeredAt, string status)
    {
        Id = id;
        MemberId = memberId;
        EventId = eventId;
        RegisteredAt = registeredAt;
        Status = status;
    }

    public static Registration Create(Guid memberId, Guid eventId)
    {
        if (memberId == Guid.Empty || eventId == Guid.Empty)
            throw new ArgumentException("MemberId hoặc EventId không hợp lệ.");

        return new Registration(Guid.NewGuid(), memberId, eventId, DateTime.UtcNow, RegistrationStatus.Pending);
    }

    /// <summary>
    /// Xác nhận phiếu đăng ký.
    /// </summary>
    public void Confirm()
    {
        if (Status == RegistrationStatus.Cancelled)
            throw new InvalidOperationException("Không thể xác nhận phiếu đăng ký đã bị huỷ.");
        Status = RegistrationStatus.Confirmed;
    }

    /// <summary>
    /// Huỷ phiếu đăng ký.
    /// </summary>
    public void Cancel()
    {
        Status = RegistrationStatus.Cancelled;
    }
}
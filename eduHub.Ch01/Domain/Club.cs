namespace eduHub.Ch01.Domain;

/// <summary>
/// Đại diện cho một Câu lạc bộ sinh viên trong hệ thống EduHub.
/// </summary>
public class Club
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; }

    private readonly List<Member> _members = new();
    public IReadOnlyCollection<Member> Members => _members.AsReadOnly();

    private Club(Guid id, string name, string description, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedAt = createdAt;
    }

    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên CLB không được để trống.", nameof(name));

        return new Club(Guid.NewGuid(), name.Trim(), description?.Trim() ?? string.Empty, DateTime.UtcNow);
    }

    /// <summary>
    /// Thêm một thành viên vào CLB.
    /// </summary>
    public void AddMember(Member member)
    {
        ArgumentNullException.ThrowIfNull(member);
        if (!_members.Contains(member))
        {
            _members.Add(member);
        }
    }

    /// <summary>
    /// Trả về tổng số lượng thành viên hiện tại của CLB.
    /// </summary>
    public int MemberCount() => _members.Count;
}
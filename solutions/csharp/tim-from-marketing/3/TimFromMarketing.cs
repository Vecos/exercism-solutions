static class Badge
{
    public static string Print(int? id, string name, string? department) => id is null ? $"{name} - {(department ?? "OWNER").ToUpper()}": $"[{id}] - {name} - {(department ?? "OWNER").ToUpper()}" ;
}

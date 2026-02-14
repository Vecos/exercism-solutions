static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
    var depart = (department ?? "OWNER").ToUpper();
        {
            if (id is null)
            {
                return ($"{name} - {depart}");
             }
        else
        {return ($"[{id}] - {name} - {depart}");
         }
        }
    }
}

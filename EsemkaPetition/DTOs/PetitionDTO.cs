namespace EsemkaPetition.DTOs
{
    public class PetitionDTO
    {
        public int PetitionID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Target { get; set; }
        public string? CreatorName { get; set; }
        public int? TotalSigners { get; set; }
    }
}

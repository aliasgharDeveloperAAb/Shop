namespace DgKala.Models.ViewModels.Category
{
    public class ShowCategoryForAdminViewModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int CategoryCount { get; set; }
        public bool IsStatues { get; set; } 
        public string CategoryImageName { get; set; } 

    }
}

namespace ArmyTechTask.viewModels
{
    public class ResultModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public ResultModel()
        {
            Success = false;
            Message = string.Empty;
        }
    }
}

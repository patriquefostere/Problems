namespace Problems.UserInteraction
{
    public interface IUserInteraction
    {
        // would like a better way than having these two methods
        public int GetIntInput();
        public string GetStringInput();

        public void DisplayResult(object result);
    }
}

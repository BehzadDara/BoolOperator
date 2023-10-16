namespace BoolOperator
{
    public record LightStatus
    {
        public static readonly LightStatus Green = new(0);
        public static readonly LightStatus Red = new(1);

        public static LightStatus Create(int status) => new LightStatus(status);
        private LightStatus(int status) => Status = status;
        public int Status { get; private set; }

        public static bool operator true(LightStatus lightStatus) => lightStatus == Green;
        public static bool operator false(LightStatus lightStatus) => lightStatus == Red;
    }
}
